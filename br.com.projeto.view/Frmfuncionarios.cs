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
    public partial class Frmfuncionarios : Form
    {
        public Frmfuncionarios()
        {
            InitializeComponent();
        }

        private void Btncadastrar_Click(object sender, EventArgs e)
        {
            //Botao cadastrar
            //1 passo - Receber os dados em um objeto model de cliente
            Funcionarios funcionarios = new Funcionarios();

            funcionarios.nome = txtnome.Text;
            funcionarios.rg = txtrg.Text;
            funcionarios.cpf = txtcpf.Text;
            funcionarios.email = txtemail.Text;
            funcionarios.senha = txtsenha.Text;
            funcionarios.cargo = txtcargo.Text;
            funcionarios.nivel = txtnivelacesso.Text;
            funcionarios.telefone = txttelefone.Text;
            funcionarios.celular = txtcelular.Text;
            funcionarios.cep = txtcep.Text;
            funcionarios.endereco = txtendereco.Text;
            funcionarios.numero = int.Parse(txtnumero.Text);
            funcionarios.complemento = txtcomplemento.Text;
            funcionarios.bairro = txtbairro.Text;
            funcionarios.cidade = txtcidade.Text;
            funcionarios.uf = cbuf.Text;

            //2 passo - Criar o objeto FuncionarioDAO para chamar o método CadastrarFuncionario
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.CadastrarFuncionario(funcionarios);

            //Recarregar o datagridview
            dgfuncionarios.DataSource = dao.ListarTodosFuncionarios();
        }

        private void Btnexcluir_Click(object sender, EventArgs e)
        {
            //Botao excluir
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.ExcluirFuncionario(int.Parse(txtcod.Text));

            //Recarregar o datagridview
            dgfuncionarios.DataSource = dao.ListarTodosFuncionarios();
        }

        private void Btneditar_Click(object sender, EventArgs e)
        {
            //Botão editar
            //1 passo - Receber os dados em um objeto model de funcionário
            Funcionarios funcionarios = new Funcionarios();

            funcionarios.nome = txtnome.Text;
            funcionarios.rg = txtrg.Text;
            funcionarios.cpf = txtcpf.Text;
            funcionarios.email = txtemail.Text;
            funcionarios.senha = txtsenha.Text;
            funcionarios.cargo = txtcargo.Text;
            funcionarios.nivel = txtnivelacesso.Text;
            funcionarios.telefone = txttelefone.Text;
            funcionarios.celular = txtcelular.Text;
            funcionarios.cep = txtcep.Text;
            funcionarios.endereco = txtendereco.Text;
            funcionarios.numero = int.Parse(txtnumero.Text);
            funcionarios.complemento = txtcomplemento.Text;
            funcionarios.bairro = txtbairro.Text;
            funcionarios.cidade = txtcidade.Text;
            funcionarios.uf = cbuf.Text;

            //Receber o id do funcionário
            funcionarios.id = int.Parse(txtcod.Text);

            //2 passo - Criar o objeto FuncionarioDAO para chamar o método CadastrarFuncionario
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.AlterarFuncionario(funcionarios);

            //Recarregar o datagridview
            dgfuncionarios.DataSource = dao.ListarTodosFuncionarios();
        }

        private void Btnpesquisar_Click(object sender, EventArgs e)
        {
            //Botao que consulta o cep
            try
            {
                //1 Passo - Receber o cep
                string cep = txtcep.Text;

                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet dados = new DataSet();
                dados.ReadXml(xml);

                //Exibir os dados no campo de texto
                txtendereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtbairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtcidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txtcomplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                cbuf.Text = dados.Tables[0].Rows[0]["uf"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Endereço não encontrado, por favor digite manualmente.");

            }
        }

        private void Btnconsultar_Click(object sender, EventArgs e)
        {
            //Botao consultar funcionario
            string dados = txtconsulta.Text;
            FuncionarioDAO dao = new FuncionarioDAO();

            //Verificar qual é a opção escolhida no combobox filtro
            // Se for nome
            if (cbfiltro.SelectedIndex == 0)
            {
                MessageBox.Show("Consulta por Nome");
                dgfuncionarios.DataSource = dao.ConsultarFuncionarioPorNome(dados);

            }

            else if (cbfiltro.SelectedIndex == 1)
            {
                MessageBox.Show("Consulta por CPF");
                dgfuncionarios.DataSource = dao.ConsultarFuncionarioPorCPF(dados);
            }

            if (dgfuncionarios.Rows.Count == 0)
            {
                MessageBox.Show("Funcionário não encontrado!");
                dgfuncionarios.DataSource = dao.ListarTodosFuncionarios();
            }
        }

        private void Frmfuncionarios_Load(object sender, EventArgs e)
        {
            //Listar Funcionarios no datagrid
            FuncionarioDAO dao = new FuncionarioDAO();
            dgfuncionarios.DataSource = dao.ListarTodosFuncionarios();
        }

        private void dgfuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Esse código pega o codigo da coluna 0 do datagrid, e coloca
            //no campo de texto

            txtcod.Text = dgfuncionarios.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = dgfuncionarios.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text = dgfuncionarios.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text = dgfuncionarios.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = dgfuncionarios.CurrentRow.Cells[4].Value.ToString();
            txtsenha.Text = dgfuncionarios.CurrentRow.Cells[5].Value.ToString();
            txtcargo.Text = dgfuncionarios.CurrentRow.Cells[6].Value.ToString();
            txtnivelacesso.Text = dgfuncionarios.CurrentRow.Cells[7].Value.ToString();
            txttelefone.Text = dgfuncionarios.CurrentRow.Cells[8].Value.ToString();
            txtcelular.Text = dgfuncionarios.CurrentRow.Cells[9].Value.ToString();
            txtcep.Text = dgfuncionarios.CurrentRow.Cells[10].Value.ToString();
            txtendereco.Text = dgfuncionarios.CurrentRow.Cells[11].Value.ToString();
            txtnumero.Text = dgfuncionarios.CurrentRow.Cells[12].Value.ToString();
            txtcomplemento.Text = dgfuncionarios.CurrentRow.Cells[13].Value.ToString();
            txtbairro.Text = dgfuncionarios.CurrentRow.Cells[14].Value.ToString();
            txtcidade.Text = dgfuncionarios.CurrentRow.Cells[15].Value.ToString();
            cbuf.Text = dgfuncionarios.CurrentRow.Cells[16].Value.ToString();

            //troca de aba
            tabControl1.SelectedTab = tabPage1;
        }
    }
}

