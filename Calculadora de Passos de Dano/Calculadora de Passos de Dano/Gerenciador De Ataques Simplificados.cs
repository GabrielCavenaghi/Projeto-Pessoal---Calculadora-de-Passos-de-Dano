using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using static Calculadora_de_Passos_de_Dano.Modulo_De_Ataque;

namespace Calculadora_de_Passos_de_Dano
{
    public partial class Gerenciador_De_Ataques_Simplificados : Form
    {
        public Gerenciador_De_Ataques_Simplificados()
        {
            InitializeComponent();

            LoadData();
        }

        public void LoadData()
        {
            string path = @"Data\ataques.json";

            if (!File.Exists(path))
                return;

            string json = File.ReadAllText(path);
            var listaDados = JsonConvert.DeserializeObject<List<AtaqueData>>(json);

            foreach (var data in listaDados)
            {
                Modulo_De_Ataque modulo = new Modulo_De_Ataque();
                modulo.SetData(data);
                flowLayoutPanelAtaques.Controls.Add(modulo);
            }
        }

        public void SaveData()
        {
            string folder = @"Data";
            string filePath = Path.Combine(folder, "ataques.json");

            // Garante que a pasta existe
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            var listaDados = new List<AtaqueData>();

            foreach (Modulo_De_Ataque modulo in flowLayoutPanelAtaques.Controls)
            {
                listaDados.Add(modulo.GetData());
            }

            string json = JsonConvert.SerializeObject(listaDados, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }


        private void Btn_AdicionarAtq_Click(object sender, EventArgs e)
        {
            Modulo_De_Ataque novo = new Modulo_De_Ataque();

            // Adiciona o módulo dentro do painel
            flowLayoutPanelAtaques.Controls.Add(novo);
        }

        private void Btn_SalvarAtq_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}
