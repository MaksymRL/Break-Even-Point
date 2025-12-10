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


    }
}
