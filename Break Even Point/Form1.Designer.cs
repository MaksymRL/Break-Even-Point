namespace Break_Even_Point
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.plotGrafico = new ScottPlot.WinForms.FormsPlot();
            this.b_calcola = new System.Windows.Forms.Button();
            this.txtPrezzo = new System.Windows.Forms.TextBox();
            this.txtCostoVariabile = new System.Windows.Forms.TextBox();
            this.txtCostiFissi = new System.Windows.Forms.TextBox();
            this.txtVenditePreviste = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // plotGrafico
            // 
            this.plotGrafico.DisplayScale = 0F;
            this.plotGrafico.Location = new System.Drawing.Point(12, 12);
            this.plotGrafico.Name = "plotGrafico";
            this.plotGrafico.Size = new System.Drawing.Size(776, 426);
            this.plotGrafico.TabIndex = 0;
            // 
            // b_calcola
            // 
            this.b_calcola.Location = new System.Drawing.Point(439, 271);
            this.b_calcola.Name = "b_calcola";
            this.b_calcola.Size = new System.Drawing.Size(100, 62);
            this.b_calcola.TabIndex = 1;
            this.b_calcola.Text = "CALCOLA";
            this.b_calcola.UseVisualStyleBackColor = true;
            this.b_calcola.Click += new System.EventHandler(this.b_calcola_Click);
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(408, 94);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(309, 20);
            this.txtPrezzo.TabIndex = 2;
            // 
            // txtCostoVariabile
            // 
            this.txtCostoVariabile.Location = new System.Drawing.Point(408, 134);
            this.txtCostoVariabile.Name = "txtCostoVariabile";
            this.txtCostoVariabile.Size = new System.Drawing.Size(309, 20);
            this.txtCostoVariabile.TabIndex = 3;
            // 
            // txtCostiFissi
            // 
            this.txtCostiFissi.Location = new System.Drawing.Point(408, 174);
            this.txtCostiFissi.Name = "txtCostiFissi";
            this.txtCostiFissi.Size = new System.Drawing.Size(309, 20);
            this.txtCostiFissi.TabIndex = 4;
            // 
            // txtVenditePreviste
            // 
            this.txtVenditePreviste.Location = new System.Drawing.Point(408, 210);
            this.txtVenditePreviste.Name = "txtVenditePreviste";
            this.txtVenditePreviste.Size = new System.Drawing.Size(309, 20);
            this.txtVenditePreviste.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVenditePreviste);
            this.Controls.Add(this.txtCostiFissi);
            this.Controls.Add(this.txtCostoVariabile);
            this.Controls.Add(this.txtPrezzo);
            this.Controls.Add(this.b_calcola);
            this.Controls.Add(this.plotGrafico);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScottPlot.WinForms.FormsPlot plotGrafico;
        private System.Windows.Forms.Button b_calcola;
        private System.Windows.Forms.TextBox txtPrezzo;
        private System.Windows.Forms.TextBox txtCostoVariabile;
        private System.Windows.Forms.TextBox txtCostiFissi;
        private System.Windows.Forms.TextBox txtVenditePreviste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

