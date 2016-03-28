using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using ProjetCDD.Infra.Data.Contexto;

namespace ProjetCDD.Infra.Data.Configuration
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
