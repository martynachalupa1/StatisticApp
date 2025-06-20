using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StatisticApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chartWykres_Click(object sender, EventArgs e)
        {

        }

        private void btnOblicz_Click(object sender, EventArgs e)
        {
            string[] liczbynaTekst = txtDane.Text.Split(',');
            List<double> liczby = new List<double>();

            foreach (string tekst in liczbynaTekst)
            {
                liczby.Add(double.Parse(tekst));
            }

            if (liczby.Count == 0)
            {
                MessageBox.Show("Wpisz liczby oddzielone przecinkami, np. 5, 10, 15");
                return;
            }

           
            double suma = 0;
            foreach (double liczba in liczby)
            {
                suma += liczba;
            }
            double srednia = suma / liczby.Count;

            liczby.Sort();
            double mediana;
            if (liczby.Count % 2 == 0) // parzysta ilość
            {
                mediana = (liczby[liczby.Count / 2 - 1] + liczby[liczby.Count / 2]) / 2.0;
            }
            else // nieparzysta ilość
            {
                mediana = liczby[liczby.Count / 2];
            }
            double minimum = liczby[0]; 
            double maksimum = liczby[liczby.Count - 1]; 

           
            lblWyniki.Text = $"Średnia: {srednia:F2}\n" +
                            $"Mediana: {mediana:F2}\n" +
                            $"Minimum: {minimum:F2}\n" +
                            $"Maksimum: {maksimum:F2}";

            chartWykres.Series.Clear();
            Series slupki = new Series("Dane");
            slupki.ChartType = SeriesChartType.Column;

            for (int i = 0; i < liczby.Count; i++)
            {
                slupki.Points.AddXY((i + 1).ToString(), liczby[i]);
            }

            chartWykres.Series.Add(slupki);
            chartWykres.Titles.Clear();
            chartWykres.Titles.Add("Wykres danych");
        }
    }
    
}
