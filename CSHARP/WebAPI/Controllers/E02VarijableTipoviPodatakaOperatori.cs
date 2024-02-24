using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E02")]
    public class E02VarijableTipoviPodatakaOperatori:ControllerBase
    {
  

        // ovdje počinje ruta
        [HttpGet]
        [Route("zad1")]
        public int Zad1()
        {
            //zadatak 1.
            //Ruta vraća najveći int broj
            return int.MaxValue;
        }
        // ovdje završava ruta

        
        
        
        
        // ovdje počinje ruta
        [HttpGet]
        [Route("zad2")]
        public float Zad2(int a, int b)
        {
            //zadatak 2.
            //Ruta vraća kvocijent dvaju primljenih brojeva 
           
            return  a /(float) b;
        }
        // ovdje završava ruta



        // ovdje počinje ruta
        [HttpGet]
        [Route("zad3")]
        public float Zad3(int a, int b)
        {
            //zadatak 3.
            //Ruta prima dva cijela broja i
            //vraća zbroj umnoška i kvocijenta tih brojeva 

            return (a * b) + (a/(float)b);
        }
        // ovdje završava ruta



        // ovdje počinje ruta
        [HttpGet]
        [Route("zad4")]
        public bool Zad4(int a, int b)
        {
            //zadatak 4.
            //Ruta prima dva cijela broja i
            //vraća true ako je a=b inaće vraća false. 

            return a == b;
        }
        // ovdje završava ruta



        // ovdje počinje ruta
        [HttpGet]
        [Route("zad5")]
        public string Zad5(string a, string b)
        {
            //zadatak 4.
            //Ruta prima dva stringa i
            //vraća ih sljepljene s razmakom natrag. 

            return (a+" "+ b);
        }
        // ovdje završava ruta
    }
}
