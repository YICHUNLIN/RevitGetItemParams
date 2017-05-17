namespace GetItemParams.View
{
    partial class NewNewForm
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
            this._outputBTN = new System.Windows.Forms.Button();
            this._filenameTB = new System.Windows.Forms.TextBox();
            this._show1LB = new System.Windows.Forms.Label();
            this._show2LB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _outputBTN
            // 
            this._outputBTN.Location = new System.Drawing.Point(256, 30);
            this._outputBTN.Name = "_outputBTN";
            this._outputBTN.Size = new System.Drawing.Size(75, 23);
            this._outputBTN.TabIndex = 0;
            this._outputBTN.Text = "輸出";
            this._outputBTN.UseVisualStyleBackColor = true;
            this._outputBTN.Click += new System.EventHandler(this._outputBTN_Click);
            // 
            // _filenameTB
            // 
            this._filenameTB.Location = new System.Drawing.Point(107, 32);
            this._filenameTB.Name = "_filenameTB";
            this._filenameTB.Size = new System.Drawing.Size(114, 22);
            this._filenameTB.TabIndex = 1;
            this._filenameTB.TextChanged += new System.EventHandler(this._filenameTB_TextChanged);
            // 
            // _show1LB
            // 
            this._show1LB.AutoSize = true;
            this._show1LB.Location = new System.Drawing.Point(12, 35);
            this._show1LB.Name = "_show1LB";
            this._show1LB.Size = new System.Drawing.Size(89, 12);
            this._show1LB.TabIndex = 2;
            this._show1LB.Text = "檔案名稱及位置";
            // 
            // _show2LB
            // 
            this._show2LB.AutoSize = true;
            this._show2LB.Location = new System.Drawing.Point(227, 35);
            this._show2LB.Name = "_show2LB";
            this._show2LB.Size = new System.Drawing.Size(23, 12);
            this._show2LB.TabIndex = 3;
            this._show2LB.Text = ".csv";
            // 
            // NewNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 81);
            this.Controls.Add(this._show2LB);
            this.Controls.Add(this._show1LB);
            this.Controls.Add(this._filenameTB);
            this.Controls.Add(this._outputBTN);
            this.Name = "NewNewForm";
            this.Text = "BIM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _outputBTN;
        private System.Windows.Forms.TextBox _filenameTB;
        private System.Windows.Forms.Label _show1LB;
        private System.Windows.Forms.Label _show2LB;
    }
}