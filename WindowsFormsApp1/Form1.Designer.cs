namespace WindowsFormsApp1
{
    partial class Form1
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
            this.nomeTxt = new System.Windows.Forms.Label();
            this.cpfTxt = new System.Windows.Forms.Label();
            this.diasTxt = new System.Windows.Forms.Label();
            this.valorTxt = new System.Windows.Forms.Label();
            this.nomeEsc = new System.Windows.Forms.TextBox();
            this.diasEsc = new System.Windows.Forms.TextBox();
            this.valorEsc = new System.Windows.Forms.TextBox();
            this.cpfEsc = new System.Windows.Forms.MaskedTextBox();
            this.submitBut = new System.Windows.Forms.Button();
            this.baseTxt = new System.Windows.Forms.Label();
            this.irTxt = new System.Windows.Forms.Label();
            this.liqTxt = new System.Windows.Forms.Label();
            this.baseEsc = new System.Windows.Forms.TextBox();
            this.irEsc = new System.Windows.Forms.TextBox();
            this.liqEsc = new System.Windows.Forms.TextBox();
            this.divisao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nomeTxt
            // 
            this.nomeTxt.AutoSize = true;
            this.nomeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTxt.Location = new System.Drawing.Point(21, 55);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(79, 25);
            this.nomeTxt.TabIndex = 0;
            this.nomeTxt.Text = "Nome:";
            this.nomeTxt.Click += new System.EventHandler(this.label1_Click);
            // 
            // cpfTxt
            // 
            this.cpfTxt.AutoSize = true;
            this.cpfTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfTxt.Location = new System.Drawing.Point(22, 102);
            this.cpfTxt.Name = "cpfTxt";
            this.cpfTxt.Size = new System.Drawing.Size(64, 25);
            this.cpfTxt.TabIndex = 1;
            this.cpfTxt.Text = "CPF:";
            // 
            // diasTxt
            // 
            this.diasTxt.AutoSize = true;
            this.diasTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diasTxt.Location = new System.Drawing.Point(22, 149);
            this.diasTxt.Name = "diasTxt";
            this.diasTxt.Size = new System.Drawing.Size(197, 25);
            this.diasTxt.TabIndex = 2;
            this.diasTxt.Text = "Dias trabalhados:";
            // 
            // valorTxt
            // 
            this.valorTxt.AutoSize = true;
            this.valorTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTxt.Location = new System.Drawing.Point(22, 197);
            this.valorTxt.Name = "valorTxt";
            this.valorTxt.Size = new System.Drawing.Size(143, 25);
            this.valorTxt.TabIndex = 3;
            this.valorTxt.Text = "Valor Diário:";
            // 
            // nomeEsc
            // 
            this.nomeEsc.Location = new System.Drawing.Point(100, 55);
            this.nomeEsc.Name = "nomeEsc";
            this.nomeEsc.Size = new System.Drawing.Size(318, 20);
            this.nomeEsc.TabIndex = 4;
            this.nomeEsc.TextChanged += new System.EventHandler(this.nomeEsc_TextChanged);
            // 
            // diasEsc
            // 
            this.diasEsc.Location = new System.Drawing.Point(225, 154);
            this.diasEsc.Name = "diasEsc";
            this.diasEsc.Size = new System.Drawing.Size(193, 20);
            this.diasEsc.TabIndex = 6;
            this.diasEsc.TextChanged += new System.EventHandler(this.diasEsc_TextChanged);
            // 
            // valorEsc
            // 
            this.valorEsc.Location = new System.Drawing.Point(164, 202);
            this.valorEsc.Name = "valorEsc";
            this.valorEsc.Size = new System.Drawing.Size(254, 20);
            this.valorEsc.TabIndex = 7;
            // 
            // cpfEsc
            // 
            this.cpfEsc.Location = new System.Drawing.Point(100, 102);
            this.cpfEsc.Mask = "000.000.000-00";
            this.cpfEsc.Name = "cpfEsc";
            this.cpfEsc.Size = new System.Drawing.Size(77, 20);
            this.cpfEsc.TabIndex = 8;
            this.cpfEsc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.cpfEsc_MaskInputRejected);
            // 
            // submitBut
            // 
            this.submitBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBut.Location = new System.Drawing.Point(85, 482);
            this.submitBut.Name = "submitBut";
            this.submitBut.Size = new System.Drawing.Size(276, 31);
            this.submitBut.TabIndex = 9;
            this.submitBut.Text = "Calcular";
            this.submitBut.UseVisualStyleBackColor = true;
            this.submitBut.Click += new System.EventHandler(this.submitBut_Click);
            // 
            // baseTxt
            // 
            this.baseTxt.AutoSize = true;
            this.baseTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseTxt.Location = new System.Drawing.Point(22, 313);
            this.baseTxt.Name = "baseTxt";
            this.baseTxt.Size = new System.Drawing.Size(132, 24);
            this.baseTxt.TabIndex = 10;
            this.baseTxt.Text = "Salário Base:";
            // 
            // irTxt
            // 
            this.irTxt.AutoSize = true;
            this.irTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.irTxt.Location = new System.Drawing.Point(22, 358);
            this.irTxt.Name = "irTxt";
            this.irTxt.Size = new System.Drawing.Size(120, 24);
            this.irTxt.TabIndex = 11;
            this.irTxt.Text = "Valor do IR:";
            // 
            // liqTxt
            // 
            this.liqTxt.AutoSize = true;
            this.liqTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liqTxt.Location = new System.Drawing.Point(22, 399);
            this.liqTxt.Name = "liqTxt";
            this.liqTxt.Size = new System.Drawing.Size(155, 24);
            this.liqTxt.TabIndex = 12;
            this.liqTxt.Text = "Salário Líquido:";
            // 
            // baseEsc
            // 
            this.baseEsc.Location = new System.Drawing.Point(183, 317);
            this.baseEsc.Name = "baseEsc";
            this.baseEsc.Size = new System.Drawing.Size(235, 20);
            this.baseEsc.TabIndex = 13;
            this.baseEsc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // irEsc
            // 
            this.irEsc.Location = new System.Drawing.Point(183, 358);
            this.irEsc.Name = "irEsc";
            this.irEsc.Size = new System.Drawing.Size(235, 20);
            this.irEsc.TabIndex = 14;
            // 
            // liqEsc
            // 
            this.liqEsc.Location = new System.Drawing.Point(183, 399);
            this.liqEsc.Name = "liqEsc";
            this.liqEsc.Size = new System.Drawing.Size(235, 20);
            this.liqEsc.TabIndex = 15;
            // 
            // divisao
            // 
            this.divisao.AutoSize = true;
            this.divisao.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisao.Location = new System.Drawing.Point(158, 257);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(111, 32);
            this.divisao.TabIndex = 16;
            this.divisao.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 567);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.liqEsc);
            this.Controls.Add(this.irEsc);
            this.Controls.Add(this.baseEsc);
            this.Controls.Add(this.liqTxt);
            this.Controls.Add(this.irTxt);
            this.Controls.Add(this.baseTxt);
            this.Controls.Add(this.submitBut);
            this.Controls.Add(this.cpfEsc);
            this.Controls.Add(this.valorEsc);
            this.Controls.Add(this.diasEsc);
            this.Controls.Add(this.nomeEsc);
            this.Controls.Add(this.valorTxt);
            this.Controls.Add(this.diasTxt);
            this.Controls.Add(this.cpfTxt);
            this.Controls.Add(this.nomeTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeTxt;
        private System.Windows.Forms.Label cpfTxt;
        private System.Windows.Forms.Label diasTxt;
        private System.Windows.Forms.Label valorTxt;
        private System.Windows.Forms.TextBox nomeEsc;
        private System.Windows.Forms.TextBox diasEsc;
        private System.Windows.Forms.TextBox valorEsc;
        private System.Windows.Forms.MaskedTextBox cpfEsc;
        private System.Windows.Forms.Button submitBut;
        private System.Windows.Forms.Label baseTxt;
        private System.Windows.Forms.Label irTxt;
        private System.Windows.Forms.Label liqTxt;
        private System.Windows.Forms.TextBox baseEsc;
        private System.Windows.Forms.TextBox irEsc;
        private System.Windows.Forms.TextBox liqEsc;
        private System.Windows.Forms.Label divisao;
    }
}

