namespace DoltSharp
{
    partial class Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Project));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.TxtName = new MetroFramework.Controls.MetroTextBox();
            this.TxtDescription = new MetroFramework.Controls.MetroTextBox();
            this.DtpStartdate = new MetroFramework.Controls.MetroDateTime();
            this.DtpDeadline = new MetroFramework.Controls.MetroDateTime();
            this.BtnReturn = new MetroFramework.Controls.MetroButton();
            this.TxtResource = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(110, 210);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(140, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Nombre del proyecto:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(226, 60);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(151, 242);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Descripcion:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(151, 313);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(85, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Fecha Limite:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(151, 273);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(99, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Fecha de Inicio:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(58, 385);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(0, 0);
            this.metroLabel5.TabIndex = 5;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(96, 354);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(154, 19);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Asigaciones de Recursos:";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(196, 414);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(82, 54);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtName
            // 
            // 
            // 
            // 
            this.TxtName.CustomButton.Image = null;
            this.TxtName.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.TxtName.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtName.CustomButton.Name = "";
            this.TxtName.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.TxtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtName.CustomButton.TabIndex = 1;
            this.TxtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtName.CustomButton.UseSelectable = true;
            this.TxtName.CustomButton.Visible = false;
            this.TxtName.Lines = new string[0];
            this.TxtName.Location = new System.Drawing.Point(262, 210);
            this.TxtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtName.MaxLength = 32767;
            this.TxtName.Name = "TxtName";
            this.TxtName.PasswordChar = '\0';
            this.TxtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtName.SelectedText = "";
            this.TxtName.SelectionLength = 0;
            this.TxtName.SelectionStart = 0;
            this.TxtName.ShortcutsEnabled = true;
            this.TxtName.Size = new System.Drawing.Size(164, 19);
            this.TxtName.TabIndex = 8;
            this.TxtName.UseSelectable = true;
            this.TxtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtDescription
            // 
            // 
            // 
            // 
            this.TxtDescription.CustomButton.Image = null;
            this.TxtDescription.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.TxtDescription.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtDescription.CustomButton.Name = "";
            this.TxtDescription.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.TxtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtDescription.CustomButton.TabIndex = 1;
            this.TxtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtDescription.CustomButton.UseSelectable = true;
            this.TxtDescription.CustomButton.Visible = false;
            this.TxtDescription.Lines = new string[0];
            this.TxtDescription.Location = new System.Drawing.Point(262, 242);
            this.TxtDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtDescription.MaxLength = 32767;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.PasswordChar = '\0';
            this.TxtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtDescription.SelectedText = "";
            this.TxtDescription.SelectionLength = 0;
            this.TxtDescription.SelectionStart = 0;
            this.TxtDescription.ShortcutsEnabled = true;
            this.TxtDescription.Size = new System.Drawing.Size(164, 19);
            this.TxtDescription.TabIndex = 9;
            this.TxtDescription.UseSelectable = true;
            this.TxtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DtpStartdate
            // 
            this.DtpStartdate.Location = new System.Drawing.Point(262, 273);
            this.DtpStartdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DtpStartdate.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtpStartdate.Name = "DtpStartdate";
            this.DtpStartdate.Size = new System.Drawing.Size(165, 29);
            this.DtpStartdate.TabIndex = 10;
            // 
            // DtpDeadline
            // 
            this.DtpDeadline.Location = new System.Drawing.Point(262, 313);
            this.DtpDeadline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DtpDeadline.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtpDeadline.Name = "DtpDeadline";
            this.DtpDeadline.Size = new System.Drawing.Size(165, 29);
            this.DtpDeadline.TabIndex = 11;
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(322, 414);
            this.BtnReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(82, 54);
            this.BtnReturn.TabIndex = 13;
            this.BtnReturn.Text = "Regresar";
            this.BtnReturn.UseSelectable = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // TxtResource
            // 
            // 
            // 
            // 
            this.TxtResource.CustomButton.Image = null;
            this.TxtResource.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.TxtResource.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtResource.CustomButton.Name = "";
            this.TxtResource.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.TxtResource.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtResource.CustomButton.TabIndex = 1;
            this.TxtResource.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtResource.CustomButton.UseSelectable = true;
            this.TxtResource.CustomButton.Visible = false;
            this.TxtResource.Lines = new string[0];
            this.TxtResource.Location = new System.Drawing.Point(262, 354);
            this.TxtResource.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtResource.MaxLength = 32767;
            this.TxtResource.Name = "TxtResource";
            this.TxtResource.PasswordChar = '\0';
            this.TxtResource.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtResource.SelectedText = "";
            this.TxtResource.SelectionLength = 0;
            this.TxtResource.SelectionStart = 0;
            this.TxtResource.ShortcutsEnabled = true;
            this.TxtResource.Size = new System.Drawing.Size(164, 19);
            this.TxtResource.TabIndex = 14;
            this.TxtResource.UseSelectable = true;
            this.TxtResource.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtResource.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 477);
            this.Controls.Add(this.TxtResource);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.DtpDeadline);
            this.Controls.Add(this.DtpStartdate);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Project";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "Agregar Proyecto";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroTextBox TxtName;
        private MetroFramework.Controls.MetroTextBox TxtDescription;
        private MetroFramework.Controls.MetroDateTime DtpStartdate;
        private MetroFramework.Controls.MetroDateTime DtpDeadline;
        private MetroFramework.Controls.MetroButton BtnReturn;
        private MetroFramework.Controls.MetroTextBox TxtResource;
    }
}