//using Cinefilo_1.BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinefilo_1
{
    partial class FormPelicula
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
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAcceptar = new System.Windows.Forms.Button();
            this.groupBoxTemas = new System.Windows.Forms.GroupBox();
            this.listBoxTemas = new System.Windows.Forms.ListBox();
            this.tEMASBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.labelPelicula = new System.Windows.Forms.Label();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.groupBoxDatos.SuspendLayout();
            this.groupBoxTemas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tEMASBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.buttonCancel);
            this.groupBoxDatos.Controls.Add(this.buttonAcceptar);
            this.groupBoxDatos.Controls.Add(this.groupBoxTemas);
            this.groupBoxDatos.Controls.Add(this.labelPelicula);
            this.groupBoxDatos.Controls.Add(this.textBoxDirector);
            this.groupBoxDatos.Controls.Add(this.labelTitulo);
            this.groupBoxDatos.Controls.Add(this.textBoxTitulo);
            this.groupBoxDatos.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(500, 294);
            this.groupBoxDatos.TabIndex = 0;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackgroundImage = global::Cinefilo_1.Properties.Resources.delete_32;
            this.buttonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCancel.Location = new System.Drawing.Point(437, 235);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(50, 48);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAcceptar
            // 
            this.buttonAcceptar.BackgroundImage = global::Cinefilo_1.Properties.Resources.accept_64;
            this.buttonAcceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAcceptar.Location = new System.Drawing.Point(369, 235);
            this.buttonAcceptar.Name = "buttonAcceptar";
            this.buttonAcceptar.Size = new System.Drawing.Size(50, 48);
            this.buttonAcceptar.TabIndex = 9;
            this.buttonAcceptar.UseVisualStyleBackColor = true;
            this.buttonAcceptar.Click += new System.EventHandler(this.buttonAcceptar_Click);
            // 
            // groupBoxTemas
            // 
            this.groupBoxTemas.Controls.Add(this.listBoxTemas);
            this.groupBoxTemas.Location = new System.Drawing.Point(26, 94);
            this.groupBoxTemas.Name = "groupBoxTemas";
            this.groupBoxTemas.Size = new System.Drawing.Size(460, 126);
            this.groupBoxTemas.TabIndex = 8;
            this.groupBoxTemas.TabStop = false;
            this.groupBoxTemas.Text = "Temas";
            // 
            // listBoxTemas
            // 
            this.listBoxTemas.DataSource = this.tEMASBindingSource1;
            this.listBoxTemas.DisplayMember = "descripcion";
            this.listBoxTemas.FormattingEnabled = true;
            this.listBoxTemas.Location = new System.Drawing.Point(11, 19);
            this.listBoxTemas.Name = "listBoxTemas";
            this.listBoxTemas.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxTemas.Size = new System.Drawing.Size(439, 95);
            this.listBoxTemas.TabIndex = 0;
            this.listBoxTemas.ValueMember = "descripcion";
            this.listBoxTemas.SelectedIndexChanged += new System.EventHandler(this.listBoxTemas_SelectedIndexChanged);
            // 
            // tEMASBindingSource1
            // 
            this.tEMASBindingSource1.DataSource = typeof(Cinefilo_1.BD.TEMAS);
            // 
            // labelPelicula
            // 
            this.labelPelicula.AutoSize = true;
            this.labelPelicula.Location = new System.Drawing.Point(23, 60);
            this.labelPelicula.Name = "labelPelicula";
            this.labelPelicula.Size = new System.Drawing.Size(47, 13);
            this.labelPelicula.TabIndex = 7;
            this.labelPelicula.Text = "Director:";
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Location = new System.Drawing.Point(74, 57);
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(412, 20);
            this.textBoxDirector.TabIndex = 6;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(23, 27);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(38, 13);
            this.labelTitulo.TabIndex = 5;
            this.labelTitulo.Text = "Título:";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(74, 24);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(412, 20);
            this.textBoxTitulo.TabIndex = 4;
            // 
            // FormPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 320);
            this.Controls.Add(this.groupBoxDatos);
            this.Name = "FormPelicula";
            this.Text = "Pelicula";
            this.Load += new System.EventHandler(this.FormPelicula_Load);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.groupBoxTemas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tEMASBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.GroupBox groupBoxTemas;
        private System.Windows.Forms.ListBox listBoxTemas;
        private System.Windows.Forms.Label labelPelicula;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAcceptar;
        private System.Windows.Forms.BindingSource tEMASBindingSource1;
    }
}