namespace GetItemParams
{
    partial class CusForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._parameterlv = new System.Windows.Forms.ListView();
            this._g1 = new System.Windows.Forms.GroupBox();
            this._checkbtn = new System.Windows.Forms.Button();
            this._pnameTB = new System.Windows.Forms.TextBox();
            this._parmNamelb = new System.Windows.Forms.Label();
            this._g2 = new System.Windows.Forms.GroupBox();
            this._g3 = new System.Windows.Forms.GroupBox();
            this._parvaluelb = new System.Windows.Forms.Label();
            this._parnamelb = new System.Windows.Forms.Label();
            this._parvaluetb = new System.Windows.Forms.TextBox();
            this._parnametb = new System.Windows.Forms.TextBox();
            this._saveNewbtn = new System.Windows.Forms.Button();
            this._componentidlb = new System.Windows.Forms.Label();
            this._componentnamelb = new System.Windows.Forms.Label();
            this._g1.SuspendLayout();
            this._g2.SuspendLayout();
            this._g3.SuspendLayout();
            this.SuspendLayout();
            // 
            // _parameterlv
            // 
            this._parameterlv.Location = new System.Drawing.Point(10, 21);
            this._parameterlv.Name = "_parameterlv";
            this._parameterlv.Size = new System.Drawing.Size(330, 374);
            this._parameterlv.TabIndex = 0;
            this._parameterlv.UseCompatibleStateImageBehavior = false;
            this._parameterlv.SelectedIndexChanged += new System.EventHandler(this._parameterlv_SelectedIndexChanged);
            // 
            // _g1
            // 
            this._g1.Controls.Add(this._checkbtn);
            this._g1.Controls.Add(this._pnameTB);
            this._g1.Controls.Add(this._parmNamelb);
            this._g1.Location = new System.Drawing.Point(14, 54);
            this._g1.Name = "_g1";
            this._g1.Size = new System.Drawing.Size(242, 110);
            this._g1.TabIndex = 1;
            this._g1.TabStop = false;
            this._g1.Text = "修改區";
            // 
            // _checkbtn
            // 
            this._checkbtn.Location = new System.Drawing.Point(185, 81);
            this._checkbtn.Name = "_checkbtn";
            this._checkbtn.Size = new System.Drawing.Size(51, 23);
            this._checkbtn.TabIndex = 3;
            this._checkbtn.Text = "儲存";
            this._checkbtn.UseVisualStyleBackColor = true;
            this._checkbtn.Click += new System.EventHandler(this._checkbtn_Click);
            // 
            // _pnameTB
            // 
            this._pnameTB.Location = new System.Drawing.Point(19, 47);
            this._pnameTB.Name = "_pnameTB";
            this._pnameTB.Size = new System.Drawing.Size(130, 22);
            this._pnameTB.TabIndex = 2;
            this._pnameTB.TextChanged += new System.EventHandler(this._pnameTB_TextChanged);
            // 
            // _parmNamelb
            // 
            this._parmNamelb.AutoSize = true;
            this._parmNamelb.Location = new System.Drawing.Point(17, 32);
            this._parmNamelb.Name = "_parmNamelb";
            this._parmNamelb.Size = new System.Drawing.Size(53, 12);
            this._parmNamelb.TabIndex = 0;
            this._parmNamelb.Text = "參數名稱";
            // 
            // _g2
            // 
            this._g2.Controls.Add(this._parameterlv);
            this._g2.Location = new System.Drawing.Point(261, 13);
            this._g2.Name = "_g2";
            this._g2.Size = new System.Drawing.Size(346, 414);
            this._g2.TabIndex = 2;
            this._g2.TabStop = false;
            this._g2.Text = "參數區";
            // 
            // _g3
            // 
            this._g3.Controls.Add(this._parvaluelb);
            this._g3.Controls.Add(this._parnamelb);
            this._g3.Controls.Add(this._parvaluetb);
            this._g3.Controls.Add(this._parnametb);
            this._g3.Controls.Add(this._saveNewbtn);
            this._g3.Location = new System.Drawing.Point(14, 170);
            this._g3.Name = "_g3";
            this._g3.Size = new System.Drawing.Size(243, 140);
            this._g3.TabIndex = 3;
            this._g3.TabStop = false;
            this._g3.Text = "新增參數";
            // 
            // _parvaluelb
            // 
            this._parvaluelb.AutoSize = true;
            this._parvaluelb.Location = new System.Drawing.Point(20, 69);
            this._parvaluelb.Name = "_parvaluelb";
            this._parvaluelb.Size = new System.Drawing.Size(41, 12);
            this._parvaluelb.TabIndex = 4;
            this._parvaluelb.Text = "參數值";
            // 
            // _parnamelb
            // 
            this._parnamelb.AutoSize = true;
            this._parnamelb.Location = new System.Drawing.Point(18, 35);
            this._parnamelb.Name = "_parnamelb";
            this._parnamelb.Size = new System.Drawing.Size(53, 12);
            this._parnamelb.TabIndex = 3;
            this._parnamelb.Text = "參數名稱";
            // 
            // _parvaluetb
            // 
            this._parvaluetb.Location = new System.Drawing.Point(77, 66);
            this._parvaluetb.Name = "_parvaluetb";
            this._parvaluetb.Size = new System.Drawing.Size(116, 22);
            this._parvaluetb.TabIndex = 2;
            this._parvaluetb.TextChanged += new System.EventHandler(this._parvaluetb_TextChanged);
            // 
            // _parnametb
            // 
            this._parnametb.Location = new System.Drawing.Point(77, 32);
            this._parnametb.Name = "_parnametb";
            this._parnametb.Size = new System.Drawing.Size(116, 22);
            this._parnametb.TabIndex = 1;
            this._parnametb.TextChanged += new System.EventHandler(this._parnametb_TextChanged);
            // 
            // _saveNewbtn
            // 
            this._saveNewbtn.Location = new System.Drawing.Point(186, 111);
            this._saveNewbtn.Name = "_saveNewbtn";
            this._saveNewbtn.Size = new System.Drawing.Size(50, 23);
            this._saveNewbtn.TabIndex = 0;
            this._saveNewbtn.Text = "儲存";
            this._saveNewbtn.UseVisualStyleBackColor = true;
            this._saveNewbtn.Click += new System.EventHandler(this._saveNewbtn_Click);
            // 
            // _componentidlb
            // 
            this._componentidlb.AutoSize = true;
            this._componentidlb.Location = new System.Drawing.Point(12, 25);
            this._componentidlb.Name = "_componentidlb";
            this._componentidlb.Size = new System.Drawing.Size(53, 12);
            this._componentidlb.TabIndex = 4;
            this._componentidlb.Text = "元件類別";
            // 
            // _componentnamelb
            // 
            this._componentnamelb.AutoSize = true;
            this._componentnamelb.Location = new System.Drawing.Point(71, 25);
            this._componentnamelb.Name = "_componentnamelb";
            this._componentnamelb.Size = new System.Drawing.Size(0, 12);
            this._componentnamelb.TabIndex = 5;
            // 
            // CusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 439);
            this.Controls.Add(this._componentnamelb);
            this.Controls.Add(this._componentidlb);
            this.Controls.Add(this._g3);
            this.Controls.Add(this._g2);
            this.Controls.Add(this._g1);
            this.Name = "CusForm";
            this.Text = "CusForm";
            this._g1.ResumeLayout(false);
            this._g1.PerformLayout();
            this._g2.ResumeLayout(false);
            this._g3.ResumeLayout(false);
            this._g3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView _parameterlv;
        private System.Windows.Forms.GroupBox _g1;
        private System.Windows.Forms.GroupBox _g2;
        private System.Windows.Forms.TextBox _pnameTB;
        private System.Windows.Forms.Label _parmNamelb;
        private System.Windows.Forms.GroupBox _g3;
        private System.Windows.Forms.Button _checkbtn;
        private System.Windows.Forms.Label _parvaluelb;
        private System.Windows.Forms.Label _parnamelb;
        private System.Windows.Forms.TextBox _parvaluetb;
        private System.Windows.Forms.TextBox _parnametb;
        private System.Windows.Forms.Button _saveNewbtn;
        private System.Windows.Forms.Label _componentidlb;
        private System.Windows.Forms.Label _componentnamelb;
    }
}