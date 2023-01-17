namespace Refatorado
{
    public class CalculaDescontoStatusContaClienteVip : ICalculaDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal preco)
        {
            decimal precoAposDesconto = 0;
            precoAposDesconto = (preco - (Constantes.DESCONTO_CLIENTE_VIP * preco));
            return precoAposDesconto;
        }
    }
}