namespace Button
{
    partial class Form1
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
            this.Etichetta = new System.Windows.Forms.Label();
            this.InsNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TipoNumero = new System.Windows.Forms.Label();
            this.Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Etichetta
            // 
            this.Etichetta.AutoSize = true;
            this.Etichetta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Etichetta.Location = new System.Drawing.Point(12, 9);
            this.Etichetta.Name = "Etichetta";
            this.Etichetta.Size = new System.Drawing.Size(106, 15);
            this.Etichetta.TabIndex = 0;
            this.Etichetta.Text = "Inserisci un numero: ";
            this.Etichetta.Click += new System.EventHandler(this.label1_Click);
            // 
            // InsNum
            // 
            this.InsNum.Location = new System.Drawing.Point(122, 6);
            this.InsNum.Name = "InsNum";
            this.InsNum.Size = new System.Drawing.Size(118, 20);
            this.InsNum.TabIndex = 1;
            this.InsNum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Il numero è";
            // 
            // TipoNumero
            // 
            this.TipoNumero.AutoSize = true;
            this.TipoNumero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TipoNumero.Location = new System.Drawing.Point(83, 35);
            this.TipoNumero.Name = "TipoNumero";
            this.TipoNumero.Size = new System.Drawing.Size(2, 15);
            this.TipoNumero.TabIndex = 3;
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(122, 35);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(118, 15);
            this.Button.TabIndex = 4;
            this.Button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 67);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.TipoNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InsNum);
            this.Controls.Add(this.Etichetta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Etichetta;
        private System.Windows.Forms.TextBox InsNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TipoNumero;
        private System.Windows.Forms.Button Button;
    }
}

