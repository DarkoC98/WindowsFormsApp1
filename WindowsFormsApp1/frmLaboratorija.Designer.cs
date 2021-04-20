
namespace WindowsFormsApp1
{
    partial class frmLaboratorija
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
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnStampaj = new System.Windows.Forms.Button();
            this.btnSkeniraj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCenaAnaliza = new System.Windows.Forms.TextBox();
            this.cmbPrioritet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBrojAnaliza = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spisak svih analiza";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(34, 82);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(679, 244);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(34, 335);
            this.btnUnos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(84, 29);
            this.btnUnos.TabIndex = 2;
            this.btnUnos.Text = "Unos nove";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnStampaj
            // 
            this.btnStampaj.Location = new System.Drawing.Point(331, 335);
            this.btnStampaj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStampaj.Name = "btnStampaj";
            this.btnStampaj.Size = new System.Drawing.Size(84, 29);
            this.btnStampaj.TabIndex = 3;
            this.btnStampaj.Text = "Stampaj";
            this.btnStampaj.UseVisualStyleBackColor = true;
            this.btnStampaj.Click += new System.EventHandler(this.btnStampaj_Click);
            // 
            // btnSkeniraj
            // 
            this.btnSkeniraj.Location = new System.Drawing.Point(629, 335);
            this.btnSkeniraj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSkeniraj.Name = "btnSkeniraj";
            this.btnSkeniraj.Size = new System.Drawing.Size(84, 29);
            this.btnSkeniraj.TabIndex = 4;
            this.btnSkeniraj.Text = "Skeniraj";
            this.btnSkeniraj.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ukupna cena svih analiza";
            // 
            // tbCenaAnaliza
            // 
            this.tbCenaAnaliza.Enabled = false;
            this.tbCenaAnaliza.Location = new System.Drawing.Point(252, 434);
            this.tbCenaAnaliza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCenaAnaliza.Name = "tbCenaAnaliza";
            this.tbCenaAnaliza.ReadOnly = true;
            this.tbCenaAnaliza.Size = new System.Drawing.Size(112, 26);
            this.tbCenaAnaliza.TabIndex = 6;
            // 
            // cmbPrioritet
            // 
            this.cmbPrioritet.FormattingEnabled = true;
            this.cmbPrioritet.Location = new System.Drawing.Point(201, 496);
            this.cmbPrioritet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPrioritet.Name = "cmbPrioritet";
            this.cmbPrioritet.Size = new System.Drawing.Size(136, 28);
            this.cmbPrioritet.TabIndex = 7;
            this.cmbPrioritet.SelectedIndexChanged += new System.EventHandler(this.cmbPrioritet_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prioritet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 505);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Broj analiza";
            // 
            // tbBrojAnaliza
            // 
            this.tbBrojAnaliza.Enabled = false;
            this.tbBrojAnaliza.Location = new System.Drawing.Point(530, 501);
            this.tbBrojAnaliza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbBrojAnaliza.Name = "tbBrojAnaliza";
            this.tbBrojAnaliza.ReadOnly = true;
            this.tbBrojAnaliza.Size = new System.Drawing.Size(112, 26);
            this.tbBrojAnaliza.TabIndex = 10;
            // 
            // frmLaboratorija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 562);
            this.Controls.Add(this.tbBrojAnaliza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPrioritet);
            this.Controls.Add(this.tbCenaAnaliza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSkeniraj);
            this.Controls.Add(this.btnStampaj);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLaboratorija";
            this.Text = "frmLaboratorija";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLaboratorija_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnStampaj;
        private System.Windows.Forms.Button btnSkeniraj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCenaAnaliza;
        private System.Windows.Forms.ComboBox cmbPrioritet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBrojAnaliza;
    }
}