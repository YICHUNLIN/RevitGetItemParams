using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
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

        private bool CheckType(string type)
        {
            string[] filter = {"磚牆(12)", "磚", "馬賽克", "二丁", "粉刷", "石英", "防滑", "水箱", "防水", "大廳", "回填"};
            foreach(string x in filter)
            {
               
                if (type.Contains(x))
                {
                    return true;
                }
            }
            return false;
        }

        public void write(String outfile)
        {
            if (CheckType("二丁掛修補"))
            {
                MessageBox.Show("HIHI");
            }
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
                Dictionary<string, int> floorCon = new Dictionary<string, int>();
                FileStream fs = new FileStream(path, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.Default);
                string msg = "";
                int size = 0;
                foreach (Item it in this._items)
                {
                   
                    if(this.CheckType(it.Type))
                    {
                        msg += it.IID + "  " + it.Name + " " + it.Type + " \n";
                    }else
                        sw.WriteLine(it.IID + "," + it.Name + "," + it.Type + "," + it.size + "," + it.Floor);

                }
                MessageBox.Show(msg);

                /*
                foreach(KeyValuePair<string, int> kvp in floorCon)
                {
                    sw.WriteLine(kvp.Key + "," + kvp.Value);
                }
                */
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
