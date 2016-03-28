using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCDD.Domain.Interface.InfraEstrutura
{
    public interface IUnidadeDeTrabalho
    {
        void Iniciar();
        void Persistir();
    }
}
