﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscola.Formulários.Admin.Aluno
{
    public partial class CadastrarAluno : Form
    {
        public CadastrarAluno()
        {
            InitializeComponent();
        }

        private void CadastrarAluno_Load(object sender, EventArgs e)
        {
            int ano = DateTime.Now.Year;
            txtLoginAno.Text = Convert.ToString(ano);
        }
    }
}
