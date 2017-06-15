using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculadoraClasses;

namespace FormProjetoCalculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            try
            {
                Calculadora c = new Calculadora();
                double Resultado;

                Resultado = c.Somar(Convert.ToDouble(txtValor1.Text), Convert.ToDouble(txtValor2.Text));

                lblOperacao.Text = "+";
                lblResultado.Text = Convert.ToString(Resultado);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            try
            { 
                Calculadora c = new Calculadora();
                double Resultado;

                Resultado = c.Subtrair(Convert.ToDouble(txtValor1.Text), Convert.ToDouble(txtValor2.Text));

                lblOperacao.Text = "-";
                lblResultado.Text = Convert.ToString(Resultado);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                Calculadora c = new Calculadora();
                double Resultado;

                Resultado = c.Dividir(Convert.ToDouble(txtValor1.Text), Convert.ToDouble(txtValor2.Text));

                lblOperacao.Text = "/";
                lblResultado.Text = Convert.ToString(Resultado);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                Calculadora c = new Calculadora();
                double Resultado;

                Resultado = c.Multiplicar(Convert.ToDouble(txtValor1.Text), Convert.ToDouble(txtValor2.Text));

                lblOperacao.Text = "*";
                lblResultado.Text = Convert.ToString(Resultado);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnMaior_Click(object sender, EventArgs e)
        {

        }

        private void btnMenor_Click(object sender, EventArgs e)
        {

        }
    }
}
