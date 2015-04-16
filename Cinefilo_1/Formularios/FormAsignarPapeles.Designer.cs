namespace Cinefilo_1.Formularios
{
    partial class FormAsignarPapeles
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAsignarPapeles));
            this.groupBoxActor = new System.Windows.Forms.GroupBox();
            this.groupBoxActorActores = new System.Windows.Forms.GroupBox();
            this.listBoxActores = new System.Windows.Forms.ListBox();
            this.aCTORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxCriteriosDeBuqueda = new System.Windows.Forms.GroupBox();
            this.buttonBuscarActor = new System.Windows.Forms.Button();
            this.textBoxNombreActor = new System.Windows.Forms.TextBox();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.labelcSexo = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.groupBoxPelicula = new System.Windows.Forms.GroupBox();
            this.buttonBuscarPapeles = new System.Windows.Forms.Button();
            this.groupBoxPeliculas = new System.Windows.Forms.GroupBox();
            this.listBoxPeliculas = new System.Windows.Forms.ListBox();
            this.bindingSourcePeliculas = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonBuscarPelicula = new System.Windows.Forms.Button();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.labelDirector = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBoxPapeles = new System.Windows.Forms.GroupBox();
            this.buttonCancelarAsignacion = new System.Windows.Forms.Button();
            this.buttonAsignarPapeles = new System.Windows.Forms.Button();
            this.listBoxPapeles = new System.Windows.Forms.ListBox();
            this.groupBoxActor.SuspendLayout();
            this.groupBoxActorActores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aCTORESBindingSource)).BeginInit();
            this.groupBoxCriteriosDeBuqueda.SuspendLayout();
            this.groupBoxPelicula.SuspendLayout();
            this.groupBoxPeliculas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePeliculas)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBoxPapeles.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxActor
            // 
            this.groupBoxActor.Controls.Add(this.groupBoxActorActores);
            this.groupBoxActor.Controls.Add(this.groupBoxCriteriosDeBuqueda);
            this.groupBoxActor.Location = new System.Drawing.Point(12, 30);
            this.groupBoxActor.Name = "groupBoxActor";
            this.groupBoxActor.Size = new System.Drawing.Size(424, 402);
            this.groupBoxActor.TabIndex = 0;
            this.groupBoxActor.TabStop = false;
            this.groupBoxActor.Text = "Actor";
            // 
            // groupBoxActorActores
            // 
            this.groupBoxActorActores.Controls.Add(this.listBoxActores);
            this.groupBoxActorActores.Location = new System.Drawing.Point(12, 162);
            this.groupBoxActorActores.Name = "groupBoxActorActores";
            this.groupBoxActorActores.Size = new System.Drawing.Size(400, 220);
            this.groupBoxActorActores.TabIndex = 1;
            this.groupBoxActorActores.TabStop = false;
            this.groupBoxActorActores.Text = "Actores";
            // 
            // listBoxActores
            // 
            this.listBoxActores.DataSource = this.aCTORESBindingSource;
            this.listBoxActores.FormattingEnabled = true;
            this.listBoxActores.Location = new System.Drawing.Point(16, 26);
            this.listBoxActores.Name = "listBoxActores";
            this.listBoxActores.Size = new System.Drawing.Size(362, 186);
            this.listBoxActores.TabIndex = 4;
            // 
            // aCTORESBindingSource
            // 
            this.aCTORESBindingSource.DataSource = typeof(Cinefilo_1.BD.ACTORES);
            // 
            // groupBoxCriteriosDeBuqueda
            // 
            this.groupBoxCriteriosDeBuqueda.Controls.Add(this.buttonBuscarActor);
            this.groupBoxCriteriosDeBuqueda.Controls.Add(this.textBoxNombreActor);
            this.groupBoxCriteriosDeBuqueda.Controls.Add(this.comboBoxSexo);
            this.groupBoxCriteriosDeBuqueda.Controls.Add(this.labelcSexo);
            this.groupBoxCriteriosDeBuqueda.Controls.Add(this.labelNombre);
            this.groupBoxCriteriosDeBuqueda.Location = new System.Drawing.Point(12, 27);
            this.groupBoxCriteriosDeBuqueda.Name = "groupBoxCriteriosDeBuqueda";
            this.groupBoxCriteriosDeBuqueda.Size = new System.Drawing.Size(400, 129);
            this.groupBoxCriteriosDeBuqueda.TabIndex = 1;
            this.groupBoxCriteriosDeBuqueda.TabStop = false;
            this.groupBoxCriteriosDeBuqueda.Text = "Criterios de búsqueda";
            // 
            // buttonBuscarActor
            // 
            this.buttonBuscarActor.Location = new System.Drawing.Point(287, 92);
            this.buttonBuscarActor.Name = "buttonBuscarActor";
            this.buttonBuscarActor.Size = new System.Drawing.Size(91, 23);
            this.buttonBuscarActor.TabIndex = 9;
            this.buttonBuscarActor.Text = "Buscar Actor";
            this.buttonBuscarActor.UseVisualStyleBackColor = true;
            this.buttonBuscarActor.Click += new System.EventHandler(this.buttonBuscarActor_Click);
            // 
            // textBoxNombreActor
            // 
            this.textBoxNombreActor.Location = new System.Drawing.Point(97, 57);
            this.textBoxNombreActor.Name = "textBoxNombreActor";
            this.textBoxNombreActor.Size = new System.Drawing.Size(281, 20);
            this.textBoxNombreActor.TabIndex = 3;
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.comboBoxSexo.Location = new System.Drawing.Point(97, 26);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(197, 21);
            this.comboBoxSexo.TabIndex = 2;
            // 
            // labelcSexo
            // 
            this.labelcSexo.AutoSize = true;
            this.labelcSexo.Location = new System.Drawing.Point(42, 29);
            this.labelcSexo.Name = "labelcSexo";
            this.labelcSexo.Size = new System.Drawing.Size(31, 13);
            this.labelcSexo.TabIndex = 1;
            this.labelcSexo.Text = "Sexo";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(42, 60);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // groupBoxPelicula
            // 
            this.groupBoxPelicula.Controls.Add(this.buttonBuscarPapeles);
            this.groupBoxPelicula.Controls.Add(this.groupBoxPeliculas);
            this.groupBoxPelicula.Controls.Add(this.groupBox3);
            this.groupBoxPelicula.Location = new System.Drawing.Point(442, 30);
            this.groupBoxPelicula.Name = "groupBoxPelicula";
            this.groupBoxPelicula.Size = new System.Drawing.Size(424, 402);
            this.groupBoxPelicula.TabIndex = 1;
            this.groupBoxPelicula.TabStop = false;
            this.groupBoxPelicula.Text = "Pelicula";
            // 
            // buttonBuscarPapeles
            // 
            this.buttonBuscarPapeles.Location = new System.Drawing.Point(12, 359);
            this.buttonBuscarPapeles.Name = "buttonBuscarPapeles";
            this.buttonBuscarPapeles.Size = new System.Drawing.Size(396, 23);
            this.buttonBuscarPapeles.TabIndex = 9;
            this.buttonBuscarPapeles.Text = "Buscar papeles";
            this.buttonBuscarPapeles.UseVisualStyleBackColor = true;
            this.buttonBuscarPapeles.Click += new System.EventHandler(this.buttonBuscarPapeles_Click);
            // 
            // groupBoxPeliculas
            // 
            this.groupBoxPeliculas.Controls.Add(this.listBoxPeliculas);
            this.groupBoxPeliculas.Location = new System.Drawing.Point(12, 162);
            this.groupBoxPeliculas.Name = "groupBoxPeliculas";
            this.groupBoxPeliculas.Size = new System.Drawing.Size(400, 173);
            this.groupBoxPeliculas.TabIndex = 1;
            this.groupBoxPeliculas.TabStop = false;
            this.groupBoxPeliculas.Text = "Películas";
            // 
            // listBoxPeliculas
            // 
            this.listBoxPeliculas.DataSource = this.bindingSourcePeliculas;
            this.listBoxPeliculas.FormattingEnabled = true;
            this.listBoxPeliculas.Location = new System.Drawing.Point(14, 16);
            this.listBoxPeliculas.Name = "listBoxPeliculas";
            this.listBoxPeliculas.Size = new System.Drawing.Size(375, 147);
            this.listBoxPeliculas.TabIndex = 5;
            // 
            // bindingSourcePeliculas
            // 
            this.bindingSourcePeliculas.DataSource = typeof(Cinefilo_1.BD.PELICULAS);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonBuscarPelicula);
            this.groupBox3.Controls.Add(this.textBoxDirector);
            this.groupBox3.Controls.Add(this.labelDirector);
            this.groupBox3.Controls.Add(this.textBoxTitulo);
            this.groupBox3.Controls.Add(this.labelTitulo);
            this.groupBox3.Location = new System.Drawing.Point(12, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 129);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Criterios de búsqueda";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // buttonBuscarPelicula
            // 
            this.buttonBuscarPelicula.Location = new System.Drawing.Point(288, 92);
            this.buttonBuscarPelicula.Name = "buttonBuscarPelicula";
            this.buttonBuscarPelicula.Size = new System.Drawing.Size(91, 23);
            this.buttonBuscarPelicula.TabIndex = 8;
            this.buttonBuscarPelicula.Text = "Buscar película";
            this.buttonBuscarPelicula.UseVisualStyleBackColor = true;
            this.buttonBuscarPelicula.Click += new System.EventHandler(this.buttonBuscarPelicula_Click);
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Location = new System.Drawing.Point(82, 55);
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(297, 20);
            this.textBoxDirector.TabIndex = 7;
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Location = new System.Drawing.Point(28, 58);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(44, 13);
            this.labelDirector.TabIndex = 6;
            this.labelDirector.Text = "Director";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(82, 29);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(297, 20);
            this.textBoxTitulo.TabIndex = 5;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(27, 32);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(33, 13);
            this.labelTitulo.TabIndex = 4;
            this.labelTitulo.Text = "Titulo";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(878, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // groupBoxPapeles
            // 
            this.groupBoxPapeles.Controls.Add(this.buttonCancelarAsignacion);
            this.groupBoxPapeles.Controls.Add(this.buttonAsignarPapeles);
            this.groupBoxPapeles.Controls.Add(this.listBoxPapeles);
            this.groupBoxPapeles.Location = new System.Drawing.Point(12, 438);
            this.groupBoxPapeles.Name = "groupBoxPapeles";
            this.groupBoxPapeles.Size = new System.Drawing.Size(855, 115);
            this.groupBoxPapeles.TabIndex = 4;
            this.groupBoxPapeles.TabStop = false;
            this.groupBoxPapeles.Text = "Papeles";
            // 
            // buttonCancelarAsignacion
            // 
            this.buttonCancelarAsignacion.Location = new System.Drawing.Point(448, 59);
            this.buttonCancelarAsignacion.Name = "buttonCancelarAsignacion";
            this.buttonCancelarAsignacion.Size = new System.Drawing.Size(396, 23);
            this.buttonCancelarAsignacion.TabIndex = 11;
            this.buttonCancelarAsignacion.Text = "Cancelar asignación";
            this.buttonCancelarAsignacion.UseVisualStyleBackColor = true;
            this.buttonCancelarAsignacion.Click += new System.EventHandler(this.buttonCancelarAsignacion_Click);
            // 
            // buttonAsignarPapeles
            // 
            this.buttonAsignarPapeles.Location = new System.Drawing.Point(448, 30);
            this.buttonAsignarPapeles.Name = "buttonAsignarPapeles";
            this.buttonAsignarPapeles.Size = new System.Drawing.Size(396, 23);
            this.buttonAsignarPapeles.TabIndex = 10;
            this.buttonAsignarPapeles.Text = "Asignar papeles";
            this.buttonAsignarPapeles.UseVisualStyleBackColor = true;
            this.buttonAsignarPapeles.Click += new System.EventHandler(this.buttonAsignarPapeles_Click);
            // 
            // listBoxPapeles
            // 
            this.listBoxPapeles.FormattingEnabled = true;
            this.listBoxPapeles.Location = new System.Drawing.Point(12, 19);
            this.listBoxPapeles.Name = "listBoxPapeles";
            this.listBoxPapeles.Size = new System.Drawing.Size(418, 82);
            this.listBoxPapeles.TabIndex = 5;
            // 
            // FormAsignarPapeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 439);
            this.Controls.Add(this.groupBoxPapeles);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBoxPelicula);
            this.Controls.Add(this.groupBoxActor);
            this.Name = "FormAsignarPapeles";
            this.Text = "Asignar papeles";
            this.Load += new System.EventHandler(this.FormAsignarPapeles_Load);
            this.groupBoxActor.ResumeLayout(false);
            this.groupBoxActorActores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aCTORESBindingSource)).EndInit();
            this.groupBoxCriteriosDeBuqueda.ResumeLayout(false);
            this.groupBoxCriteriosDeBuqueda.PerformLayout();
            this.groupBoxPelicula.ResumeLayout(false);
            this.groupBoxPeliculas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePeliculas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBoxPapeles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxActor;
        private System.Windows.Forms.GroupBox groupBoxCriteriosDeBuqueda;
        private System.Windows.Forms.GroupBox groupBoxActorActores;
        private System.Windows.Forms.GroupBox groupBoxPelicula;
        private System.Windows.Forms.GroupBox groupBoxPeliculas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ListBox listBoxActores;
        private System.Windows.Forms.TextBox textBoxNombreActor;
        private System.Windows.Forms.ComboBox comboBoxSexo;
        private System.Windows.Forms.Label labelcSexo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.GroupBox groupBoxPapeles;
        private System.Windows.Forms.ListBox listBoxPapeles;
        private System.Windows.Forms.Button buttonBuscarActor;
        private System.Windows.Forms.Button buttonBuscarPapeles;
        private System.Windows.Forms.ListBox listBoxPeliculas;
        private System.Windows.Forms.Button buttonBuscarPelicula;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonCancelarAsignacion;
        private System.Windows.Forms.Button buttonAsignarPapeles;
        private System.Windows.Forms.BindingSource aCTORESBindingSource;
        private System.Windows.Forms.BindingSource bindingSourcePeliculas;
    }
}