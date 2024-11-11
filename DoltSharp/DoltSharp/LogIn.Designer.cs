namespace DoltSharp
{
    partial class LogIn
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.LblEmail = new MetroFramework.Controls.MetroLabel();
            this.LblPw = new MetroFramework.Controls.MetroLabel();
            this.LblResetPw = new MetroFramework.Controls.MetroLabel();
            this.LblNoAccount = new MetroFramework.Controls.MetroLabel();
            this.TxtEmail = new MetroFramework.Controls.MetroTextBox();
            this.TxtPw = new MetroFramework.Controls.MetroTextBox();
            this.BtnLogin = new MetroFramework.Controls.MetroButton();
            this.BtnRegister = new MetroFramework.Controls.MetroButton();
            this.BtnResetPw = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CbxSee = new MetroFramework.Controls.MetroCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(192, 262);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(45, 20);
            this.LblEmail.TabIndex = 0;
            this.LblEmail.Text = "Email:";
            // 
            // LblPw
            // 
            this.LblPw.AutoSize = true;
            this.LblPw.Location = new System.Drawing.Point(155, 306);
            this.LblPw.Name = "LblPw";
            this.LblPw.Size = new System.Drawing.Size(82, 20);
            this.LblPw.TabIndex = 1;
            this.LblPw.Text = "Contraseña:";
            // 
            // LblResetPw
            // 
            this.LblResetPw.AutoSize = true;
            this.LblResetPw.Location = new System.Drawing.Point(113, 425);
            this.LblResetPw.Name = "LblResetPw";
            this.LblResetPw.Size = new System.Drawing.Size(160, 20);
            this.LblResetPw.TabIndex = 2;
            this.LblResetPw.Text = "Olvidaste tu contraseña?";
            // 
            // LblNoAccount
            // 
            this.LblNoAccount.AutoSize = true;
            this.LblNoAccount.Location = new System.Drawing.Point(125, 486);
            this.LblNoAccount.Name = "LblNoAccount";
            this.LblNoAccount.Size = new System.Drawing.Size(148, 20);
            this.LblNoAccount.TabIndex = 3;
            this.LblNoAccount.Text = "No tienes una cuenta?";
            // 
            // TxtEmail
            // 
            // 
            // 
            // 
            this.TxtEmail.CustomButton.Image = null;
            this.TxtEmail.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.TxtEmail.CustomButton.Name = "";
            this.TxtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtEmail.CustomButton.TabIndex = 1;
            this.TxtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtEmail.CustomButton.UseSelectable = true;
            this.TxtEmail.CustomButton.Visible = false;
            this.TxtEmail.Lines = new string[0];
            this.TxtEmail.Location = new System.Drawing.Point(259, 259);
            this.TxtEmail.MaxLength = 32767;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PasswordChar = '\0';
            this.TxtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.SelectionLength = 0;
            this.TxtEmail.SelectionStart = 0;
            this.TxtEmail.ShortcutsEnabled = true;
            this.TxtEmail.Size = new System.Drawing.Size(202, 23);
            this.TxtEmail.TabIndex = 4;
            this.TxtEmail.UseSelectable = true;
            this.TxtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtPw
            // 
            // 
            // 
            // 
            this.TxtPw.CustomButton.Image = null;
            this.TxtPw.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.TxtPw.CustomButton.Name = "";
            this.TxtPw.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtPw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPw.CustomButton.TabIndex = 1;
            this.TxtPw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPw.CustomButton.UseSelectable = true;
            this.TxtPw.CustomButton.Visible = false;
            this.TxtPw.Lines = new string[0];
            this.TxtPw.Location = new System.Drawing.Point(259, 303);
            this.TxtPw.MaxLength = 32767;
            this.TxtPw.Name = "TxtPw";
            this.TxtPw.PasswordChar = '*';
            this.TxtPw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPw.SelectedText = "";
            this.TxtPw.SelectionLength = 0;
            this.TxtPw.SelectionStart = 0;
            this.TxtPw.ShortcutsEnabled = true;
            this.TxtPw.Size = new System.Drawing.Size(202, 23);
            this.TxtPw.TabIndex = 5;
            this.TxtPw.UseSelectable = true;
            this.TxtPw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(288, 354);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(136, 36);
            this.BtnLogin.TabIndex = 6;
            this.BtnLogin.Text = "Iniciar Sesion";
            this.BtnLogin.UseSelectable = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(327, 483);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(142, 23);
            this.BtnRegister.TabIndex = 7;
            this.BtnRegister.Text = "Registrarse";
            this.BtnRegister.UseSelectable = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // BtnResetPw
            // 
            this.BtnResetPw.Location = new System.Drawing.Point(327, 422);
            this.BtnResetPw.Name = "BtnResetPw";
            this.BtnResetPw.Size = new System.Drawing.Size(175, 23);
            this.BtnResetPw.TabIndex = 8;
            this.BtnResetPw.Text = "Recuperar Contraseña";
            this.BtnResetPw.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(230, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // CbxSee
            // 
            this.CbxSee.AutoSize = true;
            this.CbxSee.Location = new System.Drawing.Point(488, 303);
            this.CbxSee.Name = "CbxSee";
            this.CbxSee.Size = new System.Drawing.Size(43, 17);
            this.CbxSee.TabIndex = 10;
            this.CbxSee.Text = "Ver";
            this.CbxSee.UseSelectable = true;
            this.CbxSee.CheckedChanged += new System.EventHandler(this.CbxSee_CheckedChanged);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 549);
            this.Controls.Add(this.CbxSee);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnResetPw);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPw);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblNoAccount);
            this.Controls.Add(this.LblResetPw);
            this.Controls.Add(this.LblPw);
            this.Controls.Add(this.LblEmail);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogIn";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Iniciar Sesion";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LblEmail;
        private MetroFramework.Controls.MetroLabel LblPw;
        private MetroFramework.Controls.MetroLabel LblResetPw;
        private MetroFramework.Controls.MetroLabel LblNoAccount;
        private MetroFramework.Controls.MetroTextBox TxtEmail;
        private MetroFramework.Controls.MetroTextBox TxtPw;
        private MetroFramework.Controls.MetroButton BtnLogin;
        private MetroFramework.Controls.MetroButton BtnRegister;
        private MetroFramework.Controls.MetroButton BtnResetPw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroCheckBox CbxSee;
    }
}

