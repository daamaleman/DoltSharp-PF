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
            this.LblEmail.Location = new System.Drawing.Point(105, 261);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(44, 19);
            this.LblEmail.TabIndex = 0;
            this.LblEmail.Text = "Email:";
            // 
            // LblPw
            // 
            this.LblPw.AutoSize = true;
            this.LblPw.Location = new System.Drawing.Point(68, 305);
            this.LblPw.Name = "LblPw";
            this.LblPw.Size = new System.Drawing.Size(78, 19);
            this.LblPw.TabIndex = 1;
            this.LblPw.Text = "Contraseña:";
            // 
            // LblResetPw
            // 
            this.LblResetPw.AutoSize = true;
            this.LblResetPw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LblResetPw.Location = new System.Drawing.Point(68, 423);
            this.LblResetPw.Name = "LblResetPw";
            this.LblResetPw.Size = new System.Drawing.Size(157, 19);
            this.LblResetPw.TabIndex = 2;
            this.LblResetPw.Text = "¿Olvidaste tu contraseña?";
            // 
            // LblNoAccount
            // 
            this.LblNoAccount.AutoSize = true;
            this.LblNoAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LblNoAccount.Location = new System.Drawing.Point(79, 481);
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
            this.TxtEmail.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.TxtEmail.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtEmail.CustomButton.Name = "";
            this.TxtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtEmail.CustomButton.TabIndex = 1;
            this.TxtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtEmail.CustomButton.UseSelectable = true;
            this.TxtEmail.CustomButton.Visible = false;
            this.TxtEmail.Lines = new string[0];
            this.TxtEmail.Location = new System.Drawing.Point(172, 257);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtEmail.MaxLength = 32767;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PasswordChar = '\0';
            this.TxtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.SelectionLength = 0;
            this.TxtEmail.SelectionStart = 0;
            this.TxtEmail.ShortcutsEnabled = true;
            this.TxtEmail.Size = new System.Drawing.Size(203, 23);
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
            this.TxtPw.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.TxtPw.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPw.CustomButton.Name = "";
            this.TxtPw.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtPw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPw.CustomButton.TabIndex = 1;
            this.TxtPw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPw.CustomButton.UseSelectable = true;
            this.TxtPw.CustomButton.Visible = false;
            this.TxtPw.Lines = new string[0];
            this.TxtPw.Location = new System.Drawing.Point(172, 302);
            this.TxtPw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPw.MaxLength = 32767;
            this.TxtPw.Name = "TxtPw";
            this.TxtPw.PasswordChar = '*';
            this.TxtPw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPw.SelectedText = "";
            this.TxtPw.SelectionLength = 0;
            this.TxtPw.SelectionStart = 0;
            this.TxtPw.ShortcutsEnabled = true;
            this.TxtPw.Size = new System.Drawing.Size(203, 23);
            this.TxtPw.TabIndex = 2;
            this.TxtPw.UseSelectable = true;
            this.TxtPw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.Location = new System.Drawing.Point(201, 353);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(136, 36);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Iniciar Sesion";
            this.BtnLogin.UseSelectable = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(172, 76);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // CbxSee
            // 
            this.CbxSee.AutoSize = true;
            this.CbxSee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbxSee.Location = new System.Drawing.Point(401, 302);
            this.CbxSee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.LnResetPw.Location = new System.Drawing.Point(275, 423);
            this.LnResetPw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LnResetPw.Name = "LnResetPw";
            this.LnResetPw.Size = new System.Drawing.Size(199, 23);
            this.LnResetPw.TabIndex = 10;
            this.LnResetPw.Text = "Recuperar Contraseña";
            this.LnResetPw.UseSelectable = true;
            // 
            // LnRegister
            // 
            this.LnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LnRegister.Location = new System.Drawing.Point(285, 481);
            this.LnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LnRegister.Name = "LnRegister";
            this.LnRegister.Size = new System.Drawing.Size(99, 23);
            this.LnRegister.TabIndex = 11;
            this.LnRegister.Text = "Regístrate";
            this.LnRegister.UseSelectable = true;
            this.LnRegister.Click += new System.EventHandler(this.LnRegister_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 549);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogIn";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Text = "Iniciar Sesion";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.LogIn_Load);
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

