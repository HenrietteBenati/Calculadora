using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class CALCULADORA : Form
    {
        public CALCULADORA()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero01.Clear();
            txtNumero02.Clear();
            txtResultado.Clear();

            AcceptButton = btnCalcular;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;

            num1 = int.Parse(txtNumero01.Text);
            num2 = int.Parse(txtNumero01.Text);

            if (rdbSomar.Checked)
            {
                resultado = num1 + num2;
            }

            else if (rdbSubtracao.Checked)
            {
                resultado = num1 - num2;
            }

            else if (rdbMultiplicacao.Checked)
            {
                resultado = num1 * num2;
            }
            else
            {
                resultado = num1 / num2;
            }

            AcceptButton = btnLimpar;
            txtResultado.Text = resultado.ToString();
        }

        private void CALCULADORA_Load(object sender, EventArgs e)
        {

        }
    }
}
