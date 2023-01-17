namespace Refatorado
{
    public class CalculaDescontoFidelidade : ICalculaDescontoFidelidade
    {
        public decimal AplicarDescontoFidelidade(decimal preco, int tempoEmAnos)
        {
            decimal descontoPorFidelidade = (tempoEmAnos > Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE) ? (decimal)5 / 100 : (decimal)tempoEmAnos / 100;
            return preco - preco * descontoPorFidelidade;
        }
    }
}