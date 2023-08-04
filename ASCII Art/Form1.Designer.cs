namespace ASCII_Art
{
    partial class Form
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
            this.btnConvertToASCII = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.textPath = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnConvertToASCII
            // 
            this.btnConvertToASCII.Location = new System.Drawing.Point(66, 145);
            this.btnConvertToASCII.Name = "btnConvertToASCII";
            this.btnConvertToASCII.Size = new System.Drawing.Size(156, 67);
            this.btnConvertToASCII.TabIndex = 3;
            this.btnConvertToASCII.Text = "Convert To ASCII";
            this.btnConvertToASCII.UseVisualStyleBackColor = true;
            //this.btnConvertToASCII.Click += new System.EventHandler(this.BtnConvertToASCII_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(12, 48);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(266, 43);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(13, 14);
            this.textPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(971, 26);
            this.textPath.TabIndex = 1;
            // 
            // browser
            // 
            this.browser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browser.Location = new System.Drawing.Point(297, 57);
            this.browser.MinimumSize = new System.Drawing.Size(30, 31);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(687, 615);
            this.browser.TabIndex = 0;
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(66, 608);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(171, 64);
            this.btnSaveAs.TabIndex = 4;
            this.btnSaveAs.Text = "Save As";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.BtnSaveAs_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1002, 686);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnConvertToASCII);
            this.Controls.Add(this.btnSaveAs);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form";
            this.Text = "ASCII ART";
            this.TransparencyKey = System.Drawing.Color.RosyBrown;
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        public System.Windows.Forms.Button btnConvertToASCII;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSaveAs;
        public System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        public System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

