using PedidoPackingAPI.Models;

namespace PedidoPackingAPI.Services;

public class PackingService
{
    private const double MAX_VOLUME = 50 * 50 * 50;

    public List<Caixa> EmpacotarProdutos(List<Produto> produtos)
    {
        var caixas = new List<Caixa>();
        var caixaAtual = new Caixa { CaixaId = 1 };
        double volumeAtual = 0;

        foreach (var produto in produtos)
        {
            if (volumeAtual + produto.Volume > MAX_VOLUME)
            {
                caixas.Add(caixaAtual);
                caixaAtual = new Caixa { CaixaId = caixaAtual.CaixaId + 1 };
                volumeAtual = 0;
            }

            caixaAtual.Produtos.Add(produto.Id);
            volumeAtual += produto.Volume;
        }

        caixas.Add(caixaAtual);
        return caixas;
    }
}
