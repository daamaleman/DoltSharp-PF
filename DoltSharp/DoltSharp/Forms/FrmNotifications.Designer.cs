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
            this.SuspendLayout();
            // 
            // LtbNotifications
            // 
            this.LtbNotifications.FormattingEnabled = true;
            this.LtbNotifications.Location = new System.Drawing.Point(85, 84);
            this.LtbNotifications.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LtbNotifications.Name = "LtbNotifications";
            this.LtbNotifications.Size = new System.Drawing.Size(425, 212);
            this.LtbNotifications.TabIndex = 0;
            // 
            // FrmNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.LtbNotifications);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmNotifications";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "Notificaciones";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LtbNotifications;
    }
}