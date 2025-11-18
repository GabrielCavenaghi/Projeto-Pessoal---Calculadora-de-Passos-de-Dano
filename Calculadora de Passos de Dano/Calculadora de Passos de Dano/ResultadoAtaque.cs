using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculadora_de_Passos_de_Dano
{
    public class ResultadoAtaque : Form
    {
        private Label lblMensagem;
        private Button btnOk;

        public ResultadoAtaque(string mensagem)
        {
            this.Text = "Resultado do Ataque";
            this.Size = new Size(550, 500);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Painel com barra de rolagem
            Panel panel = new Panel();
            panel.Dock = DockStyle.Top;
            panel.Height = 380;
            panel.AutoScroll = true;

            // Label dentro do painel
            lblMensagem = new Label();
            lblMensagem.Text = mensagem;
            lblMensagem.AutoSize = true; // PERMITE EXPANDIR
            lblMensagem.Font = new Font("Segoe UI", 11);
            lblMensagem.MaximumSize = new Size(500, 0);
            lblMensagem.Padding = new Padding(10);

            panel.Controls.Add(lblMensagem);

            // Botão OK
            btnOk = new Button();
            btnOk.Text = "OK";
            btnOk.Width = 120;
            btnOk.Height = 40;
            btnOk.Left = 210;
            btnOk.Top = 400;
            btnOk.Click += (s, e) => this.Close();

            // Adicionando
            this.Controls.Add(panel);
            this.Controls.Add(btnOk);
        }

        public static void Mostrar(string mensagem)
        {
            using (var form = new ResultadoAtaque(mensagem))
            {
                form.ShowDialog();
            }
        }
    }
}
