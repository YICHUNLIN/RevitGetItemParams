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
    public partial class CusForm : Form
    {
        List<CusParameter> _parms = null;
        CusParameters _cps = null;
        public CusForm(CusParameters cps)
        {
            InitializeComponent();

            this._parameterlv.View = System.Windows.Forms.View.Details;
            this._parameterlv.Columns.Add("參數名稱");
            this._parameterlv.Columns.Add("參數內容");
            _cps = cps;
            _parms = _cps.getElementParameters();
            this._componentidlb.Text = _cps.Id;
            this._componentnamelb.Text = _cps.Type;
            _saveNewbtn.Enabled = false;
            _checkbtn.Enabled = false;
            this.setListView();
        }

        //更新listview
        private void setListView()
        {
            _parameterlv.Items.Clear();
            _cps.clearStorages();
            _parms = _cps.getElementParameters();
            foreach (CusParameter cp in _parms)
            {
                ListViewItem lvi = new ListViewItem(cp.DefName);
                lvi.SubItems.Add(cp.Value);
                this._parameterlv.Items.Add(lvi);
            }

            this._parameterlv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            this._parameterlv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        //更新參數
        private void _checkbtn_Click(object sender, EventArgs e)
        {
            // 　寫入
            _cps.setElementParameters(this._parmNamelb.Text, this._pnameTB.Text);
            //更新畫面
            this.setListView();
        }

        //當點選listview
        private void _parameterlv_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //選到的row
                string selectIndex = this._parameterlv.SelectedItems[0].Text;
                this._parmNamelb.Text = selectIndex;
                //取得value
                this._pnameTB.Text = _cps.getParmValueByName(selectIndex);
                this._checkbtn.Enabled = true;
            }
            catch
            {

            }
        }

        // 按下儲存 (新增參數)
        private void _saveNewbtn_Click(object sender, EventArgs e)
        {

        }

        // 當 參數名稱 tb 改變
        private void _parnametb_TextChanged(object sender, EventArgs e)
        {
            if ((_parnametb.Text == "") || (_parvaluetb.Text == ""))
            {
                _saveNewbtn.Enabled = false;
            }
            else
                _saveNewbtn.Enabled = true;
        }

        // 當 參數內容 tb改變
        private void _parvaluetb_TextChanged(object sender, EventArgs e)
        {

            if ((_parnametb.Text == "") || (_parvaluetb.Text == ""))
            {
                _saveNewbtn.Enabled = false;
            }
            else
                _saveNewbtn.Enabled = true;
        }

        // 當參數內容tb改變 (更改參數)
        private void _pnameTB_TextChanged(object sender, EventArgs e)
        {
            if(_pnameTB.Text == "")
            {
                _checkbtn.Enabled = false;
            }else
            {
                _checkbtn.Enabled = true;
            }
        }
    }
}
