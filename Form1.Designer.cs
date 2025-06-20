namespace StatisticApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnOblicz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWyniki = new System.Windows.Forms.Label();
            this.txtDane = new System.Windows.Forms.TextBox();
            this.chartWykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartWykres)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOblicz
            // 
            this.btnOblicz.Location = new System.Drawing.Point(668, 187);
            this.btnOblicz.Name = "btnOblicz";
            this.btnOblicz.Size = new System.Drawing.Size(309, 69);
            this.btnOblicz.TabIndex = 0;
            this.btnOblicz.Text = "Zacznijmy statystykę!";
            this.btnOblicz.UseVisualStyleBackColor = true;
            this.btnOblicz.Click += new System.EventHandler(this.btnOblicz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(942, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ten program zwróci statystykę opisową twoich danych (średnia, mediana, max, min) " +
    "oraz wykres ";
            // 
            // lblWyniki
            // 
            this.lblWyniki.AutoSize = true;
            this.lblWyniki.Location = new System.Drawing.Point(179, 520);
            this.lblWyniki.Name = "lblWyniki";
            this.lblWyniki.Size = new System.Drawing.Size(134, 25);
            this.lblWyniki.TabIndex = 2;
            this.lblWyniki.Text = "Twoje wyniki";
            // 
            // txtDane
            // 
            this.txtDane.Location = new System.Drawing.Point(510, 206);
            this.txtDane.Name = "txtDane";
            this.txtDane.Size = new System.Drawing.Size(100, 31);
            this.txtDane.TabIndex = 3;
            // 
            // chartWykres
            // 
            chartArea4.Name = "ChartArea1";
            this.chartWykres.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartWykres.Legends.Add(legend4);
            this.chartWykres.Location = new System.Drawing.Point(410, 311);
            this.chartWykres.Name = "chartWykres";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartWykres.Series.Add(series4);
            this.chartWykres.Size = new System.Drawing.Size(557, 507);
            this.chartWykres.TabIndex = 4;
            this.chartWykres.Text = "chart1";
            this.chartWykres.Click += new System.EventHandler(this.chartWykres_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(501, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wprowadź swoje dane po przecinku np. 1,2,3,4,5,6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2257, 858);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chartWykres);
            this.Controls.Add(this.txtDane);
            this.Controls.Add(this.lblWyniki);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOblicz);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartWykres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOblicz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWyniki;
        private System.Windows.Forms.TextBox txtDane;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWykres;
        private System.Windows.Forms.Label label2;
    }
}

