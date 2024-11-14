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
            this.LblDescription = new MetroFramework.Controls.MetroLabel();
            this.LblDeadline = new MetroFramework.Controls.MetroLabel();
            this.LblState = new MetroFramework.Controls.MetroLabel();
            this.LblPriority = new MetroFramework.Controls.MetroLabel();
            this.DtpDeadLine = new MetroFramework.Controls.MetroDateTime();
            this.TxtNameTask = new MetroFramework.Controls.MetroTextBox();
            this.TxtDescription = new MetroFramework.Controls.MetroTextBox();
            this.CmbPriority = new MetroFramework.Controls.MetroComboBox();
            this.CmbState = new MetroFramework.Controls.MetroComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnReturn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
<<<<<<< HEAD
            this.BtnAdd.Location = new System.Drawing.Point(188, 405);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(94, 43);
=======
            this.BtnAdd.Location = new System.Drawing.Point(359, 499);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(125, 53);
>>>>>>> 4aa385153075d94759c73e1ffa88ad5866aa0460
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Crear";
            this.BtnAdd.UseSelectable = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
<<<<<<< HEAD
            this.LblName.Location = new System.Drawing.Point(71, 212);
            this.LblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(129, 19);
=======
            this.LblName.Location = new System.Drawing.Point(170, 265);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(133, 20);
>>>>>>> 4aa385153075d94759c73e1ffa88ad5866aa0460
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Nombre de la tarea:";
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
<<<<<<< HEAD
            this.LblDescription.Location = new System.Drawing.Point(124, 245);
            this.LblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(76, 19);
=======
            this.LblDescription.Location = new System.Drawing.Point(221, 306);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(82, 20);
>>>>>>> 4aa385153075d94759c73e1ffa88ad5866aa0460
            this.LblDescription.TabIndex = 2;
            this.LblDescription.Text = "Descripcion";
            // 
            // LblDeadline
            // 
            this.LblDeadline.AutoSize = true;
<<<<<<< HEAD
            this.LblDeadline.Location = new System.Drawing.Point(115, 276);
            this.LblDeadline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDeadline.Name = "LblDeadline";
            this.LblDeadline.Size = new System.Drawing.Size(85, 19);
=======
            this.LblDeadline.Location = new System.Drawing.Point(213, 344);
            this.LblDeadline.Name = "LblDeadline";
            this.LblDeadline.Size = new System.Drawing.Size(90, 20);
>>>>>>> 4aa385153075d94759c73e1ffa88ad5866aa0460
            this.LblDeadline.TabIndex = 3;
            this.LblDeadline.Text = "Fecha Limite:";
            // 
            // LblState
            // 
            this.LblState.AutoSize = true;
<<<<<<< HEAD
            this.LblState.Location = new System.Drawing.Point(149, 349);
            this.LblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblState.Name = "LblState";
            this.LblState.Size = new System.Drawing.Size(51, 19);
=======
            this.LblState.Location = new System.Drawing.Point(250, 433);
            this.LblState.Name = "LblState";
            this.LblState.Size = new System.Drawing.Size(53, 20);
>>>>>>> 4aa385153075d94759c73e1ffa88ad5866aa0460
            this.LblState.TabIndex = 4;
            this.LblState.Text = "Estado:";
            // 
            // LblPriority
            // 
            this.LblPriority.AutoSize = true;
<<<<<<< HEAD
            this.LblPriority.Location = new System.Drawing.Point(133, 309);
            this.LblPriority.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPriority.Name = "LblPriority";
            this.LblPriority.Size = new System.Drawing.Size(67, 19);
=======
            this.LblPriority.Location = new System.Drawing.Point(236, 384);
            this.LblPriority.Name = "LblPriority";
            this.LblPriority.Size = new System.Drawing.Size(67, 20);
>>>>>>> 4aa385153075d94759c73e1ffa88ad5866aa0460
            this.LblPriority.TabIndex = 5;
            this.LblPriority.Text = "Prioridad:";
            // 
            // DtpDeadLine
            // 
<<<<<<< HEAD
            this.DtpDeadLine.Location = new System.Drawing.Point(211, 276);
            this.DtpDeadLine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DtpDeadLine.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtpDeadLine.Name = "DtpDeadLine";
            this.DtpDeadLine.Size = new System.Drawing.Size(212, 29);
=======
            this.DtpDeadLine.Location = new System.Drawing.Point(336, 344);
            this.DtpDeadLine.MinimumSize = new System.Drawing.Size(0, 30);
            this.DtpDeadLine.Name = "DtpDeadLine";
            this.DtpDeadLine.Size = new System.Drawing.Size(281, 30);
>>>>>>> 4aa385153075d94759c73e1ffa88ad5866aa0460
            this.DtpDeadLine.TabIndex = 6;
            // 
            // TxtNameTask
            // 
            // 
            // 
            // 
            this.TxtNameTask.CustomButton.Image = null;
<<<<<<< HEAD
            this.TxtNameTask.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.TxtNameTask.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtNameTask.CustomButton.Name = "";
            this.TxtNameTask.CustomButton.Size = new System.Drawing.Size(13, 14);
=======
            this.TxtNameTask.CustomButton.Location = new System.Drawing.Point(259, 1);
            this.TxtNameTask.CustomButton.Name = "";
            this.TxtNameTask.CustomButton.Size = new System.Drawing.Size(21, 21);
>>>>>>> 4aa385153075d94759c73e1ffa88ad5866aa0460
            this.TxtNameTask.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtNameTask.CustomButton.TabIndex = 1;
            this.TxtNameTask.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtNameTask.CustomButton.UseSelectable = true;
            this.TxtNameTask.CustomButton.Visible = false;
            this.TxtNameTask.Lines = new string[0];
<<<<<<< HEAD
            this.TxtNameTask.Location = new System.Drawing.Point(211, 212);
            this.TxtNameTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
=======
            this.TxtNameTask.Location = new System.Drawing.Point(336, 265);
>>>>>>> 4aa385153075d94759c73e1ffa88ad5866aa0460
            this.TxtNameTask.MaxLength = 32767;
            this.TxtNameTask.Name = "TxtNameTask";
            this.TxtNameTask.PasswordChar = '\0';
            this.TxtNameTask.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtNameTask.SelectedText = "";
            this.TxtNameTask.SelectionLength = 0;
            this.TxtNameTask.SelectionStart = 0;
            this.TxtNameTask.ShortcutsEnabled = true;
<<<<<<< HEAD
            this.TxtNameTask.Size = new System.Drawing.Size(211, 19);
=======
            this.TxtNameTask.Size = new System.Drawing.Size(281, 23);
>>>>>>> 4aa385153075d94759c73e1ffa88ad5866aa0460
            this.TxtNameTask.TabIndex = 9;
            this.TxtNameTask.UseSelectable = true;
            this.TxtNameTask.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtNameTask.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtDescription
            // 
            // 
            // 
            // 
            this.TxtDescription.CustomButton.Image = null;
<<<<<<< HEAD
            this.TxtDescription.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.TxtDescription.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtDescription.CustomButton.Name = "";
            this.TxtDescription.CustomButton.Size = new System.Drawing.Size(13, 14);
=======
            this.TxtDescription.CustomButton.Location = new System.Drawing.Point(259, 1);
            this.TxtDescription.CustomButton.Name = "";
            this.TxtDescription.CustomButton.Size = new System.Drawing.Size(21, 21);
>>>>>>> 4aa385153075d94759c73e1ffa88ad5866aa0460
            this.TxtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtDescription.CustomButton.TabIndex = 1;
            this.TxtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtDescription.CustomButton.UseSelectable = true;
            this.TxtDescription.CustomButton.Visible = false;
            this.TxtDescription.Lines = new string[0];
<<<<<<< HEAD
            this.TxtDescription.Location = new System.Drawing.Point(211, 243);
            this.TxtDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
=======
            this.TxtDescription.Location = new System.Drawing.Point(336, 303);
>>>>>>> 4aa385153075d94759c73e1ffa88ad5866aa0460
            this.TxtDescription.MaxLength = 32767;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.PasswordChar = '\0';
            this.TxtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtDescription.SelectedText = "";
            this.TxtDescription.SelectionLength = 0;
            this.TxtDescription.SelectionStart = 0;
            this.TxtDescription.ShortcutsEnabled = true;
<<<<<<< HEAD
            this.TxtDescription.Size = new System.Drawing.Size(211, 19);
=======
            this.TxtDescription.Size = new System.Drawing.Size(281, 23);
>>>>>>> 4aa385153075d94759c73e1ffa88ad5866aa0460
            this.TxtDescription.TabIndex = 10;
            this.TxtDescription.UseSelectable = true;
            this.TxtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CmbPriority
            // 
            this.CmbPriority.FormattingEnabled = true;
<<<<<<< HEAD
            this.CmbPriority.ItemHeight = 23;
            this.CmbPriority.Items.AddRange(new object[] {
            "Urgente",
            "Importante",
            "Alta",
            "Baja "});
            this.CmbPriority.Location = new System.Drawing.Point(211, 309);
            this.CmbPriority.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbPriority.Name = "CmbPriority";
            this.CmbPriority.Size = new System.Drawing.Size(212, 29);
=======
            this.CmbPriority.ItemHeight = 24;
            this.CmbPriority.Location = new System.Drawing.Point(336, 384);
            this.CmbPriority.Name = "CmbPriority";
            this.CmbPriority.Size = new System.Drawing.Size(281, 30);
>>>>>>> 4aa385153075d94759c73e1ffa88ad5866aa0460
            this.CmbPriority.TabIndex = 12;
            this.CmbPriority.UseSelectable = true;
            // 
            // CmbState
            // 
            this.CmbState.FormattingEnabled = true;
<<<<<<< HEAD
            this.CmbState.ItemHeight = 23;
            this.CmbState.Items.AddRange(new object[] {
            "Realizado",
            "No realizado",
            "En proceso"});
            this.CmbState.Location = new System.Drawing.Point(211, 349);
            this.CmbState.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbState.Name = "CmbState";
            this.CmbState.Size = new System.Drawing.Size(212, 29);
=======
            this.CmbState.ItemHeight = 24;
            this.CmbState.Location = new System.Drawing.Point(336, 433);
            this.CmbState.Name = "CmbState";
            this.CmbState.Size = new System.Drawing.Size(281, 30);
>>>>>>> 4aa385153075d94759c73e1ffa88ad5866aa0460
            this.CmbState.TabIndex = 13;
            this.CmbState.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
<<<<<<< HEAD
            this.pictureBox1.Location = new System.Drawing.Point(227, 63);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 123);
=======
            this.pictureBox1.Location = new System.Drawing.Point(296, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 151);
>>>>>>> 4aa385153075d94759c73e1ffa88ad5866aa0460
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // BtnReturn
            // 
<<<<<<< HEAD
            this.BtnReturn.Location = new System.Drawing.Point(309, 405);
            this.BtnReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(94, 43);
=======
            this.BtnReturn.Location = new System.Drawing.Point(521, 499);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(125, 53);
>>>>>>> 4aa385153075d94759c73e1ffa88ad5866aa0460
            this.BtnReturn.TabIndex = 15;
            this.BtnReturn.Text = "Regresar";
            this.BtnReturn.UseSelectable = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // Task
            // 
<<<<<<< HEAD
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 467);
=======
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 575);
>>>>>>> 4aa385153075d94759c73e1ffa88ad5866aa0460
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CmbState);
            this.Controls.Add(this.CmbPriority);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.TxtNameTask);
            this.Controls.Add(this.DtpDeadLine);
            this.Controls.Add(this.LblPriority);
            this.Controls.Add(this.LblState);
            this.Controls.Add(this.LblDeadline);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.BtnAdd);
<<<<<<< HEAD
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Task";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
=======
            this.Name = "Task";
>>>>>>> 4aa385153075d94759c73e1ffa88ad5866aa0460
            this.Text = "Agregar Tarea";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnAdd;
        private MetroFramework.Controls.MetroLabel LblName;
        private MetroFramework.Controls.MetroLabel LblDescription;
        private MetroFramework.Controls.MetroLabel LblDeadline;
        private MetroFramework.Controls.MetroLabel LblState;
        private MetroFramework.Controls.MetroLabel LblPriority;
        private MetroFramework.Controls.MetroDateTime DtpDeadLine;
        private MetroFramework.Controls.MetroTextBox TxtNameTask;
        private MetroFramework.Controls.MetroTextBox TxtDescription;
        private MetroFramework.Controls.MetroComboBox CmbPriority;
        private MetroFramework.Controls.MetroComboBox CmbState;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton BtnReturn;
    }
}