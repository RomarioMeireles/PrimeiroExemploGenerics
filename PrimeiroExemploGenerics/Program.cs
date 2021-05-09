using System;
using System.Collections.Generic;

namespace PrimeiroExemploGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            //IList<int> numeros = new List<int>();
            //numeros.Add(1);
            //numeros.Add(2);
            //numeros.Add(3);
            //numeros.Add(4);
            //foreach (var item in numeros)
            //{
            //    Console.WriteLine(item);
            //}

            //IList<string> nomes = new List<string>();
            //nomes.Add("Romario");
            //nomes.Add("Meireles");
            //nomes.Add("Irina");
            //nomes.Add("Balta");
            //foreach (var item in nomes)
            //{
            //    Console.WriteLine(item);
            //}


            var professor = new Professor()
            {
                DataRegisto = DateTime.Now,
                Nome = "Amireldes Xavier",
                Numero = "2000",
                Sexo = "M",
                Id = 1
            };
            Console.WriteLine("-----Professor------");
            Console.WriteLine($"Nome: {professor.Nome}\nNumero:{professor.Numero}\nSexo:{professor.Sexo}\nId:{professor.Id}\nData de registo:{professor.DataRegisto}");

            var estudante = new Estudante()
            {
                DataRegisto = DateTime.Now,
                Nome = "Luisa Matumona",
                NumeroMatricula = "2000",
                Sexo = "M",
                Id = 1
            };
            Console.WriteLine("-----Estudante------");
            Console.WriteLine($"Nome: {estudante.Nome}\nNumero:{estudante.NumeroMatricula}\nSexo:{estudante.Sexo}\nId:{professor.Id}\nData de registo:{estudante.DataRegisto}");

            var utilizador = new Utilizador()
            {
                DataRegisto = DateTime.Now,
                Nome = "Romario Angelo",
                UserName = "romario",
                Sexo = "M",
                Id = Guid.NewGuid()
            };
            Console.WriteLine("-----Utilizador------");
            Console.WriteLine($"Nome: {utilizador.Nome}\nUserName:{utilizador.UserName}\nSexo:{utilizador.Sexo}\nId:{utilizador.Id}\nData de registo:{utilizador.DataRegisto}");
        }


    }
}
