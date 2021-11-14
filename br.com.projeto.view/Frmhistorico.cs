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
    public partial class Frmhistorico : Form
    {
        public Frmhistorico()
        {
            InitializeComponent();
        }

        private void Btnpesquisar_Click(object sender, EventArgs e)
        {
            //Botao Pesquisar
            try
            {
                DateTime dtinicio, dtfim;

                //Pega a primeira data
                dtinicio = txtdatainicio.Value;
                dtfim    = txtdatafim.Value;

                VendasDAO dao = new VendasDAO();

                dgHistorico.DataSource = dao.ListarVendasPorPeriodo(dtinicio, dtfim);

                //Se não retornar linhas do dataTable
                if(dgHistorico.Rows.Count == 0)
                {
                    MessageBox.Show("Não foram encontradas vendas neste periodo!");
                    dgHistorico.DataSource = dao.ListarVendas();
                }

            }
            catch (Exception)
            {

               
            }
        }

        private void Frmhistorico_Load(object sender, EventArgs e)
        {
            //Chamando o metodo que lista todas as vendas
            VendasDAO dao = new VendasDAO();
            dgHistorico.DataSource = dao.ListarVendas();
        }

        private void DgHistorico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Clicando em uma venda

            //1° passo - Criar os objetos e declaração de variavel
            ItemVendaDAO itemdao = new ItemVendaDAO();
            DataTable tabelaHistorico = new DataTable();

            int venda_id;
            
            //Criando as variaveis que irão ser passadas pelo construtor
            string nomecliente, datavenda, obs;
            double total;
           
            
            datavenda   = dgHistorico.CurrentRow.Cells[1].Value.ToString();
            total       = double.Parse(dgHistorico.CurrentRow.Cells[2].Value.ToString());
            nomecliente = dgHistorico.CurrentRow.Cells[3].Value.ToString();
            obs         = dgHistorico.CurrentRow.Cells[4].Value.ToString();

            //2° passo - Pegar o id de uma venda
            venda_id = int.Parse(dgHistorico.CurrentRow.Cells[0].Value.ToString());
            tabelaHistorico = itemdao.ListasItensPorVenda(venda_id);

            // Passando os valores pelo construtor
            Frmdetalhe tela = new Frmdetalhe(datavenda,total,nomecliente,obs,tabelaHistorico);

            //4° Passo - Chamar a tela de detalhes
            tela.ShowDialog();

        }
    }
}
