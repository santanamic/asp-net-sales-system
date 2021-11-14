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
    public partial class Frmmenu : Form
    {
        public Frmmenu()
        {
            InitializeComponent();
        }

        private void CadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmclientes tela = new Frmclientes();
            // tela.Show();
            tela.ShowDialog();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //Capturar  hora atual
            lblhoraatual.Text = DateTime.Now.ToLongTimeString();

        }

        private void Frmmenu_Load(object sender, EventArgs e)
        {
            //Pegando a data a atual
            lbldata.Text = DateTime.Now.ToShortDateString();

            //Iniciei o timer
            timer1.Start();

        }

        private void HistóricoDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir a tela de Historico de vendas
            Frmhistorico tela = new Frmhistorico();
            tela.ShowDialog();
        }

        private void NovaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir a tela de Vendas
            Frmvendas tela = new Frmvendas();
            tela.ShowDialog();
        }
    }
}
