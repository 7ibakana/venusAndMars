﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace venusAndMars
{
    public partial class Form1 : Form
    {
        SortedList<String, Double> WeightConversionFactors = new SortedList<string, double>();
        public Form1()
        {
            InitializeComponent();

            //Initialize the SortedList
            WeightConversionFactors.Add("Mercury", 0.3772);
            WeightConversionFactors.Add("Venus", 0.9042);
            WeightConversionFactors.Add("Mars", 0.3783);
        }

        private void button1_Click(object sender, EventArgs e)
        {//converts  the earthweight entered to a double number and then multiplies by each planet weight conversion to get result on each planet
            double earthWeight = Convert.ToDouble(txtEarthWeight.Text);
            double mercuryWeight = earthWeight * WeightConversionFactors["Mercury"];
            txtMercuryWeight.Text = mercuryWeight.ToString();
            //TODO - can you finish Venus and Mars?
            double venusWeight = earthWeight * WeightConversionFactors["Venus"];
            txtVenusWeight.Text = venusWeight.ToString();
            double marsWeight = earthWeight * WeightConversionFactors["Mars"];
            txtMarsWeight.Text = marsWeight.ToString();

        }
    }
}
