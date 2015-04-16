namespace Cinefilo_1.Formularios
{
    partial class FormActor
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
            this.groupBoxDades = new System.Windows.Forms.GroupBox();
            this.labelSexo = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAcceptar = new System.Windows.Forms.Button();
            this.groupBoxDades.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDades
            // 
            this.groupBoxDades.Controls.Add(this.labelSexo);
            this.groupBoxDades.Controls.Add(this.labelEdad);
            this.groupBoxDades.Controls.Add(this.labelNombre);
            this.groupBoxDades.Controls.Add(this.labelDNI);
            this.groupBoxDades.Controls.Add(this.comboBoxSexo);
            this.groupBoxDades.Controls.Add(this.textBoxEdad);
            this.groupBoxDades.Controls.Add(this.textBoxNombre);
            this.groupBoxDades.Controls.Add(this.textBoxDNI);
            this.groupBoxDades.Location = new System.Drawing.Point(11, 10);
            this.groupBoxDades.Name = "groupBoxDades";
            this.groupBoxDades.Size = new System.Drawing.Size(420, 165);
            this.groupBoxDades.TabIndex = 13;
            this.groupBoxDades.TabStop = false;
            this.groupBoxDades.Text = "Dades";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.BackColor = System.Drawing.Color.Transparent;
            this.labelSexo.ForeColor = System.Drawing.Color.Black;
            this.labelSexo.Location = new System.Drawing.Point(18, 114);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(31, 13);
            this.labelSexo.TabIndex = 7;
            this.labelSexo.Text = "Sexo";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.BackColor = System.Drawing.Color.Transparent;
            this.labelEdad.ForeColor = System.Drawing.Color.Black;
            this.labelEdad.Location = new System.Drawing.Point(18, 88);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(32, 13);
            this.labelEdad.TabIndex = 6;
            this.labelEdad.Text = "Edad";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.ForeColor = System.Drawing.Color.Black;
            this.labelNombre.Location = new System.Drawing.Point(18, 65);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 5;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.BackColor = System.Drawing.Color.Transparent;
            this.labelDNI.ForeColor = System.Drawing.Color.Black;
            this.labelDNI.Location = new System.Drawing.Point(18, 39);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(26, 13);
            this.labelDNI.TabIndex = 4;
            this.labelDNI.Text = "DNI";
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Items.AddRange(new object[] {
            "Hombre\t",
            "Mujer"});
            this.comboBoxSexo.Location = new System.Drawing.Point(85, 114);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(283, 21);
            this.comboBoxSexo.TabIndex = 3;
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Location = new System.Drawing.Point(85, 88);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(283, 20);
            this.textBoxEdad.TabIndex = 2;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(85, 62);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(283, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(85, 36);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(283, 20);
            this.textBoxDNI.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackgroundImage = global::Cinefilo_1.Properties.Resources.delete_32;
            this.buttonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCancel.Location = new System.Drawing.Point(356, 187);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(50, 48);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAcceptar
            // 
            this.buttonAcceptar.BackgroundImage = global::Cinefilo_1.Properties.Resources.accept_64;
            this.buttonAcceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAcceptar.Location = new System.Drawing.Point(288, 187);
            this.buttonAcceptar.Name = "buttonAcceptar";
            this.buttonAcceptar.Size = new System.Drawing.Size(50, 48);
            this.buttonAcceptar.TabIndex = 14;
            this.buttonAcceptar.UseVisualStyleBackColor = true;
            this.buttonAcceptar.Click += new System.EventHandler(this.buttonAcceptar_Click);
            // 
            // FormActor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 254);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAcceptar);
            this.Controls.Add(this.groupBoxDades);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "FormActor";
            this.Text = "Actor";
            this.groupBoxDades.ResumeLayout(false);
            this.groupBoxDades.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAcceptar;
        private System.Windows.Forms.GroupBox groupBoxDades;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.ComboBox comboBoxSexo;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDNI;
    }
}