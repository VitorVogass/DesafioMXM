public class Pedido
{
    public string Codigo { get; set; }
    public DateTime DataPedido { get; set; }
    public decimal ValorTotal { get; set; }
    public bool Status { get; set; }
    public virtual Cliente Cliente { get; set; }
}
