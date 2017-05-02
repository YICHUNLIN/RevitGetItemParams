using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetItemParams
{
    public partial class NewForm : Form
    {
        public ItemController _ic;
        public NewForm(ItemController ic)
        {
            InitializeComponent();
            this._ic = ic;

        }
        
        public NewForm()
        {
        }

        private void _outputBTN_Click(object sender, EventArgs e)
        {
            // 如果不是空的
            if(!this.checkTB())
            {
                this._ic.write(this._filenameTB.Text);
            }
        }

        // 判斷是不是空的
        private bool checkTB()
        {
            return this._filenameTB.Text == "";
        }
    }
}
