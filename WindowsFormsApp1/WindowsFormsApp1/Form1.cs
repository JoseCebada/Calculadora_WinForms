using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int a = 0;
        int b = 0;
        int resultado = 0;
        string mostrar;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            richPantalla.Text += "0";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            richPantalla.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            richPantalla.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            richPantalla.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            richPantalla.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            richPantalla.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            richPantalla.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            richPantalla.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            richPantalla.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            richPantalla.Text += "9";
        }

        private void BtnPunto_Click(object sender, EventArgs e)
        {
            richPantalla.Text += ".";
        }

        private void BtnPorciento_Click(object sender, EventArgs e)
        {

        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {

        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {

        }

        private void BtnResta_Click(object sender, EventArgs e)
        {

        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {

        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(richPantalla.Text);
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            richPantalla.Text = "";
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {

        }
    }
}
