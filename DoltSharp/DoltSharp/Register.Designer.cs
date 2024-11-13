namespace DoltSharp
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.LblName = new MetroFramework.Controls.MetroLabel();
            this.TxtRegisterName = new MetroFramework.Controls.MetroTextBox();
            this.LblRegisterEmail = new MetroFramework.Controls.MetroLabel();
            this.DtpBirthDate = new MetroFramework.Controls.MetroDateTime();
            this.LblBirthDate = new MetroFramework.Controls.MetroLabel();
            this.LblRegisterPw = new MetroFramework.Controls.MetroLabel();
            this.TxtRegisterEmail = new MetroFramework.Controls.MetroTextBox();
            this.TxtRegisterPw = new MetroFramework.Controls.MetroTextBox();
            this.BtnRegister = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.TxtRegisterLastName = new MetroFramework.Controls.MetroTextBox();
            this.LblRegisterVPw = new MetroFramework.Controls.MetroLabel();
            this.TxtRegisterVPw = new MetroFramework.Controls.MetroTextBox();
            this.CbxRegisterSeePw = new MetroFramework.Controls.MetroCheckBox();
            this.CbxRegisterSeePw2 = new MetroFramework.Controls.MetroCheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnReturn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(172, 215);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(206, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Registro de usuarios en el sistema";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(125, 250);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(62, 19);
            this.LblName.TabIndex = 2;
            this.LblName.Text = "Nombre:";
            // 
            // TxtRegisterName
            // 
            // 
            // 
            // 
            this.TxtRegisterName.CustomButton.Image = null;
            this.TxtRegisterName.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.TxtRegisterName.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtRegisterName.CustomButton.Name = "";
            this.TxtRegisterName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtRegisterName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtRegisterName.CustomButton.TabIndex = 1;
            this.TxtRegisterName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtRegisterName.CustomButton.UseSelectable = true;
            this.TxtRegisterName.CustomButton.Visible = false;
            this.TxtRegisterName.Lines = new string[0];
            this.TxtRegisterName.Location = new System.Drawing.Point(245, 246);
            this.TxtRegisterName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtRegisterName.MaxLength = 32767;
            this.TxtRegisterName.Name = "TxtRegisterName";
            this.TxtRegisterName.PasswordChar = '\0';
            this.TxtRegisterName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtRegisterName.SelectedText = "";
            this.TxtRegisterName.SelectionLength = 0;
            this.TxtRegisterName.SelectionStart = 0;
            this.TxtRegisterName.ShortcutsEnabled = true;
            this.TxtRegisterName.Size = new System.Drawing.Size(204, 23);
            this.TxtRegisterName.TabIndex = 3;
            this.TxtRegisterName.UseSelectable = true;
            this.TxtRegisterName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtRegisterName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtRegisterName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRegisterName_KeyPress);
            // 
            // LblRegisterEmail
            // 
            this.LblRegisterEmail.AutoSize = true;
            this.LblRegisterEmail.Location = new System.Drawing.Point(147, 383);
            this.LblRegisterEmail.Name = "LblRegisterEmail";
            this.LblRegisterEmail.Size = new System.Drawing.Size(44, 19);
            this.LblRegisterEmail.TabIndex = 4;
            this.LblRegisterEmail.Text = "Email:";
            // 
            // DtpBirthDate
            // 
            this.DtpBirthDate.Location = new System.Drawing.Point(245, 334);
            this.DtpBirthDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtpBirthDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtpBirthDate.Name = "DtpBirthDate";
            this.DtpBirthDate.Size = new System.Drawing.Size(251, 30);
            this.DtpBirthDate.TabIndex = 5;
            // 
            // LblBirthDate
            // 
            this.LblBirthDate.AutoSize = true;
            this.LblBirthDate.Location = new System.Drawing.Point(48, 345);
            this.LblBirthDate.Name = "LblBirthDate";
            this.LblBirthDate.Size = new System.Drawing.Size(133, 19);
            this.LblBirthDate.TabIndex = 6;
            this.LblBirthDate.Text = "Fecha de nacimiento:";
            // 
            // LblRegisterPw
            // 
            this.LblRegisterPw.AutoSize = true;
            this.LblRegisterPw.Location = new System.Drawing.Point(107, 428);
            this.LblRegisterPw.Name = "LblRegisterPw";
            this.LblRegisterPw.Size = new System.Drawing.Size(78, 19);
            this.LblRegisterPw.TabIndex = 7;
            this.LblRegisterPw.Text = "Contraseña:";
            // 
            // TxtRegisterEmail
            // 
            // 
            // 
            // 
            this.TxtRegisterEmail.CustomButton.Image = null;
            this.TxtRegisterEmail.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.TxtRegisterEmail.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtRegisterEmail.CustomButton.Name = "";
            this.TxtRegisterEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtRegisterEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtRegisterEmail.CustomButton.TabIndex = 1;
            this.TxtRegisterEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtRegisterEmail.CustomButton.UseSelectable = true;
            this.TxtRegisterEmail.CustomButton.Visible = false;
            this.TxtRegisterEmail.Lines = new string[0];
            this.TxtRegisterEmail.Location = new System.Drawing.Point(245, 383);
            this.TxtRegisterEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtRegisterEmail.MaxLength = 32767;
            this.TxtRegisterEmail.Name = "TxtRegisterEmail";
            this.TxtRegisterEmail.PasswordChar = '\0';
            this.TxtRegisterEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtRegisterEmail.SelectedText = "";
            this.TxtRegisterEmail.SelectionLength = 0;
            this.TxtRegisterEmail.SelectionStart = 0;
            this.TxtRegisterEmail.ShortcutsEnabled = true;
            this.TxtRegisterEmail.Size = new System.Drawing.Size(204, 23);
            this.TxtRegisterEmail.TabIndex = 8;
            this.TxtRegisterEmail.UseSelectable = true;
            this.TxtRegisterEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtRegisterEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtRegisterPw
            // 
            // 
            // 
            // 
            this.TxtRegisterPw.CustomButton.Image = null;
            this.TxtRegisterPw.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.TxtRegisterPw.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtRegisterPw.CustomButton.Name = "";
            this.TxtRegisterPw.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtRegisterPw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtRegisterPw.CustomButton.TabIndex = 1;
            this.TxtRegisterPw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtRegisterPw.CustomButton.UseSelectable = true;
            this.TxtRegisterPw.CustomButton.Visible = false;
            this.TxtRegisterPw.Lines = new string[0];
            this.TxtRegisterPw.Location = new System.Drawing.Point(248, 423);
            this.TxtRegisterPw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtRegisterPw.MaxLength = 32767;
            this.TxtRegisterPw.Name = "TxtRegisterPw";
            this.TxtRegisterPw.PasswordChar = '*';
            this.TxtRegisterPw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtRegisterPw.SelectedText = "";
            this.TxtRegisterPw.SelectionLength = 0;
            this.TxtRegisterPw.SelectionStart = 0;
            this.TxtRegisterPw.ShortcutsEnabled = true;
            this.TxtRegisterPw.Size = new System.Drawing.Size(203, 23);
            this.TxtRegisterPw.TabIndex = 9;
            this.TxtRegisterPw.UseSelectable = true;
            this.TxtRegisterPw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtRegisterPw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(158, 520);
            this.BtnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(113, 68);
            this.BtnRegister.TabIndex = 10;
            this.BtnRegister.Text = "Registrarse";
            this.BtnRegister.UseSelectable = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(125, 294);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(61, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Apellido:";
            // 
            // TxtRegisterLastName
            // 
            // 
            // 
            // 
            this.TxtRegisterLastName.CustomButton.Image = null;
            this.TxtRegisterLastName.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.TxtRegisterLastName.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtRegisterLastName.CustomButton.Name = "";
            this.TxtRegisterLastName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtRegisterLastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtRegisterLastName.CustomButton.TabIndex = 1;
            this.TxtRegisterLastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtRegisterLastName.CustomButton.UseSelectable = true;
            this.TxtRegisterLastName.CustomButton.Visible = false;
            this.TxtRegisterLastName.Lines = new string[0];
            this.TxtRegisterLastName.Location = new System.Drawing.Point(245, 290);
            this.TxtRegisterLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtRegisterLastName.MaxLength = 32767;
            this.TxtRegisterLastName.Name = "TxtRegisterLastName";
            this.TxtRegisterLastName.PasswordChar = '\0';
            this.TxtRegisterLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtRegisterLastName.SelectedText = "";
            this.TxtRegisterLastName.SelectionLength = 0;
            this.TxtRegisterLastName.SelectionStart = 0;
            this.TxtRegisterLastName.ShortcutsEnabled = true;
            this.TxtRegisterLastName.Size = new System.Drawing.Size(204, 23);
            this.TxtRegisterLastName.TabIndex = 12;
            this.TxtRegisterLastName.UseSelectable = true;
            this.TxtRegisterLastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtRegisterLastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtRegisterLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRegisterLastName_KeyPress);
            // 
            // LblRegisterVPw
            // 
            this.LblRegisterVPw.AutoSize = true;
            this.LblRegisterVPw.Location = new System.Drawing.Point(3, 466);
            this.LblRegisterVPw.Name = "LblRegisterVPw";
            this.LblRegisterVPw.Size = new System.Drawing.Size(177, 19);
            this.LblRegisterVPw.TabIndex = 13;
            this.LblRegisterVPw.Text = "Confirmacion de contraseña:";
            // 
            // TxtRegisterVPw
            // 
            // 
            // 
            // 
            this.TxtRegisterVPw.CustomButton.Image = null;
            this.TxtRegisterVPw.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.TxtRegisterVPw.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtRegisterVPw.CustomButton.Name = "";
            this.TxtRegisterVPw.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtRegisterVPw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtRegisterVPw.CustomButton.TabIndex = 1;
            this.TxtRegisterVPw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtRegisterVPw.CustomButton.UseSelectable = true;
            this.TxtRegisterVPw.CustomButton.Visible = false;
            this.TxtRegisterVPw.Lines = new string[0];
            this.TxtRegisterVPw.Location = new System.Drawing.Point(248, 466);
            this.TxtRegisterVPw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtRegisterVPw.MaxLength = 32767;
            this.TxtRegisterVPw.Name = "TxtRegisterVPw";
            this.TxtRegisterVPw.PasswordChar = '*';
            this.TxtRegisterVPw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtRegisterVPw.SelectedText = "";
            this.TxtRegisterVPw.SelectionLength = 0;
            this.TxtRegisterVPw.SelectionStart = 0;
            this.TxtRegisterVPw.ShortcutsEnabled = true;
            this.TxtRegisterVPw.Size = new System.Drawing.Size(204, 23);
            this.TxtRegisterVPw.TabIndex = 14;
            this.TxtRegisterVPw.UseSelectable = true;
            this.TxtRegisterVPw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtRegisterVPw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CbxRegisterSeePw
            // 
            this.CbxRegisterSeePw.AutoSize = true;
            this.CbxRegisterSeePw.Location = new System.Drawing.Point(456, 428);
            this.CbxRegisterSeePw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbxRegisterSeePw.Name = "CbxRegisterSeePw";
            this.CbxRegisterSeePw.Size = new System.Drawing.Size(39, 15);
            this.CbxRegisterSeePw.TabIndex = 15;
            this.CbxRegisterSeePw.Text = "Ver";
            this.CbxRegisterSeePw.UseSelectable = true;
            this.CbxRegisterSeePw.CheckedChanged += new System.EventHandler(this.CbxRegisterSeePw_CheckedChanged);
            // 
            // CbxRegisterSeePw2
            // 
            this.CbxRegisterSeePw2.AutoSize = true;
            this.CbxRegisterSeePw2.Location = new System.Drawing.Point(459, 471);
            this.CbxRegisterSeePw2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbxRegisterSeePw2.Name = "CbxRegisterSeePw2";
            this.CbxRegisterSeePw2.Size = new System.Drawing.Size(39, 15);
            this.CbxRegisterSeePw2.TabIndex = 16;
            this.CbxRegisterSeePw2.Text = "Ver";
            this.CbxRegisterSeePw2.UseSelectable = true;
            this.CbxRegisterSeePw2.CheckedChanged += new System.EventHandler(this.CbxRegisterSeePw2_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(184, 63);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(309, 520);
            this.BtnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(113, 68);
            this.BtnReturn.TabIndex = 17;
            this.BtnReturn.Text = "Regresar";
            this.BtnReturn.UseSelectable = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 610);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.CbxRegisterSeePw2);
            this.Controls.Add(this.CbxRegisterSeePw);
            this.Controls.Add(this.TxtRegisterVPw);
            this.Controls.Add(this.LblRegisterVPw);
            this.Controls.Add(this.TxtRegisterLastName);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.TxtRegisterPw);
            this.Controls.Add(this.TxtRegisterEmail);
            this.Controls.Add(this.LblRegisterPw);
            this.Controls.Add(this.LblBirthDate);
            this.Controls.Add(this.DtpBirthDate);
            this.Controls.Add(this.LblRegisterEmail);
            this.Controls.Add(this.TxtRegisterName);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Register";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Text = "Registro";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel LblName;
        private MetroFramework.Controls.MetroTextBox TxtRegisterName;
        private MetroFramework.Controls.MetroLabel LblRegisterEmail;
        private MetroFramework.Controls.MetroDateTime DtpBirthDate;
        private MetroFramework.Controls.MetroLabel LblBirthDate;
        private MetroFramework.Controls.MetroLabel LblRegisterPw;
        private MetroFramework.Controls.MetroTextBox TxtRegisterEmail;
        private MetroFramework.Controls.MetroTextBox TxtRegisterPw;
        private MetroFramework.Controls.MetroButton BtnRegister;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox TxtRegisterLastName;
        private MetroFramework.Controls.MetroLabel LblRegisterVPw;
        private MetroFramework.Controls.MetroTextBox TxtRegisterVPw;
        private MetroFramework.Controls.MetroCheckBox CbxRegisterSeePw;
        private MetroFramework.Controls.MetroCheckBox CbxRegisterSeePw2;
        private MetroFramework.Controls.MetroButton BtnReturn;
    }
}