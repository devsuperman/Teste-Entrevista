using System;
using System.Collections.Generic;


namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaDeTestes = new List<List<int>>();

            listaDeTestes.Add(new List<int>() { 3, 1, 1, 3 });
            listaDeTestes.Add(new List<int>() { 1, 3, 2, 2 });
            listaDeTestes.Add(new List<int>() { 1, 1, 1, 3, 3, 2 });
            listaDeTestes.Add(new List<int>() { 3, 3, 1, 3, 3, 2 });


            listaDeTestes.ForEach(teste =>
            {
                var resultado = Formatador.FormatarLista(teste);
                Console.WriteLine(resultado);
            });
            

        }


    }
}
