using Projeto_Vendas_Fatec_2.br.com.projeto.dao;
using Projeto_Vendas_Fatec_2.br.com.projeto.model;
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
    public partial class Frmpagamento : Form
    {
        //Criar os objetos que irão receber os dados
        Cliente cliente = new Cliente();
        DataTable carrinho = new DataTable();
        DateTime dataatual;
               
        public Frmpagamento(Cliente vcliente, DataTable vcarrinho, DateTime vdataatual)
        {
            //Recebendo os dados
            this.cliente   = vcliente;
            this.carrinho  = vcarrinho;
            this.dataatual = vdataatual;

            InitializeComponent();
        }


     
        private void Frmpagamento_Load(object sender, EventArgs e)
        {
            //Carrega tela
            txttroco.Text = "0,00";
            txtavista.Text = "0,00";
            txtcartao.Text = "0,00";
        }

        private void Btnfinaizar_Click(object sender, EventArgs e)
        {
            //Botao finalizar Venda
            try
            {
                //1° passo - Declarar as variaveis 
                decimal v_avista, v_cartao, troco, totalpago, total;

                //2° Passo - Receber os dados nas variaveis
                v_avista = decimal.Parse(txtavista.Text);
                v_cartao = decimal.Parse(txtcartao.Text);
                total = decimal.Parse(txttotal.Text);

                //3°Passo - calcular o total pago
                totalpago = v_avista + v_cartao;

                //4° Passo  - Verificar o valor do total pago
                if(totalpago < total)
                {
                    MessageBox.Show("O total pago é menor que o valor Total da venda");
                }

                else
                {   //5° Passo - Salvar os dados no banco

                    // Calcular o troco
                    troco = totalpago - total;

                    //Montar o objeto vendas
                    Vendas vendas = new Vendas();
                    vendas.cliente_id  = cliente.id;
                    vendas.data_venda  = dataatual;
                    vendas.total_venda = total;
                    vendas.obs         = txtobs.Text;

                    VendasDAO vdao = new VendasDAO();
                    vdao.CadastrarVenda(vendas);

                    //MessageBox.Show("Venda cadastrada com sucesso!");

                    txttroco.Text = troco.ToString();

                    //Cadastrar os itens da venda
                    //Percorrer e fazer para todos os itens do carrinho
                    foreach (DataRow linha in carrinho.Rows)
                    {
                        //Montar o item Venda
                        ItemVenda item   = new ItemVenda();
                        item.produto_id  = int.Parse(linha["Código"].ToString());
                        item.qtd         = int.Parse(linha["Qtd"].ToString());
                        item.subtotal    = decimal.Parse(linha["Subtotal"].ToString());

                        //Receber o id da venda
                        item.venda_id = vdao.RetornaIdUltimaVenda();

                        //Criar um objeto item venda dao
                        ItemVendaDAO itemdao = new ItemVendaDAO();
                        itemdao.CadastraItemVenda(item);

                    }

                    MessageBox.Show("Venda cadastrada com sucesso!");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
