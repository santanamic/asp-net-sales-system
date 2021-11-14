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
    public partial class Frmfornecedores : Form
    {
        public Frmfornecedores()
        {
            InitializeComponent();
        }

        private void Btncadastrar_Click(object sender, EventArgs e)
        {
            //Botao cadastrar
            //1 passo - Receber os dados em um objeto model de fornecedores
            Fornecedores fornecedores = new Fornecedores();

            fornecedores.nome = txtnome.Text;
            fornecedores.cnpj = txtcnpj.Text;
            fornecedores.email = txtemail.Text;
            fornecedores.telefone = txttelefone.Text;
            fornecedores.celular = txtcelular.Text;
            fornecedores.cep = txtcep.Text;
            fornecedores.endereco = txtendereco.Text;
            fornecedores.numero = int.Parse(txtnumero.Text);
            fornecedores.complemento = txtcomplemento.Text;
            fornecedores.bairro = txtbairro.Text;
            fornecedores.cidade = txtcidade.Text;
            fornecedores.uf = cbuf.Text;

            //2 passo - Criar o objeto ClienteDAO para chamar o método CadastrarFornecedor
            FornecedorDAO dao = new FornecedorDAO();
            dao.CadastrarFornecedor(fornecedores);

            //Recarregar o datagridview
            dgfornecedores.DataSource = dao.ListarTodosFornecedores(); ;
        }

        private void Btnexcluir_Click(object sender, EventArgs e)
        {
            //Botao excluir
            FornecedorDAO dao = new FornecedorDAO();
            dao.ExcluirFornecedor(int.Parse(txtcodigo.Text));

            //Recarregar o datagridview
            dgfornecedores.DataSource = dao.ListarTodosFornecedores();
        }

        private void Btneditar_Click(object sender, EventArgs e)
        {
            //Botão editar
            Fornecedores fornecedores = new Fornecedores();

            fornecedores.nome = txtnome.Text;
            fornecedores.cnpj = txtcnpj.Text;
            fornecedores.email = txtemail.Text;
            fornecedores.telefone = txttelefone.Text;
            fornecedores.celular = txtcelular.Text;
            fornecedores.cep = txtcep.Text;
            fornecedores.endereco = txtendereco.Text;
            fornecedores.numero = int.Parse(txtnumero.Text);
            fornecedores.complemento = txtcomplemento.Text;
            fornecedores.bairro = txtbairro.Text;
            fornecedores.cidade = txtcidade.Text;
            fornecedores.uf = cbuf.Text;

            //Receber o id do fornecedor
            fornecedores.id = int.Parse(txtcodigo.Text);

            //2 passo - Criar o objeto ClienteDAO para chamar o método CadastrarFornecedor
            FornecedorDAO dao = new FornecedorDAO();
            dao.AlterarFornecedores(fornecedores);

            //Recarregar o datagridview
            dgfornecedores.DataSource = dao.ListarTodosFornecedores();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
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
            //Botao consultar fornecedor
            string dados = txtconsulta.Text;
            FornecedorDAO dao = new FornecedorDAO();

            if (cbfiltro.SelectedIndex == 0)
            {
                MessageBox.Show("Consulta por Nome");
                dgfornecedores.DataSource = dao.ConsultarFornecedorPorNome(dados);

            }

            else if (cbfiltro.SelectedIndex == 1)
            {
                MessageBox.Show("Consulta por CNPJ");
                dgfornecedores.DataSource = dao.ConsultarFornecedorPorCNPJ(dados);
            }

            if (dgfornecedores.Rows.Count == 0)
            {
                MessageBox.Show("Fornecedor não encontrado!");
                dgfornecedores.DataSource = dao.ListarTodosFornecedores();
            }
        }

        private void dgfornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pega os dados do datagridview

            //lembrando que esse 0 do Cells, representa a coluna do datagrid

            txtcodigo.Text = dgfornecedores.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = dgfornecedores.CurrentRow.Cells[1].Value.ToString();
            txtcnpj.Text = dgfornecedores.CurrentRow.Cells[2].Value.ToString();
            txtemail.Text = dgfornecedores.CurrentRow.Cells[3].Value.ToString();
            txttelefone.Text = dgfornecedores.CurrentRow.Cells[4].Value.ToString();
            txtcelular.Text = dgfornecedores.CurrentRow.Cells[5].Value.ToString();
            txtcep.Text = dgfornecedores.CurrentRow.Cells[6].Value.ToString();
            txtendereco.Text = dgfornecedores.CurrentRow.Cells[7].Value.ToString();
            txtnumero.Text = dgfornecedores.CurrentRow.Cells[8].Value.ToString();
            txtcomplemento.Text = dgfornecedores.CurrentRow.Cells[9].Value.ToString();
            txtbairro.Text = dgfornecedores.CurrentRow.Cells[10].Value.ToString();
            txtcidade.Text = dgfornecedores.CurrentRow.Cells[11].Value.ToString();
            cbuf.Text = dgfornecedores.CurrentRow.Cells[12].Value.ToString();

            //Alterar para a guia de dados pessoais
            tabControl1.SelectedTab = tabPage1;
        }

        private void Frmfornecedores_Load(object sender, EventArgs e)
        {
            FornecedorDAO dao = new FornecedorDAO();
            dgfornecedores.DataSource = dao.ListarTodosFornecedores();
        }
    }
}
