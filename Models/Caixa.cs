namespace PedidoPackingAPI.Models;

public class Caixa
{
    public int CaixaId { get; set; }
    public List<int> Produtos { get; set; } = new();
}
