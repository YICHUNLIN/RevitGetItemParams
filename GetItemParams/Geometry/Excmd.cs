using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Windows.Forms;
namespace Geometry
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class EXcmd : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {

            // 柱 -> 梁 -> 版 -> 牆
            String column = "結構柱";
            String beam = "結構構架";
            String beamsystem = "結構樑系統";
            String board = "樓板";

            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;
            ICollection<ElementId> elemids = uidoc.Selection.GetElementIds();
            MessageBox.Show("You select " + elemids.Count.ToString());
            
            Transaction trans = new Transaction(doc);
            foreach (ElementId fid in elemids)
            {
                Element firstElement = doc.GetElement(fid);
                BoundingBoxXYZ bbx = firstElement.get_BoundingBox(null);
                Outline outline = new Outline(bbx.Min, bbx.Max);
                BoundingBoxIntersectsFilter invertFilter = new BoundingBoxIntersectsFilter(outline, false);
                IList<Element> noIntersects = new FilteredElementCollector(doc).WherePasses(invertFilter).ToElements();
                foreach(Element secondElement in noIntersects)
                {
                    try
                    {
                        String fn = firstElement.Category.Name;
                        String sn = secondElement.Category.Name;
                        trans.Start("join");
                        if (fn == column)
                        {
                            if (sn != column)
                                try
                                {
                                    if (!JoinGeometryUtils.AreElementsJoined(doc, firstElement, secondElement))
                                        JoinGeometryUtils.JoinGeometry(doc, firstElement, secondElement);
                                }
                                catch (Exception e)
                                {
                                    //MessageBox.Show("1"+e.ToString());
                                }

                        }
                        else if (fn == beam)
                        {
                            if (sn != beam && sn != column)
                                try
                                {
                                    if (!JoinGeometryUtils.AreElementsJoined(doc, firstElement, secondElement))
                                        JoinGeometryUtils.JoinGeometry(doc, firstElement, secondElement);
                                }
                                catch (Exception e)
                                {
                                    //MessageBox.Show("2"+e.ToString());
                                }
                        }
                        else if (fn == board)
                        {
                            if (sn != board && sn != column && sn != beam)
                                try
                                {
                                    if (!JoinGeometryUtils.AreElementsJoined(doc, firstElement, secondElement))
                                        JoinGeometryUtils.JoinGeometry(doc, firstElement, secondElement);
                                }
                                catch (Exception e)
                                {
                                    // MessageBox.Show("3" + e.ToString());

                                }

                        }
                        else
                        {

                        }
                        trans.Commit();
                    } catch (Exception e) {

                    }
                }
                /*foreach (Element sid in noIntersects)
                {

                    // if (fid.IntegerValue != sid.IntegerValue)
                    // {
                    //Element secondElement = doc.GetElement(sid);
                        Element secondElement = sid;
                        String fn = firstElement.Category.Name;
                        String sn = secondElement.Category.Name;
                        trans.Start("join");
                        if (fn == column)
                        {
                            if(sn != column)
                                try
                                {
                                    if(!JoinGeometryUtils.AreElementsJoined(doc, firstElement, secondElement))
                                        JoinGeometryUtils.JoinGeometry(doc, firstElement, secondElement); 
                                }
                                catch (Exception e)
                                {
                                    //MessageBox.Show("1"+e.ToString());
                                }
                             
                        }
                        else if(fn == beam)
                        {
                            if(sn != beam && sn != column)
                                try
                                {
                                    if (!JoinGeometryUtils.AreElementsJoined(doc, firstElement, secondElement))
                                        JoinGeometryUtils.JoinGeometry(doc, firstElement, secondElement);
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.ToString());
                                    //MessageBox.Show("2"+e.ToString());
                                }
                        }
                        else if(fn == board)
                        {
                            if(sn != board && sn != column && sn != beam)
                                try
                                {
                                    if (!JoinGeometryUtils.AreElementsJoined(doc, firstElement, secondElement))
                                        JoinGeometryUtils.JoinGeometry(doc, firstElement, secondElement);
                                }
                                catch (Exception e)
                                {
                                    // MessageBox.Show("3" + e.ToString());

                                }

                        }
                        else
                        {

                        }
                        trans.Commit();

                    //}
                }*/

            }
          


            return Result.Succeeded;
        }

    }
}
