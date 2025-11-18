namespace Calculadora_de_Passos_de_Dano
{
    partial class Gerenciador_De_Ataques_Simplificados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_AdicionarAtq = new System.Windows.Forms.Button();
            this.flowLayoutPanelAtaques = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_SalvarAtq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_AdicionarAtq
            // 
            this.Btn_AdicionarAtq.Location = new System.Drawing.Point(12, 12);
            this.Btn_AdicionarAtq.Name = "Btn_AdicionarAtq";
            this.Btn_AdicionarAtq.Size = new System.Drawing.Size(141, 43);
            this.Btn_AdicionarAtq.TabIndex = 0;
            this.Btn_AdicionarAtq.Text = "Adicionar Ataque";
            this.Btn_AdicionarAtq.UseVisualStyleBackColor = true;
            this.Btn_AdicionarAtq.Click += new System.EventHandler(this.Btn_AdicionarAtq_Click);
            // 
            // flowLayoutPanelAtaques
            // 
            this.flowLayoutPanelAtaques.AutoScroll = true;
            this.flowLayoutPanelAtaques.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelAtaques.Location = new System.Drawing.Point(12, 61);
            this.flowLayoutPanelAtaques.Name = "flowLayoutPanelAtaques";
            this.flowLayoutPanelAtaques.Size = new System.Drawing.Size(845, 416);
            this.flowLayoutPanelAtaques.TabIndex = 1;
            this.flowLayoutPanelAtaques.WrapContents = false;
            // 
            // Btn_SalvarAtq
            // 
            this.Btn_SalvarAtq.Location = new System.Drawing.Point(716, 12);
            this.Btn_SalvarAtq.Name = "Btn_SalvarAtq";
            this.Btn_SalvarAtq.Size = new System.Drawing.Size(141, 43);
            this.Btn_SalvarAtq.TabIndex = 2;
            this.Btn_SalvarAtq.Text = "Salvar Ataque";
            this.Btn_SalvarAtq.UseVisualStyleBackColor = true;
            this.Btn_SalvarAtq.Click += new System.EventHandler(this.Btn_SalvarAtq_Click);
            // 
            // Gerenciador_De_Ataques_Simplificados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 489);
            this.Controls.Add(this.Btn_SalvarAtq);
            this.Controls.Add(this.flowLayoutPanelAtaques);
            this.Controls.Add(this.Btn_AdicionarAtq);
            this.Name = "Gerenciador_De_Ataques_Simplificados";
            this.Text = "Gerenciador_De_Ataques_Simplificados";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_AdicionarAtq;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAtaques;
        private System.Windows.Forms.Button Btn_SalvarAtq;
    }
}