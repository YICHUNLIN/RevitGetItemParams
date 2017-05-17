using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetItemParams.View
{
    public partial class NewNewForm : Form
    {
        ItemController _ic = null;
        public NewNewForm(ItemController ic)
        {
            this._ic = ic;
            InitializeComponent();
        }

        private void _filenameTB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void _outputBTN_Click(object sender, EventArgs e)
        {
            if(_filenameTB.Text != "")
            {
                this._ic.write(_filenameTB.Text);
                MessageBox.Show("Output Finish");
            }
        }

        public void setItemController(ItemController ic)
        {
            this._ic = ic;
        }
    }
}
