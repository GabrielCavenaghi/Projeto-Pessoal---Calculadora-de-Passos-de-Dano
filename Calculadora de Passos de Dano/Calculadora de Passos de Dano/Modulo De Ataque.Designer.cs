namespace Calculadora_de_Passos_de_Dano
{
    partial class Modulo_De_Ataque
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Atacar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Dados = new System.Windows.Forms.TextBox();
            this.numericUpDownTeste = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMult = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAmeaça = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDanoDado = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Txt_Ataque = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownMod = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTeste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmeaça)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDanoDado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMod)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Atacar
            // 
            this.Btn_Atacar.Location = new System.Drawing.Point(512, 69);
            this.Btn_Atacar.Name = "Btn_Atacar";
            this.Btn_Atacar.Size = new System.Drawing.Size(129, 52);
            this.Btn_Atacar.TabIndex = 0;
            this.Btn_Atacar.Text = "Calcular";
            this.Btn_Atacar.UseVisualStyleBackColor = true;
            this.Btn_Atacar.Click += new System.EventHandler(this.Btn_Atacar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dados Teste:";
            // 
            // Txt_Dados
            // 
            this.Txt_Dados.Location = new System.Drawing.Point(174, 148);
            this.Txt_Dados.Name = "Txt_Dados";
            this.Txt_Dados.Size = new System.Drawing.Size(100, 22);
            this.Txt_Dados.TabIndex = 2;
            // 
            // numericUpDownTeste
            // 
            this.numericUpDownTeste.Location = new System.Drawing.Point(160, 69);
            this.numericUpDownTeste.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownTeste.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTeste.Name = "numericUpDownTeste";
            this.numericUpDownTeste.Size = new System.Drawing.Size(42, 22);
            this.numericUpDownTeste.TabIndex = 3;
            this.numericUpDownTeste.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownMult
            // 
            this.numericUpDownMult.Location = new System.Drawing.Point(416, 68);
            this.numericUpDownMult.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMult.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMult.Name = "numericUpDownMult";
            this.numericUpDownMult.Size = new System.Drawing.Size(42, 22);
            this.numericUpDownMult.TabIndex = 4;
            this.numericUpDownMult.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDownAmeaça
            // 
            this.numericUpDownAmeaça.Location = new System.Drawing.Point(351, 101);
            this.numericUpDownAmeaça.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownAmeaça.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmeaça.Name = "numericUpDownAmeaça";
            this.numericUpDownAmeaça.Size = new System.Drawing.Size(42, 22);
            this.numericUpDownAmeaça.TabIndex = 5;
            this.numericUpDownAmeaça.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numericUpDownDanoDado
            // 
            this.numericUpDownDanoDado.Location = new System.Drawing.Point(176, 100);
            this.numericUpDownDanoDado.Name = "numericUpDownDanoDado";
            this.numericUpDownDanoDado.Size = new System.Drawing.Size(42, 22);
            this.numericUpDownDanoDado.TabIndex = 7;
            this.numericUpDownDanoDado.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dano Por Dado:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Margem:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(208, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Multiplicador Crítico:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dados de Dano:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(294, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Modificador de Teste:";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(611, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txt_Ataque
            // 
            this.Txt_Ataque.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Ataque.Location = new System.Drawing.Point(192, 17);
            this.Txt_Ataque.Name = "Txt_Ataque";
            this.Txt_Ataque.Size = new System.Drawing.Size(408, 38);
            this.Txt_Ataque.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nome Do Ataque:";
            // 
            // numericUpDownMod
            // 
            this.numericUpDownMod.Location = new System.Drawing.Point(512, 148);
            this.numericUpDownMod.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownMod.Name = "numericUpDownMod";
            this.numericUpDownMod.Size = new System.Drawing.Size(55, 22);
            this.numericUpDownMod.TabIndex = 17;
            // 
            // Modulo_De_Ataque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericUpDownMod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_Ataque);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownDanoDado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownAmeaça);
            this.Controls.Add(this.numericUpDownMult);
            this.Controls.Add(this.numericUpDownTeste);
            this.Controls.Add(this.Txt_Dados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Atacar);
            this.Name = "Modulo_De_Ataque";
            this.Size = new System.Drawing.Size(696, 193);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTeste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmeaça)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDanoDado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Atacar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Dados;
        private System.Windows.Forms.NumericUpDown numericUpDownTeste;
        private System.Windows.Forms.NumericUpDown numericUpDownMult;
        private System.Windows.Forms.NumericUpDown numericUpDownAmeaça;
        private System.Windows.Forms.NumericUpDown numericUpDownDanoDado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Txt_Ataque;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownMod;
    }
}
