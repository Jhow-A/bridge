using BridgePattern.ConcreteImplementor;
using BridgePattern.Domain;
using BridgePattern.RefinedAbstaction;
using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionario = new Funcionario()
            {
                Id = 1,
                Nome = "Jhonathan",
                SalarioBase = 1000,
                Incentivo = 200
            };

            //RedefinedAbestraction recebe via construtor a implementação de IGeradorArquivo (Bridge)
            var calcularSalario = new CalcularSalario(new GerarXML());
            calcularSalario.ProcessarSalario(funcionario);

            funcionario.Incentivo = 500;

            calcularSalario = new CalcularSalario(new GerarJson());
            calcularSalario.ProcessarSalario(funcionario);
        }
    }
}
