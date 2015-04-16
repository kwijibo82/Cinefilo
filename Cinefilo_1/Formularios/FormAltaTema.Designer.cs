namespace Cinefilo_1
{
    partial class FormAltaTema
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
            this.groupBoxFormAltaTipoPapel = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAltaTema = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxFormAltaTipoPapel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFormAltaTipoPapel
            // 
            this.groupBoxFormAltaTipoPapel.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxFormAltaTipoPapel.Controls.Add(this.label1);
            this.groupBoxFormAltaTipoPapel.Controls.Add(this.textBoxAltaTema);
            this.groupBoxFormAltaTipoPapel.Location = new System.Drawing.Point(22, 22);
            this.groupBoxFormAltaTipoPapel.Name = "groupBoxFormAltaTipoPapel";
            this.groupBoxFormAltaTipoPapel.Size = new System.Drawing.Size(497, 90);
            this.groupBoxFormAltaTipoPapel.TabIndex = 5;
            this.groupBoxFormAltaTipoPapel.TabStop = false;
            this.groupBoxFormAltaTipoPapel.Text = "Dades";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tema:";
            // 
            // textBoxAltaTema
            // 
            this.textBoxAltaTema.Location = new System.Drawing.Point(122, 38);
            this.textBoxAltaTema.Name = "textBoxAltaTema";
            this.textBoxAltaTema.Size = new System.Drawing.Size(329, 20);
            this.textBoxAltaTema.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Cinefilo_1.Properties.Resources.delete_32;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(469, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 48);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Cinefilo_1.Properties.Resources.accept_64;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(401, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 48);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAltaTema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 204);
            this.Controls.Add(this.groupBoxFormAltaTipoPapel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormAltaTema";
            this.Text = "Form Alta Tema";
            this.Load += new System.EventHandler(this.FormAltaTema_Load);
            this.groupBoxFormAltaTipoPapel.ResumeLayout(false);
            this.groupBoxFormAltaTipoPapel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFormAltaTipoPapel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAltaTema;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;

    }
}