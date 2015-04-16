namespace Cinefilo_1
{
    partial class FormInici
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datosGeneralesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDePapelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.películasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaciónDePapelesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosGeneralesToolStripMenuItem,
            this.películasToolStripMenuItem,
            this.actoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datosGeneralesToolStripMenuItem
            // 
            this.datosGeneralesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiposDePapelToolStripMenuItem,
            this.temasToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.datosGeneralesToolStripMenuItem.Name = "datosGeneralesToolStripMenuItem";
            this.datosGeneralesToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.datosGeneralesToolStripMenuItem.Text = "Datos Generales";
            // 
            // tiposDePapelToolStripMenuItem
            // 
            this.tiposDePapelToolStripMenuItem.Name = "tiposDePapelToolStripMenuItem";
            this.tiposDePapelToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.tiposDePapelToolStripMenuItem.Text = "Tipos de papel";
            this.tiposDePapelToolStripMenuItem.Click += new System.EventHandler(this.tiposDePapelToolStripMenuItem_Click);
            // 
            // temasToolStripMenuItem
            // 
            this.temasToolStripMenuItem.Name = "temasToolStripMenuItem";
            this.temasToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.temasToolStripMenuItem.Text = "Temas";
            this.temasToolStripMenuItem.Click += new System.EventHandler(this.temasToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // películasToolStripMenuItem
            // 
            this.películasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem});
            this.películasToolStripMenuItem.Name = "películasToolStripMenuItem";
            this.películasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.películasToolStripMenuItem.Text = "Películas";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            this.mantenimientoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoToolStripMenuItem_Click);
            // 
            // actoresToolStripMenuItem
            // 
            this.actoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem1,
            this.asignaciónDePapelesToolStripMenuItem});
            this.actoresToolStripMenuItem.Name = "actoresToolStripMenuItem";
            this.actoresToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actoresToolStripMenuItem.Text = "Actores";
            // 
            // mantenimientoToolStripMenuItem1
            // 
            this.mantenimientoToolStripMenuItem1.Name = "mantenimientoToolStripMenuItem1";
            this.mantenimientoToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.mantenimientoToolStripMenuItem1.Text = "Mantenimiento";
            this.mantenimientoToolStripMenuItem1.Click += new System.EventHandler(this.mantenimientoToolStripMenuItem1_Click);
            // 
            // asignaciónDePapelesToolStripMenuItem
            // 
            this.asignaciónDePapelesToolStripMenuItem.Name = "asignaciónDePapelesToolStripMenuItem";
            this.asignaciónDePapelesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.asignaciónDePapelesToolStripMenuItem.Text = "Asignación de papeles";
            this.asignaciónDePapelesToolStripMenuItem.Click += new System.EventHandler(this.asignaciónDePapelesToolStripMenuItem_Click);
            // 
            // FormInici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 168);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormInici";
            this.Text = "Cinefilo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datosGeneralesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDePapelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem películasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem asignaciónDePapelesToolStripMenuItem;
    }
}

