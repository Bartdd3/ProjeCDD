using System.Web;
using ProjetCDD.Infra.Data.Configuration;
using ProjetCDD.Infra.Data.Contexto;

namespace ProjetCDD.Infra.Data.configurations
{
    public class GerenciadorDeRepositorio : IGerenciadorDeRepositorio

    {
        public const string ContextoHttp = "ContextoHttp";

        public ContextoBanco Contexto
        {
            get
            {
                if (HttpContext.Current.Items[ContextoHttp] == null)
                    HttpContext.Current.Items[ContextoHttp] = new ContextoBanco();
                    return HttpContext.Current.Items[ContextoHttp] as ContextoBanco;
            }
        }

        public void Finalizar()
        {
            if(HttpContext.Current.Items[ContextoHttp]!=null)
                (HttpContext.Current.Items[ContextoHttp] as ContextoBanco).Dispose();
        }
    }
}
