namespace Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public string Item { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public Cliente Cliente { get; set; }
    }
}
