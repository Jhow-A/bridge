using BridgePattern.Domain;
using BridgePattern.Implementor;
using System;
using System.IO;
using System.Xml.Serialization;

namespace BridgePattern.ConcreteImplementor
{
    public class GerarXML : IGeradorArquivo
    {
        private const string nomeArquivo = "funcionario.xml";

        public void GravarArquivo(Funcionario funcionario)
        {
            using (var fileStream = new FileStream(nomeArquivo, FileMode.OpenOrCreate))
            {
                var xmlSerializer = new XmlSerializer(typeof(Funcionario));
                Console.WriteLine($"Salário para o funcionário {funcionario.Nome} gerdo com sucesso em {nomeArquivo} \n");
            }
        }
    }
}
