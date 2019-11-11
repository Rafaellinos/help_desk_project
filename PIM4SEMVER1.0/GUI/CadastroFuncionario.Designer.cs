namespace PIM4SEMVER1._0.GUI
{
    partial class CadastroFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFuncionario));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIdFuncionario = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.cmbDef = new System.Windows.Forms.ComboBox();
            this.lblDef = new System.Windows.Forms.Label();
            this.txtEmailFuncionario = new System.Windows.Forms.TextBox();
            this.txtTelefoneFuncionario = new System.Windows.Forms.TextBox();
            this.lblTelefoneFuncionario = new System.Windows.Forms.Label();
            this.txtCpfFuncionario = new System.Windows.Forms.TextBox();
            this.lblCPFFuncionario = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.lblCargoFuncionario = new System.Windows.Forms.Label();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.lblEmailFuncionario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSenhaFunc = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridFuncionarios = new System.Windows.Forms.DataGridView();
            this.btnExcluirFuncionario = new System.Windows.Forms.Button();
            this.btnAlterarFuncionario = new System.Windows.Forms.Button();
            this.btnVoltarMenu = new System.Windows.Forms.Button();
            this.btnLimparFuncionario = new System.Windows.Forms.Button();
            this.btnSalvarFuncionario = new System.Windows.Forms.Button();
            this.btnAtivar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIdFuncionario);
            this.groupBox2.Controls.Add(this.lbl_ID);
            this.groupBox2.Controls.Add(this.lblSituacao);
            this.groupBox2.Controls.Add(this.txtSituacao);
            this.groupBox2.Controls.Add(this.cmbDef);
            this.groupBox2.Controls.Add(this.lblDef);
            this.groupBox2.Controls.Add(this.txtEmailFuncionario);
            this.groupBox2.Controls.Add(this.txtTelefoneFuncionario);
            this.groupBox2.Controls.Add(this.lblTelefoneFuncionario);
            this.groupBox2.Controls.Add(this.txtCpfFuncionario);
            this.groupBox2.Controls.Add(this.lblCPFFuncionario);
            this.groupBox2.Controls.Add(this.cmbCargo);
            this.groupBox2.Controls.Add(this.lblCargoFuncionario);
            this.groupBox2.Controls.Add(this.txtNomeFuncionario);
            this.groupBox2.Controls.Add(this.lblNomeFuncionario);
            this.groupBox2.Controls.Add(this.lblEmailFuncionario);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 201);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações Pessoais";
            // 
            // txtIdFuncionario
            // 
            this.txtIdFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdFuncionario.Location = new System.Drawing.Point(552, 75);
            this.txtIdFuncionario.Name = "txtIdFuncionario";
            this.txtIdFuncionario.Size = new System.Drawing.Size(107, 22);
            this.txtIdFuncionario.TabIndex = 75;
            this.txtIdFuncionario.Visible = false;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(522, 78);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(24, 16);
            this.lbl_ID.TabIndex = 74;
            this.lbl_ID.Text = "ID:";
            this.lbl_ID.Visible = false;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.Location = new System.Drawing.Point(334, 162);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(64, 16);
            this.lblSituacao.TabIndex = 73;
            this.lblSituacao.Text = "Situação:";
            // 
            // txtSituacao
            // 
            this.txtSituacao.BackColor = System.Drawing.SystemColors.Window;
            this.txtSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSituacao.Location = new System.Drawing.Point(410, 159);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.ReadOnly = true;
            this.txtSituacao.Size = new System.Drawing.Size(133, 22);
            this.txtSituacao.TabIndex = 72;
            // 
            // cmbDef
            // 
            this.cmbDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDef.FormattingEnabled = true;
            this.cmbDef.Items.AddRange(new object[] {
            "SIM",
            "NAO"});
            this.cmbDef.Location = new System.Drawing.Point(410, 75);
            this.cmbDef.Name = "cmbDef";
            this.cmbDef.Size = new System.Drawing.Size(54, 23);
            this.cmbDef.TabIndex = 69;
            this.cmbDef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbDef_KeyPress);
            // 
            // lblDef
            // 
            this.lblDef.AutoSize = true;
            this.lblDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDef.Location = new System.Drawing.Point(327, 78);
            this.lblDef.Name = "lblDef";
            this.lblDef.Size = new System.Drawing.Size(71, 16);
            this.lblDef.TabIndex = 71;
            this.lblDef.Text = "Deficiente:";
            // 
            // txtEmailFuncionario
            // 
            this.txtEmailFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailFuncionario.Location = new System.Drawing.Point(410, 117);
            this.txtEmailFuncionario.Name = "txtEmailFuncionario";
            this.txtEmailFuncionario.Size = new System.Drawing.Size(352, 22);
            this.txtEmailFuncionario.TabIndex = 70;
            // 
            // txtTelefoneFuncionario
            // 
            this.txtTelefoneFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneFuncionario.Location = new System.Drawing.Point(78, 117);
            this.txtTelefoneFuncionario.Name = "txtTelefoneFuncionario";
            this.txtTelefoneFuncionario.Size = new System.Drawing.Size(106, 22);
            this.txtTelefoneFuncionario.TabIndex = 65;
            this.txtTelefoneFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefoneFuncionario_KeyPress_1);
            // 
            // lblTelefoneFuncionario
            // 
            this.lblTelefoneFuncionario.AutoSize = true;
            this.lblTelefoneFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneFuncionario.Location = new System.Drawing.Point(6, 120);
            this.lblTelefoneFuncionario.Name = "lblTelefoneFuncionario";
            this.lblTelefoneFuncionario.Size = new System.Drawing.Size(65, 16);
            this.lblTelefoneFuncionario.TabIndex = 66;
            this.lblTelefoneFuncionario.Text = "Telefone:";
            // 
            // txtCpfFuncionario
            // 
            this.txtCpfFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfFuncionario.Location = new System.Drawing.Point(77, 75);
            this.txtCpfFuncionario.Name = "txtCpfFuncionario";
            this.txtCpfFuncionario.Size = new System.Drawing.Size(107, 22);
            this.txtCpfFuncionario.TabIndex = 63;
            // 
            // lblCPFFuncionario
            // 
            this.lblCPFFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFFuncionario.Location = new System.Drawing.Point(23, 78);
            this.lblCPFFuncionario.Name = "lblCPFFuncionario";
            this.lblCPFFuncionario.Size = new System.Drawing.Size(48, 17);
            this.lblCPFFuncionario.TabIndex = 64;
            this.lblCPFFuncionario.Text = "CPF:";
            this.lblCPFFuncionario.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbCargo
            // 
            this.cmbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Items.AddRange(new object[] {
            "Operador",
            "Admin",
            "Técnico"});
            this.cmbCargo.Location = new System.Drawing.Point(78, 159);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(106, 24);
            this.cmbCargo.TabIndex = 68;
            this.cmbCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCargo_KeyPress);
            // 
            // lblCargoFuncionario
            // 
            this.lblCargoFuncionario.AutoSize = true;
            this.lblCargoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargoFuncionario.Location = new System.Drawing.Point(23, 162);
            this.lblCargoFuncionario.Name = "lblCargoFuncionario";
            this.lblCargoFuncionario.Size = new System.Drawing.Size(48, 16);
            this.lblCargoFuncionario.TabIndex = 62;
            this.lblCargoFuncionario.Text = "Cargo:";
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFuncionario.Location = new System.Drawing.Point(78, 32);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(684, 22);
            this.txtNomeFuncionario.TabIndex = 61;
            this.txtNomeFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeFuncionario_KeyPress_1);
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFuncionario.Location = new System.Drawing.Point(23, 35);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(48, 16);
            this.lblNomeFuncionario.TabIndex = 60;
            this.lblNomeFuncionario.Text = "Nome:";
            // 
            // lblEmailFuncionario
            // 
            this.lblEmailFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailFuncionario.Location = new System.Drawing.Point(338, 120);
            this.lblEmailFuncionario.Name = "lblEmailFuncionario";
            this.lblEmailFuncionario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEmailFuncionario.Size = new System.Drawing.Size(60, 16);
            this.lblEmailFuncionario.TabIndex = 67;
            this.lblEmailFuncionario.Text = "E-mail:";
            this.lblEmailFuncionario.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSenhaFunc);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 65);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações de Login";
            // 
            // txtSenhaFunc
            // 
            this.txtSenhaFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaFunc.Location = new System.Drawing.Point(410, 27);
            this.txtSenhaFunc.Name = "txtSenhaFunc";
            this.txtSenhaFunc.Size = new System.Drawing.Size(184, 22);
            this.txtSenhaFunc.TabIndex = 3;
            this.txtSenhaFunc.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(77, 27);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(184, 22);
            this.txtUser.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(348, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // gridFuncionarios
            // 
            this.gridFuncionarios.AllowUserToAddRows = false;
            this.gridFuncionarios.AllowUserToDeleteRows = false;
            this.gridFuncionarios.AllowUserToResizeColumns = false;
            this.gridFuncionarios.AllowUserToResizeRows = false;
            this.gridFuncionarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFuncionarios.ColumnHeadersVisible = false;
            this.gridFuncionarios.Location = new System.Drawing.Point(27, 299);
            this.gridFuncionarios.MultiSelect = false;
            this.gridFuncionarios.Name = "gridFuncionarios";
            this.gridFuncionarios.ReadOnly = true;
            this.gridFuncionarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFuncionarios.Size = new System.Drawing.Size(760, 245);
            this.gridFuncionarios.TabIndex = 57;
            this.gridFuncionarios.TabStop = false;
            this.gridFuncionarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFuncionarios_CellClick_1);
            // 
            // btnExcluirFuncionario
            // 
            this.btnExcluirFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirFuncionario.Location = new System.Drawing.Point(438, 568);
            this.btnExcluirFuncionario.Name = "btnExcluirFuncionario";
            this.btnExcluirFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirFuncionario.TabIndex = 61;
            this.btnExcluirFuncionario.Text = "Desativar";
            this.btnExcluirFuncionario.UseVisualStyleBackColor = true;
            this.btnExcluirFuncionario.Click += new System.EventHandler(this.btnExcluirFuncionario_Click);
            // 
            // btnAlterarFuncionario
            // 
            this.btnAlterarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarFuncionario.Location = new System.Drawing.Point(164, 566);
            this.btnAlterarFuncionario.Name = "btnAlterarFuncionario";
            this.btnAlterarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarFuncionario.TabIndex = 59;
            this.btnAlterarFuncionario.Text = "Alterar";
            this.btnAlterarFuncionario.UseVisualStyleBackColor = true;
            this.btnAlterarFuncionario.Click += new System.EventHandler(this.btnAlterarFuncionario_Click);
            // 
            // btnVoltarMenu
            // 
            this.btnVoltarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarMenu.Location = new System.Drawing.Point(705, 567);
            this.btnVoltarMenu.Name = "btnVoltarMenu";
            this.btnVoltarMenu.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarMenu.TabIndex = 62;
            this.btnVoltarMenu.Text = "Voltar";
            this.btnVoltarMenu.UseVisualStyleBackColor = true;
            this.btnVoltarMenu.Click += new System.EventHandler(this.btnVoltarMenu_Click);
            // 
            // btnLimparFuncionario
            // 
            this.btnLimparFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparFuncionario.Location = new System.Drawing.Point(300, 566);
            this.btnLimparFuncionario.Name = "btnLimparFuncionario";
            this.btnLimparFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnLimparFuncionario.TabIndex = 60;
            this.btnLimparFuncionario.Text = "Limpar";
            this.btnLimparFuncionario.UseVisualStyleBackColor = true;
            this.btnLimparFuncionario.Click += new System.EventHandler(this.btnLimparFuncionario_Click);
            // 
            // btnSalvarFuncionario
            // 
            this.btnSalvarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarFuncionario.Location = new System.Drawing.Point(35, 566);
            this.btnSalvarFuncionario.Name = "btnSalvarFuncionario";
            this.btnSalvarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarFuncionario.TabIndex = 58;
            this.btnSalvarFuncionario.Text = "Salvar";
            this.btnSalvarFuncionario.UseVisualStyleBackColor = true;
            this.btnSalvarFuncionario.Click += new System.EventHandler(this.btnSalvarFuncionario_Click);
            // 
            // btnAtivar
            // 
            this.btnAtivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtivar.Location = new System.Drawing.Point(570, 568);
            this.btnAtivar.Name = "btnAtivar";
            this.btnAtivar.Size = new System.Drawing.Size(75, 23);
            this.btnAtivar.TabIndex = 65;
            this.btnAtivar.Text = "Ativar";
            this.btnAtivar.UseVisualStyleBackColor = true;
            this.btnAtivar.Click += new System.EventHandler(this.btnAtivar_Click);
            // 
            // CadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 603);
            this.Controls.Add(this.btnAtivar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridFuncionarios);
            this.Controls.Add(this.btnExcluirFuncionario);
            this.Controls.Add(this.btnAlterarFuncionario);
            this.Controls.Add(this.btnVoltarMenu);
            this.Controls.Add(this.btnLimparFuncionario);
            this.Controls.Add(this.btnSalvarFuncionario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Funcionários";
            this.Load += new System.EventHandler(this.CadastroFuncionario_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIdFuncionario;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.ComboBox cmbDef;
        private System.Windows.Forms.Label lblDef;
        private System.Windows.Forms.TextBox txtEmailFuncionario;
        private System.Windows.Forms.TextBox txtTelefoneFuncionario;
        private System.Windows.Forms.Label lblTelefoneFuncionario;
        private System.Windows.Forms.TextBox txtCpfFuncionario;
        private System.Windows.Forms.Label lblCPFFuncionario;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Label lblCargoFuncionario;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.Label lblEmailFuncionario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSenhaFunc;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridFuncionarios;
        private System.Windows.Forms.Button btnExcluirFuncionario;
        private System.Windows.Forms.Button btnAlterarFuncionario;
        private System.Windows.Forms.Button btnVoltarMenu;
        private System.Windows.Forms.Button btnLimparFuncionario;
        private System.Windows.Forms.Button btnSalvarFuncionario;
        private System.Windows.Forms.Button btnAtivar;
    }
}