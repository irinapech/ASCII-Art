namespace ASCII_Art
{
    partial class Parent
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
        /// 
        public void InitializeComponent()
        {
            this.backgroundColorButton = new System.Windows.Forms.Button();
            this.textColorButton = new System.Windows.Forms.Button();
            this.btnConvertToASCII = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.textPath = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnConvertToNumbersASCII = new System.Windows.Forms.Button();
            this.btnChangeLightness = new System.Windows.Forms.Button();
            this.btnChangeLuminosity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backgroundColorButton
            // 
            this.backgroundColorButton.Location = new System.Drawing.Point(66, 358);
            this.backgroundColorButton.Name = "backgroundColorButton";
            this.backgroundColorButton.Size = new System.Drawing.Size(156, 69);
            this.backgroundColorButton.TabIndex = 7;
            this.backgroundColorButton.Text = "Change Background Color";
            this.backgroundColorButton.UseVisualStyleBackColor = true;
            this.backgroundColorButton.Click += new System.EventHandler(this.backgroundColorButton_Click);
            // 
            // textColorButton
            // 
            this.textColorButton.Location = new System.Drawing.Point(66, 276);
            this.textColorButton.Name = "textColorButton";
            this.textColorButton.Size = new System.Drawing.Size(156, 66);
            this.textColorButton.TabIndex = 6;
            this.textColorButton.Text = "Change Text Color";
            this.textColorButton.UseVisualStyleBackColor = true;
            this.textColorButton.Click += new System.EventHandler(this.textColorButton_Click);
            // 
            // btnConvertToASCII
            // 
            this.btnConvertToASCII.Location = new System.Drawing.Point(66, 108);
            this.btnConvertToASCII.Name = "btnConvertToASCII";
            this.btnConvertToASCII.Size = new System.Drawing.Size(156, 67);
            this.btnConvertToASCII.TabIndex = 3;
            this.btnConvertToASCII.Text = "Convert To ASCII";
            this.btnConvertToASCII.UseVisualStyleBackColor = true;
            this.btnConvertToASCII.Click += new System.EventHandler(this.btnConvertToASCII_Click);
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
            this.browser.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.browser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browser.Location = new System.Drawing.Point(297, 57);
            this.browser.MinimumSize = new System.Drawing.Size(30, 31);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(687, 783);
            this.browser.TabIndex = 0;
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(66, 776);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(156, 64);
            this.btnSaveAs.TabIndex = 4;
            this.btnSaveAs.Text = "Save As";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.BtnSaveAs_Click);
            // 
            // btnConvertToNumbersASCII
            // 
            this.btnConvertToNumbersASCII.Location = new System.Drawing.Point(66, 194);
            this.btnConvertToNumbersASCII.Name = "btnConvertToNumbersASCII";
            this.btnConvertToNumbersASCII.Size = new System.Drawing.Size(156, 66);
            this.btnConvertToNumbersASCII.TabIndex = 5;
            this.btnConvertToNumbersASCII.Text = "Convert To Numbers";
            this.btnConvertToNumbersASCII.UseVisualStyleBackColor = true;
            this.btnConvertToNumbersASCII.Click += new System.EventHandler(this.BtnConvertToNumbersASCII_Click);
            // 
            // btnChangeLightness
            // 
            this.btnChangeLightness.Location = new System.Drawing.Point(66, 444);
            this.btnChangeLightness.Name = "btnChangeLightness";
            this.btnChangeLightness.Size = new System.Drawing.Size(156, 65);
            this.btnChangeLightness.TabIndex = 8;
            this.btnChangeLightness.Text = "Change Lightness";
            this.btnChangeLightness.UseVisualStyleBackColor = true;
            this.btnChangeLightness.Click += new System.EventHandler(this.BtnChangeLightness_Click);
            // 
            // btnChangeLuminosity
            // 
            this.btnChangeLuminosity.Location = new System.Drawing.Point(66, 526);
            this.btnChangeLuminosity.Name = "btnChangeLuminosity";
            this.btnChangeLuminosity.Size = new System.Drawing.Size(156, 66);
            this.btnChangeLuminosity.TabIndex = 9;
            this.btnChangeLuminosity.Text = "Change Luminosity";
            this.btnChangeLuminosity.UseVisualStyleBackColor = true;
            this.btnChangeLuminosity.Click += new System.EventHandler(this.BtnChangeLuminosity_Click);
            // 
            // Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(999, 854);
            this.Controls.Add(this.btnChangeLuminosity);
            this.Controls.Add(this.btnChangeLightness);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.backgroundColorButton);
            this.Controls.Add(this.textColorButton);
            this.Controls.Add(this.btnConvertToNumbersASCII);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnConvertToASCII);
            this.Controls.Add(this.btnSaveAs);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Parent";
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
        private System.Windows.Forms.Button btnConvertToNumbersASCII;
        private System.Windows.Forms.Button backgroundColorButton;
        private System.Windows.Forms.Button textColorButton;
        private System.Windows.Forms.Button btnChangeLightness;
        private System.Windows.Forms.Button btnChangeLuminosity;
        //private System.Windows.Forms.RichTextBox browser;
    }
}

