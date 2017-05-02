using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetItemParams
{
    public class ItemController
    {
        private ItemsModel _im = null;
        private CusParameters _cps = null;
        public ItemController(ItemsModel im, CusParameters cps)
        {
            this._im = im;
            this._cps = cps;
            this._im.setItems(cps.getItems());
        }

        public void write(String filename)
        {
            if(filename != "")
                _im.write(filename);
        }

       
    }
}
