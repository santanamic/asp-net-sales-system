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
    public class FornecedorDAO
    {
        //Atributo
        private MySqlConnection conexao;

        //Construtor
        public FornecedorDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region  Método que cadastra um fornecedor
        public void CadastrarFornecedor(Fornecedores fornecedores)
        {
            try
            {
                //1 passo - Criar o comando SQL
                string sql = @"insert into tb_fornecedores (nome,cnpj,email,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
                                 values (@nome, @cnpj, @email, @telefone, @celular, @cep, @end, @numero, @comp, @bairro, @cidade, @estado)";

                //2 passo - Organizar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@nome", fornecedores.nome);
                executasql.Parameters.AddWithValue("@cnpj", fornecedores.cnpj);
                executasql.Parameters.AddWithValue("@email", fornecedores.email);
                executasql.Parameters.AddWithValue("@telefone", fornecedores.telefone);
                executasql.Parameters.AddWithValue("@celular", fornecedores.celular);
                executasql.Parameters.AddWithValue("@cep", fornecedores.cep);
                executasql.Parameters.AddWithValue("@end", fornecedores.endereco);
                executasql.Parameters.AddWithValue("@numero", fornecedores.numero);
                executasql.Parameters.AddWithValue("@comp", fornecedores.complemento);
                executasql.Parameters.AddWithValue("@bairro", fornecedores.bairro);
                executasql.Parameters.AddWithValue("@cidade", fornecedores.cidade);
                executasql.Parameters.AddWithValue("@estado", fornecedores.uf);

                // 3 passo - Abrir a conexao e executa o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Fornecedor Cadastrado com Sucesso!");

                //fechar a conexao
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }


        #endregion

        #region Método que alterar um fornecedor
        public void AlterarFornecedores(Fornecedores fornecedores)
        {
            try
            {
                //1 passo - Criar o comando SQL
                string sql = @"update tb_fornecedores set nome = @nome, cnpj = @cnpj,
                               email = @email, telefone = @telefone, celular = @celular,
                               cep = @cep, endereco = @endereco, numero = @numero, complemento = @comp,
                               bairro = @bairro, cidade = @cidade, estado = @estado where id = @id";

                //2 passo - Organizar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@nome", fornecedores.nome);
                executasql.Parameters.AddWithValue("@cnpj", fornecedores.cnpj);
                executasql.Parameters.AddWithValue("@email", fornecedores.email);
                executasql.Parameters.AddWithValue("@telefone", fornecedores.telefone);
                executasql.Parameters.AddWithValue("@celular", fornecedores.celular);
                executasql.Parameters.AddWithValue("@cep", fornecedores.cep);
                executasql.Parameters.AddWithValue("@endereco", fornecedores.endereco);
                executasql.Parameters.AddWithValue("@numero", fornecedores.numero);
                executasql.Parameters.AddWithValue("@comp", fornecedores.complemento);
                executasql.Parameters.AddWithValue("@bairro", fornecedores.bairro);
                executasql.Parameters.AddWithValue("@cidade", fornecedores.cidade);
                executasql.Parameters.AddWithValue("@estado", fornecedores.uf);

                executasql.Parameters.AddWithValue("@id", fornecedores.id);

                // 3 passo - Abrir a conexao e executa o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Dados do fornecedor Alterados com Sucesso!");

                //fechar a conexao
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }


        #endregion

        #region Método para excluir um Fornecedor
        public void ExcluirFornecedor(int idfornecedor)
        {
            try
            {
                //1 passo - Criar o comando SQL
                string sql = @"delete from tb_fornecedores where id = @id";

                //2 Passo - Organizar e executar o comando sql
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@id", idfornecedor);

                // 3 passo - Abrir a conexao e executa o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Fornecedor excluido com Sucesso!");

                //fechar a conexao
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }
        #endregion

        #region Métódo que Lista Todos os Fornecedores
        public DataTable ListarTodosFornecedores()
        {
            try
            {
                //1 Passo - Criar o comando SQL e o nosso DataTable
                DataTable tabelaFornecedor = new DataTable();
                string sql = @"select * from tb_fornecedores";

                //2 Passo - Organizar e executar o comando sql               
                MySqlCommand executasql = new MySqlCommand(sql, conexao);

                //3 passo - Abrir a conexao e executa o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                //4 Passo - Preencher o nosso DataTable com os dados do select
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaFornecedor);
                conexao.Close();

                return tabelaFornecedor;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }
        #endregion

        #region Método que listaFornecedores utilizando List
        public List<Fornecedores> ListarFornecedor()
        {
            try
            {
                List<Fornecedores> listafornecedores = new List<Fornecedores>();
                //1 passo - Criar o comando SQL
                string sql = @"select * from tb_fornecedores";

                //2 Passo - Organizar e executar o comando sql               
                MySqlCommand executasql = new MySqlCommand(sql, conexao);

                //3 passo - Abrir a conexao e executa o comando sql
                conexao.Open();

                MySqlDataReader dr = executasql.ExecuteReader();

                while (dr.Read())
                {
                    Fornecedores obj = new Fornecedores();

                    obj.id = dr.GetInt32("id");
                    obj.nome = dr.GetString("nome");
                    obj.cnpj = dr.GetString("cnpj");

                    listafornecedores.Add(obj);
                }

                return listafornecedores;


            }
            catch (Exception)
            {

                return null;
            }
        }
        #endregion

        #region Método que Consulta um Fornecedor Por CNPJ
        public DataTable ConsultarFornecedorPorCNPJ(string cnpj)
        {
            try
            {
                //1 Passo - Criar o comando SQL e o nosso DataTable
                DataTable tabelaFornecedores = new DataTable();
                string sql = @"select * from tb_fornecedores where cnpj = @cnpj";

                //2 Passo - Organizar e executar o comando sql               
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@cnpj", cnpj);

                //3 passo - Abrir a conexao e executa o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                //4 Passo - Preencher o nosso DataTable com os dados do select
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaFornecedores);

                conexao.Close();

                return tabelaFornecedores;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }

        #endregion

        #region Método que Consulta um Fornecedor Por Nome
        public DataTable ConsultarFornecedorPorNome(string nome)
        {
            try
            {
                //1 Passo - Criar o comando SQL e o nosso DataTable
                DataTable tabelaFornecedores = new DataTable();
                string sql = @"select * from tb_fornecedores where nome = @nome";

                //2 Passo - Organizar e executar o comando sql               
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@nome", nome);

                //3 passo - Abrir a conexao e executa o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                //4 Passo - Preencher o nosso DataTable com os dados do select
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaFornecedores);
                conexao.Close();

                return tabelaFornecedores;

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