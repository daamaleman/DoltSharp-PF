namespace DoltSharp.Forms
{
    partial class FrmCustomDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomDialog));
            this.LblMessage = new System.Windows.Forms.Label();
            this.BtnTask = new MetroFramework.Controls.MetroButton();
            this.BtnProject = new MetroFramework.Controls.MetroButton();
            this.BtnLeave = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Enabled = false;
            this.LblMessage.Location = new System.Drawing.Point(23, 49);
            this.LblMessage.MaximumSize = new System.Drawing.Size(229, 0);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(193, 16);
            this.LblMessage.TabIndex = 0;
            this.LblMessage.Text = "¿Que reporte desea visualizar?";
            // 
            // BtnTask
            // 
            this.BtnTask.Location = new System.Drawing.Point(5, 112);
            this.BtnTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnTask.Name = "BtnTask";
            this.BtnTask.Size = new System.Drawing.Size(69, 30);
            this.BtnTask.TabIndex = 1;
            this.BtnTask.Text = "Tareas";
            this.BtnTask.UseSelectable = true;
            this.BtnTask.Click += new System.EventHandler(this.BtnTask_Click);
            // 
            // BtnProject
            // 
            this.BtnProject.Location = new System.Drawing.Point(92, 112);
            this.BtnProject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnProject.Name = "BtnProject";
            this.BtnProject.Size = new System.Drawing.Size(69, 30);
            this.BtnProject.TabIndex = 2;
            this.BtnProject.Text = "Proyectos";
            this.BtnProject.UseSelectable = true;
            this.BtnProject.Click += new System.EventHandler(this.BtnProject_Click);
            // 
            // BtnLeave
            // 
            this.BtnLeave.Location = new System.Drawing.Point(177, 112);
            this.BtnLeave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLeave.Name = "BtnLeave";
            this.BtnLeave.Size = new System.Drawing.Size(69, 30);
            this.BtnLeave.TabIndex = 3;
            this.BtnLeave.Text = "Salir";
            this.BtnLeave.UseSelectable = true;
            this.BtnLeave.Click += new System.EventHandler(this.BtnLeave_Click);
            // 
            // FrmCustomDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 150);
            this.ControlBox = false;
            this.Controls.Add(this.BtnLeave);
            this.Controls.Add(this.BtnProject);
            this.Controls.Add(this.BtnTask);
            this.Controls.Add(this.LblMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCustomDialog";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMessage;
        private MetroFramework.Controls.MetroButton BtnTask;
        private MetroFramework.Controls.MetroButton BtnProject;
        private MetroFramework.Controls.MetroButton BtnLeave;
    }
}