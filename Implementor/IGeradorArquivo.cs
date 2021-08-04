using BridgePattern.Domain;

namespace BridgePattern.Implementor
{
    public interface IGeradorArquivo
    {
        void GravarArquivo(Funcionario funcionario);
    }
}
