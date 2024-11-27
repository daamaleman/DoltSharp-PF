namespace DoltSharp
{
    partial class FrmMainPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainPage));
            this.LblWelcome = new MetroFramework.Controls.MetroLabel();
            this.LblTaskView = new MetroFramework.Controls.MetroLabel();
            this.LlblProjectsView = new MetroFramework.Controls.MetroLabel();
            this.BtnNewTask = new MetroFramework.Controls.MetroButton();
            this.BtnNewProject = new MetroFramework.Controls.MetroButton();
            this.DgvTaskList = new MetroFramework.Controls.MetroGrid();
            this.DgvProjectsList = new MetroFramework.Controls.MetroGrid();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.BtnEditInformation = new MetroFramework.Controls.MetroButton();
            this.BtnLeave = new MetroFramework.Controls.MetroButton();
            this.BtnConfiguration = new MetroFramework.Controls.MetroButton();
            this.BtnViewReports = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTaskList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProjectsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblWelcome
            // 
            this.LblWelcome.AutoSize = true;
            this.LblWelcome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblWelcome.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LblWelcome.Location = new System.Drawing.Point(417, 87);
            this.LblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(206, 25);
            this.LblWelcome.TabIndex = 0;
            this.LblWelcome.Text = "Bienvenidos a DoltSharp";
            // 
            // LblTaskView
            // 
            this.LblTaskView.AutoSize = true;
            this.LblTaskView.Location = new System.Drawing.Point(217, 305);
            this.LblTaskView.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTaskView.Name = "LblTaskView";
            this.LblTaskView.Size = new System.Drawing.Size(93, 19);
            this.LblTaskView.TabIndex = 3;
            this.LblTaskView.Text = "Lista de Tareas";
            // 
            // LlblProjectsView
            // 
            this.LlblProjectsView.AutoSize = true;
            this.LlblProjectsView.Location = new System.Drawing.Point(772, 305);
            this.LlblProjectsView.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LlblProjectsView.Name = "LlblProjectsView";
            this.LlblProjectsView.Size = new System.Drawing.Size(114, 19);
            this.LlblProjectsView.TabIndex = 5;
            this.LlblProjectsView.Text = "Lista de Proyectos";
            // 
            // BtnNewTask
            // 
            this.BtnNewTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewTask.Location = new System.Drawing.Point(175, 558);
            this.BtnNewTask.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNewTask.Name = "BtnNewTask";
            this.BtnNewTask.Size = new System.Drawing.Size(167, 37);
            this.BtnNewTask.TabIndex = 1;
            this.BtnNewTask.Text = "Agregar nueva Tarea";
            this.BtnNewTask.UseSelectable = true;
            this.BtnNewTask.Click += new System.EventHandler(this.BtnNewTask_Click);
            // 
            // BtnNewProject
            // 
            this.BtnNewProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewProject.Location = new System.Drawing.Point(772, 558);
            this.BtnNewProject.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNewProject.Name = "BtnNewProject";
            this.BtnNewProject.Size = new System.Drawing.Size(189, 37);
            this.BtnNewProject.TabIndex = 2;
            this.BtnNewProject.Text = "Agregar nuevo Proyecto";
            this.BtnNewProject.UseSelectable = true;
            this.BtnNewProject.Click += new System.EventHandler(this.BtnNewProject_Click);
            // 
            // DgvTaskList
            // 
            this.DgvTaskList.AllowUserToResizeRows = false;
            this.DgvTaskList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvTaskList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvTaskList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvTaskList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvTaskList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvTaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvTaskList.DefaultCellStyle = dataGridViewCellStyle8;
            this.DgvTaskList.EnableHeadersVisualStyles = false;
            this.DgvTaskList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DgvTaskList.GridColor = System.Drawing.Color.Black;
            this.DgvTaskList.Location = new System.Drawing.Point(7, 332);
            this.DgvTaskList.Margin = new System.Windows.Forms.Padding(4);
            this.DgvTaskList.Name = "DgvTaskList";
            this.DgvTaskList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvTaskList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DgvTaskList.RowHeadersWidth = 51;
            this.DgvTaskList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvTaskList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTaskList.Size = new System.Drawing.Size(524, 218);
            this.DgvTaskList.TabIndex = 13;
            this.DgvTaskList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTaskList_CellContentClick);
            // 
            // DgvProjectsList
            // 
            this.DgvProjectsList.AllowUserToResizeRows = false;
            this.DgvProjectsList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvProjectsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvProjectsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvProjectsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProjectsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DgvProjectsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvProjectsList.DefaultCellStyle = dataGridViewCellStyle11;
            this.DgvProjectsList.EnableHeadersVisualStyles = false;
            this.DgvProjectsList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DgvProjectsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgvProjectsList.Location = new System.Drawing.Point(561, 332);
            this.DgvProjectsList.Margin = new System.Windows.Forms.Padding(4);
            this.DgvProjectsList.Name = "DgvProjectsList";
            this.DgvProjectsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProjectsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DgvProjectsList.RowHeadersWidth = 51;
            this.DgvProjectsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvProjectsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProjectsList.Size = new System.Drawing.Size(524, 218);
            this.DgvProjectsList.TabIndex = 14;
            this.DgvProjectsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProjectsList_CellContentClick);
            // 
            // PbLogo
            // 
            this.PbLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PbLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbLogo.Image")));
            this.PbLogo.Location = new System.Drawing.Point(452, 140);
            this.PbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(193, 157);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogo.TabIndex = 12;
            this.PbLogo.TabStop = false;
            this.PbLogo.WaitOnLoad = true;
            // 
            // BtnEditInformation
            // 
            this.BtnEditInformation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEditInformation.BackgroundImage")));
            this.BtnEditInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEditInformation.Location = new System.Drawing.Point(7, 23);
            this.BtnEditInformation.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEditInformation.Name = "BtnEditInformation";
            this.BtnEditInformation.Size = new System.Drawing.Size(60, 62);
            this.BtnEditInformation.TabIndex = 3;
            this.BtnEditInformation.UseSelectable = true;
            this.BtnEditInformation.Click += new System.EventHandler(this.BtnEditarInformarcion_Click);
            // 
            // BtnLeave
            // 
            this.BtnLeave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLeave.BackgroundImage")));
            this.BtnLeave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnLeave.Location = new System.Drawing.Point(149, 23);
            this.BtnLeave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLeave.Name = "BtnLeave";
            this.BtnLeave.Size = new System.Drawing.Size(76, 62);
            this.BtnLeave.TabIndex = 5;
            this.BtnLeave.UseSelectable = true;
            this.BtnLeave.Click += new System.EventHandler(this.BtnSalida_Click);
            // 
            // BtnConfiguration
            // 
            this.BtnConfiguration.BackColor = System.Drawing.Color.White;
            this.BtnConfiguration.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnConfiguration.BackgroundImage")));
            this.BtnConfiguration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnConfiguration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfiguration.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnConfiguration.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnConfiguration.ForeColor = System.Drawing.Color.White;
            this.BtnConfiguration.Location = new System.Drawing.Point(75, 23);
            this.BtnConfiguration.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConfiguration.Name = "BtnConfiguration";
            this.BtnConfiguration.Size = new System.Drawing.Size(67, 62);
            this.BtnConfiguration.TabIndex = 4;
            this.BtnConfiguration.UseSelectable = true;
            this.BtnConfiguration.Click += new System.EventHandler(this.BtnConfiguration_Click);
            // 
            // BtnViewReports
            // 
            this.BtnViewReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnViewReports.Location = new System.Drawing.Point(364, 558);
            this.BtnViewReports.Margin = new System.Windows.Forms.Padding(4);
            this.BtnViewReports.Name = "BtnViewReports";
            this.BtnViewReports.Size = new System.Drawing.Size(167, 37);
            this.BtnViewReports.TabIndex = 15;
            this.BtnViewReports.Text = "Ver Reporte";
            this.BtnViewReports.UseSelectable = true;
            this.BtnViewReports.Click += new System.EventHandler(this.BtnViewReports_Click);
            // 
            // FrmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 731);
            this.Controls.Add(this.BtnViewReports);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMainPage";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Text = "Principal";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FrmMainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTaskList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProjectsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
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
        private MetroFramework.Controls.MetroButton BtnViewReports;
    }
}