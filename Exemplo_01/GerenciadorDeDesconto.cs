namespace Refatorado
{
    public class GerenciadorDeDesconto
    {    
        private readonly ICalculaDescontoFidelidade _calculaDescontoFidelidade;
        private readonly ICalculaDescontoStatusContaFactory _calculaDescontoStatusContaFactory;
        public GerenciadorDeDesconto(ICalculaDescontoFidelidade calculaDescontoFidelidade, ICalculaDescontoStatusContaFactory calculaDescontoStatusContaFactory)
        {
            _calculaDescontoFidelidade = calculaDescontoFidelidade;
            _calculaDescontoStatusContaFactory = calculaDescontoStatusContaFactory;
        }
        public decimal AplicarDesconto(decimal preco, StatusContaCliente statusContaCliente, int tempoEmAnos)
        {
            decimal precoAposDesconto = 0;
            precoAposDesconto = _calculaDescontoStatusContaFactory.GetCalculoDescontoStatusConta(statusContaCliente).AplicarDescontoStatusConta(preco);     
            precoAposDesconto = _calculaDescontoFidelidade.AplicarDescontoFidelidade(precoAposDesconto, tempoEmAnos);
            return precoAposDesconto;
        }
    }
}