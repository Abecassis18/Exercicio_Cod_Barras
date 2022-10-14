using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Cod_Barras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private int gerarCodigo(string codigo)
        {
            int codigoControlo;
            int soma, resto;

            codigoControlo = soma = resto = 0;
            //Vamos fazer o calculo da primeira casa 1 e da segunda por 3 sucessivamente ate o 12º valor.

            for(int cont = 0; cont <= 11; cont++)
            {
                if (cont % 2 == 0) soma += int.Parse(codigo[cont].ToString());
                else soma += int.Parse(codigo[cont].ToString()) * 3;

                resto = soma % 10;
                if (resto == 0) codigoControlo = 0;
                else codigoControlo = 10 - resto;
            }

            return codigoControlo;
        }        
        private void button1_Click(object sender, EventArgs e)
        {
            string codigo, digControlo;

            if (mtxtPais.MaskCompleted == true && mtxtEmpresa.MaskCompleted == true && mtxtProduto.MaskCompleted)
            {
                digControlo = mtxtPais.Text + mtxtEmpresa.Text + mtxtProduto.Text;

                codigo = gerarCodigo(digControlo).ToString();

                lblControlo.Text = codigo.ToString();
                lblCodigoBarras.Text = digControlo + codigo.ToString();
            }
            else MessageBox.Show("Digite um codigo.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                     
        }
    }
}