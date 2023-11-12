using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.MetodosDeExtension
{
    public static class Ordenamiento
    {
        public static void BubbleSortPorKey(this List<Dictionary<string, object>> lista, string ordenamiento, string key)
        {
            int tam = lista.Count;

            for (int i = 0; i < tam - 1; i++)
            {
                for (int j = i + 1; j < tam; j++)
                {
                    if (ordenamiento == "Ascendente" && (float)lista[i][key] > (float)lista[j][key]
                        || ordenamiento == "Descendente" && (float)lista[i][key] < (float)lista[j][key])
                    {
                        var aux = lista[i];
                        lista[i] = lista[j];
                        lista[j] = aux;
                    }
                }
            }
        }
    }
}
