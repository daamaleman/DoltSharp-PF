namespace DoltSharp
{
    partial class FrmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfig));
            this.LblTema = new MetroFramework.Controls.MetroLabel();
            this.BttnRestablecerConfig = new MetroFramework.Controls.MetroButton();
            this.BttnGuardarConfig = new MetroFramework.Controls.MetroButton();
            this.BtnReturn = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TglDark = new MetroFramework.Controls.MetroToggle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CmbStyle = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTema
            // 
            this.LblTema.AutoSize = true;
            this.LblTema.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblTema.Location = new System.Drawing.Point(174, 202);
            this.LblTema.Name = "LblTema";
            this.LblTema.Size = new System.Drawing.Size(55, 25);
            this.LblTema.TabIndex = 1;
            this.LblTema.Text = "Tema:";
            // 
            // BttnRestablecerConfig
            // 
            this.BttnRestablecerConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BttnRestablecerConfig.Location = new System.Drawing.Point(108, 353);
            this.BttnRestablecerConfig.Name = "BttnRestablecerConfig";
            this.BttnRestablecerConfig.Size = new System.Drawing.Size(151, 30);
            this.BttnRestablecerConfig.TabIndex = 15;
            this.BttnRestablecerConfig.Text = "Reestablecer Configuración";
            this.BttnRestablecerConfig.UseSelectable = true;
            // 
            // BttnGuardarConfig
            // 
            this.BttnGuardarConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BttnGuardarConfig.Location = new System.Drawing.Point(301, 353);
            this.BttnGuardarConfig.Name = "BttnGuardarConfig";
            this.BttnGuardarConfig.Size = new System.Drawing.Size(130, 30);
            this.BttnGuardarConfig.TabIndex = 16;
            this.BttnGuardarConfig.Text = "Guardar Configuracion";
            this.BttnGuardarConfig.UseSelectable = true;
            this.BttnGuardarConfig.Click += new System.EventHandler(this.BttnGuardarConfig_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnReturn.BackgroundImage")));
            this.BtnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReturn.Location = new System.Drawing.Point(454, 62);
            this.BtnReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(47, 46);
            this.BtnReturn.TabIndex = 17;
            this.BtnReturn.UseSelectable = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(227, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // TglDark
            // 
            this.TglDark.AutoSize = true;
            this.TglDark.Location = new System.Drawing.Point(268, 206);
            this.TglDark.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TglDark.Name = "TglDark";
            this.TglDark.Size = new System.Drawing.Size(80, 17);
            this.TglDark.TabIndex = 19;
            this.TglDark.Text = "Off";
            this.TglDark.UseSelectable = true;
            this.TglDark.CheckedChanged += new System.EventHandler(this.TglDark_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(174, 239);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 25);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "Estilo:";
            // 
            // CmbStyle
            // 
            this.CmbStyle.FormattingEnabled = true;
            this.CmbStyle.ItemHeight = 23;
            this.CmbStyle.Items.AddRange(new object[] {
            "Black",
            "Blue ",
            "Red"});
            this.CmbStyle.Location = new System.Drawing.Point(269, 239);
            this.CmbStyle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbStyle.Name = "CmbStyle";
            this.CmbStyle.Size = new System.Drawing.Size(108, 29);
            this.CmbStyle.TabIndex = 21;
            this.CmbStyle.UseSelectable = true;
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 431);
            this.Controls.Add(this.CmbStyle);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.TglDark);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BttnGuardarConfig);
            this.Controls.Add(this.BttnRestablecerConfig);
            this.Controls.Add(this.LblTema);
            this.Name = "FrmConfig";
            this.Resizable = false;
            this.Text = "Configuracion y Personalización";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel LblTema;
        private MetroFramework.Controls.MetroButton BttnRestablecerConfig;
        private MetroFramework.Controls.MetroButton BttnGuardarConfig;
        private MetroFramework.Controls.MetroButton BtnReturn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroToggle TglDark;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox CmbStyle;
    }
}