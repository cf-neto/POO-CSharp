using Estudando.Interface;
using System;

namespace Estudando.Service
{
    public class PagamentoCartao : IPayament
    {
        public void Pagar(double valor)
        {
            valor = valor * 1.05;
            Console.WriteLine($"[Cartão] Pagamento de R$ {valor} realizado com uma taxa de 5%.");
            double payament = valor;
        }
    }
}
