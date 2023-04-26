using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoContrato.Services
{
    internal interface ITaxaService
    {
        double TaxaServico(double valor);
        double TaxaJuros(double valor, int meses);
    }
}
