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
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void Frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void Txtemail_Leave(object sender, EventArgs e)
        {
            //if(txtemail.Text == "")
            //{
            //    txtemail.Text = "Digite seu e-mail";
            //    txtemail.ForeColor = Color.Gray;
            //}
        }

        private void Btnentrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Botão entrar
                FuncionarioDAO dao = new FuncionarioDAO();
                string email, senha;

                email = txtemail.Text;
                senha = txtsenha.Text;

                //esconder a tela de login
                //this.Hide();

                //dao.EfetuarLogin(email, senha);

                bool verificarLogin = dao.VerificarLogin(email, senha);

                if (verificarLogin)
                {
                    this.Hide();
                    new Frmmenu();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Preencha todos os campos!");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frmrecuperar frmRecuperar = new Frmrecuperar();
            frmRecuperar.ShowDialog();
        }
    }
}
