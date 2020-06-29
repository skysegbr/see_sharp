using System.Collections.Generic;
using api_loja_presente.Model;

namespace api_loja_presente.DAO
{
    public interface IPresenteDAO
    {
        List<PresenteEntity> ListarPresente();
        void CadPresente(PresenteEntity presente);
    }
}