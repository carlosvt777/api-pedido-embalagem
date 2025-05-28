using System.ComponentModel.DataAnnotations;

namespace PedidoPackingAPI.Models;

public class Pedido
{
    [Key]
    public int Id { get; set; }

    public List<Produto> Produtos { get; set; } = new();
}
