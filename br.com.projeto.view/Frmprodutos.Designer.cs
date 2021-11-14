namespace Projeto_Vendas_Fatec_2.br.com.projeto.view
{
    partial class Frmprodutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbfornecedor = new System.Windows.Forms.ComboBox();
            this.txtestoque = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbfiltro = new System.Windows.Forms.ComboBox();
            this.dgprodutos = new System.Windows.Forms.DataGridView();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.txtconsulta = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgprodutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(269, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(609, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produtos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1259, 138);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(35, 171);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1193, 439);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbfornecedor);
            this.tabPage1.Controls.Add(this.txtestoque);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtpreco);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtdesc);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtcodigo);
            this.tabPage1.Controls.Add(this.lblcodigo);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1185, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados do Produto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbfornecedor
            // 
            this.cbfornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbfornecedor.FormattingEnabled = true;
            this.cbfornecedor.Items.AddRange(new object[] {
            "Coca-Cola",
            "Asus",
            "Microsoft"});
            this.cbfornecedor.Location = new System.Drawing.Point(165, 245);
            this.cbfornecedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbfornecedor.Name = "cbfornecedor";
            this.cbfornecedor.Size = new System.Drawing.Size(369, 33);
            this.cbfornecedor.TabIndex = 25;
            // 
            // txtestoque
            // 
            this.txtestoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtestoque.Location = new System.Drawing.Point(165, 190);
            this.txtestoque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtestoque.Name = "txtestoque";
            this.txtestoque.Size = new System.Drawing.Size(180, 30);
            this.txtestoque.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 246);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Fornecedor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 190);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Qtd Estoque:";
            // 
            // txtpreco
            // 
            this.txtpreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpreco.Location = new System.Drawing.Point(165, 124);
            this.txtpreco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(180, 30);
            this.txtpreco.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Preço:";
            // 
            // txtdesc
            // 
            this.txtdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesc.Location = new System.Drawing.Point(165, 69);
            this.txtdesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(472, 30);
            this.txtdesc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(165, 25);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(75, 30);
            this.txtcodigo.TabIndex = 1;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(73, 32);
            this.lblcodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(81, 25);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Código:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbfiltro);
            this.tabPage2.Controls.Add(this.dgprodutos);
            this.tabPage2.Controls.Add(this.btnconsultar);
            this.tabPage2.Controls.Add(this.txtconsulta);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1185, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta de Produtos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbfiltro
            // 
            this.cbfiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbfiltro.FormattingEnabled = true;
            this.cbfiltro.Items.AddRange(new object[] {
            "Nome"});
            this.cbfiltro.Location = new System.Drawing.Point(607, 33);
            this.cbfiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbfiltro.Name = "cbfiltro";
            this.cbfiltro.Size = new System.Drawing.Size(184, 33);
            this.cbfiltro.TabIndex = 34;
            // 
            // dgprodutos
            // 
            this.dgprodutos.AllowUserToAddRows = false;
            this.dgprodutos.AllowUserToDeleteRows = false;
            this.dgprodutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgprodutos.Location = new System.Drawing.Point(23, 94);
            this.dgprodutos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgprodutos.Name = "dgprodutos";
            this.dgprodutos.ReadOnly = true;
            this.dgprodutos.RowHeadersWidth = 51;
            this.dgprodutos.Size = new System.Drawing.Size(1143, 290);
            this.dgprodutos.TabIndex = 33;
            this.dgprodutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgprodutos_CellClick);
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(825, 26);
            this.btnconsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(159, 42);
            this.btnconsultar.TabIndex = 32;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.Btnconsultar_Click);
            // 
            // txtconsulta
            // 
            this.txtconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconsulta.Location = new System.Drawing.Point(105, 36);
            this.txtconsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtconsulta.Name = "txtconsulta";
            this.txtconsulta.Size = new System.Drawing.Size(472, 30);
            this.txtconsulta.TabIndex = 5;
            this.txtconsulta.TextChanged += new System.EventHandler(this.Txtconsulta_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(24, 39);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 25);
            this.label16.TabIndex = 4;
            this.label16.Text = "Dados:";
            // 
            // btneditar
            // 
            this.btneditar.Image = global::Projeto_Vendas_Fatec_2.Properties.Resources.editar;
            this.btneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneditar.Location = new System.Drawing.Point(725, 654);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(111, 52);
            this.btneditar.TabIndex = 34;
            this.btneditar.Text = "Editar";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.Btneditar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Image = global::Projeto_Vendas_Fatec_2.Properties.Resources.excluir;
            this.btnexcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexcluir.Location = new System.Drawing.Point(556, 654);
            this.btnexcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(123, 52);
            this.btnexcluir.TabIndex = 33;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.Btnexcluir_Click);
            // 
            // btncadastrar
            // 
            this.btncadastrar.Image = global::Projeto_Vendas_Fatec_2.Properties.Resources.salvar;
            this.btncadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncadastrar.Location = new System.Drawing.Point(360, 654);
            this.btncadastrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(131, 52);
            this.btncadastrar.TabIndex = 32;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.Btncadastrar_Click);
            // 
            // Frmprodutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 747);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frmprodutos";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.Frmprodutos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgprodutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbfiltro;
        private System.Windows.Forms.DataGridView dgprodutos;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.TextBox txtconsulta;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbfornecedor;
        private System.Windows.Forms.TextBox txtestoque;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btncadastrar;
    }
}