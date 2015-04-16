using Cinefilo_1.BD;

namespace Cinefilo_1
{
    partial class FormTiposPapel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTiposPapel));
            this.toolStripFormTiposPapel = new System.Windows.Forms.ToolStrip();
            this.nuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.busquedaButton = new System.Windows.Forms.ToolStripButton();
            this.SaveChangesButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.groupBoxCriteriosDeBusqueda = new System.Windows.Forms.GroupBox();
            this.textBoxBusquedaTipo = new System.Windows.Forms.TextBox();
            this.labelTipo = new System.Windows.Forms.Label();
            this.groupBoxTiposDePapel = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceTiposPapel = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripFormTiposPapel.SuspendLayout();
            this.groupBoxCriteriosDeBusqueda.SuspendLayout();
            this.groupBoxTiposDePapel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTiposPapel)).BeginInit();
            this.SuspendLayout();
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
            this.toolStripFormTiposPapel.Size = new System.Drawing.Size(505, 25);
            this.toolStripFormTiposPapel.TabIndex = 0;
            this.toolStripFormTiposPapel.Text = "toolStrip1";
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
            this.busquedaButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveChangesButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveChangesButton.Image")));
            this.SaveChangesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(23, 22);
            this.SaveChangesButton.Text = "toolStripButton2";
            this.SaveChangesButton.Click += new System.EventHandler(this.toolStripButton2_Click);
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
            // groupBoxCriteriosDeBusqueda
            // 
            this.groupBoxCriteriosDeBusqueda.Controls.Add(this.textBoxBusquedaTipo);
            this.groupBoxCriteriosDeBusqueda.Controls.Add(this.labelTipo);
            this.groupBoxCriteriosDeBusqueda.Location = new System.Drawing.Point(12, 28);
            this.groupBoxCriteriosDeBusqueda.Name = "groupBoxCriteriosDeBusqueda";
            this.groupBoxCriteriosDeBusqueda.Size = new System.Drawing.Size(480, 100);
            this.groupBoxCriteriosDeBusqueda.TabIndex = 1;
            this.groupBoxCriteriosDeBusqueda.TabStop = false;
            this.groupBoxCriteriosDeBusqueda.Text = "Criterios de búsqueda";
            // 
            // textBoxBusquedaTipo
            // 
            this.textBoxBusquedaTipo.Location = new System.Drawing.Point(64, 39);
            this.textBoxBusquedaTipo.Name = "textBoxBusquedaTipo";
            this.textBoxBusquedaTipo.Size = new System.Drawing.Size(380, 20);
            this.textBoxBusquedaTipo.TabIndex = 1;
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(23, 42);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(28, 13);
            this.labelTipo.TabIndex = 0;
            this.labelTipo.Text = "Tipo";
            // 
            // groupBoxTiposDePapel
            // 
            this.groupBoxTiposDePapel.Controls.Add(this.dataGridView1);
            this.groupBoxTiposDePapel.Location = new System.Drawing.Point(12, 134);
            this.groupBoxTiposDePapel.Name = "groupBoxTiposDePapel";
            this.groupBoxTiposDePapel.Size = new System.Drawing.Size(480, 279);
            this.groupBoxTiposDePapel.TabIndex = 2;
            this.groupBoxTiposDePapel.TabStop = false;
            this.groupBoxTiposDePapel.Text = " Tipos de papel";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourceTiposPapel;
            this.dataGridView1.Location = new System.Drawing.Point(16, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 253);
            this.dataGridView1.TabIndex = 0;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 350;
            // 
            // bindingSourceTiposPapel
            // 
            this.bindingSourceTiposPapel.DataSource = typeof(Cinefilo_1.BD.TIPOS_PAPEL);
            // 
            // FormTiposPapel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 425);
            this.Controls.Add(this.groupBoxTiposDePapel);
            this.Controls.Add(this.groupBoxCriteriosDeBusqueda);
            this.Controls.Add(this.toolStripFormTiposPapel);
            this.Name = "FormTiposPapel";
            this.Text = "Tipos de papel";
            this.Activated += new System.EventHandler(this.FormTiposPapel_Activated);
            this.Load += new System.EventHandler(this.FormTiposPapel_Load);
            this.toolStripFormTiposPapel.ResumeLayout(false);
            this.toolStripFormTiposPapel.PerformLayout();
            this.groupBoxCriteriosDeBusqueda.ResumeLayout(false);
            this.groupBoxCriteriosDeBusqueda.PerformLayout();
            this.groupBoxTiposDePapel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTiposPapel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripFormTiposPapel;
        private System.Windows.Forms.ToolStripButton nuevoToolStripButton;
        private System.Windows.Forms.ToolStripButton busquedaButton;
        private System.Windows.Forms.ToolStripButton SaveChangesButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.GroupBox groupBoxCriteriosDeBusqueda;
        private System.Windows.Forms.TextBox textBoxBusquedaTipo;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.GroupBox groupBoxTiposDePapel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSourceTiposPapel;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
    }
}