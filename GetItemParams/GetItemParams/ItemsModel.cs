using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GetItemParams
{
    public class ItemsModel
    {
        private List<Item> _items = null;
        public ItemsModel()
        {
            if(this._items == null)
                this._items = new List<Item>();
        }

        public void setItem(Item newit)
        {
            if (this._items != null)
                this._items.Add(newit);
        }

        public void setItems(List<Item> its)
        {
            this._items = its;
        }

        public void write(String outfile)
        {
            /*
            String fn = outfile+".csv";
            System.IO.FileInfo fileattribute = new System.IO.FileInfo(fn);
            fileattribute.Attributes = System.IO.FileAttributes.Normal;
            
            System.IO.FileStream fs = new System.IO.FileStream(fn, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write);
            System.IO.StreamWriter sw = new System.IO.StreamWriter(fs, System.Text.Encoding.Default);
            
            foreach(Item it in this._items)
            {
                sw.WriteLine(it.IID + "," + it.Name+","+it.Type+","+it.size+","+it.Floor);
            }
            sw.Close();*/

            string path = outfile + ".csv";
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                FileStream fs = new FileStream(path, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.Default);
                foreach (Item it in this._items)
                {
                    sw.WriteLine(it.IID + "," + it.Name + "," + it.Type + "," + it.size + "," + it.Floor);
                }
                sw.Flush();
                sw.Close();
                fs.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
