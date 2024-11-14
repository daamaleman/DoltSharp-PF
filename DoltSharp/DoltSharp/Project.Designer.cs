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
            this.CmbResource = new MetroFramework.Controls.MetroComboBox();
            this.BtnReturn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(179, 258);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(146, 20);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Nombre del proyecto:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(301, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(201, 298);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(85, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Descripcion:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(201, 385);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(90, 20);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Fecha Limite:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(201, 336);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(105, 20);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Fecha de Inicio:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(77, 474);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(0, 0);
            this.metroLabel5.TabIndex = 5;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(160, 448);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(165, 20);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Asigaciones de Recursos:";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(350, 509);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(109, 66);
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
            this.TxtName.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.TxtName.CustomButton.Name = "";
            this.TxtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtName.CustomButton.TabIndex = 1;
            this.TxtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtName.CustomButton.UseSelectable = true;
            this.TxtName.CustomButton.Visible = false;
            this.TxtName.Lines = new string[0];
            this.TxtName.Location = new System.Drawing.Point(350, 258);
            this.TxtName.MaxLength = 32767;
            this.TxtName.Name = "TxtName";
            this.TxtName.PasswordChar = '\0';
            this.TxtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtName.SelectedText = "";
            this.TxtName.SelectionLength = 0;
            this.TxtName.SelectionStart = 0;
            this.TxtName.ShortcutsEnabled = true;
            this.TxtName.Size = new System.Drawing.Size(219, 23);
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
            this.TxtDescription.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.TxtDescription.CustomButton.Name = "";
            this.TxtDescription.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtDescription.CustomButton.TabIndex = 1;
            this.TxtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtDescription.CustomButton.UseSelectable = true;
            this.TxtDescription.CustomButton.Visible = false;
            this.TxtDescription.Lines = new string[0];
            this.TxtDescription.Location = new System.Drawing.Point(350, 295);
            this.TxtDescription.MaxLength = 32767;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.PasswordChar = '\0';
            this.TxtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtDescription.SelectedText = "";
            this.TxtDescription.SelectionLength = 0;
            this.TxtDescription.SelectionStart = 0;
            this.TxtDescription.ShortcutsEnabled = true;
            this.TxtDescription.Size = new System.Drawing.Size(219, 23);
            this.TxtDescription.TabIndex = 9;
            this.TxtDescription.UseSelectable = true;
            this.TxtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DtpStartdate
            // 
            this.DtpStartdate.Location = new System.Drawing.Point(350, 336);
            this.DtpStartdate.MinimumSize = new System.Drawing.Size(0, 30);
            this.DtpStartdate.Name = "DtpStartdate";
            this.DtpStartdate.Size = new System.Drawing.Size(219, 30);
            this.DtpStartdate.TabIndex = 10;
            // 
            // DtpDeadline
            // 
            this.DtpDeadline.Location = new System.Drawing.Point(350, 385);
            this.DtpDeadline.MinimumSize = new System.Drawing.Size(0, 30);
            this.DtpDeadline.Name = "DtpDeadline";
            this.DtpDeadline.Size = new System.Drawing.Size(219, 30);
            this.DtpDeadline.TabIndex = 11;
            // 
            // CmbResource
            // 
            this.CmbResource.FormattingEnabled = true;
            this.CmbResource.ItemHeight = 24;
            this.CmbResource.Location = new System.Drawing.Point(350, 438);
            this.CmbResource.Name = "CmbResource";
            this.CmbResource.Size = new System.Drawing.Size(219, 30);
            this.CmbResource.TabIndex = 12;
            this.CmbResource.UseSelectable = true;
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(500, 509);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(109, 66);
            this.BtnReturn.TabIndex = 13;
            this.BtnReturn.Text = "Regresar";
            this.BtnReturn.UseSelectable = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.CmbResource);
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
            this.Name = "Project";
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
        private MetroFramework.Controls.MetroComboBox CmbResource;
        private MetroFramework.Controls.MetroButton BtnReturn;
    }
}