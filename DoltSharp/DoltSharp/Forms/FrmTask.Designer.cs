namespace DoltSharp
{
    partial class FrmTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTask));
            this.BtnAdd = new MetroFramework.Controls.MetroButton();
            this.LblName = new MetroFramework.Controls.MetroLabel();
            this.LblTaskDescription = new MetroFramework.Controls.MetroLabel();
            this.LblTaskDeadLine = new MetroFramework.Controls.MetroLabel();
            this.LblTaskStatus = new MetroFramework.Controls.MetroLabel();
            this.LblTaskPriority = new MetroFramework.Controls.MetroLabel();
            this.DtpTaskDeadLine = new MetroFramework.Controls.MetroDateTime();
            this.TxtTaskName = new MetroFramework.Controls.MetroTextBox();
            this.TxtTaskDescription = new MetroFramework.Controls.MetroTextBox();
            this.CmbTaskPriority = new MetroFramework.Controls.MetroComboBox();
            this.CmbTaskStatus = new MetroFramework.Controls.MetroComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnReturn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.Location = new System.Drawing.Point(134, 403);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(72, 30);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "Crear";
            this.BtnAdd.UseSelectable = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(18, 212);
            this.LblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(129, 19);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Nombre de la tarea:";
            // 
            // LblTaskDescription
            // 
            this.LblTaskDescription.AutoSize = true;
            this.LblTaskDescription.Location = new System.Drawing.Point(65, 246);
            this.LblTaskDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTaskDescription.Name = "LblTaskDescription";
            this.LblTaskDescription.Size = new System.Drawing.Size(76, 19);
            this.LblTaskDescription.TabIndex = 2;
            this.LblTaskDescription.Text = "Descripcion";
            // 
            // LblTaskDeadLine
            // 
            this.LblTaskDeadLine.AutoSize = true;
            this.LblTaskDeadLine.Location = new System.Drawing.Point(59, 277);
            this.LblTaskDeadLine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTaskDeadLine.Name = "LblTaskDeadLine";
            this.LblTaskDeadLine.Size = new System.Drawing.Size(85, 19);
            this.LblTaskDeadLine.TabIndex = 3;
            this.LblTaskDeadLine.Text = "Fecha Limite:";
            // 
            // LblTaskStatus
            // 
            this.LblTaskStatus.AutoSize = true;
            this.LblTaskStatus.Location = new System.Drawing.Point(87, 349);
            this.LblTaskStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTaskStatus.Name = "LblTaskStatus";
            this.LblTaskStatus.Size = new System.Drawing.Size(51, 19);
            this.LblTaskStatus.TabIndex = 4;
            this.LblTaskStatus.Text = "Estado:";
            // 
            // LblTaskPriority
            // 
            this.LblTaskPriority.AutoSize = true;
            this.LblTaskPriority.Location = new System.Drawing.Point(76, 309);
            this.LblTaskPriority.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTaskPriority.Name = "LblTaskPriority";
            this.LblTaskPriority.Size = new System.Drawing.Size(67, 19);
            this.LblTaskPriority.TabIndex = 5;
            this.LblTaskPriority.Text = "Prioridad:";
            // 
            // DtpTaskDeadLine
            // 
            this.DtpTaskDeadLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DtpTaskDeadLine.Location = new System.Drawing.Point(151, 277);
            this.DtpTaskDeadLine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DtpTaskDeadLine.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtpTaskDeadLine.Name = "DtpTaskDeadLine";
            this.DtpTaskDeadLine.Size = new System.Drawing.Size(212, 30);
            this.DtpTaskDeadLine.TabIndex = 3;
            // 
            // TxtTaskName
            // 
            // 
            // 
            // 
            this.TxtTaskName.CustomButton.Image = null;
            this.TxtTaskName.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.TxtTaskName.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtTaskName.CustomButton.Name = "";
            this.TxtTaskName.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.TxtTaskName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtTaskName.CustomButton.TabIndex = 1;
            this.TxtTaskName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtTaskName.CustomButton.UseSelectable = true;
            this.TxtTaskName.CustomButton.Visible = false;
            this.TxtTaskName.Lines = new string[0];
            this.TxtTaskName.Location = new System.Drawing.Point(151, 212);
            this.TxtTaskName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtTaskName.MaxLength = 32767;
            this.TxtTaskName.Name = "TxtTaskName";
            this.TxtTaskName.PasswordChar = '\0';
            this.TxtTaskName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtTaskName.SelectedText = "";
            this.TxtTaskName.SelectionLength = 0;
            this.TxtTaskName.SelectionStart = 0;
            this.TxtTaskName.ShortcutsEnabled = true;
            this.TxtTaskName.Size = new System.Drawing.Size(211, 19);
            this.TxtTaskName.TabIndex = 1;
            this.TxtTaskName.UseSelectable = true;
            this.TxtTaskName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtTaskName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtTaskDescription
            // 
            // 
            // 
            // 
            this.TxtTaskDescription.CustomButton.Image = null;
            this.TxtTaskDescription.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.TxtTaskDescription.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtTaskDescription.CustomButton.Name = "";
            this.TxtTaskDescription.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.TxtTaskDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtTaskDescription.CustomButton.TabIndex = 1;
            this.TxtTaskDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtTaskDescription.CustomButton.UseSelectable = true;
            this.TxtTaskDescription.CustomButton.Visible = false;
            this.TxtTaskDescription.Lines = new string[0];
            this.TxtTaskDescription.Location = new System.Drawing.Point(151, 243);
            this.TxtTaskDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtTaskDescription.MaxLength = 32767;
            this.TxtTaskDescription.Name = "TxtTaskDescription";
            this.TxtTaskDescription.PasswordChar = '\0';
            this.TxtTaskDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtTaskDescription.SelectedText = "";
            this.TxtTaskDescription.SelectionLength = 0;
            this.TxtTaskDescription.SelectionStart = 0;
            this.TxtTaskDescription.ShortcutsEnabled = true;
            this.TxtTaskDescription.Size = new System.Drawing.Size(211, 19);
            this.TxtTaskDescription.TabIndex = 2;
            this.TxtTaskDescription.UseSelectable = true;
            this.TxtTaskDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtTaskDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CmbTaskPriority
            // 
            this.CmbTaskPriority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbTaskPriority.FormattingEnabled = true;
            this.CmbTaskPriority.ItemHeight = 23;
            this.CmbTaskPriority.Items.AddRange(new object[] {
            "Urgente",
            "Importante",
            "Alta",
            "Baja",
            "No prioritaria"});
            this.CmbTaskPriority.Location = new System.Drawing.Point(151, 309);
            this.CmbTaskPriority.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbTaskPriority.Name = "CmbTaskPriority";
            this.CmbTaskPriority.Size = new System.Drawing.Size(212, 29);
            this.CmbTaskPriority.TabIndex = 4;
            this.CmbTaskPriority.UseSelectable = true;
            // 
            // CmbTaskStatus
            // 
            this.CmbTaskStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbTaskStatus.FormattingEnabled = true;
            this.CmbTaskStatus.ItemHeight = 23;
            this.CmbTaskStatus.Items.AddRange(new object[] {
            "No iniciado ",
            "Iniciado",
            "En proceso",
            "Culminado"});
            this.CmbTaskStatus.Location = new System.Drawing.Point(151, 349);
            this.CmbTaskStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbTaskStatus.Name = "CmbTaskStatus";
            this.CmbTaskStatus.Size = new System.Drawing.Size(212, 29);
            this.CmbTaskStatus.TabIndex = 5;
            this.CmbTaskStatus.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(168, 62);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // BtnReturn
            // 
            this.BtnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReturn.Location = new System.Drawing.Point(232, 403);
            this.BtnReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(77, 30);
            this.BtnReturn.TabIndex = 7;
            this.BtnReturn.Text = "Regresar";
            this.BtnReturn.UseSelectable = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // FrmTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 467);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CmbTaskStatus);
            this.Controls.Add(this.CmbTaskPriority);
            this.Controls.Add(this.TxtTaskDescription);
            this.Controls.Add(this.TxtTaskName);
            this.Controls.Add(this.DtpTaskDeadLine);
            this.Controls.Add(this.LblTaskPriority);
            this.Controls.Add(this.LblTaskStatus);
            this.Controls.Add(this.LblTaskDeadLine);
            this.Controls.Add(this.LblTaskDescription);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.BtnAdd);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmTask";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Resizable = false;
            this.Text = "Agregar Tarea";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnAdd;
        private MetroFramework.Controls.MetroLabel LblName;
        private MetroFramework.Controls.MetroLabel LblTaskDescription;
        private MetroFramework.Controls.MetroLabel LblTaskDeadLine;
        private MetroFramework.Controls.MetroLabel LblTaskStatus;
        private MetroFramework.Controls.MetroLabel LblTaskPriority;
        private MetroFramework.Controls.MetroDateTime DtpTaskDeadLine;
        private MetroFramework.Controls.MetroTextBox TxtTaskName;
        private MetroFramework.Controls.MetroTextBox TxtTaskDescription;
        private MetroFramework.Controls.MetroComboBox CmbTaskPriority;
        private MetroFramework.Controls.MetroComboBox CmbTaskStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton BtnReturn;
    }
}