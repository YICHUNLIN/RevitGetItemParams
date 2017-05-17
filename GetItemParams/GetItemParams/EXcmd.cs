using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.DB.Events;
using System.Windows.Forms;
using System.Threading;

namespace GetItemParams
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class EXcmd : IExternalCommand
    {
        ItemController _ic = null;
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uidoc = commandData.Application.ActiveUIDocument;

            CusParameters cp = new CusParameters(uidoc);
            ItemsModel im = new ItemsModel();
            ItemController ic = new ItemController(im, cp);
            this._ic = ic;
            Thread ofthread = new Thread(openForm);
            ofthread.Start();

            return Result.Succeeded;
        }

        public void openForm()
        {

            View.NewNewForm outputForm = new View.NewNewForm(this._ic);
            outputForm.ShowDialog();
        }
        
    }

}
