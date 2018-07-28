using ProjetoWebAPI2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjetoWebAPI2.Controllers
{
    public class JogoController : ApiController
    {
        Jogo[] jogos = new Jogo[]
        {
            new Jogo(){ IdJogo = 1, Nome = "GTA V", Categoria = "sandbox"},
            new Jogo(){ IdJogo = 2, Nome = "Ragnarok", Categoria = "mmorpg"},
            new Jogo(){ IdJogo = 3, Nome = "Perfect World", Categoria = "mmorpg"}
        };
        
   //     [Route("api/jogo")]
        public IEnumerable<Jogo> GetTodosJogos()
        {
            return jogos;
        }

     //   [Route("api/jogo/{categoria}")]
        public IEnumerable<Jogo> GetTodosJogosPorCategoria(string categoria)
        {
            return jogos.Where(j => j.Categoria == categoria);
        }

        public IEnumerable<String> GetTodasCategorias()
        {
            List<string> categorias = new List<string>();

            foreach(var j in jogos.OrderBy(j => categorias))
            {
                if (!categorias.Contains(j.Categoria))
                {
                    categorias.Add(j.Categoria);
                }
            }

            return categorias;
        }

        public Jogo GetTodosJogos(int id)
        {
            return jogos.FirstOrDefault(j => j.IdJogo == id);
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}