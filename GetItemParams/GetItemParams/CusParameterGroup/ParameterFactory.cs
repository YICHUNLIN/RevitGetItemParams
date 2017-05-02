using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace BIMFinal
{
    // Revit 原生 Parmeter轉成自定義 CusParmeter
    public class ParameterFactory
    {
        //private CusParameter _cusp = null;
        private Parameter _parm = null;
        private Document _doc = null;
        public ParameterFactory(Parameter parm, Document doc)
        {
            //_cusp = this.getParameterInfo(parm, doc);
            this._parm = parm;
            this._doc = doc;
        }

        public CusParameter Cusparmeter
        {
            get
            {
                return this.getParameterInfo(_parm, _doc);
            }
        }

        //取得 parameter 內容
        private CusParameter getParameterInfo(Parameter parm, Document doc)
        {
            string value = "< >";

            string defname = parm.Definition.Name;
            switch (parm.StorageType)
            {
                case StorageType.Double:
                    value = parm.AsValueString();
                    break;
                case StorageType.Integer:
                    if (ParameterType.YesNo == parm.Definition.ParameterType)
                    {
                        if (parm.AsInteger() == 0)
                        {
                            value = "False";
                        }
                        else
                        {
                            value = "True";
                        }
                    }
                    else
                    {
                        value = parm.AsInteger().ToString();
                    }
                    break;
                case StorageType.ElementId:
                    ElementId eid = parm.AsElementId();
                    if (eid.IntegerValue > 0)
                    {
                        value = doc.GetElement(eid).Name;
                    }
                    else
                    {
                        value = eid.IntegerValue.ToString();
                    }
                    break;
                case StorageType.String:
                    value = parm.AsString();
                    break;
                default:
                    return null;
            }
            return new CusParameter(defname, value);
        }
    }
}
