namespace DoltSharp.Forms
{
    partial class FrmNotifications
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
            this.LtbNotifications = new System.Windows.Forms.ListBox();
            this.BtnCloseNotifications = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // LtbNotifications
            // 
            this.LtbNotifications.FormattingEnabled = true;
            this.LtbNotifications.ItemHeight = 16;
            this.LtbNotifications.Location = new System.Drawing.Point(113, 103);
            this.LtbNotifications.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LtbNotifications.Name = "LtbNotifications";
            this.LtbNotifications.Size = new System.Drawing.Size(565, 260);
            this.LtbNotifications.TabIndex = 0;
            // 
            // BtnCloseNotifications
            // 
            this.BtnCloseNotifications.Location = new System.Drawing.Point(332, 378);
            this.BtnCloseNotifications.Name = "BtnCloseNotifications";
            this.BtnCloseNotifications.Size = new System.Drawing.Size(121, 49);
            this.BtnCloseNotifications.TabIndex = 1;
            this.BtnCloseNotifications.Text = "Cerrar Notificacion";
            this.BtnCloseNotifications.UseSelectable = true;
            this.BtnCloseNotifications.Click += new System.EventHandler(this.BtnCloseNotifications_Click);
            // 
            // FrmNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCloseNotifications);
            this.Controls.Add(this.LtbNotifications);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmNotifications";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Text = "Notificaciones";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LtbNotifications;
        private MetroFramework.Controls.MetroButton BtnCloseNotifications;
    }
}