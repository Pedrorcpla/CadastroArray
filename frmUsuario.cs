using System;
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
        private void Mostra()
        {
            txtCodigo.Text = (frmPrincipal.usuarios[atual].codigo).ToString();
            txtNome.Text = frmPrincipal.usuarios[atual].nome;
            txtNivel.Text = frmPrincipal.usuarios[atual].nivel;
            txtLogin.Text = frmPrincipal.usuarios[atual].login;
            txtSenha.Text = frmPrincipal.usuarios[atual].senha;
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
                txtNome.Clear();
                txtNivel.Clear();
                txtLogin.Clear();
                txtSenha.Clear();
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
                Mostra();
            }            
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            atual = int.Parse(txtCodigo.Text);
            if (atual <= frmPrincipal.cadusu - 1) 
            {
                Mostra();
            }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quer apagar esse registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                frmPrincipal.usuarios[atual].nome = "";
                frmPrincipal.usuarios[atual].nivel = "";
                frmPrincipal.usuarios[atual].login = "";
                frmPrincipal.usuarios[atual].senha = "";
                Mostra();
            }
        }

        private void btnCancelarPesquisa_Click(object sender, EventArgs e)
        {
            pnlPesquisa.Visible = false;
            txtNomePesquisa.Text = null;
        }

        private void btnOkPesquisa_Click(object sender, EventArgs e)
        {
            int x;
            if (txtNomePesquisa.Text != "")
            {
                for (x = 0; x < 10; x++)
                {
                    if (frmPrincipal.usuarios[x].nome == txtNomePesquisa.Text)
                    {
                        atual = x;
                        Mostra();
                        break;
                    }
                }
                if (x == 10)
                {
                    MessageBox.Show("Nome não encontrado!");
                }
                pnlPesquisa.Visible = false;
                txtNomePesquisa.Text = null;
            }
            else
            {
                MessageBox.Show("Digite um nome para pesquisa.");
                txtNomePesquisa.Focus();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pnlPesquisa.Visible = true;
            txtNomePesquisa.Focus();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "FICHA DE USUÁRIO" + (char)10 + (char)10;
            strDados = strDados + "Código: " + txtCodigo.Text + (char)10 + (char)10;
            strDados = strDados + "Nome: " + txtNome.Text + (char)10 + (char)10;
            strDados = strDados + "Nível: " + txtNivel.Text + (char)10 + (char)10;
            strDados = strDados + "Login: " + txtLogin.Text;

            objImpressao.DrawString(strDados, new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 50);
            objImpressao.DrawLine(new System.Drawing.Pen(Brushes.Black, 1), 50, 80, 780, 80);
        }
    }
}
