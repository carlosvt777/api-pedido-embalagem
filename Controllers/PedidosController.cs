using Microsoft.AspNetCore.Mvc;
using PedidoPackingAPI.Models;
using PedidoPackingAPI.Services;
using PedidoPackingAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace PedidoPackingAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PedidosController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly PackingService _service = new();

    public PedidosController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost("empacotar")]
    public async Task<IActionResult> EmpacotarAsync([FromBody] List<Pedido> pedidos)
    {
        var resultado = new List<object>();

        foreach (var pedido in pedidos)
        {
            // Salva o pedido no banco
            _context.Pedidos.Add(pedido);
            await _context.SaveChangesAsync();

            // Empacota os produtos
            var caixas = _service.EmpacotarProdutos(pedido.Produtos);

            resultado.Add(new
            {
                pedidoId = pedido.Id,
                caixas
            });
        }

        return Ok(resultado);
    }
}
