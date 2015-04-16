namespace Cinefilo_1
{
    partial class FormActores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormActores));
            this.groupBoxActores = new System.Windows.Forms.GroupBox();
            this.dataGridViewActores = new System.Windows.Forms.DataGridView();
            this.toolStripFormTiposPapel = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBoxCriteriosDeBusqueda = new System.Windows.Forms.GroupBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.nuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.busquedaButton = new System.Windows.Forms.ToolStripButton();
            this.SaveChangesButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAPELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxActores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActores)).BeginInit();
            this.toolStripFormTiposPapel.SuspendLayout();
            this.groupBoxCriteriosDeBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aCTORESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxActores
            // 
            this.groupBoxActores.Controls.Add(this.dataGridViewActores);
            this.groupBoxActores.Location = new System.Drawing.Point(12, 139);
            this.groupBoxActores.Name = "groupBoxActores";
            this.groupBoxActores.Size = new System.Drawing.Size(480, 279);
            this.groupBoxActores.TabIndex = 3;
            this.groupBoxActores.TabStop = false;
            this.groupBoxActores.Text = "Actores";
            // 
            // dataGridViewActores
            // 
            this.dataGridViewActores.AutoGenerateColumns = false;
            this.dataGridViewActores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dniDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.pAPELDataGridViewTextBoxColumn});
            this.dataGridViewActores.DataSource = this.aCTORESBindingSource;
            this.dataGridViewActores.Location = new System.Drawing.Point(16, 19);
            this.dataGridViewActores.Name = "dataGridViewActores";
            this.dataGridViewActores.Size = new System.Drawing.Size(449, 254);
            this.dataGridViewActores.TabIndex = 0;
            this.dataGridViewActores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewActores_CellClick);
            this.dataGridViewActores.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewActores_UserDeletingRow);
            // 
            // toolStripFormTiposPapel
            // 
            this.toolStripFormTiposPapel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripButton,
            this.busquedaButton,
            this.SaveChangesButton,
            this.toolStripSeparator1,
            this.toolStripButton3});
            this.toolStripFormTiposPapel.Location = new System.Drawing.Point(0, 0);
            this.toolStripFormTiposPapel.Name = "toolStripFormTiposPapel";
            this.toolStripFormTiposPapel.Size = new System.Drawing.Size(511, 25);
            this.toolStripFormTiposPapel.TabIndex = 4;
            this.toolStripFormTiposPapel.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // groupBoxCriteriosDeBusqueda
            // 
            this.groupBoxCriteriosDeBusqueda.Controls.Add(this.labelNombre);
            this.groupBoxCriteriosDeBusqueda.Controls.Add(this.labelSexo);
            this.groupBoxCriteriosDeBusqueda.Controls.Add(this.textBoxNombre);
            this.groupBoxCriteriosDeBusqueda.Controls.Add(this.comboBoxSexo);
            this.groupBoxCriteriosDeBusqueda.Location = new System.Drawing.Point(12, 28);
            this.groupBoxCriteriosDeBusqueda.Name = "groupBoxCriteriosDeBusqueda";
            this.groupBoxCriteriosDeBusqueda.Size = new System.Drawing.Size(480, 105);
            this.groupBoxCriteriosDeBusqueda.TabIndex = 5;
            this.groupBoxCriteriosDeBusqueda.TabStop = false;
            this.groupBoxCriteriosDeBusqueda.Text = "Criterios de búsqueda";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(19, 68);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(18, 31);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(31, 13);
            this.labelSexo.TabIndex = 2;
            this.labelSexo.Text = "Sexo";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(71, 65);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(377, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.comboBoxSexo.Location = new System.Drawing.Point(71, 30);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(173, 21);
            this.comboBoxSexo.TabIndex = 0;
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
            // busquedaButton
            // 
            this.busquedaButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.busquedaButton.Image = ((System.Drawing.Image)(resources.GetObject("busquedaButton.Image")));
            this.busquedaButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.busquedaButton.Name = "busquedaButton";
            this.busquedaButton.Size = new System.Drawing.Size(23, 22);
            this.busquedaButton.Text = "toolStripButton1";
            this.busquedaButton.Click += new System.EventHandler(this.busquedaButton_Click);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveChangesButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveChangesButton.Image")));
            this.SaveChangesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(23, 22);
            this.SaveChangesButton.Text = "toolStripButton2";
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
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
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "dni";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            this.dniDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // pAPELDataGridViewTextBoxColumn
            // 
            this.pAPELDataGridViewTextBoxColumn.DataPropertyName = "PAPEL";
            this.pAPELDataGridViewTextBoxColumn.HeaderText = "PAPEL";
            this.pAPELDataGridViewTextBoxColumn.Name = "pAPELDataGridViewTextBoxColumn";
            this.pAPELDataGridViewTextBoxColumn.Visible = false;
            // 
            // aCTORESBindingSource
            // 
            this.aCTORESBindingSource.DataSource = typeof(Cinefilo_1.BD.ACTORES);
            // 
            // FormActores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 434);
            this.Controls.Add(this.groupBoxCriteriosDeBusqueda);
            this.Controls.Add(this.toolStripFormTiposPapel);
            this.Controls.Add(this.groupBoxActores);
            this.Name = "FormActores";
            this.Text = "Actores";
            this.Load += new System.EventHandler(this.FormActores_Load);
            this.groupBoxActores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActores)).EndInit();
            this.toolStripFormTiposPapel.ResumeLayout(false);
            this.toolStripFormTiposPapel.PerformLayout();
            this.groupBoxCriteriosDeBusqueda.ResumeLayout(false);
            this.groupBoxCriteriosDeBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aCTORESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxActores;
        private System.Windows.Forms.DataGridView dataGridViewActores;
        private System.Windows.Forms.ToolStrip toolStripFormTiposPapel;
        private System.Windows.Forms.ToolStripButton nuevoToolStripButton;
        private System.Windows.Forms.ToolStripButton busquedaButton;
        private System.Windows.Forms.ToolStripButton SaveChangesButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.GroupBox groupBoxCriteriosDeBusqueda;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.ComboBox comboBoxSexo;
        private System.Windows.Forms.BindingSource aCTORESBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAPELDataGridViewTextBoxColumn;
    }
}