using MySql.Data.MySqlClient;
using Projeto_Vendas_Fatec_2.br.com.projeto.con;
using Projeto_Vendas_Fatec_2.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Vendas_Fatec_2.br.com.projeto.dao
{
    public class ItemVendaDAO
    {
        //Atributo
        private MySqlConnection conexao;

        //Construtor
        public ItemVendaDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }


        #region Método que Cadastra um Item Venda

        public void CadastraItemVenda(ItemVenda item)
        {
            try
            {
                //1 passo - Criar o comando SQL
                string sql = @"insert into tb_itensvendas (venda_id, produto_id, qtd, subtotal)
                                 values (@venda_id, @produto_id, @qtd, @subtotal)";

                //2 passo - Organizar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@venda_id", item.venda_id);
                executasql.Parameters.AddWithValue("@produto_id", item.produto_id);
                executasql.Parameters.AddWithValue("@qtd", item.qtd);
                executasql.Parameters.AddWithValue("@subtotal", item.subtotal);

                // 3 passo - Abrir a conexao e executa o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Item Cadastrado com Sucesso!");

                //fechar a conexao
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);

            }

        }

        #endregion

        #region Método que lista os items de uma venda
        public DataTable ListasItensPorVenda(int venda_id)
        {
            try
            {
                DataTable tabelaItens = new DataTable();

                //1 passo - Criar o comando SQL
                string sql = @"SELECT p.descricao as 'Descrição', 
                                      i.qtd as 'Qtd', 
	                                  p.preco as 'Preço', 
                                      i.subtotal as 'SubTotal' from tb_itensvendas as i
                                      inner join tb_produtos as p on(i.produto_id = p.id) where i.venda_id = @venda_id";

                //2 passo - Organizar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@venda_id", venda_id);

                // 3 passo - Abrir a conexao e executa o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();
                
                //4 Passo - Preencher o nosso DataTable com os dados do select
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaItens);

                return tabelaItens;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }

       
        #endregion
    }
}
