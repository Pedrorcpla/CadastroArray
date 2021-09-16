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
    public partial class frmCliente : Form
    {
        bool tipo;
        int atual;
        private void Habilita()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtCpf.Enabled = true;
            txtRg.Enabled = true;
            txtEmail.Enabled = true;
            txtTelefone.Enabled = true;
            txtEstado.Enabled = true;
            txtCidade.Enabled = true;
            txtBairro.Enabled = true;
            txtRua.Enabled = true;
            txtNumero.Enabled = true;
            txtCep.Enabled = true;
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
            txtCpf.Enabled = false;
            txtRg.Enabled = false;
            txtEmail.Enabled = false;
            txtTelefone.Enabled = false;
            txtEstado.Enabled = false;
            txtCidade.Enabled = false;
            txtBairro.Enabled = false;
            txtRua.Enabled = false;
            txtNumero.Enabled = false;
            txtCep.Enabled = false;
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
        public void Mostra()
        {
            txtCodigo.Text = (frmPrincipal.cliente[atual].codigo).ToString();
            txtNome.Text = frmPrincipal.cliente[atual].nome;
            txtCpf.Text = frmPrincipal.cliente[atual].cpf;
            txtRg.Text = frmPrincipal.cliente[atual].rg;
            txtEmail.Text = frmPrincipal.cliente[atual].email;
            txtTelefone.Text = frmPrincipal.cliente[atual].telefone;
            txtEstado.Text = frmPrincipal.cliente[atual].estado;
            txtCidade.Text = frmPrincipal.cliente[atual].cidade;
            txtBairro.Text = frmPrincipal.cliente[atual].bairro;
            txtRua.Text = frmPrincipal.cliente[atual].rua;
            txtNumero.Text = frmPrincipal.cliente[atual].numero;
            txtCep.Text = frmPrincipal.cliente[atual].cep;
        }
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            Desabilita();
            atual = 0;
            txtCodigo.Text = (frmPrincipal.cliente[atual].codigo).ToString();
            txtNome.Text = frmPrincipal.cliente[atual].nome;
            txtCpf.Text = frmPrincipal.cliente[atual].cpf;
            txtRg.Text = frmPrincipal.cliente[atual].rg;
            txtEmail.Text = frmPrincipal.cliente[atual].email;
            txtTelefone.Text = frmPrincipal.cliente[atual].telefone;
            txtEstado.Text = frmPrincipal.cliente[atual].estado;
            txtCidade.Text = frmPrincipal.cliente[atual].cidade;
            txtBairro.Text = frmPrincipal.cliente[atual].bairro;
            txtRua.Text = frmPrincipal.cliente[atual].rua;
            txtNumero.Text = frmPrincipal.cliente[atual].numero;
            txtCep.Text = frmPrincipal.cliente[atual].cep;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (frmPrincipal.cadcli < 10)
            {
                Habilita();
                txtCodigo.Text = (frmPrincipal.cadcli + 1).ToString();
                txtNome.Clear();
                txtCpf.Clear();
                txtRg.Clear();
                txtEmail.Clear();
                txtTelefone.Clear();
                txtEstado.Clear();
                txtCidade.Clear();
                txtBairro.Clear();
                txtRua.Clear();
                txtNumero.Clear();
                txtCep.Clear();
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
                frmPrincipal.cliente[frmPrincipal.cadcli].codigo = int.Parse(txtCodigo.Text);
                frmPrincipal.cliente[frmPrincipal.cadcli].nome = txtNome.Text;
                frmPrincipal.cliente[frmPrincipal.cadcli].cpf = txtCpf.Text;
                frmPrincipal.cliente[frmPrincipal.cadcli].rg = txtRg.Text;
                frmPrincipal.cliente[frmPrincipal.cadcli].email = txtEmail.Text;
                frmPrincipal.cliente[frmPrincipal.cadcli].telefone = txtTelefone.Text;
                frmPrincipal.cliente[frmPrincipal.cadcli].estado = txtEstado.Text;
                frmPrincipal.cliente[frmPrincipal.cadcli].cidade = txtCidade.Text;
                frmPrincipal.cliente[frmPrincipal.cadcli].bairro = txtBairro.Text;
                frmPrincipal.cliente[frmPrincipal.cadcli].rua = txtRua.Text;
                frmPrincipal.cliente[frmPrincipal.cadcli].numero = txtNumero.Text;
                frmPrincipal.cliente[frmPrincipal.cadcli].cep = txtCep.Text;
                atual = frmPrincipal.cadcli++;
            }
            else
            {
                frmPrincipal.cliente[atual].nome = txtNome.Text;
                frmPrincipal.cliente[atual].cpf = txtCpf.Text;
                frmPrincipal.cliente[atual].rg = txtRg.Text;
                frmPrincipal.cliente[atual].email = txtEmail.Text;
                frmPrincipal.cliente[atual].telefone = txtTelefone.Text;
                frmPrincipal.cliente[atual].estado = txtEstado.Text;
                frmPrincipal.cliente[atual].cidade = txtCidade.Text;
                frmPrincipal.cliente[atual].bairro = txtBairro.Text;
                frmPrincipal.cliente[atual].rua = txtRua.Text;
                frmPrincipal.cliente[atual].numero = txtNumero.Text;
                frmPrincipal.cliente[atual].cep = txtCep.Text;
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
            if (atual <= frmPrincipal.cadcli - 1)
            {
                Mostra();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quer apagar esse registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmPrincipal.cliente[atual].nome = null;
                frmPrincipal.cliente[atual].cpf = null;
                frmPrincipal.cliente[atual].rg = null;
                frmPrincipal.cliente[atual].email = null;
                frmPrincipal.cliente[atual].telefone = null;
                frmPrincipal.cliente[atual].estado = null;
                frmPrincipal.cliente[atual].cidade = null;
                frmPrincipal.cliente[atual].bairro = null;
                frmPrincipal.cliente[atual].rua = null;
                frmPrincipal.cliente[atual].numero = null;
                frmPrincipal.cliente[atual].cep = null;
                Mostra();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pnlPesquisa.Visible = true;
        }

        private void btnOkPesquisa_Click(object sender, EventArgs e)
        {
            int x;
            if (txtNomePesquisa.Text != "")
            {
                for (x = 0; x < 10; x++)
                {
                    if (frmPrincipal.cliente[x].nome == txtNomePesquisa.Text)
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

        private void btnCancelarPesquisa_Click(object sender, EventArgs e)
        {
            pnlPesquisa.Visible = false;
            txtNomePesquisa.Text = null;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "FICHA DE CLIENTE" + (char)10 + (char)10;
            strDados = strDados + "Código: " + txtCodigo.Text + (char)10 + (char)10;
            strDados = strDados + "Nome: " + txtNome.Text + (char)10 + (char)10;
            strDados = strDados + "CPF: " + txtCpf.Text + (char)10 + (char)10;
            strDados = strDados + "RG: " + txtRg.Text + (char)10 + (char)10;
            strDados = strDados + "E-mail: " + txtEmail.Text + (char)10 + (char)10;
            strDados = strDados + "Telefone: " + txtTelefone.Text + (char)10 + (char)10;
            strDados = strDados + "Estado: " + txtEstado.Text + (char)10 + (char)10;
            strDados = strDados + "Cidade: " + txtCidade.Text + (char)10 + (char)10;
            strDados = strDados + "Número: " + txtNumero.Text + (char)10 + (char)10;
            strDados = strDados + "Bairro: " + txtBairro.Text + (char)10 + (char)10;
            strDados = strDados + "Rua: " + txtRua.Text + (char)10 + (char)10;
            strDados = strDados + "CEP: " + txtCep.Text;

            objImpressao.DrawString(strDados, new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 50);
            objImpressao.DrawLine(new System.Drawing.Pen(Brushes.Black, 1), 50, 80, 780, 80);
        }
    }
}
