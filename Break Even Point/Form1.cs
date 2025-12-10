using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Break_Even_Point
{
    public partial class Form1 : Form
    {
        ScottPlot.Plot myPlot = new ScottPlot.Plot();

        public Form1()
        {
            InitializeComponent();

           
            double[] xs = { 1, 2, 3, 4, 5 };
            double[] ys = { 1, 4, 9, 16, 25 };

         
            myPlot.Add.Scatter(xs, ys);

     
            myPlot.SavePng("quickstart.png", 400, 300);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b_calcola_Click(object sender, EventArgs e)
        {
            try
            {
             
                double prezzo = double.Parse(txtPrezzo.Text);
                double costoVariabile = double.Parse(txtCostoVariabile.Text);
                double costiFissi = double.Parse(txtCostiFissi.Text);
                double venditePreviste = double.Parse(txtVenditePreviste.Text);

               
                double mcu = prezzo - costoVariabile;
                double bepUnita = costiFissi / mcu;
                double bepValore = bepUnita * prezzo;
                double risultato = (mcu * venditePreviste) - costiFissi;

               

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore nei dati: {ex.Message}", "Errore",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
