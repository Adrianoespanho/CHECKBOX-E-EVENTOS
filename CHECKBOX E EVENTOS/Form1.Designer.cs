namespace CHECKBOX_E_EVENTOS
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxMaca = new System.Windows.Forms.CheckBox();
            this.checkBoxPera = new System.Windows.Forms.CheckBox();
            this.checkBoxAbacaxi = new System.Windows.Forms.CheckBox();
            this.checkBoxLaranja = new System.Windows.Forms.CheckBox();
            this.checkBoxMorango = new System.Windows.Forms.CheckBox();
            this.checkBoxBanana = new System.Windows.Forms.CheckBox();
            this.checkBoxMamao = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEscolha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxMaca
            // 
            this.checkBoxMaca.AutoSize = true;
            this.checkBoxMaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMaca.Location = new System.Drawing.Point(53, 71);
            this.checkBoxMaca.Name = "checkBoxMaca";
            this.checkBoxMaca.Size = new System.Drawing.Size(64, 20);
            this.checkBoxMaca.TabIndex = 0;
            this.checkBoxMaca.Text = "Maça";
            this.checkBoxMaca.UseVisualStyleBackColor = true;
            this.checkBoxMaca.CheckedChanged += new System.EventHandler(this.checkBoxMaca_CheckedChanged);
            // 
            // checkBoxPera
            // 
            this.checkBoxPera.AutoSize = true;
            this.checkBoxPera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPera.Location = new System.Drawing.Point(53, 105);
            this.checkBoxPera.Name = "checkBoxPera";
            this.checkBoxPera.Size = new System.Drawing.Size(59, 20);
            this.checkBoxPera.TabIndex = 1;
            this.checkBoxPera.Text = "Pera";
            this.checkBoxPera.UseVisualStyleBackColor = true;
            this.checkBoxPera.CheckedChanged += new System.EventHandler(this.checkBoxPera_CheckedChanged);
            // 
            // checkBoxAbacaxi
            // 
            this.checkBoxAbacaxi.AutoSize = true;
            this.checkBoxAbacaxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAbacaxi.Location = new System.Drawing.Point(53, 139);
            this.checkBoxAbacaxi.Name = "checkBoxAbacaxi";
            this.checkBoxAbacaxi.Size = new System.Drawing.Size(82, 20);
            this.checkBoxAbacaxi.TabIndex = 2;
            this.checkBoxAbacaxi.Text = "Abacaxi";
            this.checkBoxAbacaxi.UseVisualStyleBackColor = true;
            this.checkBoxAbacaxi.CheckedChanged += new System.EventHandler(this.checkBoxAbacaxi_CheckedChanged);
            // 
            // checkBoxLaranja
            // 
            this.checkBoxLaranja.AutoSize = true;
            this.checkBoxLaranja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLaranja.Location = new System.Drawing.Point(53, 176);
            this.checkBoxLaranja.Name = "checkBoxLaranja";
            this.checkBoxLaranja.Size = new System.Drawing.Size(78, 20);
            this.checkBoxLaranja.TabIndex = 3;
            this.checkBoxLaranja.Text = "Laranja";
            this.checkBoxLaranja.UseVisualStyleBackColor = true;
            this.checkBoxLaranja.CheckedChanged += new System.EventHandler(this.checkBoxLaranja_CheckedChanged);
            // 
            // checkBoxMorango
            // 
            this.checkBoxMorango.AutoSize = true;
            this.checkBoxMorango.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMorango.Location = new System.Drawing.Point(53, 215);
            this.checkBoxMorango.Name = "checkBoxMorango";
            this.checkBoxMorango.Size = new System.Drawing.Size(87, 20);
            this.checkBoxMorango.TabIndex = 4;
            this.checkBoxMorango.Text = "Morango";
            this.checkBoxMorango.UseVisualStyleBackColor = true;
            this.checkBoxMorango.CheckedChanged += new System.EventHandler(this.checkBoxMorango_CheckedChanged);
            // 
            // checkBoxBanana
            // 
            this.checkBoxBanana.AutoSize = true;
            this.checkBoxBanana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBanana.Location = new System.Drawing.Point(53, 253);
            this.checkBoxBanana.Name = "checkBoxBanana";
            this.checkBoxBanana.Size = new System.Drawing.Size(79, 20);
            this.checkBoxBanana.TabIndex = 5;
            this.checkBoxBanana.Text = "Banana";
            this.checkBoxBanana.UseVisualStyleBackColor = true;
            this.checkBoxBanana.CheckedChanged += new System.EventHandler(this.checkBoxBanana_CheckedChanged);
            // 
            // checkBoxMamao
            // 
            this.checkBoxMamao.AutoSize = true;
            this.checkBoxMamao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMamao.Location = new System.Drawing.Point(53, 289);
            this.checkBoxMamao.Name = "checkBoxMamao";
            this.checkBoxMamao.Size = new System.Drawing.Size(77, 20);
            this.checkBoxMamao.TabIndex = 6;
            this.checkBoxMamao.Text = "Mamao";
            this.checkBoxMamao.UseVisualStyleBackColor = true;
            this.checkBoxMamao.CheckedChanged += new System.EventHandler(this.checkBoxMamao_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Escolha a Fruta :";
            // 
            // btnEscolha
            // 
            this.btnEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscolha.Location = new System.Drawing.Point(289, 29);
            this.btnEscolha.Name = "btnEscolha";
            this.btnEscolha.Size = new System.Drawing.Size(323, 22);
            this.btnEscolha.TabIndex = 8;
            this.btnEscolha.Text = "Escolha  a Fruta ao lado e clique aqui";
            this.btnEscolha.UseVisualStyleBackColor = true;
            this.btnEscolha.Click += new System.EventHandler(this.btnEscolha_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 382);
            this.Controls.Add(this.btnEscolha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxMamao);
            this.Controls.Add(this.checkBoxBanana);
            this.Controls.Add(this.checkBoxMorango);
            this.Controls.Add(this.checkBoxLaranja);
            this.Controls.Add(this.checkBoxAbacaxi);
            this.Controls.Add(this.checkBoxPera);
            this.Controls.Add(this.checkBoxMaca);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxMaca;
        private System.Windows.Forms.CheckBox checkBoxPera;
        private System.Windows.Forms.CheckBox checkBoxAbacaxi;
        private System.Windows.Forms.CheckBox checkBoxLaranja;
        private System.Windows.Forms.CheckBox checkBoxMorango;
        private System.Windows.Forms.CheckBox checkBoxBanana;
        private System.Windows.Forms.CheckBox checkBoxMamao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEscolha;
    }
}

