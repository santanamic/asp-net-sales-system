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
    public partial class Frmvendas : Form
    {

        //Objetos de cliente e ClienteDAO
        Cliente cliente = new Cliente();
        ClienteDAO clientedao = new ClienteDAO();

        //Objetos de produto e ProdutoDAO
        Produtos produto = new Produtos();
        ProdutosDAO produtodao = new ProdutosDAO();

        //Variaveis
        int qtd;
        decimal preco;
        decimal subtotal, total;

        //Carrinho
        DataTable carrinho = new DataTable();

     
        public Frmvendas()
        {
            InitializeComponent();

            //Montar o datagridview
            carrinho.Columns.Add("Código", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Qtd", typeof(int));
            carrinho.Columns.Add("Preço", typeof(decimal));
            carrinho.Columns.Add("Subtotal", typeof(decimal));

            //Definir que o DatagridView irá utilizar o datatable
            dgProdutos.DataSource = carrinho;                

        }

        private void Frmvendas_Load(object sender, EventArgs e)
        {
            //Pegando a data atual do sistema
            txtdata.Text = DateTime.Now.ToShortDateString();
        }

        private void Txtcpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Consulta de cliente por CPF

            if(e.KeyChar == 13)
            {
               
                cliente = clientedao.RetornaClientePorCpf(txtcpf.Text);

                if(cliente != null)
                {
                    //Colocar o nome do cliente no Campo de texto de cliente
                    txtnome.Text = cliente.nome;                    

                }
                else
                {
                    //Limpar os campos
                    txtcpf.Clear();
                    txtcpf.Focus();
                    txtnome.Clear();
                    
                }

            }
        }

        private void Txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Consulta de produto por codigo

            if (e.KeyChar == 13)
            {
            
                produto = produtodao.RetornaProdutoPorId(int.Parse(txtcodigo.Text));

                if (produto != null)
                {
                    //Colocar a descricao do Produto no Campo de texto de descricao
                    //Colocar o preco do produto no campo de preco
                    txtdescricao.Text = produto.descricao;
                    txtpreco.Text = produto.preco.ToString();

                    txtqtd.Focus();
                    txtqtd.BackColor = Color.Yellow;
                }
                else
                {
                    //Limpar os campos
                    txtcodigo.Focus();

                    txtcodigo.Clear();
                    txtpreco.Clear();
                    txtdescricao.Clear();

                }

            }
        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {
            //Botao cancelar venda
         
        }

        private void Btnadicionar_Click(object sender, EventArgs e)
        {
            //Botao adicionar no carrinho
            try
            {
                //1° Passo - Receber os valores
                qtd   = int.Parse(txtqtd.Text);
                preco = decimal.Parse(txtpreco.Text);

                //Calcular o subtotal
                subtotal = qtd * preco;

                //Calcular o Total
                total += subtotal;
                txttotal.Text = total.ToString();

                //adicionar o produto no carrinho
                carrinho.Rows.Add(int.Parse(txtcodigo.Text), txtdescricao.Text, qtd, preco, subtotal);

                //Limpar Campos
                txtcodigo.Clear();
                txtdescricao.Clear();
                txtqtd.Clear();
                txtpreco.Clear();

                //Focar no campo codigo
                txtcodigo.Focus();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Pesquise um Produto!");

            }

        }

        private void Btnexcluir_Click(object sender, EventArgs e)
        {
            //Botao remover item
            try
            {
                decimal subproduto = decimal.Parse(dgProdutos.CurrentRow.Cells[4].Value.ToString());

                //Excluir um item do carrinho
                int indice    = dgProdutos.CurrentRow.Index;
                DataRow linha = carrinho.Rows[indice];

                //Remover a linha do DataTable Carrinho
                carrinho.Rows.Remove(linha);
                carrinho.AcceptChanges();

                //Recalcular o total
                total -= subproduto;

                //exibi o novo total
                txttotal.Text = total.ToString();
                MessageBox.Show("Item Removido do carrinho com sucesso!");

            }
            catch (Exception erro)
            {
                MessageBox.Show("Selecione o item para excluir");
            }
        }

        private void Btnpagamento_Click(object sender, EventArgs e)
        {
            //botao pagamento
            Frmpagamento tela = new Frmpagamento(cliente, carrinho, DateTime.Parse(txtdata.Text));

            //Passando o total para o campo txttotal da tela de pagamentos
            tela.txttotal.Text = total.ToString();

           // tela.btnfinaizar.Text = "FATEC";
            
            tela.ShowDialog();

            
        }
    }
}
