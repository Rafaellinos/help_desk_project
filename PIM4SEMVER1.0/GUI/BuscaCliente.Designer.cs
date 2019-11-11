namespace PIM4SEMVER1._0.GUI
{
    partial class BuscaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscaCliente));
            this.label9 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVprotocolos = new System.Windows.Forms.DataGridView();
            this.rbCPFchamado = new System.Windows.Forms.RadioButton();
            this.rbCNPJchamado = new System.Windows.Forms.RadioButton();
            this.txtCPFchamado = new System.Windows.Forms.TextBox();
            this.txtCNPJchamado = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGVprotocolos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(684, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Status:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(318, 129);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 59;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(26, 129);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 58;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(585, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Nome funcionário:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(486, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Resumo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Equipamento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Hora do chamado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Data do chamado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Nome Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Protocolo:";
            // 
            // DGVprotocolos
            // 
            this.DGVprotocolos.AllowUserToAddRows = false;
            this.DGVprotocolos.AllowUserToDeleteRows = false;
            this.DGVprotocolos.AllowUserToResizeColumns = false;
            this.DGVprotocolos.AllowUserToResizeRows = false;
            this.DGVprotocolos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVprotocolos.ColumnHeadersVisible = false;
            this.DGVprotocolos.Location = new System.Drawing.Point(13, 198);
            this.DGVprotocolos.MultiSelect = false;
            this.DGVprotocolos.Name = "DGVprotocolos";
            this.DGVprotocolos.ReadOnly = true;
            this.DGVprotocolos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVprotocolos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVprotocolos.Size = new System.Drawing.Size(815, 266);
            this.DGVprotocolos.TabIndex = 50;
            // 
            // rbCPFchamado
            // 
            this.rbCPFchamado.AutoSize = true;
            this.rbCPFchamado.Location = new System.Drawing.Point(26, 54);
            this.rbCPFchamado.Name = "rbCPFchamado";
            this.rbCPFchamado.Size = new System.Drawing.Size(45, 17);
            this.rbCPFchamado.TabIndex = 49;
            this.rbCPFchamado.TabStop = true;
            this.rbCPFchamado.Text = "CPF";
            this.rbCPFchamado.UseVisualStyleBackColor = true;
            this.rbCPFchamado.CheckedChanged += new System.EventHandler(this.rbCPFchamado_CheckedChanged);
            // 
            // rbCNPJchamado
            // 
            this.rbCNPJchamado.AutoSize = true;
            this.rbCNPJchamado.Location = new System.Drawing.Point(26, 80);
            this.rbCNPJchamado.Name = "rbCNPJchamado";
            this.rbCNPJchamado.Size = new System.Drawing.Size(52, 17);
            this.rbCNPJchamado.TabIndex = 48;
            this.rbCNPJchamado.TabStop = true;
            this.rbCNPJchamado.Text = "CNPJ";
            this.rbCNPJchamado.UseVisualStyleBackColor = true;
            this.rbCNPJchamado.CheckedChanged += new System.EventHandler(this.rbCNPJchamado_CheckedChanged);
            // 
            // txtCPFchamado
            // 
            this.txtCPFchamado.Enabled = false;
            this.txtCPFchamado.Location = new System.Drawing.Point(106, 53);
            this.txtCPFchamado.MaxLength = 11;
            this.txtCPFchamado.Name = "txtCPFchamado";
            this.txtCPFchamado.Size = new System.Drawing.Size(287, 20);
            this.txtCPFchamado.TabIndex = 47;
            this.txtCPFchamado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPFchamado_KeyPress);
            // 
            // txtCNPJchamado
            // 
            this.txtCNPJchamado.Enabled = false;
            this.txtCNPJchamado.Location = new System.Drawing.Point(106, 84);
            this.txtCNPJchamado.MaxLength = 14;
            this.txtCNPJchamado.Name = "txtCNPJchamado";
            this.txtCNPJchamado.Size = new System.Drawing.Size(287, 20);
            this.txtCNPJchamado.TabIndex = 46;
            this.txtCNPJchamado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCNPJchamado_KeyPress);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(124, 129);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 45;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(223, 129);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 44;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Digite o CPF ou CNPJ do cliente:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(785, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "Visita:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
            this.menuStrip1.TabIndex = 62;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // BuscaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 482);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGVprotocolos);
            this.Controls.Add(this.rbCPFchamado);
            this.Controls.Add(this.rbCNPJchamado);
            this.Controls.Add(this.txtCPFchamado);
            this.Controls.Add(this.txtCNPJchamado);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuscaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Chamado";
            ((System.ComponentModel.ISupportInitialize)(this.DGVprotocolos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVprotocolos;
        private System.Windows.Forms.RadioButton rbCPFchamado;
        private System.Windows.Forms.RadioButton rbCNPJchamado;
        private System.Windows.Forms.TextBox txtCPFchamado;
        private System.Windows.Forms.TextBox txtCNPJchamado;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
    }
}