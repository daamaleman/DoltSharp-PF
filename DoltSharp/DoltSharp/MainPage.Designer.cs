namespace DoltSharp
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblWelcome = new MetroFramework.Controls.MetroLabel();
            this.LblTaskView = new MetroFramework.Controls.MetroLabel();
            this.LlblProjectsView = new MetroFramework.Controls.MetroLabel();
            this.BtnNewTask = new MetroFramework.Controls.MetroButton();
            this.BtnNewProject = new MetroFramework.Controls.MetroButton();
            this.BtnEditInformation = new MetroFramework.Controls.MetroButton();
            this.BtnLeave = new MetroFramework.Controls.MetroButton();
            this.BtnConfiguration = new MetroFramework.Controls.MetroButton();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.DgvTaskList = new MetroFramework.Controls.MetroGrid();
            this.DgvProjectsList = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTaskList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProjectsList)).BeginInit();
            this.SuspendLayout();
            // 
            // LblWelcome
            // 
            this.LblWelcome.AutoSize = true;
            this.LblWelcome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblWelcome.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LblWelcome.Location = new System.Drawing.Point(387, 74);
            this.LblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(206, 25);
            this.LblWelcome.TabIndex = 0;
            this.LblWelcome.Text = "Bienvenidos a DoltSharp";
            // 
            // LblTaskView
            // 
            this.LblTaskView.AutoSize = true;
            this.LblTaskView.Location = new System.Drawing.Point(88, 293);
            this.LblTaskView.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTaskView.Name = "LblTaskView";
            this.LblTaskView.Size = new System.Drawing.Size(93, 19);
            this.LblTaskView.TabIndex = 3;
            this.LblTaskView.Text = "Lista de Tareas";
            // 
            // LlblProjectsView
            // 
            this.LlblProjectsView.AutoSize = true;
            this.LlblProjectsView.Location = new System.Drawing.Point(583, 293);
            this.LlblProjectsView.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LlblProjectsView.Name = "LlblProjectsView";
            this.LlblProjectsView.Size = new System.Drawing.Size(114, 19);
            this.LlblProjectsView.TabIndex = 5;
            this.LlblProjectsView.Text = "Lista de Proyectos";
            // 
            // BtnNewTask
            // 
            this.BtnNewTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewTask.Location = new System.Drawing.Point(132, 508);
            this.BtnNewTask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnNewTask.Name = "BtnNewTask";
            this.BtnNewTask.Size = new System.Drawing.Size(167, 37);
            this.BtnNewTask.TabIndex = 7;
            this.BtnNewTask.Text = "Agregar nueva Tarea";
            this.BtnNewTask.UseSelectable = true;
            // 
            // BtnNewProject
            // 
            this.BtnNewProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewProject.Location = new System.Drawing.Point(608, 508);
            this.BtnNewProject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnNewProject.Name = "BtnNewProject";
            this.BtnNewProject.Size = new System.Drawing.Size(189, 37);
            this.BtnNewProject.TabIndex = 8;
            this.BtnNewProject.Text = "Agregar nuevo Proyecto";
            this.BtnNewProject.UseSelectable = true;
            // 
            // BtnEditInformation
            // 
            this.BtnEditInformation.BackgroundImage = global::DoltSharp.Properties.Resources.d97bbb08017ac2309307f0822e63d082;
            this.BtnEditInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEditInformation.Location = new System.Drawing.Point(724, 37);
            this.BtnEditInformation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEditInformation.Name = "BtnEditInformation";
            this.BtnEditInformation.Size = new System.Drawing.Size(73, 73);
            this.BtnEditInformation.TabIndex = 11;
            this.BtnEditInformation.UseSelectable = true;
            this.BtnEditInformation.Click += new System.EventHandler(this.BtnEditarInformarcion_Click);
            // 
            // BtnLeave
            // 
            this.BtnLeave.BackgroundImage = global::DoltSharp.Properties.Resources._59801;
            this.BtnLeave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnLeave.Location = new System.Drawing.Point(893, 37);
            this.BtnLeave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnLeave.Name = "BtnLeave";
            this.BtnLeave.Size = new System.Drawing.Size(89, 73);
            this.BtnLeave.TabIndex = 10;
            this.BtnLeave.UseSelectable = true;
            this.BtnLeave.Click += new System.EventHandler(this.BtnSalida_Click);
            // 
            // BtnConfiguration
            // 
            this.BtnConfiguration.BackColor = System.Drawing.Color.White;
            this.BtnConfiguration.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnConfiguration.BackgroundImage")));
            this.BtnConfiguration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnConfiguration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfiguration.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnConfiguration.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnConfiguration.ForeColor = System.Drawing.Color.White;
            this.BtnConfiguration.Location = new System.Drawing.Point(805, 37);
            this.BtnConfiguration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnConfiguration.Name = "BtnConfiguration";
            this.BtnConfiguration.Size = new System.Drawing.Size(80, 73);
            this.BtnConfiguration.TabIndex = 9;
            this.BtnConfiguration.UseSelectable = true;
            // 
            // PbLogo
            // 
            this.PbLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbLogo.Image")));
            this.PbLogo.Location = new System.Drawing.Point(387, 113);
            this.PbLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(195, 158);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogo.TabIndex = 12;
            this.PbLogo.TabStop = false;
            // 
            // DgvTaskList
            // 
            this.DgvTaskList.AllowUserToResizeRows = false;
            this.DgvTaskList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvTaskList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvTaskList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvTaskList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvTaskList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvTaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvTaskList.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvTaskList.EnableHeadersVisualStyles = false;
            this.DgvTaskList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DgvTaskList.GridColor = System.Drawing.Color.Black;
            this.DgvTaskList.Location = new System.Drawing.Point(88, 336);
            this.DgvTaskList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvTaskList.Name = "DgvTaskList";
            this.DgvTaskList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvTaskList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvTaskList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvTaskList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTaskList.Size = new System.Drawing.Size(279, 128);
            this.DgvTaskList.TabIndex = 13;
            // 
            // DgvProjectsList
            // 
            this.DgvProjectsList.AllowUserToResizeRows = false;
            this.DgvProjectsList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvProjectsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvProjectsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvProjectsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProjectsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvProjectsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvProjectsList.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvProjectsList.EnableHeadersVisualStyles = false;
            this.DgvProjectsList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DgvProjectsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgvProjectsList.Location = new System.Drawing.Point(583, 336);
            this.DgvProjectsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvProjectsList.Name = "DgvProjectsList";
            this.DgvProjectsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProjectsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvProjectsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvProjectsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProjectsList.Size = new System.Drawing.Size(271, 128);
            this.DgvProjectsList.TabIndex = 14;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 658);
            this.Controls.Add(this.DgvProjectsList);
            this.Controls.Add(this.DgvTaskList);
            this.Controls.Add(this.PbLogo);
            this.Controls.Add(this.BtnEditInformation);
            this.Controls.Add(this.BtnLeave);
            this.Controls.Add(this.BtnConfiguration);
            this.Controls.Add(this.BtnNewProject);
            this.Controls.Add(this.BtnNewTask);
            this.Controls.Add(this.LlblProjectsView);
            this.Controls.Add(this.LblTaskView);
            this.Controls.Add(this.LblWelcome);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainPage";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Principal";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTaskList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProjectsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LblWelcome;
        private MetroFramework.Controls.MetroLabel LblTaskView;
        private MetroFramework.Controls.MetroLabel LlblProjectsView;
        private MetroFramework.Controls.MetroButton BtnNewTask;
        private MetroFramework.Controls.MetroButton BtnNewProject;
        private MetroFramework.Controls.MetroButton BtnConfiguration;
        private MetroFramework.Controls.MetroButton BtnLeave;
        private MetroFramework.Controls.MetroButton BtnEditInformation;
        private System.Windows.Forms.PictureBox PbLogo;
        private MetroFramework.Controls.MetroGrid DgvTaskList;
        private MetroFramework.Controls.MetroGrid DgvProjectsList;
    }
}