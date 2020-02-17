using System.Collections.Generic;
using System.Linq;

namespace App
{
    public static class Formatador
    {
        public static string FormatarLista(List<int> lista)
        {
            var resultado = "";

            var listaFormatada = lista
                .GroupBy(a => a)
                .Where(a => a.Count() > 1)
                .OrderByDescending(a => a.Count())
                .ThenByDescending(a => a.Key)
                .Select(a => $"{a.Key} = {a.Count()}; ")
                .ToList();

            listaFormatada.ForEach(a => resultado += a);

            return resultado.Trim();
        }
    }
}