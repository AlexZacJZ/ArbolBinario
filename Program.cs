using System;

namespace ArbolBinario
{
    class Program
    {
        static void Main(string[] args)
        {

            ArbolBinarioBusqueda<int> abbenteros = new ArbolBinarioBusqueda<int>();
            //delegado mayor y menor para enteros
            Func<int, int, bool> MenorQueEntero = (x, y) => x < y;
            Func<int, int, bool> MayorQueEntero = (x, y) => x > y;
            //agregar nuevas llaves a la EDD
            abbenteros.Insertar(50, MenorQueEntero, MayorQueEntero);
            abbenteros.Insertar(35, MenorQueEntero, MayorQueEntero);
            abbenteros.Insertar(80, MenorQueEntero, MayorQueEntero);
            abbenteros.Insertar(10, MenorQueEntero, MayorQueEntero);
            abbenteros.Insertar(5, MenorQueEntero, MayorQueEntero);
            abbenteros.Insertar(20, MenorQueEntero, MayorQueEntero);
            abbenteros.Insertar(79, MenorQueEntero, MayorQueEntero);
            abbenteros.Insertar(21, MenorQueEntero, MayorQueEntero);
            abbenteros.Insertar(1, MenorQueEntero, MayorQueEntero);
            //abbenteros.MostrarArbol(abbenteros.raiz, "");
            //Console.WriteLine("Inicia elimina un nodo");
            //abbenteros.Eliminar(1, MenorQueEntero, MayorQueEntero);
            //Console.WriteLine(abbenteros.MuestraNodo(abbenteros.raiz, 21, MenorQueEntero, MayorQueEntero));
            //Console.WriteLine("Inicia dibuja arbol");
            //abbenteros.MostrarArbol(abbenteros.raiz, "");
            Console.WriteLine(abbenteros.Actualizarfe(abbenteros.raiz));
            //Console.WriteLine(abbenteros.Altura(abbenteros.raiz));


        }
    }
}

