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
            this.LblBienvenida = new MetroFramework.Controls.MetroLabel();
            this.LblVistaTareas = new MetroFramework.Controls.MetroLabel();
            this.CmbBxListaTareas = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CmbBxListaProyectos = new MetroFramework.Controls.MetroComboBox();
            this.BtnNuevaTarea = new MetroFramework.Controls.MetroButton();
            this.BtnNuevoProyecto = new MetroFramework.Controls.MetroButton();
            this.BtnEditarInformarcion = new MetroFramework.Controls.MetroButton();
            this.BtnSalida = new MetroFramework.Controls.MetroButton();
            this.BtnConfiguracion = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // CmbBxListaTareas
            // 
            this.CmbBxListaTareas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbBxListaTareas.FormattingEnabled = true;
            this.CmbBxListaTareas.ItemHeight = 23;
            this.CmbBxListaTareas.Location = new System.Drawing.Point(99, 260);
            this.CmbBxListaTareas.Name = "CmbBxListaTareas";
            this.CmbBxListaTareas.Size = new System.Drawing.Size(201, 29);
            this.CmbBxListaTareas.TabIndex = 4;
            this.CmbBxListaTareas.UseSelectable = true;
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
            // CmbBxListaProyectos
            // 
            this.CmbBxListaProyectos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbBxListaProyectos.FormattingEnabled = true;
            this.CmbBxListaProyectos.ItemHeight = 23;
            this.CmbBxListaProyectos.Location = new System.Drawing.Point(437, 260);
            this.CmbBxListaProyectos.Name = "CmbBxListaProyectos";
            this.CmbBxListaProyectos.Size = new System.Drawing.Size(209, 29);
            this.CmbBxListaProyectos.TabIndex = 6;
            this.CmbBxListaProyectos.UseSelectable = true;
            // 
            // BtnNuevaTarea
            // 
            this.BtnNuevaTarea.Location = new System.Drawing.Point(139, 337);
            this.BtnNuevaTarea.Name = "BtnNuevaTarea";
            this.BtnNuevaTarea.Size = new System.Drawing.Size(125, 30);
            this.BtnNuevaTarea.TabIndex = 7;
            this.BtnNuevaTarea.Text = "Agregar nueva Tarea";
            this.BtnNuevaTarea.UseSelectable = true;
            // 
            // BtnNuevoProyecto
            // 
            this.BtnNuevoProyecto.Location = new System.Drawing.Point(471, 337);
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
            this.BtnEditarInformarcion.Location = new System.Drawing.Point(543, 13);
            this.BtnEditarInformarcion.Name = "BtnEditarInformarcion";
            this.BtnEditarInformarcion.Size = new System.Drawing.Size(55, 59);
            this.BtnEditarInformarcion.TabIndex = 11;
            this.BtnEditarInformarcion.UseSelectable = true;
            this.BtnEditarInformarcion.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // BtnSalida
            // 
            this.BtnSalida.BackgroundImage = global::DoltSharp.Properties.Resources._59801;
            this.BtnSalida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSalida.Location = new System.Drawing.Point(670, 13);
            this.BtnSalida.Name = "BtnSalida";
            this.BtnSalida.Size = new System.Drawing.Size(67, 59);
            this.BtnSalida.TabIndex = 10;
            this.BtnSalida.UseSelectable = true;
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
            this.BtnConfiguracion.Location = new System.Drawing.Point(604, 13);
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
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 446);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnEditarInformarcion);
            this.Controls.Add(this.BtnSalida);
            this.Controls.Add(this.BtnConfiguracion);
            this.Controls.Add(this.BtnNuevoProyecto);
            this.Controls.Add(this.BtnNuevaTarea);
            this.Controls.Add(this.CmbBxListaProyectos);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.CmbBxListaTareas);
            this.Controls.Add(this.LblVistaTareas);
            this.Controls.Add(this.LblBienvenida);
            this.Name = "MainPage";
            this.Text = "Principal";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LblBienvenida;
        private MetroFramework.Controls.MetroLabel LblVistaTareas;
        private MetroFramework.Controls.MetroComboBox CmbBxListaTareas;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox CmbBxListaProyectos;
        private MetroFramework.Controls.MetroButton BtnNuevaTarea;
        private MetroFramework.Controls.MetroButton BtnNuevoProyecto;
        private MetroFramework.Controls.MetroButton BtnConfiguracion;
        private MetroFramework.Controls.MetroButton BtnSalida;
        private MetroFramework.Controls.MetroButton BtnEditarInformarcion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}