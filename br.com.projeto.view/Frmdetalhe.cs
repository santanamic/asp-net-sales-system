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
    public partial class Frmdetalhe : Form
    {
        //Agora vamos configurar o construtor para receber os valores

        public Frmdetalhe(string datavenda, double total, string nomecliente, string obs, DataTable tabelaHistorico)
        {
            //Constrói a tela é o método InitializeComponent
            InitializeComponent();

            txtcliente.Text    = nomecliente;
            txtdata.Text       = datavenda;
            txttotalvenda.Text = total.ToString("C2");
            txtobs.Text = obs;
            dgItens.DataSource = tabelaHistorico;


        }

        private void Frmdetalhe_Load(object sender, EventArgs e)
        {

        }
    }
}
