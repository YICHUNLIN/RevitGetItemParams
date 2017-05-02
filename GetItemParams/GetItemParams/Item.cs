using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetItemParams
{
    public class Item
    {
        private String _name;
        private String _iid;
        private String _type;
        private String _floor;
        private String _size;

        public Item()
        {

        }

        // name
        public String Name
        {
            get
            {
                return this._name;
            }

            set
            {
                this._name = value;
            }
        }

        // id
        public String IID
        {
            get
            {
                return this._iid;
            }

            set
            {
                this._iid = value;
            }
        }

        // type
        public String Type
        {
            get
            {
                return this._type;
            }

            set
            {
                this._type = value;
            }
        }

        // floor
        public String Floor
        {
            get
            {
                return this._floor;
            }

            set
            {
                this._floor = value;
            }
        }

        // size
        public String size
        {
            get
            {
                return this._size;
            }

            set
            {
                this._size = value;
            }
        }
    }
}
