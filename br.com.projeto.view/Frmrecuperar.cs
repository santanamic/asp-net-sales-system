using Projeto_Vendas_Fatec_2.br.com.projeto.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Vendas_Fatec_2.br.com.projeto.view
{
    public partial class Frmrecuperar : Form
    {
        public Frmrecuperar()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();

            string email = txtemail.Text;

            bool verificarEmail = dao.VerificarEmail(email);

            if (verificarEmail)
            {
                MessageBox.Show("Sua senha foi enviada para o seu endereço de email");

                this.Hide();
            }
            else
            {
                MessageBox.Show("Revise os dados inseridos, se o problema persistir entre em contato com administrador do sistema.");
            }
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
