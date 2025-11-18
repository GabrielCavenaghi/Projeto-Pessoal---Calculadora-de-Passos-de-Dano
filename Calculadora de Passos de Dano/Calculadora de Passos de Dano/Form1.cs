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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Calculadora_de_Passos_de_Dano calc = new Calculadora_de_Passos_de_Dano();
            calc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gerenciador_De_Ataques_Simplificados Gerenciador = new Gerenciador_De_Ataques_Simplificados();
            Gerenciador.Show();
        }
    }
}
