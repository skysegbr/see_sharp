using System;
using System.Collections.Generic;
using System.Text.Json;
using APIautorizador.DAO;
using APIAutorizador.Entity;
using Microsoft.AspNetCore.Mvc;

namespace webAPI.Controllers
{
    [ApiController]
    [Route("api/planos")]
    public class PlanosController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public List<string> planos(string plas){
            
            List<string> json = new List<string>();

            string jsonString = "";
            List<PlanoSaudeEntity> listaPlanos = new List<PlanoSaudeEntity>();
            PlanoSaudeEntity plano = new PlanoSaudeEntity();
            IPlanoSaudeDAO planoDao = new PlanoSaudeDAO();
            listaPlanos = planoDao.Listar(plas);
            
            foreach (PlanoSaudeEntity p in listaPlanos)
            {
                //Console.WriteLine(plas);
                jsonString = JsonSerializer.Serialize(p);
                json.Add(jsonString.Replace('"', ' '));
            }

            return json;
        }
        
    }

}