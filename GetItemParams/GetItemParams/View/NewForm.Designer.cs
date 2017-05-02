namespace GetItemParams
{
    partial class NewForm
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
            this._filenameTB = new System.Windows.Forms.TextBox();
            this._titleLB = new System.Windows.Forms.Label();
            this._outputBTN = new System.Windows.Forms.Button();
            this._csvLB = new System.Windows.Forms.Label();
            this._selectLV = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this._gb1 = new System.Windows.Forms.GroupBox();
            this._gb2 = new System.Windows.Forms.GroupBox();
            this._paramsofItem = new System.Windows.Forms.ListView();
            this._showcountLabel = new System.Windows.Forms.Label();
            this._contlabel = new System.Windows.Forms.Label();
            this._gb1.SuspendLayout();
            this._gb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _filenameTB
            // 
            this._filenameTB.Location = new System.Drawing.Point(74, 13);
            this._filenameTB.Name = "_filenameTB";
            this._filenameTB.Size = new System.Drawing.Size(110, 22);
            this._filenameTB.TabIndex = 0;
            // 
            // _titleLB
            // 
            this._titleLB.AutoSize = true;
            this._titleLB.Location = new System.Drawing.Point(12, 16);
            this._titleLB.Name = "_titleLB";
            this._titleLB.Size = new System.Drawing.Size(56, 12);
            this._titleLB.TabIndex = 1;
            this._titleLB.Text = "輸出檔名:";
            // 
            // _outputBTN
            // 
            this._outputBTN.Location = new System.Drawing.Point(219, 11);
            this._outputBTN.Name = "_outputBTN";
            this._outputBTN.Size = new System.Drawing.Size(75, 23);
            this._outputBTN.TabIndex = 2;
            this._outputBTN.Text = "輸出";
            this._outputBTN.UseVisualStyleBackColor = true;
            this._outputBTN.Click += new System.EventHandler(this._outputBTN_Click);
            // 
            // _csvLB
            // 
            this._csvLB.AutoSize = true;
            this._csvLB.Location = new System.Drawing.Point(190, 16);
            this._csvLB.Name = "_csvLB";
            this._csvLB.Size = new System.Drawing.Size(23, 12);
            this._csvLB.TabIndex = 3;
            this._csvLB.Text = ".csv";
            // 
            // _selectLV
            // 
            this._selectLV.Location = new System.Drawing.Point(10, 21);
            this._selectLV.Name = "_selectLV";
            this._selectLV.Size = new System.Drawing.Size(145, 240);
            this._selectLV.TabIndex = 4;
            this._selectLV.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 5;
            // 
            // _gb1
            // 
            this._gb1.Controls.Add(this._selectLV);
            this._gb1.Location = new System.Drawing.Point(14, 68);
            this._gb1.Name = "_gb1";
            this._gb1.Size = new System.Drawing.Size(170, 277);
            this._gb1.TabIndex = 6;
            this._gb1.TabStop = false;
            this._gb1.Text = "所選元件";
            // 
            // _gb2
            // 
            this._gb2.Controls.Add(this._paramsofItem);
            this._gb2.Location = new System.Drawing.Point(207, 68);
            this._gb2.Name = "_gb2";
            this._gb2.Size = new System.Drawing.Size(194, 277);
            this._gb2.TabIndex = 7;
            this._gb2.TabStop = false;
            this._gb2.Text = "元件參數";
            // 
            // _paramsofItem
            // 
            this._paramsofItem.Location = new System.Drawing.Point(13, 21);
            this._paramsofItem.Name = "_paramsofItem";
            this._paramsofItem.Size = new System.Drawing.Size(172, 240);
            this._paramsofItem.TabIndex = 0;
            this._paramsofItem.UseCompatibleStateImageBehavior = false;
            // 
            // _showcountLabel
            // 
            this._showcountLabel.AutoSize = true;
            this._showcountLabel.Location = new System.Drawing.Point(307, 16);
            this._showcountLabel.Name = "_showcountLabel";
            this._showcountLabel.Size = new System.Drawing.Size(77, 12);
            this._showcountLabel.TabIndex = 8;
            this._showcountLabel.Text = "所選元件數量";
            // 
            // _contlabel
            // 
            this._contlabel.AutoSize = true;
            this._contlabel.Location = new System.Drawing.Point(390, 16);
            this._contlabel.Name = "_contlabel";
            this._contlabel.Size = new System.Drawing.Size(11, 12);
            this._contlabel.TabIndex = 9;
            this._contlabel.Text = "0";
            // 
            // NewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 357);
            this.Controls.Add(this._contlabel);
            this.Controls.Add(this._showcountLabel);
            this.Controls.Add(this._gb2);
            this.Controls.Add(this._gb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._csvLB);
            this.Controls.Add(this._outputBTN);
            this.Controls.Add(this._titleLB);
            this.Controls.Add(this._filenameTB);
            this.Name = "NewForm";
            this.Text = "輸出模型資料";
            this._gb1.ResumeLayout(false);
            this._gb2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _filenameTB;
        private System.Windows.Forms.Label _titleLB;
        private System.Windows.Forms.Button _outputBTN;
        private System.Windows.Forms.Label _csvLB;
        private System.Windows.Forms.ListView _selectLV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox _gb1;
        private System.Windows.Forms.GroupBox _gb2;
        private System.Windows.Forms.Label _showcountLabel;
        private System.Windows.Forms.Label _contlabel;
        private System.Windows.Forms.ListView _paramsofItem;
    }
}