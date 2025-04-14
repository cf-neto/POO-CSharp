using Estudando.Interface;
using System;

namespace Estudando.Service
{
    public class PagamentoDinheiro : IPayament
    {
        public void Pagar(double valor)
        {
            valor = valor * 1.10;
            Console.WriteLine($"[Dinheiro] Pagamento de R$ {valor}");
            double payament = valor;
        }
    }
}
