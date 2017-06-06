namespace View
{
    partial class FrmCliePesJur
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
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.txtCompEnd = new System.Windows.Forms.TextBox();
            this.lblCompl = new System.Windows.Forms.Label();
            this.txtNumEnd = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtRazSoc = new System.Windows.Forms.TextBox();
            this.lblRazSoc = new System.Windows.Forms.Label();
            this.txtInscEst = new System.Windows.Forms.TextBox();
            this.lblInscEst = new System.Windows.Forms.Label();
            this.dtpFund = new System.Windows.Forms.DateTimePicker();
            this.lblFund = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtCodCliente.Location = new System.Drawing.Point(53, 51);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.ReadOnly = true;
            this.txtCodCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCodCliente.TabIndex = 28;
            this.txtCodCliente.TabStop = false;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(53, 35);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(75, 13);
            this.lblCod.TabIndex = 29;
            this.lblCod.Text = "Código Cliente";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(362, 327);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(129, 51);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(209, 327);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 51);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(515, 327);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(129, 51);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(56, 327);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(129, 51);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(53, 199);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(211, 20);
            this.txtEndereco.TabIndex = 6;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(53, 183);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(53, 13);
            this.lblEnd.TabIndex = 22;
            this.lblEnd.Text = "Endereço";
            // 
            // txtCompEnd
            // 
            this.txtCompEnd.Location = new System.Drawing.Point(487, 199);
            this.txtCompEnd.Name = "txtCompEnd";
            this.txtCompEnd.Size = new System.Drawing.Size(166, 20);
            this.txtCompEnd.TabIndex = 8;
            // 
            // lblCompl
            // 
            this.lblCompl.AutoSize = true;
            this.lblCompl.Location = new System.Drawing.Point(487, 183);
            this.lblCompl.Name = "lblCompl";
            this.lblCompl.Size = new System.Drawing.Size(71, 13);
            this.lblCompl.TabIndex = 24;
            this.lblCompl.Text = "Complemento";
            // 
            // txtNumEnd
            // 
            this.txtNumEnd.Location = new System.Drawing.Point(306, 199);
            this.txtNumEnd.Name = "txtNumEnd";
            this.txtNumEnd.Size = new System.Drawing.Size(100, 20);
            this.txtNumEnd.TabIndex = 7;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(306, 183);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(44, 13);
            this.lblNum.TabIndex = 23;
            this.lblNum.Text = "Número";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(487, 256);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 11;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(487, 240);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 27;
            this.lblEstado.Text = "Estado";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(53, 256);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(156, 20);
            this.txtBairro.TabIndex = 9;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(53, 240);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 25;
            this.lblBairro.Text = "Bairro";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(306, 256);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(130, 20);
            this.txtCidade.TabIndex = 10;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(306, 240);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 26;
            this.lblCidade.Text = "Cidade";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(306, 104);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(119, 20);
            this.txtTelefone.TabIndex = 1;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(306, 88);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 17;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(487, 104);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(126, 20);
            this.txtCnpj.TabIndex = 2;
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Location = new System.Drawing.Point(487, 88);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(34, 13);
            this.lblCnpj.TabIndex = 18;
            this.lblCnpj.Text = "CNPJ";
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Location = new System.Drawing.Point(53, 104);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(211, 20);
            this.txtNomeFantasia.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(53, 88);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(78, 13);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "Nome Fantasia";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // txtRazSoc
            // 
            this.txtRazSoc.Location = new System.Drawing.Point(53, 154);
            this.txtRazSoc.Name = "txtRazSoc";
            this.txtRazSoc.Size = new System.Drawing.Size(211, 20);
            this.txtRazSoc.TabIndex = 3;
            // 
            // lblRazSoc
            // 
            this.lblRazSoc.AutoSize = true;
            this.lblRazSoc.Location = new System.Drawing.Point(53, 138);
            this.lblRazSoc.Name = "lblRazSoc";
            this.lblRazSoc.Size = new System.Drawing.Size(70, 13);
            this.lblRazSoc.TabIndex = 19;
            this.lblRazSoc.Text = "Razão Social";
            // 
            // txtInscEst
            // 
            this.txtInscEst.Location = new System.Drawing.Point(306, 154);
            this.txtInscEst.Name = "txtInscEst";
            this.txtInscEst.Size = new System.Drawing.Size(154, 20);
            this.txtInscEst.TabIndex = 4;
            // 
            // lblInscEst
            // 
            this.lblInscEst.AutoSize = true;
            this.lblInscEst.Location = new System.Drawing.Point(306, 138);
            this.lblInscEst.Name = "lblInscEst";
            this.lblInscEst.Size = new System.Drawing.Size(94, 13);
            this.lblInscEst.TabIndex = 20;
            this.lblInscEst.Text = "Inscrição Estadual";
            // 
            // dtpFund
            // 
            this.dtpFund.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFund.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.dtpFund.Location = new System.Drawing.Point(487, 154);
            this.dtpFund.Name = "dtpFund";
            this.dtpFund.Size = new System.Drawing.Size(126, 20);
            this.dtpFund.TabIndex = 5;
            this.dtpFund.Value = new System.DateTime(2017, 5, 20, 17, 14, 12, 0);
            // 
            // lblFund
            // 
            this.lblFund.AutoSize = true;
            this.lblFund.Location = new System.Drawing.Point(487, 138);
            this.lblFund.Name = "lblFund";
            this.lblFund.Size = new System.Drawing.Size(81, 13);
            this.lblFund.TabIndex = 21;
            this.lblFund.Text = "Data Fundação";
            // 
            // FrmCliePesJur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(713, 426);
            this.ControlBox = false;
            this.Controls.Add(this.lblFund);
            this.Controls.Add(this.dtpFund);
            this.Controls.Add(this.txtInscEst);
            this.Controls.Add(this.lblInscEst);
            this.Controls.Add(this.txtRazSoc);
            this.Controls.Add(this.lblRazSoc);
            this.Controls.Add(this.txtCodCliente);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.txtCompEnd);
            this.Controls.Add(this.lblCompl);
            this.Controls.Add(this.txtNumEnd);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.txtNomeFantasia);
            this.Controls.Add(this.lblNome);
            this.MaximizeBox = false;
            this.Name = "FrmCliePesJur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Cliente - Pessoa Jurídica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.TextBox txtCompEnd;
        private System.Windows.Forms.Label lblCompl;
        private System.Windows.Forms.TextBox txtNumEnd;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtRazSoc;
        private System.Windows.Forms.Label lblRazSoc;
        private System.Windows.Forms.TextBox txtInscEst;
        private System.Windows.Forms.Label lblInscEst;
        private System.Windows.Forms.DateTimePicker dtpFund;
        private System.Windows.Forms.Label lblFund;
    }
}