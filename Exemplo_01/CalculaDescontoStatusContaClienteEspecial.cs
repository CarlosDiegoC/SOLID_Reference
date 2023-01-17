namespace Refatorado
{
    public class CalculaDescontoStatusContaClienteEspecial : ICalculaDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal preco)
        {
            decimal precoAposDesconto = 0;
            precoAposDesconto = (preco - (Constantes.DESCONTO_CLIENTE_ESPECIAL * preco));
            return precoAposDesconto;
        }
    }
}