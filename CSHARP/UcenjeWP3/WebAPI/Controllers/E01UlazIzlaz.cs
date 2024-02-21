using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E01")]
    public class E01UlazIzlaz:ControllerBase
    {
        // ovdje počinje ruta
        [HttpGet]
        [Route("Hello")]
        public string HelloWorld(string Ime)
        {
            return "Dobro večer " + Ime;
        }
        // ovdje završava ruta



        // ovdje počinje ruta
        [HttpGet]
        [Route("zad1")]
        public int Zad1(int prvi, int drugi)
        {
            
            return prvi + drugi;
        }
        // ovdje završava ruta

    }
}
