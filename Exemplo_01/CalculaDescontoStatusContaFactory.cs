using System;

namespace Refatorado
{
    public class CalculaDescontoStatusContaFactory : ICalculaDescontoStatusContaFactory
    {
        public ICalculaDescontoStatusConta GetCalculoDescontoStatusConta(StatusContaCliente statusContaCliente)
        {
            ICalculaDescontoStatusConta clienteStatus;
            switch (statusContaCliente)
            {

                case (StatusContaCliente.NaoRegistrado):
                    clienteStatus = new CalculaDescontoStatusContaClienteNaoRegistrado();
                    break;

                case (StatusContaCliente.ClienteComum):
                    clienteStatus = new CalculaDescontoStatusContaClienteComum();
                    break;

                case (StatusContaCliente.ClienteEspecial):
                    clienteStatus = new CalculaDescontoStatusContaClienteEspecial();
                    break;

                case (StatusContaCliente.ClienteVip):
                    clienteStatus = new CalculaDescontoStatusContaClienteVip();
                    break;

                default:
                    throw new Exception("Escolha uma opção válida de status de conta do cliente.");
            }
            return clienteStatus;         
        }
    }
}