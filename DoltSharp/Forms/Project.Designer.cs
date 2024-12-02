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
            this.LblProjectName = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblProjectDescription = new MetroFramework.Controls.MetroLabel();
            this.LblProjectDeadLine = new MetroFramework.Controls.MetroLabel();
            this.LblProjectStartDate = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.LblProjectResources = new MetroFramework.Controls.MetroLabel();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.TxtProjectName = new MetroFramework.Controls.MetroTextBox();
            this.TxtProjectDescription = new MetroFramework.Controls.MetroTextBox();
            this.DtpProjectStartDate = new MetroFramework.Controls.MetroDateTime();
            this.DtpProjectDeadLine = new MetroFramework.Controls.MetroDateTime();
            this.BtnReturn = new MetroFramework.Controls.MetroButton();
            this.TxtProjectResources = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblProjectName
            // 
            this.LblProjectName.AutoSize = true;
            this.LblProjectName.Location = new System.Drawing.Point(52, 209);
            this.LblProjectName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblProjectName.Name = "LblProjectName";
            this.LblProjectName.Size = new System.Drawing.Size(140, 19);
            this.LblProjectName.TabIndex = 1;
            this.LblProjectName.Text = "Nombre del proyecto:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(169, 62);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LblProjectDescription
            // 
            this.LblProjectDescription.AutoSize = true;
            this.LblProjectDescription.Location = new System.Drawing.Point(98, 239);
            this.LblProjectDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblProjectDescription.Name = "LblProjectDescription";
            this.LblProjectDescription.Size = new System.Drawing.Size(79, 19);
            this.LblProjectDescription.TabIndex = 2;
            this.LblProjectDescription.Text = "Descripcion:";
            // 
            // LblProjectDeadLine
            // 
            this.LblProjectDeadLine.AutoSize = true;
            this.LblProjectDeadLine.Location = new System.Drawing.Point(94, 312);
            this.LblProjectDeadLine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblProjectDeadLine.Name = "LblProjectDeadLine";
            this.LblProjectDeadLine.Size = new System.Drawing.Size(85, 19);
            this.LblProjectDeadLine.TabIndex = 3;
            this.LblProjectDeadLine.Text = "Fecha Limite:";
            // 
            // LblProjectStartDate
            // 
            this.LblProjectStartDate.AutoSize = true;
            this.LblProjectStartDate.Location = new System.Drawing.Point(83, 272);
            this.LblProjectStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblProjectStartDate.Name = "LblProjectStartDate";
            this.LblProjectStartDate.Size = new System.Drawing.Size(99, 19);
            this.LblProjectStartDate.TabIndex = 4;
            this.LblProjectStartDate.Text = "Fecha de Inicio:";
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
            // LblProjectResources
            // 
            this.LblProjectResources.AutoSize = true;
            this.LblProjectResources.Location = new System.Drawing.Point(38, 355);
            this.LblProjectResources.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblProjectResources.Name = "LblProjectResources";
            this.LblProjectResources.Size = new System.Drawing.Size(154, 19);
            this.LblProjectResources.TabIndex = 6;
            this.LblProjectResources.Text = "Asigaciones de Recursos:";
            // 
            // BtnSave
            // 
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.Location = new System.Drawing.Point(123, 413);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(69, 32);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtProjectName
            // 
            // 
            // 
            // 
            this.TxtProjectName.CustomButton.Image = null;
            this.TxtProjectName.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.TxtProjectName.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.TxtProjectName.CustomButton.Name = "";
            this.TxtProjectName.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.TxtProjectName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtProjectName.CustomButton.TabIndex = 1;
            this.TxtProjectName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtProjectName.CustomButton.UseSelectable = true;
            this.TxtProjectName.CustomButton.Visible = false;
            this.TxtProjectName.Lines = new string[0];
            this.TxtProjectName.Location = new System.Drawing.Point(194, 209);
            this.TxtProjectName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtProjectName.MaxLength = 32767;
            this.TxtProjectName.Name = "TxtProjectName";
            this.TxtProjectName.PasswordChar = '\0';
            this.TxtProjectName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtProjectName.SelectedText = "";
            this.TxtProjectName.SelectionLength = 0;
            this.TxtProjectName.SelectionStart = 0;
            this.TxtProjectName.ShortcutsEnabled = true;
            this.TxtProjectName.Size = new System.Drawing.Size(164, 19);
            this.TxtProjectName.TabIndex = 1;
            this.TxtProjectName.UseSelectable = true;
            this.TxtProjectName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtProjectName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtProjectDescription
            // 
            // 
            // 
            // 
            this.TxtProjectDescription.CustomButton.Image = null;
            this.TxtProjectDescription.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.TxtProjectDescription.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.TxtProjectDescription.CustomButton.Name = "";
            this.TxtProjectDescription.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.TxtProjectDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtProjectDescription.CustomButton.TabIndex = 1;
            this.TxtProjectDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtProjectDescription.CustomButton.UseSelectable = true;
            this.TxtProjectDescription.CustomButton.Visible = false;
            this.TxtProjectDescription.Lines = new string[0];
            this.TxtProjectDescription.Location = new System.Drawing.Point(194, 239);
            this.TxtProjectDescription.Margin = new System.Windows.Forms.Padding(2);
            this.TxtProjectDescription.MaxLength = 32767;
            this.TxtProjectDescription.Name = "TxtProjectDescription";
            this.TxtProjectDescription.PasswordChar = '\0';
            this.TxtProjectDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtProjectDescription.SelectedText = "";
            this.TxtProjectDescription.SelectionLength = 0;
            this.TxtProjectDescription.SelectionStart = 0;
            this.TxtProjectDescription.ShortcutsEnabled = true;
            this.TxtProjectDescription.Size = new System.Drawing.Size(164, 19);
            this.TxtProjectDescription.TabIndex = 2;
            this.TxtProjectDescription.UseSelectable = true;
            this.TxtProjectDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtProjectDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DtpProjectStartDate
            // 
            this.DtpProjectStartDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DtpProjectStartDate.Location = new System.Drawing.Point(194, 272);
            this.DtpProjectStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.DtpProjectStartDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtpProjectStartDate.Name = "DtpProjectStartDate";
            this.DtpProjectStartDate.Size = new System.Drawing.Size(165, 29);
            this.DtpProjectStartDate.TabIndex = 3;
            // 
            // DtpProjectDeadLine
            // 
            this.DtpProjectDeadLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DtpProjectDeadLine.Location = new System.Drawing.Point(194, 312);
            this.DtpProjectDeadLine.Margin = new System.Windows.Forms.Padding(2);
            this.DtpProjectDeadLine.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtpProjectDeadLine.Name = "DtpProjectDeadLine";
            this.DtpProjectDeadLine.Size = new System.Drawing.Size(165, 29);
            this.DtpProjectDeadLine.TabIndex = 4;
            // 
            // BtnReturn
            // 
            this.BtnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReturn.Location = new System.Drawing.Point(251, 413);
            this.BtnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(82, 32);
            this.BtnReturn.TabIndex = 13;
            this.BtnReturn.Text = "Regresar";
            this.BtnReturn.UseSelectable = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // TxtProjectResources
            // 
            // 
            // 
            // 
            this.TxtProjectResources.CustomButton.Image = null;
            this.TxtProjectResources.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.TxtProjectResources.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.TxtProjectResources.CustomButton.Name = "";
            this.TxtProjectResources.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.TxtProjectResources.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtProjectResources.CustomButton.TabIndex = 1;
            this.TxtProjectResources.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtProjectResources.CustomButton.UseSelectable = true;
            this.TxtProjectResources.CustomButton.Visible = false;
            this.TxtProjectResources.Lines = new string[0];
            this.TxtProjectResources.Location = new System.Drawing.Point(194, 355);
            this.TxtProjectResources.Margin = new System.Windows.Forms.Padding(2);
            this.TxtProjectResources.MaxLength = 32767;
            this.TxtProjectResources.Name = "TxtProjectResources";
            this.TxtProjectResources.PasswordChar = '\0';
            this.TxtProjectResources.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtProjectResources.SelectedText = "";
            this.TxtProjectResources.SelectionLength = 0;
            this.TxtProjectResources.SelectionStart = 0;
            this.TxtProjectResources.ShortcutsEnabled = true;
            this.TxtProjectResources.Size = new System.Drawing.Size(164, 19);
            this.TxtProjectResources.TabIndex = 14;
            this.TxtProjectResources.UseSelectable = true;
            this.TxtProjectResources.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtProjectResources.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 477);
            this.Controls.Add(this.TxtProjectResources);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.DtpProjectDeadLine);
            this.Controls.Add(this.DtpProjectStartDate);
            this.Controls.Add(this.TxtProjectDescription);
            this.Controls.Add(this.TxtProjectName);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblProjectResources);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.LblProjectStartDate);
            this.Controls.Add(this.LblProjectDeadLine);
            this.Controls.Add(this.LblProjectDescription);
            this.Controls.Add(this.LblProjectName);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Project";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Resizable = false;
            this.Text = "Agregar Proyecto";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel LblProjectName;
        private MetroFramework.Controls.MetroLabel LblProjectDescription;
        private MetroFramework.Controls.MetroLabel LblProjectDeadLine;
        private MetroFramework.Controls.MetroLabel LblProjectStartDate;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel LblProjectResources;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroTextBox TxtProjectName;
        private MetroFramework.Controls.MetroTextBox TxtProjectDescription;
        private MetroFramework.Controls.MetroDateTime DtpProjectStartDate;
        private MetroFramework.Controls.MetroDateTime DtpProjectDeadLine;
        private MetroFramework.Controls.MetroButton BtnReturn;
        private MetroFramework.Controls.MetroTextBox TxtProjectResources;
    }
}