using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.MetodosDeExtension
{
    public static class Ordenamiento
    {
        /// <summary>
        /// Método que se encarga de modificar los valores de una lista de diccionarios 
        /// ordenandolos mediante el método de 'Burbujeo' centrandose en su precio.
        /// </summary>
        /// <param name="lista">Lista que contiene los diccionarios.</param>
        /// <param name="ordenamiento">Dependiendo de que opción de ordenamiento se ingrese, la función burbujeará en torno a lo solicitado.</param>
        /// <param name="key">Primer key del diccionario a ordenar.</param>
        public static void BubbleSortPorPrecio(this List<Dictionary<string, object>> lista, string ordenamiento, string key)
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
