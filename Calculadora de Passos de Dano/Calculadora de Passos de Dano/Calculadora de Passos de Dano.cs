using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_Passos_de_Dano
{
    public partial class Calculadora_de_Passos_de_Dano : Form
    {
        public Calculadora_de_Passos_de_Dano()
        {
            InitializeComponent();
        }
        void calcularPassos(int dados, int passos, int tipoDado)
        {
            int m = 1;
            while (passos != 0)
            {
                if (tipoDado == 100)
                {
                    dados = dados * 15;
                    tipoDado = 12;
                    passos--;
                }
                else if (tipoDado == 20)
                {
                    dados = dados * 3;
                    tipoDado = 12;
                    passos--;
                }
                else if (tipoDado == 12)
                {
                    dados = dados * 2;
                    tipoDado = 8;
                    passos--;
                }else if (tipoDado > 3)
                {
                    tipoDado = tipoDado + 2;
                    passos--;
                }else if (tipoDado < 4)
                {
                    tipoDado = tipoDado + 1;
                    passos--;
                }else
                {
                    tipoDado = tipoDado + 2;
                    passos--;
                }
                while (dados > 999)
                {
                    dados = dados / 2;
                    m = m * 2;
                }
                A.B.m = m;
                A.B.d = dados;
                A.B.t = tipoDado;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Testa para observar se os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Adicione uma quantidade de dados.");
                return;
            }
            else if (numericUpDown1.Value < 1)
            {
                MessageBox.Show("Selecione uma quantidade de Passos.");
                return;
            }
            else if (numericUpDown1.Value > 49)
            {
                MessageBox.Show("HELL NAH.");
                return;
            }


            int teste = 0; 
            if (radioButtond2.Checked == true)
            {
                A.B.t = 2;
                teste = 1;
            }
            if (radioButtond3.Checked == true)
            {
                A.B.t = 3;
                teste = 1;
            }
            if (radioButtond4.Checked == true)
            {
                A.B.t = 4;
                teste = 1;
            }
            if (radioButtond6.Checked == true)
            {
                A.B.t = 6;
                teste = 1;
            }
            if (radioButtond8.Checked == true)
            {
                A.B.t = 8;
                teste = 1;
            }
            if (radioButtond10.Checked == true)
            {
                A.B.t = 10;
                teste = 1;
            }
            if (radioButtond12.Checked == true)
            {
                A.B.t = 12;
                teste = 1;
            }
            if (radioButtond20.Checked == true)
            {
                A.B.t = 20;
                teste = 1;
            }
            if (radioButtond100.Checked == true)
            {
                A.B.t = 100;
                teste = 1;
            } else if (teste == 0)
            {
                MessageBox.Show("Selecione um tipo de dado.");
                return;
            }
            A.B.d = Convert.ToInt32(textBox1.Text);
            A.B.p = Convert.ToInt32(numericUpDown1.Value);
            calcularPassos(A.B.d, A.B.p, A.B.t);
            if (A.B.m > 1)
            {
                A.B.mensagem = "(" + A.B.d + "d" + A.B.t + ")*" + A.B.m;
                MensagemComCopiar.Mostrar("O Dado principal é: " + A.B.mensagem);
            }
            else
            {
                A.B.mensagem = "" + A.B.d + "d" + A.B.t + "";
                MensagemComCopiar.Mostrar("O Dado principal é: " + A.B.mensagem);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
