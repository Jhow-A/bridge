using BridgePattern.Domain;
using BridgePattern.Implementor;
using System;
using System.IO;
using System.Text.Json;

namespace BridgePattern.ConcreteImplementor
{
    class GerarJson : IGeradorArquivo
    {
        private const string nomeArquivo = "funcionario.json";

        public void GravarArquivo(Funcionario funcionario)
        {
            var funcionarioJson = JsonSerializer.Serialize(funcionario);
            File.WriteAllText(nomeArquivo, funcionarioJson);

            Console.WriteLine($"Salário para o funcionário {funcionario.Nome} gerdo com sucesso em {nomeArquivo} \n");
        }
    }
}
