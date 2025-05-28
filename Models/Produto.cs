using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PedidoPackingAPI.Models;

public class Produto
{
    [Key]
    public int Id { get; set; }
    public double Altura { get; set; }
    public double Largura { get; set; }
    public double Comprimento { get; set; }

    [ForeignKey("Pedido")]
    public int PedidoId { get; set; }

    public double Volume => Altura * Largura * Comprimento;
}
