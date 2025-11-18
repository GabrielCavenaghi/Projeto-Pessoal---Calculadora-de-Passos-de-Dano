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
    public partial class Modulo_De_Ataque : UserControl
    {
        public Modulo_De_Ataque()
        {
            InitializeComponent();
        }

        public class AtaqueData
        {
            public string Nome { get; set; }
            public string Dado { get; set; }
            public int DanoPorDado { get; set; }
            public int TesteDado { get; set; }
            public int Modteste { get; set; }
            public int Critico { get; set; }
            public int Margem { get; set; }
        }

        public AtaqueData GetData()
        {
            return new AtaqueData
            {
                Nome = Txt_Dados.Text,
                Dado = Txt_Ataque.Text,
                TesteDado = Convert.ToInt32(numericUpDownTeste.Value),
                Critico = Convert.ToInt32(numericUpDownMult.Value),
                DanoPorDado = Convert.ToInt32(numericUpDownDanoDado.Value),
                Margem = Convert.ToInt32(numericUpDownAmeaça.Value),
                Modteste = Convert.ToInt32(numericUpDownMod.Value),
            };
        }

        public void SetData(AtaqueData data)
        {
            Txt_Dados.Text = data.Nome;
            Txt_Ataque.Text = data.Dado;
            numericUpDownTeste.Value = data.TesteDado;
            numericUpDownMult.Value = data.Critico;
            numericUpDownDanoDado.Value = data.DanoPorDado;
            numericUpDownAmeaça.Value = data.Margem;
            numericUpDownMod.Value = data.Modteste;
        }





        //aleatoriedade
        private static Random rand = new Random();
        
        //rola dados de dano
        public int SomarDados(int quantidade, int tipo)
        {
            int soma = 0;

            for (int i = 0; i < quantidade; i++)
                soma += rand.Next(1, tipo + 1);

            return soma;
        }

        //rola teste de ataque
        public int RolarTeste(int quantidade)
        {
            int maior = 0;

            for (int i = 0; i < quantidade; i++)
            {
                int resultado = rand.Next(1, 21); // d20

                if (resultado > maior)
                    maior = resultado;

                if (resultado == 20)
                    break; // 20 já é o máximo, para a função
            }

            return maior;
        }

        public bool ParseAtaque(string input, out int dados, out int tipo, out int mult)
        {
            dados = 0;
            tipo = 0;
            mult = 1; // padrão: sem multiplicador explícito

            if (string.IsNullOrWhiteSpace(input))
                return false;

            // Remover espaços e parênteses
            input = input.Replace(" ", "")
                         .Replace("(", "")
                         .Replace(")", "")
                         .ToLower();

            // Verificar se contém um 'd'
            int indexD = input.IndexOf('d');
            if (indexD <= 0)
                return false; // formato inválido

            // Parte antes do 'd' = quantidade de dados
            string parteDados = input.Substring(0, indexD);

            // Verificar multiplicador (*)
            int indexMult = input.IndexOf('*');

            if (indexMult > 0)
            {
                // Parte entre d e *
                string parteTipo = input.Substring(indexD + 1, indexMult - (indexD + 1));

                // Parte após o *
                string parteMult = input.Substring(indexMult + 1);

                if (!int.TryParse(parteDados, out dados)) return false;
                if (!int.TryParse(parteTipo, out tipo)) return false;
                if (!int.TryParse(parteMult, out mult)) return false;
            }
            else
            {
                // Sem multiplicador
                string parteTipo = input.Substring(indexD + 1);

                if (!int.TryParse(parteDados, out dados)) return false;
                if (!int.TryParse(parteTipo, out tipo)) return false;
            }

            return true;
        }


        private void Btn_Atacar_Click(object sender, EventArgs e)
        {
            //Declarando variaveis
            int testeDados;
            int danoPorDado;
            int margem;
            int multcrit;
            int quantidadeDados;
            int tipoDoDado;
            int multdado;
            int modificador;
            string text;
            string nomeAtaque;

            //verificando se os campos estao preenchidos
            if (string.IsNullOrEmpty(Txt_Dados.Text))
            {
                MessageBox.Show("Por favor, preencha o campo de dados de ataque.");
                return;
            }
            if (numericUpDownTeste.Value == 0)
            {
                MessageBox.Show("Por favor, preencha o campo de teste de ataque.");
                return;
            }

            //atribuindo valores das variaveis
            text = Txt_Dados.Text;
            nomeAtaque = Txt_Ataque.Text;
            testeDados = Convert.ToInt32(numericUpDownTeste.Value);
            danoPorDado = Convert.ToInt32(numericUpDownDanoDado.Value);
            margem = Convert.ToInt32(numericUpDownAmeaça.Value);
            multcrit = Convert.ToInt32(numericUpDownMult.Value);   // multiplicador de crítico
            modificador = Convert.ToInt32(numericUpDownMod.Value);

            // Lendo os dados do ataque (Ex: 640d12*4)
            if (ParseAtaque(text, out int dados, out int tipo, out int mult))
            {
                quantidadeDados = dados;
                tipoDoDado = tipo;
                multdado = mult;   // multiplicador final do dano
            }
            else
            {
                MessageBox.Show("Formato inválido!");
                return;
            }

            // 1. Rolando o teste de ataque
            int resultadoTeste = RolarTeste(testeDados);

            // 2. Calculando o dano base (somatório dos dados)
            int danoRolado = SomarDados(quantidadeDados, tipoDoDado);

            // 3. Aplicando dano por dado (se existir)
            danoRolado += (quantidadeDados * danoPorDado);

            // 4. Aplicando modificador fixo
            danoRolado += modificador;

            // 5. Aplicando multiplicador do próprio ataque (ex: 640d12*4)
            danoRolado *= multdado;

            //6. Somando modificador do teste de ataque
            int testefinal = resultadoTeste + modificador;

            //7. Verificando se é crítico
            bool critico = resultadoTeste >= margem;

            if (critico)
                danoRolado *= multcrit;

            // Exibindo resultados
            string mensagem =
    $"========== {nomeAtaque} ==========\n\n" +
    $"• Teste de Ataque Bruto: {resultadoTeste}\n" +
    $"• Modificador de Ataque: {modificador}\n" +
    $"• Resultado Final do Teste: {testefinal}\n" +
    $"• Margem de Ameaça: {margem}\n" +
    $"• Crítico?: {(critico ? "SIM" : "NÃO")}\n\n" +

    $"========== DADOS DO DANO ==========\n\n" +
    $"• Rolado: {quantidadeDados}d{tipoDoDado}\n" +
    $"• Dano por Dado: {danoPorDado}\n" +
    $"• Multiplicador Interno (*): {multdado}\n" +
    $"• Modificador Fixo: {modificador}\n" +
    $"• Multiplicador Crítico: x{multcrit}\n\n" +

    $"========== DANO FINAL ==========\n" +
    $"{danoRolado}";
            ResultadoAtaque.Mostrar(mensagem);
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //remove o modulo de ataque
            var parent = this.Parent as Panel;
            if (parent != null)
            {
                parent.Controls.Remove(this);
            }
        }
    }
}
