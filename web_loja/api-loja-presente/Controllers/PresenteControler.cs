using System.Collections.Generic;
using api_loja_presente.DAO;
using api_loja_presente.Model;
using Microsoft.AspNetCore.Mvc;

namespace api_loja_presente.Controllers
{
    [ApiController]
    [Route("api/v1/presente")]
    public class PresenteControler : ControllerBase
    {
        [HttpGet]
        [Route("tipo")]
        public List<PresenteTipoEntity> presenteTipo(){
            
            List<PresenteTipoEntity> listaTipoPresente = new List<PresenteTipoEntity>();
            IPresenteTipoDAO presenteTipoDAO = new PresenteTipoDAO();
            listaTipoPresente = presenteTipoDAO.ListarTipoPresente();

            return listaTipoPresente;
        }

        [HttpGet]
        [Route("marca")]
        public List<PresenteMarcaEntity> presenteMarca(){
            
            List<PresenteMarcaEntity> listaMarcaPresente = new List<PresenteMarcaEntity>();
            IPresenteMarcaDAO presenteMarcaDAO = new PresenteMarcaDAO();
            listaMarcaPresente = presenteMarcaDAO.ListarMarcaPresente();

            return listaMarcaPresente;
        }

        [HttpGet]
        [Route("finalidade")]
        public List<PresenteFinalidadeEntity> presenteFinalidade(){
            
            List<PresenteFinalidadeEntity> listaFinalidadePresente = new List<PresenteFinalidadeEntity>();
            IPresenteFinalidadeDAO presenteFinalidadeDAO = new PresenteFinalidadeDAO();
            listaFinalidadePresente = presenteFinalidadeDAO.ListarFinalidadePresente();

            return listaFinalidadePresente;
        }

        [HttpGet]
        [Route("fornecedor")]
        public List<PresenteFornecedorEntity> presenteFornecedor(){
            
            List<PresenteFornecedorEntity> listaFornecedorPresente = new List<PresenteFornecedorEntity>();
            IPresenteFornecedorDAO presenteFornecedorDAO = new PresenteFornecedorDAO();
            listaFornecedorPresente = presenteFornecedorDAO.ListarFoenecedorPresente();

            return listaFornecedorPresente;
        }

        [HttpGet]
        [Route("presente")]
        public List<PresenteEntity> presente(){
            
            List<PresenteEntity> listaPresente = new List<PresenteEntity>();
            IPresenteDAO presenteDAO = new PresenteDAO();
            listaPresente = presenteDAO.ListarPresente();

            return listaPresente;
        }

        [HttpPost]
        [Route("cadPresente")]
        public void cadPresente(PresenteEntity presente){

            IPresenteDAO presenteDAO = new PresenteDAO();
            presenteDAO.CadPresente(presente);
        }
    }
}