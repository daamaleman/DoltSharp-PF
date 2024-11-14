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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
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
            this.LblWelcome.Location = new System.Drawing.Point(290, 60);
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(206, 25);
            this.LblWelcome.TabIndex = 0;
            this.LblWelcome.Text = "Bienvenidos a DoltSharp";
            // 
            // LblTaskView
            // 
            this.LblTaskView.AutoSize = true;
            this.LblTaskView.Location = new System.Drawing.Point(66, 238);
            this.LblTaskView.Name = "LblTaskView";
            this.LblTaskView.Size = new System.Drawing.Size(93, 19);
            this.LblTaskView.TabIndex = 3;
            this.LblTaskView.Text = "Lista de Tareas";
            // 
            // LlblProjectsView
            // 
            this.LlblProjectsView.AutoSize = true;
            this.LlblProjectsView.Location = new System.Drawing.Point(437, 238);
            this.LlblProjectsView.Name = "LlblProjectsView";
            this.LlblProjectsView.Size = new System.Drawing.Size(114, 19);
            this.LlblProjectsView.TabIndex = 5;
            this.LlblProjectsView.Text = "Lista de Proyectos";
            // 
            // BtnNewTask
            // 
            this.BtnNewTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewTask.Location = new System.Drawing.Point(99, 413);
            this.BtnNewTask.Name = "BtnNewTask";
            this.BtnNewTask.Size = new System.Drawing.Size(125, 30);
            this.BtnNewTask.TabIndex = 7;
            this.BtnNewTask.Text = "Agregar nueva Tarea";
            this.BtnNewTask.UseSelectable = true;
            this.BtnNewTask.Click += new System.EventHandler(this.BtnNewTask_Click);
            // 
            // BtnNewProject
            // 
            this.BtnNewProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewProject.Location = new System.Drawing.Point(456, 413);
            this.BtnNewProject.Name = "BtnNewProject";
            this.BtnNewProject.Size = new System.Drawing.Size(142, 30);
            this.BtnNewProject.TabIndex = 8;
            this.BtnNewProject.Text = "Agregar nuevo Proyecto";
            this.BtnNewProject.UseSelectable = true;
            this.BtnNewProject.Click += new System.EventHandler(this.BtnNewProject_Click);
            // 
            // DgvTaskList
            // 
            this.DgvTaskList.AllowUserToResizeRows = false;
            this.DgvTaskList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvTaskList.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.DgvTaskList.Location = new System.Drawing.Point(66, 273);
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
            this.DgvTaskList.Size = new System.Drawing.Size(209, 104);
            this.DgvTaskList.TabIndex = 13;
            // 
            // DgvProjectsList
            // 
            this.DgvProjectsList.AllowUserToResizeRows = false;
            this.DgvProjectsList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvProjectsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.DgvProjectsList.Location = new System.Drawing.Point(437, 273);
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
            this.DgvProjectsList.Size = new System.Drawing.Size(203, 104);
            this.DgvProjectsList.TabIndex = 14;
            // 
            // PbLogo
            // 
            this.PbLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbLogo.Image")));
            this.PbLogo.Location = new System.Drawing.Point(290, 92);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(146, 128);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogo.TabIndex = 12;
            this.PbLogo.TabStop = false;
            // 
            // BtnEditInformation
            // 
            this.BtnEditInformation.BackgroundImage = global::DoltSharp.Properties.Resources.d97bbb08017ac2309307f0822e63d082;
            this.BtnEditInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEditInformation.Location = new System.Drawing.Point(543, 30);
            this.BtnEditInformation.Name = "BtnEditInformation";
            this.BtnEditInformation.Size = new System.Drawing.Size(55, 59);
            this.BtnEditInformation.TabIndex = 11;
            this.BtnEditInformation.UseSelectable = true;
            this.BtnEditInformation.Click += new System.EventHandler(this.BtnEditarInformarcion_Click);
            // 
            // BtnLeave
            // 
            this.BtnLeave.BackgroundImage = global::DoltSharp.Properties.Resources._59801;
            this.BtnLeave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnLeave.Location = new System.Drawing.Point(670, 30);
            this.BtnLeave.Name = "BtnLeave";
            this.BtnLeave.Size = new System.Drawing.Size(67, 59);
            this.BtnLeave.TabIndex = 10;
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
            this.BtnConfiguration.Location = new System.Drawing.Point(604, 30);
            this.BtnConfiguration.Name = "BtnConfiguration";
            this.BtnConfiguration.Size = new System.Drawing.Size(60, 59);
            this.BtnConfiguration.TabIndex = 9;
            this.BtnConfiguration.UseSelectable = true;
            this.BtnConfiguration.Click += new System.EventHandler(this.BtnConfiguration_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 535);
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
            this.Name = "MainPage";
            this.Text = "Principal";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
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
    }
}