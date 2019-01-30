using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("San Jose", 2019);
            escuela.Pais = "Perú";
            escuela.Ciudad = "Lima";
            escuela.TipoEscuela = TiposEscuela.Primaria;
            
            Console.WriteLine(escuela.Nombre);
        }
    }
}
