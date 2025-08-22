using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForm
{
    public partial class Form1 : Form
    {
        // Variáveis globais:
        bool operadorClicado = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            
            try
            {
                txbTela.Text = new DataTable().Compute(txbTela.Text, null).ToString();
                if (txbTela.Text == "∞")
                {
                    btnLimpar.PerformClick();
                    MessageBox.Show("OPeração invalida", "ERRO",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              }

            catch 
            {
                btnLimpar.PerformClick();
                MessageBox.Show("impossível dividir por zero", "ERRO",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }
private void numero_Clik(object sender, EventArgs e)
        {
            // Obter o botão que está chamando esse evento:
            Button botaoclicado = (Button)sender;

            // Adicionar o Text do botão clicado no TextBox:
            txbTela.Text += botaoclicado.Text;

            // a"baixar a bandeirinha"
            operadorClicado =false;
        }
        private void operador_Clik(object sender, EventArgs e) 
        {
            // Verificar se o operador ainda não foi clicado:
            if (operadorClicado == false)
            {
                // Obter o botão que está chamando esse evento:
                Button botaoclicado = (Button)sender;

                // Adicionar o Text do botão clicado no TextBox:
                txbTela.Text += botaoclicado.Text;

                // Mudar o operadorClicado pra true (levantar a bandeirinha):
                operadorClicado = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpar a tela:
            txbTela.Text = "";
            // Voltar o operador clicado para true:
            operadorClicado = true;

        }
    }
}
