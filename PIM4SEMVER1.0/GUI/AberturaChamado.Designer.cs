namespace PIM4SEMVER1._0.GUI
{
    partial class AberturaChamado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AberturaChamado));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbCPFchamado = new System.Windows.Forms.RadioButton();
            this.rbCNPJchamado = new System.Windows.Forms.RadioButton();
            this.txtCPFchamado = new System.Windows.Forms.TextBox();
            this.txtCNPJchamado = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProtocolo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbVisitaNao = new System.Windows.Forms.RadioButton();
            this.rbVisitaSim = new System.Windows.Forms.RadioButton();
            this.lblVisitaTecnica = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.txtResumoChamado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msLimpar = new System.Windows.Forms.ToolStripMenuItem();
            this.msAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.msVoltar = new System.Windows.Forms.ToolStripMenuItem();
            this.lupaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbCPFchamado);
            this.groupBox3.Controls.Add(this.rbCNPJchamado);
            this.groupBox3.Controls.Add(this.txtCPFchamado);
            this.groupBox3.Controls.Add(this.txtCNPJchamado);
            this.groupBox3.Controls.Add(this.txtNomeCliente);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtProtocolo);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 99);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chamado";
            // 
            // rbCPFchamado
            // 
            this.rbCPFchamado.AutoSize = true;
            this.rbCPFchamado.Location = new System.Drawing.Point(419, 26);
            this.rbCPFchamado.Name = "rbCPFchamado";
            this.rbCPFchamado.Size = new System.Drawing.Size(52, 20);
            this.rbCPFchamado.TabIndex = 27;
            this.rbCPFchamado.TabStop = true;
            this.rbCPFchamado.Text = "CPF";
            this.rbCPFchamado.UseVisualStyleBackColor = true;
            this.rbCPFchamado.CheckedChanged += new System.EventHandler(this.rbCPFchamado_CheckedChanged);
            // 
            // rbCNPJchamado
            // 
            this.rbCNPJchamado.AutoSize = true;
            this.rbCNPJchamado.Location = new System.Drawing.Point(419, 52);
            this.rbCNPJchamado.Name = "rbCNPJchamado";
            this.rbCNPJchamado.Size = new System.Drawing.Size(61, 20);
            this.rbCNPJchamado.TabIndex = 26;
            this.rbCNPJchamado.TabStop = true;
            this.rbCNPJchamado.Text = "CNPJ";
            this.rbCNPJchamado.UseVisualStyleBackColor = true;
            this.rbCNPJchamado.CheckedChanged += new System.EventHandler(this.rbCNPJchamado_CheckedChanged);
            // 
            // txtCPFchamado
            // 
            this.txtCPFchamado.Enabled = false;
            this.txtCPFchamado.Location = new System.Drawing.Point(499, 25);
            this.txtCPFchamado.MaxLength = 11;
            this.txtCPFchamado.Name = "txtCPFchamado";
            this.txtCPFchamado.Size = new System.Drawing.Size(246, 22);
            this.txtCPFchamado.TabIndex = 25;
            this.txtCPFchamado.TextChanged += new System.EventHandler(this.txtCPFchamado_TextChanged);
            // 
            // txtCNPJchamado
            // 
            this.txtCNPJchamado.Enabled = false;
            this.txtCNPJchamado.Location = new System.Drawing.Point(499, 56);
            this.txtCNPJchamado.MaxLength = 14;
            this.txtCNPJchamado.Name = "txtCNPJchamado";
            this.txtCNPJchamado.Size = new System.Drawing.Size(246, 22);
            this.txtCNPJchamado.TabIndex = 22;
            this.txtCNPJchamado.TextChanged += new System.EventHandler(this.txtCNPJchamado_TextChanged);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BackColor = System.Drawing.SystemColors.Window;
            this.txtNomeCliente.Location = new System.Drawing.Point(68, 61);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(329, 22);
            this.txtNomeCliente.TabIndex = 21;
            this.txtNomeCliente.TextChanged += new System.EventHandler(this.txtNomeCliente_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Cliente:";
            // 
            // txtProtocolo
            // 
            this.txtProtocolo.BackColor = System.Drawing.SystemColors.Window;
            this.txtProtocolo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtProtocolo.Location = new System.Drawing.Point(173, 22);
            this.txtProtocolo.Name = "txtProtocolo";
            this.txtProtocolo.ReadOnly = true;
            this.txtProtocolo.Size = new System.Drawing.Size(224, 22);
            this.txtProtocolo.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nº protocolo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbVisitaNao);
            this.groupBox2.Controls.Add(this.rbVisitaSim);
            this.groupBox2.Controls.Add(this.lblVisitaTecnica);
            this.groupBox2.Controls.Add(this.btnVoltar);
            this.groupBox2.Controls.Add(this.cbModelo);
            this.groupBox2.Controls.Add(this.cbCategoria);
            this.groupBox2.Controls.Add(this.btnLimpar);
            this.groupBox2.Controls.Add(this.btnAlterar);
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Controls.Add(this.txtLocal);
            this.groupBox2.Controls.Add(this.txtDescricao);
            this.groupBox2.Controls.Add(this.txtResumoChamado);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbSituacao);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 392);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Solicitação";
            // 
            // rbVisitaNao
            // 
            this.rbVisitaNao.AutoSize = true;
            this.rbVisitaNao.Location = new System.Drawing.Point(15, 305);
            this.rbVisitaNao.Name = "rbVisitaNao";
            this.rbVisitaNao.Size = new System.Drawing.Size(52, 20);
            this.rbVisitaNao.TabIndex = 22;
            this.rbVisitaNao.TabStop = true;
            this.rbVisitaNao.Text = "Não";
            this.rbVisitaNao.UseVisualStyleBackColor = true;
            // 
            // rbVisitaSim
            // 
            this.rbVisitaSim.AutoSize = true;
            this.rbVisitaSim.Location = new System.Drawing.Point(15, 279);
            this.rbVisitaSim.Name = "rbVisitaSim";
            this.rbVisitaSim.Size = new System.Drawing.Size(49, 20);
            this.rbVisitaSim.TabIndex = 21;
            this.rbVisitaSim.TabStop = true;
            this.rbVisitaSim.Text = "Sim";
            this.rbVisitaSim.UseVisualStyleBackColor = true;
            // 
            // lblVisitaTecnica
            // 
            this.lblVisitaTecnica.AutoSize = true;
            this.lblVisitaTecnica.Location = new System.Drawing.Point(12, 260);
            this.lblVisitaTecnica.Name = "lblVisitaTecnica";
            this.lblVisitaTecnica.Size = new System.Drawing.Size(96, 16);
            this.lblVisitaTecnica.TabIndex = 20;
            this.lblVisitaTecnica.Text = "Visita Técnica:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(589, 347);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 19;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // cbModelo
            // 
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(14, 161);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(157, 24);
            this.cbModelo.TabIndex = 18;
            this.cbModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbModelo_KeyPress);
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(13, 102);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(158, 24);
            this.cbCategoria.TabIndex = 17;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            this.cbCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCategoria_KeyPress);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(508, 347);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(670, 347);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(427, 347);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtLocal
            // 
            this.txtLocal.BackColor = System.Drawing.SystemColors.Window;
            this.txtLocal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLocal.Location = new System.Drawing.Point(54, 347);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.ReadOnly = true;
            this.txtLocal.Size = new System.Drawing.Size(311, 22);
            this.txtLocal.TabIndex = 13;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(201, 95);
            this.txtDescricao.MaxLength = 255;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(544, 225);
            this.txtDescricao.TabIndex = 12;
            this.txtDescricao.Text = "";
            // 
            // txtResumoChamado
            // 
            this.txtResumoChamado.Location = new System.Drawing.Point(269, 38);
            this.txtResumoChamado.MaxLength = 30;
            this.txtResumoChamado.Name = "txtResumoChamado";
            this.txtResumoChamado.Size = new System.Drawing.Size(476, 22);
            this.txtResumoChamado.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(201, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Assunto:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(198, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "Descrição:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Local:";
            // 
            // cbSituacao
            // 
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Location = new System.Drawing.Point(15, 221);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(100, 24);
            this.cbSituacao.TabIndex = 7;
            this.cbSituacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbSituacao_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Situação:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Modelo/Equipamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Categoria do equipamento";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lupaToolStripMenuItem,
            this.msLimpar,
            this.msAjuda,
            this.msVoltar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msLimpar
            // 
            this.msLimpar.Name = "msLimpar";
            this.msLimpar.Size = new System.Drawing.Size(56, 20);
            this.msLimpar.Text = "Limpar";
            this.msLimpar.Click += new System.EventHandler(this.msLimpar_Click);
            // 
            // msAjuda
            // 
            this.msAjuda.Name = "msAjuda";
            this.msAjuda.Size = new System.Drawing.Size(50, 20);
            this.msAjuda.Text = "Ajuda";
            this.msAjuda.Click += new System.EventHandler(this.msAjuda_Click);
            // 
            // msVoltar
            // 
            this.msVoltar.Name = "msVoltar";
            this.msVoltar.Size = new System.Drawing.Size(49, 20);
            this.msVoltar.Text = "Voltar";
            this.msVoltar.Click += new System.EventHandler(this.msVoltar_Click);
            // 
            // lupaToolStripMenuItem
            // 
            this.lupaToolStripMenuItem.Name = "lupaToolStripMenuItem";
            this.lupaToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.lupaToolStripMenuItem.Text = "Lupa";
            this.lupaToolStripMenuItem.Click += new System.EventHandler(this.lupaToolStripMenuItem_Click);
            // 
            // AberturaChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AberturaChamado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abertura Chamado";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbCPFchamado;
        private System.Windows.Forms.RadioButton rbCNPJchamado;
        private System.Windows.Forms.TextBox txtCPFchamado;
        private System.Windows.Forms.TextBox txtCNPJchamado;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProtocolo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.TextBox txtResumoChamado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbSituacao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msLimpar;
        private System.Windows.Forms.ToolStripMenuItem msAjuda;
        private System.Windows.Forms.ToolStripMenuItem msVoltar;
        private System.Windows.Forms.RadioButton rbVisitaNao;
        private System.Windows.Forms.RadioButton rbVisitaSim;
        private System.Windows.Forms.Label lblVisitaTecnica;
        private System.Windows.Forms.ToolStripMenuItem lupaToolStripMenuItem;
    }
}