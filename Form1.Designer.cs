namespace Calculadora
{
    partial class CALCULADORA
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNumero01 = new System.Windows.Forms.TextBox();
            this.txtNumero02 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbSomar = new System.Windows.Forms.RadioButton();
            this.rdbSubtracao = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicacao = new System.Windows.Forms.RadioButton();
            this.rdbDivisao = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(428, 361);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(270, 361);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(94, 361);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // txtNumero01
            // 
            this.txtNumero01.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNumero01.Location = new System.Drawing.Point(121, 112);
            this.txtNumero01.Name = "txtNumero01";
            this.txtNumero01.Size = new System.Drawing.Size(100, 20);
            this.txtNumero01.TabIndex = 3;
            // 
            // txtNumero02
            // 
            this.txtNumero02.Location = new System.Drawing.Point(121, 183);
            this.txtNumero02.Name = "txtNumero02";
            this.txtNumero02.Size = new System.Drawing.Size(100, 20);
            this.txtNumero02.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resultado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(181, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 41);
            this.label4.TabIndex = 8;
            this.label4.Text = "CALCULADORA";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(121, 255);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDivisao);
            this.groupBox1.Controls.Add(this.rdbMultiplicacao);
            this.groupBox1.Controls.Add(this.rdbSubtracao);
            this.groupBox1.Controls.Add(this.rdbSomar);
            this.groupBox1.Location = new System.Drawing.Point(372, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 267);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operadores";
            // 
            // rdbSomar
            // 
            this.rdbSomar.AutoSize = true;
            this.rdbSomar.Checked = true;
            this.rdbSomar.Location = new System.Drawing.Point(17, 39);
            this.rdbSomar.Name = "rdbSomar";
            this.rdbSomar.Size = new System.Drawing.Size(64, 17);
            this.rdbSomar.TabIndex = 0;
            this.rdbSomar.TabStop = true;
            this.rdbSomar.Text = "Somar +";
            this.rdbSomar.UseVisualStyleBackColor = true;
            // 
            // rdbSubtracao
            // 
            this.rdbSubtracao.AutoSize = true;
            this.rdbSubtracao.Location = new System.Drawing.Point(17, 72);
            this.rdbSubtracao.Name = "rdbSubtracao";
            this.rdbSubtracao.Size = new System.Drawing.Size(80, 17);
            this.rdbSubtracao.TabIndex = 1;
            this.rdbSubtracao.TabStop = true;
            this.rdbSubtracao.Text = "Subtração -";
            this.rdbSubtracao.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicacao
            // 
            this.rdbMultiplicacao.AutoSize = true;
            this.rdbMultiplicacao.Location = new System.Drawing.Point(17, 109);
            this.rdbMultiplicacao.Name = "rdbMultiplicacao";
            this.rdbMultiplicacao.Size = new System.Drawing.Size(94, 17);
            this.rdbMultiplicacao.TabIndex = 2;
            this.rdbMultiplicacao.TabStop = true;
            this.rdbMultiplicacao.Text = "Multiplicação *";
            this.rdbMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rdbDivisao
            // 
            this.rdbDivisao.AutoSize = true;
            this.rdbDivisao.Location = new System.Drawing.Point(17, 145);
            this.rdbDivisao.Name = "rdbDivisao";
            this.rdbDivisao.Size = new System.Drawing.Size(68, 17);
            this.rdbDivisao.TabIndex = 3;
            this.rdbDivisao.TabStop = true;
            this.rdbDivisao.Text = "Divisão /";
            this.rdbDivisao.UseVisualStyleBackColor = true;
            // 
            // CALCULADORA
            // 
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(651, 416);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumero02);
            this.Controls.Add(this.txtNumero01);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Name = "CALCULADORA";
            this.Text = "CALCULADORA";
            this.Load += new System.EventHandler(this.CALCULADORA_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtNumero01;
        private System.Windows.Forms.TextBox txtNumero02;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDivisao;
        private System.Windows.Forms.RadioButton rdbMultiplicacao;
        private System.Windows.Forms.RadioButton rdbSubtracao;
        private System.Windows.Forms.RadioButton rdbSomar;
    }
}

