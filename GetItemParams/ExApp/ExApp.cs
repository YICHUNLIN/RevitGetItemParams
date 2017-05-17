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
using GetItemParams;

namespace ExApp
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    class ExApp : IExternalApplication
    {
        ItemController _ic = null;
        GetItemParams.View.NewNewForm _outputForm = null;

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            application.ViewActivated += new EventHandler<ViewActivatedEventArgs>(onAcgivitedView);
            application.ControlledApplication.DocumentOpened += new EventHandler<DocumentOpenedEventArgs>(OnDocOpened);
            application.Idling += new EventHandler<IdlingEventArgs>(onIdling);
            //_cachedUiCtrApp = application;
            //_cachedUiCtrApp.Idling += new EventHandler<IdlingEventArgs>(onIdling);
            return Result.Succeeded;
        }
        public void onIdling(object sender,IdlingEventArgs iea)
        {
            //MessageBox.Show("idling");
            //一直觸發
            UIApplication uiapp = sender as UIApplication;

            
            if (uiapp != null)
            {
                UIDocument uidoc = uiapp.ActiveUIDocument;
               // Document doc = uidoc.Document;
                CusParameters cp = new CusParameters(uidoc);
                ItemsModel im = new ItemsModel();
                ItemController ic = new ItemController(im, cp);
                this._ic = ic;
                if (_outputForm != null)
                {
                    _outputForm.setItemController(ic);
                }
                else{ 
                    Thread ofthread = new Thread(openForm);
                    ofthread.Start();
                }

            }
        }
        public void openForm()
        {
            _outputForm = new GetItemParams.View.NewNewForm(this._ic);
             _outputForm.ShowDialog();
        }
        public void onAcgivitedView(object sender, ViewActivatedEventArgs vae)
        {
            //MessageBox.Show("onAcgivitedView");
            //切換視圖時觸發
        }

        private void OnDocOpened(object sender, DocumentOpenedEventArgs args)
        {
            Autodesk.Revit.ApplicationServices.Application app = (Autodesk.Revit.ApplicationServices.Application)sender;
            Document doc = args.Document;
            //MessageBox.Show("OnDocOpened");
            //打開視圖時觸發
           
            app.DocumentChanged += docChange;

        }

        private void docChange(object sender, DocumentChangedEventArgs dce)
        {

            MessageBox.Show("OnDocChange");
        }
    }
}
