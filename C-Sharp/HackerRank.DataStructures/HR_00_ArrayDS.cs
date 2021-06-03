namespace HackerRank.DataStructures
{
    using System.Collections.Generic;

    public class HR_00_ArrayDS
    {
        public static List<int> ReverseArray(List<int> lista)
        {
            var listaAuxiliar = new List<int>();

            for (int i = lista.Count - 1; i >= 0; i--)
            {
                listaAuxiliar.Add(lista[i]);
            }
            return listaAuxiliar;
        }
    }
}