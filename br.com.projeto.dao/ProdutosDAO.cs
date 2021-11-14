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
    public class ProdutosDAO
    {
        //Atributo
        private MySqlConnection conexao;

        //Construtor
        public ProdutosDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Método que Cadastra um Produto
        public void CadastrarProduto(Produtos produto)
        {
            try
            {
                //1 passo - Criar o comando SQL
                string sql = @"insert into tb_produtos (descricao, preco, qtd_estoque, for_id)
                                 values (@descricao, @preco, @qtd_estoque, @for_id)";

                //2 passo - Organizar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@descricao", produto.descricao);
                executasql.Parameters.AddWithValue("@preco", produto.preco);
                executasql.Parameters.AddWithValue("@qtd_estoque", produto.qtd_estoque);
                executasql.Parameters.AddWithValue("@for_id", produto.for_id);

                // 3 passo - Abrir a conexao e executa o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Produto Cadastrado com Sucesso!");

                //fechar a conexao
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);

            }

        }
        #endregion

        #region Método que Altera um Produto
        public void AlterarProduto(Produtos produto)
        {
            try
            {
                //1 passo - Criar o comando SQL
                string sql = @"update tb_produtos set descricao = @descricao, preco= @preco, qtd_estoque = @qtd_estoque, for_id = @for_id
                                 where id = @id";

                //2 passo - Organizar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@descricao", produto.descricao);
                executasql.Parameters.AddWithValue("@preco", produto.preco);
                executasql.Parameters.AddWithValue("@qtd_estoque", produto.qtd_estoque);
                executasql.Parameters.AddWithValue("@for_id", produto.for_id);

                executasql.Parameters.AddWithValue("@id", produto.id);

                // 3 passo - Abrir a conexao e executa o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Dados do Produto alterados com Sucesso!");

                //fechar a conexao
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);

            }

        }
        #endregion

        #region Método que Exclui um Produto
        public void ExcluirProduto(Produtos produto)
        {
            try
            {
                //1 passo - Criar o comando SQL
                string sql = @"delete from tb_produtos where id = @id";

                //2 passo - Organizar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);

                executasql.Parameters.AddWithValue("@id", produto.id);

                // 3 passo - Abrir a conexao e executa o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();
                MessageBox.Show("Produto excluido com sucesso");

                //fechar a conexao
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);

            }

        }



        #endregion

        #region Método que lista todos os produtos
        public DataTable ListarTodosProdutos()
        {
            try
            {
                //1 Passo - Criar o comando SQL e o nosso DataTable
                DataTable tabelProduto = new DataTable();
                string sql = @"SELECT p.id as 'Código', 
                                      p.descricao as 'Descrição',
                                      p.preco as 'Preço', 
                                      p.qtd_estoque as 'Qtd', 
                                      f.nome as 'Fornecedor' FROM tb_produtos as p  
                                      join tb_fornecedores as f on (p.for_id = f.id);";

                //2 Passo - Organizar e executar o comando sql               
                MySqlCommand executasql = new MySqlCommand(sql, conexao);

                //3 passo - Abrir a conexao e executa o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                //4 Passo - Preencher o nosso DataTable com os dados do select
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelProduto);
                conexao.Close();

                return tabelProduto;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }

        #endregion

        #region Método que lista todos os produtos por nome
        public DataTable ListarTodosProdutosPorNome(string nome)
        {
            try
            {
                //1 Passo - Criar o comando SQL e o nosso DataTable
                DataTable tabelProduto = new DataTable();
                string sql = @"SELECT p.id as 'Código', 
                                      p.descricao as 'Descrição',
                                      p.preco as 'Preço', 
                                      p.qtd_estoque as 'Qtd', 
                                      f.nome as 'Fornecedor' FROM tb_produtos as p  
                                      join tb_fornecedores as f on (p.for_id = f.id)
                                      WHERE p.descricao like @nome;";

                //2 Passo - Organizar e executar o comando sql               
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@nome", nome);

                //3 passo - Abrir a conexao e executa o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                //4 Passo - Preencher o nosso DataTable com os dados do select
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelProduto);
                conexao.Close();

                return tabelProduto;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }

        #endregion

        #region Método que retorna um objeto produto por codigo
        public Produtos RetornaProdutoPorId(int id)
        {
            try
            {
                //1 Passo - Criar o comando sql e o objeto produto
                Produtos produto = new Produtos();
                string sql = @"select * from tb_produtos where id = @id";

                //2 Passo - Organizar o comando sql e executar
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@id", id);

                //3 passo - Abrir a conexao e executa o comando sql
                conexao.Open();

                //4 Passo - Montar o objeto Produto para ser retornado
                MySqlDataReader rs = executasql.ExecuteReader();

                if (rs.Read())
                {
                    produto.id = rs.GetInt32("id");
                    produto.descricao = rs.GetString("descricao");
                    produto.preco = rs.GetDecimal("preco");

                    conexao.Close();

                    return produto;
                }

                else
                {
                    //Não encontrou ninguem
                    MessageBox.Show("Produto não encontrado no banco de dados");

                    conexao.Close();
                    return null;
                }
            
            }
            catch (Exception erro)
            {
                conexao.Close();
                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }
        #endregion



    }
}
