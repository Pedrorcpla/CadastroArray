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
    public partial class frmPrincipal : Form
    {
        public struct Usuario
        {
            public int codigo;
            public string nome;
            public string nivel;
            public string login;
            public string senha;
        }
        public struct Cliente
        {
            public int codigo;
            public string nome;
            public string cpf;
            public string rg;
            public string email;
            public string telefone;
            public string estado;
            public string cidade;
            public string bairro;
            public string rua;
            public string numero;
            public string cep;
        }
        static public Usuario[] usuarios = new Usuario[10];
        static public int cadusu = 0;

        static public Cliente[] cliente = new Cliente[10];
        static public int cadcli = 0;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario fu = new frmUsuario();
            fu.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente fc = new frmCliente();
            fc.ShowDialog();
        }

        private void pdRelUsuario_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            int x = 0;
            Graphics objImpressao = e.Graphics;

            strDados = "Relatório de Usuário" + (char)10 + (char)10;
            strDados += "Código Nome:                                    Nível Login" + (char)10;
            strDados += "--------------------------------------------------------------" + (char)10;
            while (x < cadusu)
            {
                strDados += usuarios[x].codigo.ToString("000000") + " " + usuarios[x].nome.PadRight(40) + "   " +
                    usuarios[x].nivel + "   " + usuarios[x].login + (char)10;
                x++;
            }
            objImpressao.DrawString(strDados, new System.Drawing.Font("Courier New", 12, FontStyle.Regular), Brushes.Black, 50, 50);
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ppdUsuario.Show();
        }

        private void pdRelCliente_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            int x = 0;
            Graphics objImpressao = e.Graphics;

            strDados = "Relatório de Cliente" + (char)10 + (char)10;
            strDados += "Código Nome:                                    CEP       Estado Cidade" + (char)10;
            strDados += "-----------------------------------------------------------------------" + (char)10;
            while (x < cadcli)
            {
                strDados += cliente[x].codigo.ToString("000000") + " " + cliente[x].nome.PadRight(40) + " " +
                    cliente[x].cep + "   " + cliente[x].estado + "   " + cliente[x].cidade + (char)10;
                x++;
            }
            objImpressao.DrawString(strDados, new System.Drawing.Font("Courier New", 12, FontStyle.Regular), Brushes.Black, 50, 50);
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ppdCliente.Show();
        }
    }
}
