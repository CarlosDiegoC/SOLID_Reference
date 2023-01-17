namespace Refatorado
{
    public class CalculaDescontoStatusContaClienteComum : ICalculaDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal preco)
        {
            decimal precoAposDesconto = 0;
            precoAposDesconto = (preco - (Constantes.DESCONTO_CLIENTE_COMUM * preco));
            return precoAposDesconto;
        }
    }
}