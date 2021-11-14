using MySql.Data.MySqlClient;
using Projeto_Vendas_Fatec_2.br.com.projeto.con;
using Projeto_Vendas_Fatec_2.br.com.projeto.model;
using Projeto_Vendas_Fatec_2.br.com.projeto.view;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Vendas_Fatec_2.br.com.projeto.dao
{
    class FuncionarioDAO
    {
        //Atributo
        private MySqlConnection conexao;

        //Construtor
        public FuncionarioDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }


        #region  Método que cadastra um funcionario
        public void CadastrarFuncionario(Funcionarios funcionarios)
        {
            try
            {
                //1 passo - Criar o comando SQL
                string sql = @"insert into tb_funcionarios (nome,rg,cpf,email,senha,cargo,nivel_acesso,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
                                 values (@nome, @rg, @cpf, @email, @senha, @cargo, @nivel, @telefone, @celular, @cep, @endereco, @numero, @comp, @bairro, @cidade, @estado)";

                //2 passo - Organizar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@nome", funcionarios.nome);
                executasql.Parameters.AddWithValue("@rg", funcionarios.rg);
                executasql.Parameters.AddWithValue("@cpf", funcionarios.cpf);
                executasql.Parameters.AddWithValue("@email", funcionarios.email);
                executasql.Parameters.AddWithValue("@senha", funcionarios.senha);
                executasql.Parameters.AddWithValue("@cargo", funcionarios.cargo);
                executasql.Parameters.AddWithValue("@nivel", funcionarios.nivel);
                executasql.Parameters.AddWithValue("@telefone", funcionarios.telefone);
                executasql.Parameters.AddWithValue("@celular", funcionarios.celular);
                executasql.Parameters.AddWithValue("@cep", funcionarios.cep);
                executasql.Parameters.AddWithValue("@endereco", funcionarios.endereco);
                executasql.Parameters.AddWithValue("@numero", funcionarios.numero);
                executasql.Parameters.AddWithValue("@comp", funcionarios.complemento);
                executasql.Parameters.AddWithValue("@bairro", funcionarios.bairro);
                executasql.Parameters.AddWithValue("@cidade", funcionarios.cidade);
                executasql.Parameters.AddWithValue("@estado", funcionarios.uf);

                // 3 passo - Abrir a conexao e executa o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Funcionário Cadastrado com Sucesso!");

                //fechar a conexao
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }


        #endregion

        #region Método para alterar dados de um funcionario
        public void AlterarFuncionario(Funcionarios funcionarios)
        {
            try
            {
                //1 passo - Criar o comando SQL
                string sql = @"update tb_funcionarios set nome = @nome, rg = @rg, cpf= @cpf,
                               email = @email, senha = @senha, cargo = @cargo, nivel_acesso = @nivel, telefone = @telefone, celular = @celular,
                               cep = @cep, endereco = @endereco, numero = @numero, complemento = @comp,
                               bairro = @bairro, cidade = @cidade, estado = @estado where id = @id";

                //2 passo - Organizar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@nome", funcionarios.nome);
                executasql.Parameters.AddWithValue("@rg", funcionarios.rg);
                executasql.Parameters.AddWithValue("@cpf", funcionarios.cpf);
                executasql.Parameters.AddWithValue("@email", funcionarios.email);
                executasql.Parameters.AddWithValue("@senha", funcionarios.senha);
                executasql.Parameters.AddWithValue("@cargo", funcionarios.cargo);
                executasql.Parameters.AddWithValue("@nivel", funcionarios.nivel);
                executasql.Parameters.AddWithValue("@telefone", funcionarios.telefone);
                executasql.Parameters.AddWithValue("@celular", funcionarios.celular);
                executasql.Parameters.AddWithValue("@cep", funcionarios.cep);
                executasql.Parameters.AddWithValue("@endereco", funcionarios.endereco);
                executasql.Parameters.AddWithValue("@numero", funcionarios.numero);
                executasql.Parameters.AddWithValue("@comp", funcionarios.complemento);
                executasql.Parameters.AddWithValue("@bairro", funcionarios.bairro);
                executasql.Parameters.AddWithValue("@cidade", funcionarios.cidade);
                executasql.Parameters.AddWithValue("@estado", funcionarios.uf);

                executasql.Parameters.AddWithValue("@id", funcionarios.id);

                // 3 passo - Abrir a conexao e executa o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Dados do funcionário alterados com Sucesso!");

                //fechar a conexao
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }


        #endregion

        #region Método para excluir um funcionário
        public void ExcluirFuncionario(int idfuncionario)
        {
            try
            {
                //1 passo - Criar o comando SQL
                string sql = @"delete from tb_funcionarios where id = @id";

                //2 Passo - Organizar e executar o comando sql
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@id", idfuncionario);

                // 3 passo - Abrir a conexao e executa o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Funcionário excluido com Sucesso!");

                //fechar a conexao
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }
        #endregion

        #region Métódo que Lista Todos os funcionários
        public DataTable ListarTodosFuncionarios()
        {
            try
            {
                //1 Passo - Criar o comando SQL e o nosso DataTable
                DataTable tabelaFuncionarios = new DataTable();
                string sql = @"select * from tb_funcionarios";

                //2 Passo - Organizar e executar o comando sql               
                MySqlCommand executasql = new MySqlCommand(sql, conexao);

                //3 passo - Abrir a conexao e executa o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                //4 Passo - Preencher o nosso DataTable com os dados do select
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaFuncionarios);
                conexao.Close();

                return tabelaFuncionarios;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }
        #endregion

        #region Método que listaFuncionarios utilizando List
        public List<Funcionarios> ListarFuncionarios()
        {
            try
            {
                List<Funcionarios> listafuncionarios = new List<Funcionarios>();
                //1 passo - Criar o comando SQL
                string sql = @"select * from tb_funcionarios";

                //2 Passo - Organizar e executar o comando sql               
                MySqlCommand executasql = new MySqlCommand(sql, conexao);

                //3 passo - Abrir a conexao e executa o comando sql
                conexao.Open();

                MySqlDataReader dr = executasql.ExecuteReader();

                while (dr.Read())
                {
                    Funcionarios obj = new Funcionarios();

                    obj.id = dr.GetInt32("id");
                    obj.nome = dr.GetString("nome");
                    obj.rg = dr.GetString("rg");

                    listafuncionarios.Add(obj);
                }

                return listafuncionarios;


            }
            catch (Exception)
            {

                return null;
            }
        }
        #endregion

        #region Método que Consulta um Funcionário Por Nome
        public DataTable ConsultarFuncionarioPorNome(string nome)
        {
            try
            {
                //1 Passo - Criar o comando SQL e o nosso DataTable
                DataTable tabelaFuncionarios = new DataTable();
                string sql = @"select * from tb_funcionarios where nome = @nome";

                //2 Passo - Organizar e executar o comando sql               
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@nome", nome);

                //3 passo - Abrir a conexao e executa o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                //4 Passo - Preencher o nosso DataTable com os dados do select
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaFuncionarios);
                conexao.Close();

                return tabelaFuncionarios;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }

        #endregion

        #region Método que Consulta um Funcionário Por CPF
        public DataTable ConsultarFuncionarioPorCPF(string cpf)
        {
            try
            {
                //1 Passo - Criar o comando SQL e o nosso DataTable
                DataTable tabelaFuncionarios = new DataTable();
                string sql = @"select * from tb_funcionarios where cpf = @cpf";

                //2 Passo - Organizar e executar o comando sql               
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@cpf", cpf);

                //3 passo - Abrir a conexao e executa o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                //4 Passo - Preencher o nosso DataTable com os dados do select
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaFuncionarios);
                conexao.Close();

                return tabelaFuncionarios;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }

        #endregion

        #region Método que efetua login
        public void EfetuarLogin(string email, string senha)
        {
            try
            {
                //1 passo Criar o comando sql
                string sql = @"SELECT * FROM tb_funcionarios WHERE email = @email AND senha = @senha";


                //2 passo - Organizar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@email", email);
                executasql.Parameters.AddWithValue("@senha", senha);

                // 3 passo - Abrir a conexao e executa o comando sql
                conexao.Open();
                MySqlDataReader rs = executasql.ExecuteReader();

                if (rs.Read())
                {
                    //Fez o login
                    //Descobrir qual é o nivel de acesso deste usuário
                    string nivel = rs.GetString("nivel_acesso");
                    string nome = rs.GetString("nome");

                    //Criando um objeto da tela de menu
                    Frmmenu telamenu = new Frmmenu();
                    telamenu.lbllogado.Text = nome;


                    //Restrições
                    if (nivel.Equals("Administrador"))
                    {
                        MessageBox.Show("Bem vindo ao Sistema " + nome);

                        //Abre a tela de Menu
                        telamenu.ShowDialog();
                    }

                    else if (nivel.Equals("Usuário"))
                    {
                        MessageBox.Show("Bem vindo ao Sistema " + nome);

                        //Especificar as permissões;
                        telamenu.menu_relatorios.Enabled = false;
                        telamenu.menu_cadproduto.Visible = false;

                        //Abrir a tela de menu
                        telamenu.ShowDialog();
                    }

                }

                else
                {
                    MessageBox.Show("Usuário ou senha incorretos!");
                }

                //Fecha a conexao
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }

        }

        #endregion

        #region Método para verificar e-mail
        public bool VerificarEmail(string email)
        {
            try
            {
                //1 passo Criar o comando sql
                string sql = @"SELECT * FROM tb_funcionarios WHERE email = @email";


                //2 passo - Organizar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@email", email);

                // 3 passo - Abrir a conexao e executa o comando sql
                conexao.Open();
                MySqlDataReader rs = executasql.ExecuteReader();

                if (rs.Read())
                {
                    string nome = rs.GetString("nome");
                    string senha = rs.GetString("senha");

                    try
                    {
                        MailMessage message = new MailMessage();
                        SmtpClient smtp = new SmtpClient();

                        message.From = new MailAddress("sistemavendas@fatec.com");
                        message.To.Add(new MailAddress(email));
                        message.Subject = "Recuperação de Acesso";
                        message.Body = "Entre no sistema com os seguintes dados: \n- E-mail " + email + "\n- Senha: " + senha;

                        smtp.Port = 587;
                        smtp.Host = "smtp.gmail.com";
                        smtp.EnableSsl = true;
                        smtp.UseDefaultCredentials = false;
                        //smtp.Credentials = new System.Net.NetworkCredential("seu_email@gmail.com", "sua_senha");
                        smtp.Credentials = new System.Net.NetworkCredential("suportedevendaswl@gmail.com", "AbcdefG1");
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Send(message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("erro: " + ex.Message);
                    }

                    return true;
                }

                //Fecha a conexao
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }

            return false;
        }
        #endregion

        #region Método para verificar login
        public bool VerificarLogin(string email, string senha)
        {
            try
            {
                //1 passo Criar o comando sql
                string sql = @"SELECT * FROM tb_funcionarios WHERE email = @email AND senha = @senha";


                //2 passo - Organizar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@email", email);
                executasql.Parameters.AddWithValue("@senha", senha);

                // 3 passo - Abrir a conexao e executa o comando sql
                conexao.Open();
                MySqlDataReader rs = executasql.ExecuteReader();


                if (rs.Read())
                {
                    //Fez o login
                    //Descobrir qual é o nivel de acesso deste usuário
                    string nivel = rs.GetString("nivel_acesso");
                    string nome = rs.GetString("nome");

                    //Criando um objeto da tela de menu
                    Frmmenu telamenu = new Frmmenu();
                    telamenu.lbllogado.Text = nome;


                    //Restrições
                    if (nivel.Equals("Administrador"))
                    {
                        MessageBox.Show("Bem vindo ao Sistema " + nome);

                        //Abre a tela de Menu
                        telamenu.ShowDialog();
                    }

                    else if (nivel.Equals("Usuário"))
                    {
                        MessageBox.Show("Bem vindo ao Sistema " + nome);

                        //Especificar as permissões;
                        telamenu.menu_relatorios.Enabled = false;
                        telamenu.menu_cadproduto.Visible = false;

                        //Abrir a tela de menu
                        telamenu.ShowDialog();
                    }

                    //Fecha a conexao
                    conexao.Close();
                    return true;

                }

                else
                {
                    MessageBox.Show("Usuário ou senha incorretos!");

                    //Fecha a conexao
                    conexao.Close();
                    return false;
                }

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);

            }

            //Fecha a conexao
            conexao.Close();
            return false;
        }

    }

    #endregion

}