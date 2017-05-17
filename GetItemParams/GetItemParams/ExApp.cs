using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Events;
using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.DB.Events;
using System.Windows.Forms;
using System.Threading;


namespace GetItemParams
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    class ExApp : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            application.ViewActivated += new EventHandler<ViewActivatedEventArgs>(onAcgivitedView);
            application.ControlledApplication.DocumentOpened += new EventHandler<DocumentOpenedEventArgs>(OnDocOpened);
            application.Idling += new EventHandler<IdlingEventArgs>(onIdling);
            return Result.Succeeded;
        }

        public void onIdling(object sender,IdlingEventArgs iea)
        {
            MessageBox.Show("idling");
        }

        public void onAcgivitedView(object sender, ViewActivatedEventArgs vae)
        {
            
        }

        private void OnDocOpened(object sender, DocumentOpenedEventArgs args)
        {
            Autodesk.Revit.ApplicationServices.Application app = (Autodesk.Revit.ApplicationServices.Application)sender;
            Document doc = args.Document;
            app.DocumentChanged += docChange;

        }

        private void docChange(object sender, DocumentChangedEventArgs dce)
        {
           
        }
    }
}
