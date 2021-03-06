﻿namespace SistemaEscola.Formulários.Admin.Matricula
{
    partial class MatricularAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatricularAluno));
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.grpbEnd = new System.Windows.Forms.GroupBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.grpbDadosAluno = new System.Windows.Forms.GroupBox();
            this.grpbDadosCurso = new System.Windows.Forms.GroupBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.lblTurma = new System.Windows.Forms.Label();
            this.cmbTurma = new System.Windows.Forms.ComboBox();
            this.txtLoginNumId = new System.Windows.Forms.MaskedTextBox();
            this.txtLoginAno = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLoginNumAleat = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.MaskedTextBox();
            this.txtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.grpbEnd.SuspendLayout();
            this.grpbDadosAluno.SuspendLayout();
            this.grpbDadosCurso.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(63, 87);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(342, 24);
            this.cmbCurso.TabIndex = 82;
            this.cmbCurso.SelectedIndexChanged += new System.EventHandler(this.cmbCurso_SelectionChangeCommitted);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(11, 30);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 16);
            this.lblTipo.TabIndex = 9;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(11, 90);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(46, 16);
            this.lblCurso.TabIndex = 8;
            this.lblCurso.Text = "Curso:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(54, 27);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(351, 24);
            this.cmbTipo.TabIndex = 81;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectionChangeCommitted);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(77, 516);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(96, 40);
            this.btnSalvar.TabIndex = 84;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(271, 516);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(96, 40);
            this.btnLimpar.TabIndex = 85;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(256, 88);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(144, 22);
            this.txtCPF.TabIndex = 70;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(220, 89);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(37, 16);
            this.lblCPF.TabIndex = 55;
            this.lblCPF.Text = "CPF:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(63, 89);
            this.txtEmail.MaxLength = 45;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(151, 22);
            this.txtEmail.TabIndex = 68;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(81, 59);
            this.txtTelefone.Mask = "(00) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(133, 22);
            this.txtTelefone.TabIndex = 67;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(63, 29);
            this.txtNome.MaxLength = 45;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(151, 22);
            this.txtNome.TabIndex = 66;
            // 
            // grpbEnd
            // 
            this.grpbEnd.Controls.Add(this.txtCidade);
            this.grpbEnd.Controls.Add(this.txtEstado);
            this.grpbEnd.Controls.Add(this.txtCEP);
            this.grpbEnd.Controls.Add(this.txtNum);
            this.grpbEnd.Controls.Add(this.txtBairro);
            this.grpbEnd.Controls.Add(this.txtRua);
            this.grpbEnd.Controls.Add(this.lblCEP);
            this.grpbEnd.Controls.Add(this.lblCidade);
            this.grpbEnd.Controls.Add(this.lblEstado);
            this.grpbEnd.Controls.Add(this.lblNum);
            this.grpbEnd.Controls.Add(this.lblBairro);
            this.grpbEnd.Controls.Add(this.lblRua);
            this.grpbEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbEnd.Location = new System.Drawing.Point(15, 117);
            this.grpbEnd.Name = "grpbEnd";
            this.grpbEnd.Size = new System.Drawing.Size(390, 114);
            this.grpbEnd.TabIndex = 71;
            this.grpbEnd.TabStop = false;
            this.grpbEnd.Text = "Endereço";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(258, 49);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(127, 22);
            this.txtCidade.TabIndex = 76;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(257, 21);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(127, 22);
            this.txtEstado.TabIndex = 75;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(231, 81);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(153, 22);
            this.txtCEP.TabIndex = 77;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(91, 81);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 22);
            this.txtNum.TabIndex = 74;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(80, 49);
            this.txtBairro.MaxLength = 25;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(111, 22);
            this.txtBairro.TabIndex = 73;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(70, 21);
            this.txtRua.MaxLength = 45;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(121, 22);
            this.txtRua.TabIndex = 72;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(197, 84);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(38, 16);
            this.lblCEP.TabIndex = 29;
            this.lblCEP.Text = "CEP:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(197, 52);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(55, 16);
            this.lblCidade.TabIndex = 28;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(197, 24);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(54, 16);
            this.lblEstado.TabIndex = 26;
            this.lblEstado.Text = "Estado:";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(37, 84);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(59, 16);
            this.lblNum.TabIndex = 24;
            this.lblNum.Text = "Número:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(37, 52);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(47, 16);
            this.lblBairro.TabIndex = 23;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.Location = new System.Drawing.Point(37, 24);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(36, 16);
            this.lblRua.TabIndex = 22;
            this.lblRua.Text = "Rua:";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNasc.Location = new System.Drawing.Point(220, 29);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(134, 16);
            this.lblDataNasc.TabIndex = 45;
            this.lblDataNasc.Text = "Data de Nascimento:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(13, 90);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 16);
            this.lblEmail.TabIndex = 44;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(13, 60);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(65, 16);
            this.lblTelefone.TabIndex = 43;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(13, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 16);
            this.lblNome.TabIndex = 42;
            this.lblNome.Text = "Nome:";
            // 
            // grpbDadosAluno
            // 
            this.grpbDadosAluno.Controls.Add(this.txtDataNasc);
            this.grpbDadosAluno.Controls.Add(this.grpbEnd);
            this.grpbDadosAluno.Controls.Add(this.lblNome);
            this.grpbDadosAluno.Controls.Add(this.lblTelefone);
            this.grpbDadosAluno.Controls.Add(this.lblEmail);
            this.grpbDadosAluno.Controls.Add(this.txtCPF);
            this.grpbDadosAluno.Controls.Add(this.lblDataNasc);
            this.grpbDadosAluno.Controls.Add(this.lblCPF);
            this.grpbDadosAluno.Controls.Add(this.txtNome);
            this.grpbDadosAluno.Controls.Add(this.txtTelefone);
            this.grpbDadosAluno.Controls.Add(this.txtEmail);
            this.grpbDadosAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbDadosAluno.Location = new System.Drawing.Point(12, 87);
            this.grpbDadosAluno.Name = "grpbDadosAluno";
            this.grpbDadosAluno.Size = new System.Drawing.Size(420, 240);
            this.grpbDadosAluno.TabIndex = 65;
            this.grpbDadosAluno.TabStop = false;
            this.grpbDadosAluno.Text = "Dados do aluno";
            // 
            // grpbDadosCurso
            // 
            this.grpbDadosCurso.Controls.Add(this.lblTurno);
            this.grpbDadosCurso.Controls.Add(this.cmbTurno);
            this.grpbDadosCurso.Controls.Add(this.lblTurma);
            this.grpbDadosCurso.Controls.Add(this.cmbTurma);
            this.grpbDadosCurso.Controls.Add(this.cmbTipo);
            this.grpbDadosCurso.Controls.Add(this.lblCurso);
            this.grpbDadosCurso.Controls.Add(this.lblTipo);
            this.grpbDadosCurso.Controls.Add(this.cmbCurso);
            this.grpbDadosCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbDadosCurso.Location = new System.Drawing.Point(12, 333);
            this.grpbDadosCurso.Name = "grpbDadosCurso";
            this.grpbDadosCurso.Size = new System.Drawing.Size(420, 176);
            this.grpbDadosCurso.TabIndex = 79;
            this.grpbDadosCurso.TabStop = false;
            this.grpbDadosCurso.Text = "Dados do curso";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(12, 60);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(46, 16);
            this.lblTurno.TabIndex = 85;
            this.lblTurno.Text = "Turno:";
            // 
            // cmbTurno
            // 
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(62, 57);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(343, 24);
            this.cmbTurno.TabIndex = 84;
            this.cmbTurno.SelectedIndexChanged += new System.EventHandler(this.cmbTurno_SelectionChangeCommitted);
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(7, 138);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(50, 16);
            this.lblTurma.TabIndex = 11;
            this.lblTurma.Text = "Turma:";
            // 
            // cmbTurma
            // 
            this.cmbTurma.FormattingEnabled = true;
            this.cmbTurma.Location = new System.Drawing.Point(63, 135);
            this.cmbTurma.Name = "cmbTurma";
            this.cmbTurma.Size = new System.Drawing.Size(342, 24);
            this.cmbTurma.TabIndex = 83;
            // 
            // txtLoginNumId
            // 
            this.txtLoginNumId.Location = new System.Drawing.Point(327, 23);
            this.txtLoginNumId.Mask = "000";
            this.txtLoginNumId.Name = "txtLoginNumId";
            this.txtLoginNumId.Size = new System.Drawing.Size(33, 20);
            this.txtLoginNumId.TabIndex = 62;
            // 
            // txtLoginAno
            // 
            this.txtLoginAno.Enabled = false;
            this.txtLoginAno.Location = new System.Drawing.Point(249, 23);
            this.txtLoginAno.MaxLength = 4;
            this.txtLoginAno.Name = "txtLoginAno";
            this.txtLoginAno.Size = new System.Drawing.Size(33, 20);
            this.txtLoginAno.TabIndex = 60;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(84, 23);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(162, 16);
            this.lblLogin.TabIndex = 59;
            this.lblLogin.Text = "A matrícula do aluno será:";
            // 
            // txtLoginNumAleat
            // 
            this.txtLoginNumAleat.Enabled = false;
            this.txtLoginNumAleat.Location = new System.Drawing.Point(288, 23);
            this.txtLoginNumAleat.MaxLength = 4;
            this.txtLoginNumAleat.Name = "txtLoginNumAleat";
            this.txtLoginNumAleat.Size = new System.Drawing.Size(33, 20);
            this.txtLoginNumAleat.TabIndex = 63;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(84, 55);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(152, 16);
            this.lblSenha.TabIndex = 64;
            this.lblSenha.Text = "Senha padrão do aluno:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(249, 54);
            this.txtSenha.Mask = "0000000000";
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(111, 20);
            this.txtSenha.TabIndex = 63;
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Location = new System.Drawing.Point(223, 48);
            this.txtDataNasc.Mask = "00/00/0000";
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(176, 22);
            this.txtDataNasc.TabIndex = 69;
            this.txtDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // MatricularAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 563);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtLoginNumAleat);
            this.Controls.Add(this.txtLoginNumId);
            this.Controls.Add(this.txtLoginAno);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.grpbDadosAluno);
            this.Controls.Add(this.grpbDadosCurso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MatricularAluno";
            this.Text = "Matrícula de Aluno";
            this.Load += new System.EventHandler(this.MatricularAluno_Load);
            this.grpbEnd.ResumeLayout(false);
            this.grpbEnd.PerformLayout();
            this.grpbDadosAluno.ResumeLayout(false);
            this.grpbDadosAluno.PerformLayout();
            this.grpbDadosCurso.ResumeLayout(false);
            this.grpbDadosCurso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox grpbEnd;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox grpbDadosAluno;
        private System.Windows.Forms.GroupBox grpbDadosCurso;
        private System.Windows.Forms.MaskedTextBox txtLoginNumId;
        private System.Windows.Forms.TextBox txtLoginAno;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLoginNumAleat;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.ComboBox cmbTurma;
        private System.Windows.Forms.MaskedTextBox txtSenha;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.MaskedTextBox txtDataNasc;
    }
}