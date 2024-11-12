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
            this.LblBienvenida = new MetroFramework.Controls.MetroLabel();
            this.LblVistaTareas = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BtnNuevaTarea = new MetroFramework.Controls.MetroButton();
            this.BtnNuevoProyecto = new MetroFramework.Controls.MetroButton();
            this.BtnEditarInformarcion = new MetroFramework.Controls.MetroButton();
            this.BtnSalida = new MetroFramework.Controls.MetroButton();
            this.BtnConfiguracion = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GrdListaTareas = new MetroFramework.Controls.MetroGrid();
            this.GrdListaProyectos = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdListaTareas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdListaProyectos)).BeginInit();
            this.SuspendLayout();
            // 
            // LblBienvenida
            // 
            this.LblBienvenida.AutoSize = true;
            this.LblBienvenida.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblBienvenida.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LblBienvenida.Location = new System.Drawing.Point(258, 60);
            this.LblBienvenida.Name = "LblBienvenida";
            this.LblBienvenida.Size = new System.Drawing.Size(206, 25);
            this.LblBienvenida.TabIndex = 0;
            this.LblBienvenida.Text = "Bienvenidos a DoltSharp";
            // 
            // LblVistaTareas
            // 
            this.LblVistaTareas.AutoSize = true;
            this.LblVistaTareas.Location = new System.Drawing.Point(99, 238);
            this.LblVistaTareas.Name = "LblVistaTareas";
            this.LblVistaTareas.Size = new System.Drawing.Size(93, 19);
            this.LblVistaTareas.TabIndex = 3;
            this.LblVistaTareas.Text = "Lista de Tareas";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(437, 238);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(114, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Lista de Proyectos";
            // 
            // BtnNuevaTarea
            // 
            this.BtnNuevaTarea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevaTarea.Location = new System.Drawing.Point(99, 413);
            this.BtnNuevaTarea.Name = "BtnNuevaTarea";
            this.BtnNuevaTarea.Size = new System.Drawing.Size(125, 30);
            this.BtnNuevaTarea.TabIndex = 7;
            this.BtnNuevaTarea.Text = "Agregar nueva Tarea";
            this.BtnNuevaTarea.UseSelectable = true;
            // 
            // BtnNuevoProyecto
            // 
            this.BtnNuevoProyecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevoProyecto.Location = new System.Drawing.Point(456, 413);
            this.BtnNuevoProyecto.Name = "BtnNuevoProyecto";
            this.BtnNuevoProyecto.Size = new System.Drawing.Size(142, 30);
            this.BtnNuevoProyecto.TabIndex = 8;
            this.BtnNuevoProyecto.Text = "Agregar nuevo Proyecto";
            this.BtnNuevoProyecto.UseSelectable = true;
            // 
            // BtnEditarInformarcion
            // 
            this.BtnEditarInformarcion.BackgroundImage = global::DoltSharp.Properties.Resources.d97bbb08017ac2309307f0822e63d082;
            this.BtnEditarInformarcion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEditarInformarcion.Location = new System.Drawing.Point(543, 30);
            this.BtnEditarInformarcion.Name = "BtnEditarInformarcion";
            this.BtnEditarInformarcion.Size = new System.Drawing.Size(55, 59);
            this.BtnEditarInformarcion.TabIndex = 11;
            this.BtnEditarInformarcion.UseSelectable = true;
            this.BtnEditarInformarcion.Click += new System.EventHandler(this.BtnEditarInformarcion_Click);
            // 
            // BtnSalida
            // 
            this.BtnSalida.BackgroundImage = global::DoltSharp.Properties.Resources._59801;
            this.BtnSalida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSalida.Location = new System.Drawing.Point(670, 30);
            this.BtnSalida.Name = "BtnSalida";
            this.BtnSalida.Size = new System.Drawing.Size(67, 59);
            this.BtnSalida.TabIndex = 10;
            this.BtnSalida.UseSelectable = true;
            this.BtnSalida.Click += new System.EventHandler(this.BtnSalida_Click);
            // 
            // BtnConfiguracion
            // 
            this.BtnConfiguracion.BackColor = System.Drawing.Color.White;
            this.BtnConfiguracion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnConfiguracion.BackgroundImage")));
            this.BtnConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfiguracion.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnConfiguracion.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnConfiguracion.ForeColor = System.Drawing.Color.White;
            this.BtnConfiguracion.Location = new System.Drawing.Point(604, 30);
            this.BtnConfiguracion.Name = "BtnConfiguracion";
            this.BtnConfiguracion.Size = new System.Drawing.Size(60, 59);
            this.BtnConfiguracion.TabIndex = 9;
            this.BtnConfiguracion.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(290, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // GrdListaTareas
            // 
            this.GrdListaTareas.AllowUserToResizeRows = false;
            this.GrdListaTareas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GrdListaTareas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdListaTareas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrdListaTareas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdListaTareas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrdListaTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdListaTareas.DefaultCellStyle = dataGridViewCellStyle2;
            this.GrdListaTareas.EnableHeadersVisualStyles = false;
            this.GrdListaTareas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrdListaTareas.GridColor = System.Drawing.Color.Black;
            this.GrdListaTareas.Location = new System.Drawing.Point(66, 273);
            this.GrdListaTareas.Name = "GrdListaTareas";
            this.GrdListaTareas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdListaTareas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GrdListaTareas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdListaTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdListaTareas.Size = new System.Drawing.Size(209, 104);
            this.GrdListaTareas.TabIndex = 13;
            // 
            // GrdListaProyectos
            // 
            this.GrdListaProyectos.AllowUserToResizeRows = false;
            this.GrdListaProyectos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GrdListaProyectos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdListaProyectos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrdListaProyectos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdListaProyectos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GrdListaProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdListaProyectos.DefaultCellStyle = dataGridViewCellStyle5;
            this.GrdListaProyectos.EnableHeadersVisualStyles = false;
            this.GrdListaProyectos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrdListaProyectos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdListaProyectos.Location = new System.Drawing.Point(437, 273);
            this.GrdListaProyectos.Name = "GrdListaProyectos";
            this.GrdListaProyectos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdListaProyectos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GrdListaProyectos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdListaProyectos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdListaProyectos.Size = new System.Drawing.Size(203, 104);
            this.GrdListaProyectos.TabIndex = 14;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 535);
            this.Controls.Add(this.GrdListaProyectos);
            this.Controls.Add(this.GrdListaTareas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnEditarInformarcion);
            this.Controls.Add(this.BtnSalida);
            this.Controls.Add(this.BtnConfiguracion);
            this.Controls.Add(this.BtnNuevoProyecto);
            this.Controls.Add(this.BtnNuevaTarea);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.LblVistaTareas);
            this.Controls.Add(this.LblBienvenida);
            this.Name = "MainPage";
            this.Text = "Principal";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdListaTareas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdListaProyectos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LblBienvenida;
        private MetroFramework.Controls.MetroLabel LblVistaTareas;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton BtnNuevaTarea;
        private MetroFramework.Controls.MetroButton BtnNuevoProyecto;
        private MetroFramework.Controls.MetroButton BtnConfiguracion;
        private MetroFramework.Controls.MetroButton BtnSalida;
        private MetroFramework.Controls.MetroButton BtnEditarInformarcion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroGrid GrdListaTareas;
        private MetroFramework.Controls.MetroGrid GrdListaProyectos;
    }
}