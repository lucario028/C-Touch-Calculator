using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESTRATEGIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void labelNumero7_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = DisplayLabel.Text + "7";
        }

        private void labelNumero8_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = DisplayLabel.Text + "8";
        }

        private void labelNumero9_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = DisplayLabel.Text + "9";
        }

        private void labelNumero4_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = DisplayLabel.Text + "4";
        }

        private void labelNumero5_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = DisplayLabel.Text + "5";
        }

        private void labelNumero6_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = DisplayLabel.Text + "6";
        }

        private void labelNumero1_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = DisplayLabel.Text + "1";
        }

        private void labelNumero2_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = DisplayLabel.Text + "2";
        }

        private void labelNumero3_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = DisplayLabel.Text + "3";
        }

        private void labelPunto_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = "";
        }

        private void labelNumero0_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = DisplayLabel.Text + "0";
        }

        private void label_Igual_Click(object sender, EventArgs e)
        {
            
        }

        private void labelSuma_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = DisplayLabel.Text + "+";
        }

        private void label11_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = DisplayLabel.Text + "-";
        }

        private void labelMultiplicar_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = DisplayLabel.Text + "*";
        }

        private void labelDividir_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = DisplayLabel.Text + "/";
        }
    }
}
