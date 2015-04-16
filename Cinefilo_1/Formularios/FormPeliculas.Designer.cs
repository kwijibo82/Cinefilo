namespace Cinefilo_1
{
    partial class FormPeliculas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPeliculas));
            this.groupBoxPeliculas = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourcePeliculas = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxgroupBoxCriteriosBusquedaPeliculas = new System.Windows.Forms.GroupBox();
            this.labelPelicula = new System.Windows.Forms.Label();
            this.textBoxBusquedaTema = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxBusquedaTitulo = new System.Windows.Forms.TextBox();
            this.toolStripFormPeliculas = new System.Windows.Forms.ToolStrip();
            this.nuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.groupBoxPeliculas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePeliculas)).BeginInit();
            this.groupBoxgroupBoxCriteriosBusquedaPeliculas.SuspendLayout();
            this.toolStripFormPeliculas.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPeliculas
            // 
            this.groupBoxPeliculas.Controls.Add(this.dataGridView1);
            this.groupBoxPeliculas.Location = new System.Drawing.Point(15, 141);
            this.groupBoxPeliculas.Name = "groupBoxPeliculas";
            this.groupBoxPeliculas.Size = new System.Drawing.Size(514, 254);
            this.groupBoxPeliculas.TabIndex = 6;
            this.groupBoxPeliculas.TabStop = false;
            this.groupBoxPeliculas.Text = "Peliculas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pelicula,
            this.tituloDataGridViewTextBoxColumn,
            this.directorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourcePeliculas;
            this.dataGridView1.Location = new System.Drawing.Point(0, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(505, 222);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // id_pelicula
            // 
            this.id_pelicula.DataPropertyName = "id_pelicula";
            this.id_pelicula.HeaderText = "id_pelicula";
            this.id_pelicula.Name = "id_pelicula";
            this.id_pelicula.Visible = false;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            // 
            // directorDataGridViewTextBoxColumn
            // 
            this.directorDataGridViewTextBoxColumn.DataPropertyName = "director";
            this.directorDataGridViewTextBoxColumn.HeaderText = "director";
            this.directorDataGridViewTextBoxColumn.Name = "directorDataGridViewTextBoxColumn";
            // 
            // bindingSourcePeliculas
            // 
            this.bindingSourcePeliculas.DataSource = typeof(Cinefilo_1.BD.PELICULAS);
            // 
            // groupBoxgroupBoxCriteriosBusquedaPeliculas
            // 
            this.groupBoxgroupBoxCriteriosBusquedaPeliculas.Controls.Add(this.labelPelicula);
            this.groupBoxgroupBoxCriteriosBusquedaPeliculas.Controls.Add(this.textBoxBusquedaTema);
            this.groupBoxgroupBoxCriteriosBusquedaPeliculas.Controls.Add(this.labelTitulo);
            this.groupBoxgroupBoxCriteriosBusquedaPeliculas.Controls.Add(this.textBoxBusquedaTitulo);
            this.groupBoxgroupBoxCriteriosBusquedaPeliculas.Location = new System.Drawing.Point(12, 28);
            this.groupBoxgroupBoxCriteriosBusquedaPeliculas.Name = "groupBoxgroupBoxCriteriosBusquedaPeliculas";
            this.groupBoxgroupBoxCriteriosBusquedaPeliculas.Size = new System.Drawing.Size(517, 107);
            this.groupBoxgroupBoxCriteriosBusquedaPeliculas.TabIndex = 5;
            this.groupBoxgroupBoxCriteriosBusquedaPeliculas.TabStop = false;
            this.groupBoxgroupBoxCriteriosBusquedaPeliculas.Text = "Criterios de búsqueda";
            // 
            // labelPelicula
            // 
            this.labelPelicula.AutoSize = true;
            this.labelPelicula.Location = new System.Drawing.Point(22, 68);
            this.labelPelicula.Name = "labelPelicula";
            this.labelPelicula.Size = new System.Drawing.Size(47, 13);
            this.labelPelicula.TabIndex = 3;
            this.labelPelicula.Text = "Director:";
            // 
            // textBoxBusquedaTema
            // 
            this.textBoxBusquedaTema.Location = new System.Drawing.Point(70, 65);
            this.textBoxBusquedaTema.Name = "textBoxBusquedaTema";
            this.textBoxBusquedaTema.Size = new System.Drawing.Size(412, 20);
            this.textBoxBusquedaTema.TabIndex = 2;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(27, 35);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(38, 13);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Título:";
            // 
            // textBoxBusquedaTitulo
            // 
            this.textBoxBusquedaTitulo.Location = new System.Drawing.Point(70, 32);
            this.textBoxBusquedaTitulo.Name = "textBoxBusquedaTitulo";
            this.textBoxBusquedaTitulo.Size = new System.Drawing.Size(412, 20);
            this.textBoxBusquedaTitulo.TabIndex = 0;
            // 
            // toolStripFormPeliculas
            // 
            this.toolStripFormPeliculas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripButton,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripButton3});
            this.toolStripFormPeliculas.Location = new System.Drawing.Point(0, 0);
            this.toolStripFormPeliculas.Name = "toolStripFormPeliculas";
            this.toolStripFormPeliculas.Size = new System.Drawing.Size(535, 25);
            this.toolStripFormPeliculas.TabIndex = 4;
            this.toolStripFormPeliculas.Text = "toolStrip1";
            // 
            // nuevoToolStripButton
            // 
            this.nuevoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nuevoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripButton.Image")));
            this.nuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nuevoToolStripButton.Name = "nuevoToolStripButton";
            this.nuevoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.nuevoToolStripButton.Text = "&Nuevo";
            this.nuevoToolStripButton.Click += new System.EventHandler(this.nuevoToolStripButton_Click);
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
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // FormPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 407);
            this.Controls.Add(this.groupBoxPeliculas);
            this.Controls.Add(this.groupBoxgroupBoxCriteriosBusquedaPeliculas);
            this.Controls.Add(this.toolStripFormPeliculas);
            this.Name = "FormPeliculas";
            this.Text = "Peliculas";
            this.Load += new System.EventHandler(this.FormPeliculas_Load);
            this.groupBoxPeliculas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePeliculas)).EndInit();
            this.groupBoxgroupBoxCriteriosBusquedaPeliculas.ResumeLayout(false);
            this.groupBoxgroupBoxCriteriosBusquedaPeliculas.PerformLayout();
            this.toolStripFormPeliculas.ResumeLayout(false);
            this.toolStripFormPeliculas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPeliculas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxgroupBoxCriteriosBusquedaPeliculas;
        private System.Windows.Forms.Label labelPelicula;
        private System.Windows.Forms.TextBox textBoxBusquedaTema;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textBoxBusquedaTitulo;
        private System.Windows.Forms.ToolStrip toolStripFormPeliculas;
        private System.Windows.Forms.ToolStripButton nuevoToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.BindingSource bindingSourcePeliculas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorDataGridViewTextBoxColumn;

    }
}