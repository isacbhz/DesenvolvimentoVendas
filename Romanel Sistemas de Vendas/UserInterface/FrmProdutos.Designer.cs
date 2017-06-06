namespace View
{
    partial class FrmProdutos
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
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.cbxFam = new System.Windows.Forms.ComboBox();
            this.lblFam = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.lblFormato = new System.Windows.Forms.Label();
            this.cbxFormato = new System.Windows.Forms.ComboBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.cbxGrupo = new System.Windows.Forms.ComboBox();
            this.txtCodRom = new System.Windows.Forms.TextBox();
            this.lblCodRom = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.dtpDataCad = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnSai = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.grbPreco = new System.Windows.Forms.GroupBox();
            this.txtVlrVenda = new System.Windows.Forms.TextBox();
            this.txtPercLuc = new System.Windows.Forms.TextBox();
            this.lblPrecVen = new System.Windows.Forms.Label();
            this.lblPercLuc = new System.Windows.Forms.Label();
            this.txtVlrComp = new System.Windows.Forms.TextBox();
            this.lblPrecCom = new System.Windows.Forms.Label();
            this.grbPreco.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(13, 324);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(94, 50);
            this.btnCadastro.TabIndex = 15;
            this.btnCadastro.Text = "&Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(132, 324);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(94, 50);
            this.btnLimpa.TabIndex = 16;
            this.btnLimpa.Text = "&Limpar Campos";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.Location = new System.Drawing.Point(251, 324);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(94, 50);
            this.btnCancela.TabIndex = 17;
            this.btnCancela.Text = "C&ancelar";
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(370, 324);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(94, 50);
            this.btnConsulta.TabIndex = 18;
            this.btnConsulta.Text = "C&onsultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            // 
            // cbxFam
            // 
            this.cbxFam.AccessibleName = "Família";
            this.cbxFam.FormattingEnabled = true;
            this.cbxFam.Location = new System.Drawing.Point(182, 37);
            this.cbxFam.Name = "cbxFam";
            this.cbxFam.Size = new System.Drawing.Size(151, 21);
            this.cbxFam.TabIndex = 3;
            this.cbxFam.Visible = false;
            // 
            // lblFam
            // 
            this.lblFam.AutoSize = true;
            this.lblFam.Location = new System.Drawing.Point(182, 18);
            this.lblFam.Name = "lblFam";
            this.lblFam.Size = new System.Drawing.Size(41, 13);
            this.lblFam.TabIndex = 2;
            this.lblFam.Text = "Família";
            this.lblFam.Visible = false;
            // 
            // cbxTipo
            // 
            this.cbxTipo.AccessibleName = "Tipo";
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(355, 37);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(141, 21);
            this.cbxTipo.TabIndex = 5;
            this.cbxTipo.Visible = false;
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Location = new System.Drawing.Point(185, 90);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(45, 13);
            this.lblFormato.TabIndex = 8;
            this.lblFormato.Text = "Formato";
            this.lblFormato.Visible = false;
            // 
            // cbxFormato
            // 
            this.cbxFormato.AccessibleName = "Formato";
            this.cbxFormato.FormattingEnabled = true;
            this.cbxFormato.Location = new System.Drawing.Point(185, 109);
            this.cbxFormato.Name = "cbxFormato";
            this.cbxFormato.Size = new System.Drawing.Size(148, 21);
            this.cbxFormato.TabIndex = 9;
            this.cbxFormato.Visible = false;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(12, 90);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(36, 13);
            this.lblGrupo.TabIndex = 6;
            this.lblGrupo.Text = "Grupo";
            this.lblGrupo.Visible = false;
            // 
            // cbxGrupo
            // 
            this.cbxGrupo.AccessibleName = "Grupo";
            this.cbxGrupo.FormattingEnabled = true;
            this.cbxGrupo.Location = new System.Drawing.Point(12, 109);
            this.cbxGrupo.Name = "cbxGrupo";
            this.cbxGrupo.Size = new System.Drawing.Size(147, 21);
            this.cbxGrupo.TabIndex = 7;
            this.cbxGrupo.Visible = false;
            // 
            // txtCodRom
            // 
            this.txtCodRom.AccessibleName = "Código Romanel";
            this.txtCodRom.Location = new System.Drawing.Point(12, 38);
            this.txtCodRom.Name = "txtCodRom";
            this.txtCodRom.Size = new System.Drawing.Size(150, 20);
            this.txtCodRom.TabIndex = 1;
            this.txtCodRom.Visible = false;
            // 
            // lblCodRom
            // 
            this.lblCodRom.AutoSize = true;
            this.lblCodRom.Location = new System.Drawing.Point(12, 18);
            this.lblCodRom.Name = "lblCodRom";
            this.lblCodRom.Size = new System.Drawing.Size(85, 13);
            this.lblCodRom.TabIndex = 0;
            this.lblCodRom.Text = "Código Romanel";
            this.lblCodRom.Visible = false;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(358, 90);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(107, 13);
            this.lblDesc.TabIndex = 10;
            this.lblDesc.Text = "Descrição Detalhada";
            this.lblDesc.Visible = false;
            // 
            // dtpDataCad
            // 
            this.dtpDataCad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCad.Location = new System.Drawing.Point(12, 170);
            this.dtpDataCad.Name = "dtpDataCad";
            this.dtpDataCad.Size = new System.Drawing.Size(118, 20);
            this.dtpDataCad.TabIndex = 13;
            this.dtpDataCad.Visible = false;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(12, 151);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(75, 13);
            this.lblData.TabIndex = 12;
            this.lblData.Text = "Data Cadastro";
            this.lblData.Visible = false;
            // 
            // txtDesc
            // 
            this.txtDesc.AccessibleName = "Descrição";
            this.txtDesc.Location = new System.Drawing.Point(361, 109);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(220, 100);
            this.txtDesc.TabIndex = 11;
            this.txtDesc.Visible = false;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // btnSai
            // 
            this.btnSai.Location = new System.Drawing.Point(489, 324);
            this.btnSai.Name = "btnSai";
            this.btnSai.Size = new System.Drawing.Size(94, 50);
            this.btnSai.TabIndex = 19;
            this.btnSai.Text = "&Sair";
            this.btnSai.UseVisualStyleBackColor = true;
            this.btnSai.Click += new System.EventHandler(this.btnSai_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(352, 18);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo";
            this.lblTipo.Visible = false;
            // 
            // grbPreco
            // 
            this.grbPreco.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.grbPreco.Controls.Add(this.txtVlrVenda);
            this.grbPreco.Controls.Add(this.txtPercLuc);
            this.grbPreco.Controls.Add(this.lblPrecVen);
            this.grbPreco.Controls.Add(this.lblPercLuc);
            this.grbPreco.Controls.Add(this.txtVlrComp);
            this.grbPreco.Controls.Add(this.lblPrecCom);
            this.grbPreco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grbPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPreco.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grbPreco.Location = new System.Drawing.Point(44, 230);
            this.grbPreco.Name = "grbPreco";
            this.grbPreco.Size = new System.Drawing.Size(514, 77);
            this.grbPreco.TabIndex = 14;
            this.grbPreco.TabStop = false;
            this.grbPreco.Text = "Preços";
            this.grbPreco.Enter += new System.EventHandler(this.grbPreco_Enter);
            // 
            // txtVlrVenda
            // 
            this.txtVlrVenda.AccessibleName = "Valor de Venda";
            this.txtVlrVenda.Location = new System.Drawing.Point(382, 36);
            this.txtVlrVenda.Name = "txtVlrVenda";
            this.txtVlrVenda.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtVlrVenda.Size = new System.Drawing.Size(120, 20);
            this.txtVlrVenda.TabIndex = 5;
            this.txtVlrVenda.Text = "0,00";
            this.txtVlrVenda.Click += new System.EventHandler(this.txtVlrVenda_Click);
            this.txtVlrVenda.TextChanged += new System.EventHandler(this.txtVlrVenda_TextChanged);
            // 
            // txtPercLuc
            // 
            this.txtPercLuc.AccessibleName = "Percentual Lucro";
            this.txtPercLuc.Location = new System.Drawing.Point(198, 36);
            this.txtPercLuc.MaxLength = 3;
            this.txtPercLuc.Name = "txtPercLuc";
            this.txtPercLuc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPercLuc.Size = new System.Drawing.Size(120, 20);
            this.txtPercLuc.TabIndex = 3;
            this.txtPercLuc.Text = "%";
            this.txtPercLuc.TextChanged += new System.EventHandler(this.txtPercLuc_TextChanged);
            // 
            // lblPrecVen
            // 
            this.lblPrecVen.AutoSize = true;
            this.lblPrecVen.Location = new System.Drawing.Point(379, 20);
            this.lblPrecVen.Name = "lblPrecVen";
            this.lblPrecVen.Size = new System.Drawing.Size(103, 13);
            this.lblPrecVen.TabIndex = 4;
            this.lblPrecVen.Text = "Valor de Venda (R$)";
            // 
            // lblPercLuc
            // 
            this.lblPercLuc.AutoSize = true;
            this.lblPercLuc.Location = new System.Drawing.Point(195, 20);
            this.lblPercLuc.Name = "lblPercLuc";
            this.lblPercLuc.Size = new System.Drawing.Size(102, 13);
            this.lblPercLuc.TabIndex = 2;
            this.lblPercLuc.Text = "Percentual Lucro(%)";
            // 
            // txtVlrComp
            // 
            this.txtVlrComp.AccessibleName = "Valor de Compra";
            this.txtVlrComp.Location = new System.Drawing.Point(14, 36);
            this.txtVlrComp.Name = "txtVlrComp";
            this.txtVlrComp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtVlrComp.Size = new System.Drawing.Size(120, 20);
            this.txtVlrComp.TabIndex = 1;
            this.txtVlrComp.Text = "0,00";
            this.txtVlrComp.TextChanged += new System.EventHandler(this.txtVlrComp_TextChanged);
            // 
            // lblPrecCom
            // 
            this.lblPrecCom.AutoSize = true;
            this.lblPrecCom.Location = new System.Drawing.Point(11, 20);
            this.lblPrecCom.Name = "lblPrecCom";
            this.lblPrecCom.Size = new System.Drawing.Size(108, 13);
            this.lblPrecCom.TabIndex = 0;
            this.lblPrecCom.Text = "Valor de Compra (R$)";
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 403);
            this.Controls.Add(this.grbPreco);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnSai);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.dtpDataCad);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblCodRom);
            this.Controls.Add(this.txtCodRom);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.cbxGrupo);
            this.Controls.Add(this.lblFormato);
            this.Controls.Add(this.cbxFormato);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.lblFam);
            this.Controls.Add(this.cbxFam);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnCadastro);
            this.Name = "FrmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Produto";
            this.Load += new System.EventHandler(this.cbxTipo_Load);
            this.grbPreco.ResumeLayout(false);
            this.grbPreco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.ComboBox cbxFam;
        private System.Windows.Forms.Label lblFam;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.ComboBox cbxFormato;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.ComboBox cbxGrupo;
        private System.Windows.Forms.TextBox txtCodRom;
        private System.Windows.Forms.Label lblCodRom;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.DateTimePicker dtpDataCad;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnSai;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.GroupBox grbPreco;
        private System.Windows.Forms.Label lblPrecVen;
        private System.Windows.Forms.Label lblPercLuc;
        private System.Windows.Forms.TextBox txtVlrComp;
        private System.Windows.Forms.Label lblPrecCom;
        private System.Windows.Forms.TextBox txtPercLuc;
        private System.Windows.Forms.TextBox txtVlrVenda;
    }
}