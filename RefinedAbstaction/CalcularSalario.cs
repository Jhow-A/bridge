using BridgePattern.Abstraction;
using BridgePattern.Domain;
using BridgePattern.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.RefinedAbstaction
{
    public class CalcularSalario : AbstractionGerarArquivo
    {
        public CalcularSalario(IGeradorArquivo geradorArquivo) : base(geradorArquivo)
        {
        }

        public void ProcessarSalario(Funcionario funcionario)
        {
            funcionario.SalarioTotal = funcionario.SalarioBase + funcionario.Incentivo;

            Console.WriteLine($"Valor do Salário Total do funcionário {funcionario.Id} é R$ {funcionario.SalarioTotal}");

            geradorArquivo.GravarArquivo(funcionario);
        }
    }
}
