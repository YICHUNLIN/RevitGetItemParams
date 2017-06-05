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
            String board = "樓板";

            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;
            ICollection<ElementId> elemids = uidoc.Selection.GetElementIds();
            MessageBox.Show("You select " + elemids.Count.ToString());

            Transaction trans = new Transaction(doc);
            foreach (ElementId fid in elemids){
                foreach(ElementId sid in elemids)
                {

                    if (fid.IntegerValue != sid.IntegerValue)
                    {

                        Element firstElement = doc.GetElement(fid);
                        Element secondElement = doc.GetElement(sid);

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

                    }
                }

            }
            /*
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            //Application app = uiapp.Application;
            Document doc = uidoc.Document;

            // get all walls on the active view
            FilteredElementCollector collWalls =
              new FilteredElementCollector(doc, doc.ActiveView.Id);
            collWalls.OfClass(typeof(Wall));

            foreach (Wall w in collWalls)
            {
                // get columns on the active view
                FilteredElementCollector collColumnsOnThisWall =
                  new FilteredElementCollector(doc, doc.ActiveView.Id);
                collColumnsOnThisWall.OfClass(typeof(FamilyInstance));
                collColumnsOnThisWall.OfCategory(
                  BuiltInCategory.OST_StructuralColumns);

                // as we don't want all columns, let's filter
                // by the wall bounding box (intersect)
                BoundingBoxXYZ bb = w.get_BoundingBox(doc.ActiveView);
                Outline outline = new Outline(bb.Min, bb.Max);
                BoundingBoxIntersectsFilter bbfilter =
                  new BoundingBoxIntersectsFilter(outline);
                collColumnsOnThisWall.WherePasses(bbfilter);

                // finally, call JOIN on the wall and column
                foreach (FamilyInstance column in collColumnsOnThisWall)
                {
                    JoinGeometryUtils.JoinGeometry(doc, w, column);
                }
            }
            */
            return Result.Succeeded;
        }


    }
}
