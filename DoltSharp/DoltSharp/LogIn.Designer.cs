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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CbxSee = new MetroFramework.Controls.MetroCheckBox();
            this.LnResetPw = new MetroFramework.Controls.MetroLink();
            this.LnRegister = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(79, 212);
            this.LblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(44, 19);
            this.LblEmail.TabIndex = 0;
            this.LblEmail.Text = "Email:";
            // 
            // LblPw
            // 
            this.LblPw.AutoSize = true;
            this.LblPw.Location = new System.Drawing.Point(51, 248);
            this.LblPw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPw.Name = "LblPw";
            this.LblPw.Size = new System.Drawing.Size(78, 19);
            this.LblPw.TabIndex = 1;
            this.LblPw.Text = "Contraseña:";
            // 
            // LblResetPw
            // 
            this.LblResetPw.AutoSize = true;
            this.LblResetPw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LblResetPw.Location = new System.Drawing.Point(51, 344);
            this.LblResetPw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblResetPw.Name = "LblResetPw";
            this.LblResetPw.Size = new System.Drawing.Size(157, 19);
            this.LblResetPw.TabIndex = 2;
            this.LblResetPw.Text = "¿Olvidaste tu contraseña?";
            // 
            // LblNoAccount
            // 
            this.LblNoAccount.AutoSize = true;
            this.LblNoAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LblNoAccount.Location = new System.Drawing.Point(59, 391);
            this.LblNoAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNoAccount.Name = "LblNoAccount";
            this.LblNoAccount.Size = new System.Drawing.Size(143, 19);
            this.LblNoAccount.TabIndex = 3;
            this.LblNoAccount.Text = "¿No tienes una cuenta?";
            // 
            // TxtEmail
            // 
            // 
            // 
            // 
            this.TxtEmail.CustomButton.Image = null;
            this.TxtEmail.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.TxtEmail.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtEmail.CustomButton.Name = "";
            this.TxtEmail.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.TxtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtEmail.CustomButton.TabIndex = 1;
            this.TxtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtEmail.CustomButton.UseSelectable = true;
            this.TxtEmail.CustomButton.Visible = false;
            this.TxtEmail.Lines = new string[0];
            this.TxtEmail.Location = new System.Drawing.Point(129, 209);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtEmail.MaxLength = 32767;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PasswordChar = '\0';
            this.TxtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.SelectionLength = 0;
            this.TxtEmail.SelectionStart = 0;
            this.TxtEmail.ShortcutsEnabled = true;
            this.TxtEmail.Size = new System.Drawing.Size(152, 19);
            this.TxtEmail.TabIndex = 1;
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
            this.TxtPw.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.TxtPw.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtPw.CustomButton.Name = "";
            this.TxtPw.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.TxtPw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPw.CustomButton.TabIndex = 1;
            this.TxtPw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPw.CustomButton.UseSelectable = true;
            this.TxtPw.CustomButton.Visible = false;
            this.TxtPw.Lines = new string[0];
            this.TxtPw.Location = new System.Drawing.Point(129, 245);
            this.TxtPw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtPw.MaxLength = 32767;
            this.TxtPw.Name = "TxtPw";
            this.TxtPw.PasswordChar = '*';
            this.TxtPw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPw.SelectedText = "";
            this.TxtPw.SelectionLength = 0;
            this.TxtPw.SelectionStart = 0;
            this.TxtPw.ShortcutsEnabled = true;
            this.TxtPw.Size = new System.Drawing.Size(152, 19);
            this.TxtPw.TabIndex = 2;
            this.TxtPw.UseSelectable = true;
            this.TxtPw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.Location = new System.Drawing.Point(151, 287);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(102, 29);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Iniciar Sesion";
            this.BtnLogin.UseSelectable = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(129, 62);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // CbxSee
            // 
            this.CbxSee.AutoSize = true;
            this.CbxSee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbxSee.Location = new System.Drawing.Point(301, 245);
            this.CbxSee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbxSee.Name = "CbxSee";
            this.CbxSee.Size = new System.Drawing.Size(39, 15);
            this.CbxSee.TabIndex = 3;
            this.CbxSee.Text = "Ver";
            this.CbxSee.UseSelectable = true;
            this.CbxSee.CheckedChanged += new System.EventHandler(this.CbxSee_CheckedChanged);
            // 
            // LnResetPw
            // 
            this.LnResetPw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LnResetPw.Location = new System.Drawing.Point(206, 344);
            this.LnResetPw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LnResetPw.Name = "LnResetPw";
            this.LnResetPw.Size = new System.Drawing.Size(149, 19);
            this.LnResetPw.TabIndex = 10;
            this.LnResetPw.Text = "Recuperar Contraseña";
            this.LnResetPw.UseSelectable = true;
            // 
            // LnRegister
            // 
            this.LnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LnRegister.Location = new System.Drawing.Point(214, 391);
            this.LnRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LnRegister.Name = "LnRegister";
            this.LnRegister.Size = new System.Drawing.Size(74, 19);
            this.LnRegister.TabIndex = 11;
            this.LnRegister.Text = "Regístrate";
            this.LnRegister.UseSelectable = true;
            this.LnRegister.Click += new System.EventHandler(this.LnRegister_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 446);
            this.Controls.Add(this.LnRegister);
            this.Controls.Add(this.LnResetPw);
            this.Controls.Add(this.CbxSee);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPw);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblNoAccount);
            this.Controls.Add(this.LblResetPw);
            this.Controls.Add(this.LblPw);
            this.Controls.Add(this.LblEmail);
            this.Name = "LogIn";
            this.Resizable = false;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroCheckBox CbxSee;
        private MetroFramework.Controls.MetroLink LnResetPw;
        private MetroFramework.Controls.MetroLink LnRegister;
    }
}

