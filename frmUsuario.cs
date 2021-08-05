﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroArray
{
    public partial class frmUsuario : Form
    {
        bool tipo;
        int atual;
        private void Habilita()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtNivel.Enabled = true;
            txtLogin.Enabled = true;
            txtSenha.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSair.Enabled = false;
        }
        private void Desabilita()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtNivel.Enabled = false;
            txtLogin.Enabled = false;
            txtSenha.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnPesquisar.Enabled = true;
            btnImprimir.Enabled = true;
            btnSair.Enabled = true;
        }
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            Desabilita();
            atual = 0;
            txtCodigo.Text = (frmPrincipal.usuarios[atual].codigo).ToString();
            txtNome.Text = frmPrincipal.usuarios[atual].nome;
            txtNivel.Text = frmPrincipal.usuarios[atual].nivel;
            txtLogin.Text = frmPrincipal.usuarios[atual].login;
            txtSenha.Text = frmPrincipal.usuarios[atual].senha;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if(frmPrincipal.cadusu < 10)
            {
                Habilita();
                txtCodigo.Text = (frmPrincipal.cadusu + 1).ToString();
                tipo = true;
            }
            else
            {
                MessageBox.Show("Banco de Dados cheio!");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
            tipo = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Desabilita();
            if (tipo)
            {
                frmPrincipal.usuarios[frmPrincipal.cadusu].codigo = int.Parse(txtCodigo.Text);
                frmPrincipal.usuarios[frmPrincipal.cadusu].nome = txtNome.Text;
                frmPrincipal.usuarios[frmPrincipal.cadusu].nivel = txtNivel.Text;
                frmPrincipal.usuarios[frmPrincipal.cadusu].login = txtLogin.Text;
                frmPrincipal.usuarios[frmPrincipal.cadusu].senha = txtSenha.Text;
                atual = frmPrincipal.cadusu++;
            }
            else
            {
                frmPrincipal.usuarios[atual].nome = txtNome.Text;
                frmPrincipal.usuarios[atual].nivel = txtNivel.Text;
                frmPrincipal.usuarios[atual].login = txtLogin.Text;
                frmPrincipal.usuarios[atual].senha = txtSenha.Text;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Desabilita();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            atual = int.Parse(txtCodigo.Text) - 2;
            if (atual >= 0)
            {
                txtCodigo.Text = (frmPrincipal.usuarios[atual].codigo).ToString();
                txtNome.Text = frmPrincipal.usuarios[atual].nome;
                txtNivel.Text = frmPrincipal.usuarios[atual].nivel;
                txtLogin.Text = frmPrincipal.usuarios[atual].login;
                txtSenha.Text = frmPrincipal.usuarios[atual].senha;
            }
            else
            {
               MessageBox.Show("Chegamos ao fim!");
            }
            
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            atual = int.Parse(txtCodigo.Text);
            if (atual <= 9)
            {
                txtCodigo.Text = (frmPrincipal.usuarios[atual].codigo).ToString();
                txtNome.Text = frmPrincipal.usuarios[atual].nome;
                txtNivel.Text = frmPrincipal.usuarios[atual].nivel;
                txtLogin.Text = frmPrincipal.usuarios[atual].login;
                txtSenha.Text = frmPrincipal.usuarios[atual].senha;
            }
            else
            {
                MessageBox.Show("Chegamos ao fim!");
            }
        }
    }
}
