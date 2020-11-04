using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetExample.Controllers
{
    [Route("/")] // Define a rota "Master" desse controller
    public class HomeController : Controller
    {
        [HttpGet] // Expecifica q isso é um httpGet (Padrão) 
        public IActionResult Index()
        {
            return View(); // Retorna a view q esta nas pasta view 
            // Ele segue a ondem de pesquisa para achar a view dessa forma:
            // Views/<ControllerName>/<FunctionName>
            // Views/Shared/<FunctionName>
            // Caso queira algo mais profundo
            // https://docs.microsoft.com/pt-br/aspnet/core/mvc/views/overview?view=aspnetcore-3.1
        }

        // [HttpPost("/enviar")] tbm pode ser usado assim
        [HttpPost]
        [Route("/enviar")] // pode ser usado mais de uma rota na mesma função e as duas vão funcionar
        public IActionResult ReceberDado([FromBody] string data) // vc recebe uma string do body da requisição
        {
            return Ok("teste");
            // Caso vc faça um post para localhost/enviar ele retornara codigo 200 (Ok)
            // Com o conteudo "teste"
        }

        //  Mais coisas q vc pode ler sobre
        // https://docs.microsoft.com/pt-br/aspnet/core/mvc/controllers/actions?view=aspnetcore-3.1
        // https://docs.microsoft.com/pt-br/aspnet/core/mvc/controllers/routing?view=aspnetcore-3.1
        // https://docs.microsoft.com/pt-br/aspnet/core/mvc/controllers/dependency-injection?view=aspnetcore-3.1

        // Sim ta tudo meio q explicado em topicos então aproveite a documentação
        // https://docs.microsoft.com/pt-br/aspnet/core/getting-started/?view=aspnetcore-3.1&tabs=windows
    }
}
