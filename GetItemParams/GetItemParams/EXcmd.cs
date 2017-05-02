using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System.Windows.Forms;

namespace GetItemParams
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class EXcmd : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uidoc = commandData.Application.ActiveUIDocument;

            CusParameters cp = new CusParameters(uidoc);
            ItemsModel im = new ItemsModel();
            ItemController ic = new ItemController(im, cp);
            NewForm mainForm = new NewForm(ic);
            mainForm.ShowDialog();
            //View.CusForm mainForm = new View.CusForm(cp);
            //mainForm.ShowDialog();
            return Result.Succeeded;
        }
    }

}
