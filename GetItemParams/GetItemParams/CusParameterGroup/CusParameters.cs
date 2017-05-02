using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;


namespace BIMFinal
{
    public class CusParameters
    {
        private UIDocument _uidoc = null;

        private ICollection<ElementId> _elemids = null;

        private Document _doc = null;

        List<CusParameter> _cusps = null;

        private string _componentTypeName = "";

        private string _componentId = "";

        public CusParameters(UIDocument uidoc)
        {
            // base setting
            _uidoc = uidoc;
            _elemids = _uidoc.Selection.GetElementIds();
            _doc = _uidoc.Document;
            _cusps = new List<CusParameter>();
        }

        public string getParmValueByName(string name)
        {
            foreach(CusParameter cp in this._cusps)
            {
                if(cp.DefName == name)
                {
                    return cp.Value;
                }
            }
            return null;
        }

        public string Id
        {
            get
            {
                return _componentId;
            }
        }

        public string Type
        {
            get
            {
                return _componentTypeName;
            }
        }

        //更新參數
        public void setElementParameters(string defName, string value)
        {
            try
            {
                Transaction trans = new Transaction(_doc);
                trans.Start("設定參數");
                Element selectedElement = null;
                foreach (ElementId elid in _elemids)
                {

                    selectedElement = _doc.GetElement(elid);
                    foreach (Parameter parm in selectedElement.Parameters)
                    {
                        if (parm.Definition.Name == defName)
                        {
                            switch (parm.StorageType)
                            {
                                case StorageType.String:
                                    parm.Set(value.ToString());
                                    break;
                                case StorageType.Integer:
                                    if(parm.Definition.ParameterType == ParameterType.YesNo)
                                    {
                                        if (value == "False")
                                            parm.Set(0);
                                        else
                                            parm.Set(1);
                                    }else
                                    {
                                        parm.Set(Convert.ToInt32(value));
                                    }
                                    break;
                                case StorageType.Double:
                                    parm.Set(Convert.ToDouble(value));
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    break;
                }
                trans.Commit();
            }
            catch
            {
                throw new Exception("Modify error");
            }

        }

        public void clearStorages()
        {
            //刪除全部
            this._cusps = new List<CusParameter>();
        }

        // 取得每個參數
        public List<CusParameter> getElementParameters()
        {
            Element selectedElement = null;
            foreach (ElementId elid in _elemids)
            {

                selectedElement = _doc.GetElement(elid);
                this._componentId = elid.IntegerValue.ToString();
                this._componentTypeName = selectedElement.Category.Name;
                foreach (Parameter parm in selectedElement.Parameters)
                {
                    ParameterFactory pf = new ParameterFactory(parm, _doc);
                    CusParameter csp = pf.Cusparmeter;
                    if(csp != null)
                    {
                        _cusps.Add(csp);
                    }
                }
                break;
            }
            return _cusps;
        }

        // 取得所有元件的所有參數
        public List<Item> getItems()
        {
            List<Item> items = new List<Item>();
            Element selectedElement = null;
            foreach (ElementId elid in _elemids)
            {
                List<CusParameter> cups = new List<CusParameter>();
                selectedElement = _doc.GetElement(elid);
                this._componentId = elid.IntegerValue.ToString();
                this._componentTypeName = selectedElement.Category.Name;
                foreach (Parameter parm in selectedElement.Parameters)
                {
                    ParameterFactory pf = new ParameterFactory(parm, _doc);
                    CusParameter csp = pf.Cusparmeter;
                    if (csp != null)
                    {
                        cups.Add(csp);
                    }
                }
                Item newit = new Item();
                newit.IID = elid.IntegerValue.ToString();
                newit.Name = selectedElement.Category.Name;
                newit.Floor = getParamByName(cups, "樓層");
                if (newit.Floor == "")
                    newit.Floor = getParamByName(cups, "底部約束");
                if(newit.Floor == "")
                    newit.Floor = getParamByName(cups, "基準樓層"); ;
                if(newit.Floor == "-1")
                    newit.Floor = getParamByName(cups, "參考樓層");

                newit.Type = getParamByName(cups, "類型");
                if (newit.Type == "")
                    newit.Type = getParamByName(cups, "族群");
                        
                newit.size = getParamByName(cups, "體積");
                items.Add(newit);
            }
            return items;
        }  
        
        public String getParamByName(List<CusParameter> cps ,String name)
        {
            foreach (CusParameter cp in cps)
            {
                if(cp.DefName == name)
                {
                    return cp.Value;
                }
            }
            return "";
        }
        
    }
}
