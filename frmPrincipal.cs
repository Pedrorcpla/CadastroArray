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
    }
}
