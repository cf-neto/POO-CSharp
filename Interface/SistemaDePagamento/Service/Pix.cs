using Estudando.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudando.Service
{
    public class Pix : IPayament
    {
        public void Pagar(double valor)
        {
            Console.WriteLine($"[Pix] Pagamento de R$ {valor} instantâneo");
        }
    }
}
