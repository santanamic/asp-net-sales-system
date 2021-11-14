using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Vendas_Fatec_2.br.com.projeto.model
{
   public class ItemVenda
    {
        //Atributos / propriedades
        public int id { get; set; }
        public int venda_id { get; set; }
        public int produto_id { get; set; }
        public int qtd { get; set; }
        public decimal subtotal { get; set; }
    }
}
