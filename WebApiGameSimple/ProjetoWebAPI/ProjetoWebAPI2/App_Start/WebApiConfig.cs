using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ProjetoWebAPI2
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Serviços e configuração da API da Web

            // Rotas da API da Web
            config.MapHttpAttributeRoutes();


            /*    config.Routes.MapHttpRoute(
                    name: "GetTodosJogosPorCategoria",
                    routeTemplate: "api/jogo/{categoria}",
                    defaults: new { categoria = RouteParameter.Optional, action = "GetTodosJogosPorCategoria", controller = "Jogo" }
                );
                */

            config.Routes.MapHttpRoute(
                name: "GetTodasCategorias",
                routeTemplate: "api/categorias",
                defaults: new { id = RouteParameter.Optional, action = "GetTodasCategorias", controller = "Jogo" }
            );

            config.Routes.MapHttpRoute(
                name: "GetJogo",
                routeTemplate: "api/jogo/{id}",
                defaults: new { action = "GetTodosJogos", controller = "Jogo" }
            );

            config.Routes.MapHttpRoute(
                name: "GetJogoPorCategoria",
                routeTemplate: "api/categoria/{categoria}",
                defaults: new { action = "GetTodosJogosPorCategoria", controller = "Jogo" }
            );

            config.Routes.MapHttpRoute(
                name: "GetTodosJogos",
                routeTemplate: "api/jogo",
                defaults: new { action = "GetTodosJogos", controller = "Jogo" }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
