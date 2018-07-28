using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoWebAPI.Models;
//using System.Web.Http;

namespace ProjetoWebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Jogo")]
    public class JogoController : Controller
    {
        Jogo[] jogos = new Jogo[]
        {
            new Jogo(){ IdJogo = 1, Nome = "GTA V", Categoria = "sandbox"},
            new Jogo(){ IdJogo = 2, Nome = "Ragnarok", Categoria = "mmorpg"},
            new Jogo(){ IdJogo = 3, Nome = "Perfect World", Categoria = "mmorpg"}
        };

        public IEnumerable<Jogo> GetTodosJogos()
        {
            return jogos;
        }



        //     public IHttpActionResult

    }
}