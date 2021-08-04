using BridgePattern.Domain;
using BridgePattern.Implementor;

namespace BridgePattern.Abstraction
{
    public abstract class AbstractionGerarArquivo
    {
        protected IGeradorArquivo geradorArquivo;

        protected AbstractionGerarArquivo(IGeradorArquivo geradorArquivo)
        {
            this.geradorArquivo = geradorArquivo;
        }

        public virtual void GravarArquivo(Funcionario funcionario)
        {
            geradorArquivo.GravarArquivo(funcionario);
        }
    }
}
