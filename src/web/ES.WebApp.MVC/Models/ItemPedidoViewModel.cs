using System;

namespace ES.WebApp.MVC.Models
{   
    public class ItemPedidoViewModel
    {
        public Guid ProdutoId { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public string Imagem { get; set; }
    }


}
