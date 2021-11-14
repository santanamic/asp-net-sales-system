namespace Projeto_Vendas_Fatec_2.br.com.projeto.view
{
    partial class Frmmenu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_cadproduto = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_relatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbllogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbldata = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblhoraatual = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.históricoDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.funcionáriosToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.menu_relatorios});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarClienteToolStripMenuItem,
            this.consultaDeClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Image = global::Projeto_Vendas_Fatec_2.Properties.Resources.clientes;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // cadastrarClienteToolStripMenuItem
            // 
            this.cadastrarClienteToolStripMenuItem.Name = "cadastrarClienteToolStripMenuItem";
            this.cadastrarClienteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.cadastrarClienteToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.cadastrarClienteToolStripMenuItem.Text = "Cadastrar Cliente";
            this.cadastrarClienteToolStripMenuItem.Click += new System.EventHandler(this.CadastrarClienteToolStripMenuItem_Click);
            // 
            // consultaDeClientesToolStripMenuItem
            // 
            this.consultaDeClientesToolStripMenuItem.Name = "consultaDeClientesToolStripMenuItem";
            this.consultaDeClientesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.consultaDeClientesToolStripMenuItem.Text = "Consulta de clientes";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeFuncionáriosToolStripMenuItem,
            this.consultaDeFuncionáriosToolStripMenuItem});
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // cadastroDeFuncionáriosToolStripMenuItem
            // 
            this.cadastroDeFuncionáriosToolStripMenuItem.Name = "cadastroDeFuncionáriosToolStripMenuItem";
            this.cadastroDeFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.cadastroDeFuncionáriosToolStripMenuItem.Text = "Cadastro de funcionários";
            // 
            // consultaDeFuncionáriosToolStripMenuItem
            // 
            this.consultaDeFuncionáriosToolStripMenuItem.Name = "consultaDeFuncionáriosToolStripMenuItem";
            this.consultaDeFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.consultaDeFuncionáriosToolStripMenuItem.Text = "Consulta de funcionários";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_cadproduto,
            this.consultaDeProdutosToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // menu_cadproduto
            // 
            this.menu_cadproduto.Name = "menu_cadproduto";
            this.menu_cadproduto.Size = new System.Drawing.Size(188, 22);
            this.menu_cadproduto.Text = "Cadastro de Produto";
            // 
            // consultaDeProdutosToolStripMenuItem
            // 
            this.consultaDeProdutosToolStripMenuItem.Name = "consultaDeProdutosToolStripMenuItem";
            this.consultaDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.consultaDeProdutosToolStripMenuItem.Text = "Consulta de Produtos";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.históricoDeVendasToolStripMenuItem,
            this.novaVendaToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // menu_relatorios
            // 
            this.menu_relatorios.Name = "menu_relatorios";
            this.menu_relatorios.Size = new System.Drawing.Size(71, 20);
            this.menu_relatorios.Text = "Relatórios";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbllogado,
            this.toolStripStatusLabel2,
            this.lbldata,
            this.toolStripStatusLabel3,
            this.lblhoraatual});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(90, 17);
            this.toolStripStatusLabel1.Text = "Usuário logado:";
            // 
            // lbllogado
            // 
            this.lbllogado.Name = "lbllogado";
            this.lbllogado.Size = new System.Drawing.Size(86, 17);
            this.lbllogado.Text = "Caio Malheiros";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(34, 17);
            this.toolStripStatusLabel2.Text = "Data:";
            // 
            // lbldata
            // 
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(65, 17);
            this.lbldata.Text = "08/10/2021";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabel3.Text = "Hora:";
            // 
            // lblhoraatual
            // 
            this.lblhoraatual.Name = "lblhoraatual";
            this.lblhoraatual.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // históricoDeVendasToolStripMenuItem
            // 
            this.históricoDeVendasToolStripMenuItem.Name = "históricoDeVendasToolStripMenuItem";
            this.históricoDeVendasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.históricoDeVendasToolStripMenuItem.Text = "Histórico de Vendas";
            this.históricoDeVendasToolStripMenuItem.Click += new System.EventHandler(this.HistóricoDeVendasToolStripMenuItem_Click);
            // 
            // novaVendaToolStripMenuItem
            // 
            this.novaVendaToolStripMenuItem.Name = "novaVendaToolStripMenuItem";
            this.novaVendaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novaVendaToolStripMenuItem.Text = "Nova Venda";
            this.novaVendaToolStripMenuItem.Click += new System.EventHandler(this.NovaVendaToolStripMenuItem_Click);
            // 
            // Frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frmmenu";
            this.Text = "Menu principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frmmenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeFuncionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeFuncionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel lbllogado;
        public System.Windows.Forms.ToolStripMenuItem menu_relatorios;
        public System.Windows.Forms.ToolStripMenuItem menu_cadproduto;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lbldata;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblhoraatual;
        private System.Windows.Forms.ToolStripMenuItem históricoDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaVendaToolStripMenuItem;
    }
}