namespace DoltSharp
{
    partial class Task
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task));
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
            this.BtnAdd.Location = new System.Drawing.Point(265, 499);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(125, 53);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "Crear";
            this.BtnAdd.UseSelectable = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(153, 264);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(133, 20);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Nombre de la tarea:";
            // 
            // LblTaskDescription
            // 
            this.LblTaskDescription.AutoSize = true;
            this.LblTaskDescription.Location = new System.Drawing.Point(204, 305);
            this.LblTaskDescription.Name = "LblTaskDescription";
            this.LblTaskDescription.Size = new System.Drawing.Size(82, 20);
            this.LblTaskDescription.TabIndex = 2;
            this.LblTaskDescription.Text = "Descripcion";
            // 
            // LblTaskDeadLine
            // 
            this.LblTaskDeadLine.AutoSize = true;
            this.LblTaskDeadLine.Location = new System.Drawing.Point(196, 343);
            this.LblTaskDeadLine.Name = "LblTaskDeadLine";
            this.LblTaskDeadLine.Size = new System.Drawing.Size(90, 20);
            this.LblTaskDeadLine.TabIndex = 3;
            this.LblTaskDeadLine.Text = "Fecha Limite:";
            // 
            // LblTaskStatus
            // 
            this.LblTaskStatus.AutoSize = true;
            this.LblTaskStatus.Location = new System.Drawing.Point(233, 432);
            this.LblTaskStatus.Name = "LblTaskStatus";
            this.LblTaskStatus.Size = new System.Drawing.Size(53, 20);
            this.LblTaskStatus.TabIndex = 4;
            this.LblTaskStatus.Text = "Estado:";
            // 
            // LblTaskPriority
            // 
            this.LblTaskPriority.AutoSize = true;
            this.LblTaskPriority.Location = new System.Drawing.Point(219, 383);
            this.LblTaskPriority.Name = "LblTaskPriority";
            this.LblTaskPriority.Size = new System.Drawing.Size(67, 20);
            this.LblTaskPriority.TabIndex = 5;
            this.LblTaskPriority.Text = "Prioridad:";
            // 
            // DtpTaskDeadLine
            // 
            this.DtpTaskDeadLine.Location = new System.Drawing.Point(319, 343);
            this.DtpTaskDeadLine.MinimumSize = new System.Drawing.Size(0, 30);
            this.DtpTaskDeadLine.Name = "DtpTaskDeadLine";
            this.DtpTaskDeadLine.Size = new System.Drawing.Size(281, 30);
            this.DtpTaskDeadLine.TabIndex = 3;
            // 
            // TxtTaskName
            // 
            // 
            // 
            // 
            this.TxtTaskName.CustomButton.Image = null;
            this.TxtTaskName.CustomButton.Location = new System.Drawing.Point(259, 1);
            this.TxtTaskName.CustomButton.Name = "";
            this.TxtTaskName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtTaskName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtTaskName.CustomButton.TabIndex = 1;
            this.TxtTaskName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtTaskName.CustomButton.UseSelectable = true;
            this.TxtTaskName.CustomButton.Visible = false;
            this.TxtTaskName.Lines = new string[0];
            this.TxtTaskName.Location = new System.Drawing.Point(319, 264);
            this.TxtTaskName.MaxLength = 32767;
            this.TxtTaskName.Name = "TxtTaskName";
            this.TxtTaskName.PasswordChar = '\0';
            this.TxtTaskName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtTaskName.SelectedText = "";
            this.TxtTaskName.SelectionLength = 0;
            this.TxtTaskName.SelectionStart = 0;
            this.TxtTaskName.ShortcutsEnabled = true;
            this.TxtTaskName.Size = new System.Drawing.Size(281, 23);
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
            this.TxtTaskDescription.CustomButton.Location = new System.Drawing.Point(259, 1);
            this.TxtTaskDescription.CustomButton.Name = "";
            this.TxtTaskDescription.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtTaskDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtTaskDescription.CustomButton.TabIndex = 1;
            this.TxtTaskDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtTaskDescription.CustomButton.UseSelectable = true;
            this.TxtTaskDescription.CustomButton.Visible = false;
            this.TxtTaskDescription.Lines = new string[0];
            this.TxtTaskDescription.Location = new System.Drawing.Point(319, 302);
            this.TxtTaskDescription.MaxLength = 32767;
            this.TxtTaskDescription.Name = "TxtTaskDescription";
            this.TxtTaskDescription.PasswordChar = '\0';
            this.TxtTaskDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtTaskDescription.SelectedText = "";
            this.TxtTaskDescription.SelectionLength = 0;
            this.TxtTaskDescription.SelectionStart = 0;
            this.TxtTaskDescription.ShortcutsEnabled = true;
            this.TxtTaskDescription.Size = new System.Drawing.Size(281, 23);
            this.TxtTaskDescription.TabIndex = 2;
            this.TxtTaskDescription.UseSelectable = true;
            this.TxtTaskDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtTaskDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CmbTaskPriority
            // 
            this.CmbTaskPriority.FormattingEnabled = true;
            this.CmbTaskPriority.ItemHeight = 24;
            this.CmbTaskPriority.Items.AddRange(new object[] {
            "Urgente",
            "Importante",
            "Alta",
            "Baja",
            "No prioritaria"});
            this.CmbTaskPriority.Location = new System.Drawing.Point(319, 383);
            this.CmbTaskPriority.Name = "CmbTaskPriority";
            this.CmbTaskPriority.Size = new System.Drawing.Size(281, 30);
            this.CmbTaskPriority.TabIndex = 4;
            this.CmbTaskPriority.UseSelectable = true;
            // 
            // CmbTaskStatus
            // 
            this.CmbTaskStatus.FormattingEnabled = true;
            this.CmbTaskStatus.ItemHeight = 24;
            this.CmbTaskStatus.Items.AddRange(new object[] {
            "No iniciado ",
            "Iniciado",
            "En proceso",
            "Culminado"});
            this.CmbTaskStatus.Location = new System.Drawing.Point(319, 432);
            this.CmbTaskStatus.Name = "CmbTaskStatus";
            this.CmbTaskStatus.Size = new System.Drawing.Size(281, 30);
            this.CmbTaskStatus.TabIndex = 5;
            this.CmbTaskStatus.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(296, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(427, 499);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(125, 53);
            this.BtnReturn.TabIndex = 7;
            this.BtnReturn.Text = "Regresar";
            this.BtnReturn.UseSelectable = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 575);
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
            this.Name = "Task";
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