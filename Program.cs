using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicio1();
            Ejercicio7();
            Console.ReadKey();

        }
        public static void Ejercicio1()
        {
            Alumno[] alumnos = new Alumno[30];
            cargarAlumnos(alumnos);
            Array.Sort(alumnos, (x, y) => x.numero.CompareTo(y.numero));
            do
            {
                Console.Clear();
                buscarAlumno(alumnos);
                Console.WriteLine("Presione S para continuar buscando");
            } while (Console.ReadKey().Key == ConsoleKey.S);
        }

        public static void Ejercicio7()
        {
            List<int> numero = new List<int>(); // creo lista
            Random numeroRnd = new Random();

            int cantidad;               // cantidad de elemtos en la lista
            do {
                Console.Write("Cantidad de elemtos: ");
            } while (!Int32.TryParse(Console.ReadLine(), out cantidad));

            for (int i = 0; i < cantidad; i++) // lleno lista con randoms
            {
                numero.Add(numeroRnd.Next(0, 2000));
            }

            //// Para mostrar la lista,usado para comprobar
            //foreach(int value in numero) 
            //{
            //    Console.WriteLine(value);
            //}

            Console.WriteLine($"Total: {sumarLista(numero, numero.Count - 1, 0)}");

        }

        #region METODOS 1
        static void cargarAlumnos(Alumno[]arreglo)
        {
            Random numero = new Random();

            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = new Alumno();
                arreglo[i].numero = numero.Next(0, 12000);
                arreglo[i].parcial1 = numero.Next(1, 11);
                arreglo[i].parcial2 = numero.Next(1, 11);
                arreglo[i].parcial3 = numero.Next(1, 11);
                arreglo[i].parcial4 = numero.Next(1, 11);
            }
        }

        static void buscarAlumno(Alumno[] alumno)
        {
            int numero;

                do
                {
                    Console.Write("Numero de alumno: ");
                } while (!Int32.TryParse(Console.ReadLine(), out numero));

                for (int x = 0; x < alumno.Length; x++)
                {
                    if (alumno[x].numero == numero)
                    {
                        Console.WriteLine($"Parcial 1:{alumno[x].parcial1} ");
                        Console.WriteLine($"Parcial 2:{alumno[x].parcial2} ");
                        Console.WriteLine($"Parcial 3:{alumno[x].parcial3} ");
                        Console.WriteLine($"Parcial 4:{alumno[x].parcial4} ");
                        return;
                    }
                    ///CARGA
                    //do
                    //{
                    //    bandera = true;
                    //    try
                    //    {
                    //        Console.Write("Parcial 1: ");
                    //        alumno[x].parcial1 = Convert.ToInt32(Console.ReadLine());
                    //        Console.Write("Parcial 2: ");
                    //        alumno[x].parcial2 = Convert.ToInt32(Console.ReadLine());
                    //        Console.Write("Parcial 3: ");
                    //        alumno[x].parcial3 = Convert.ToInt32(Console.ReadLine());
                    //    }
                    //    catch (Exception)
                    //    {
                    //        Console.WriteLine("error");
                    //        bandera = false;
                    //    }
                    //} while (bandera == false);


                }
                Console.WriteLine("No se encontro el alumno");

}
        #endregion

        #region METODOS 7
        public static int sumarLista(List<int> lista,int pos,int suma)
        {
            if(pos >= 0)
            suma += lista[pos] + sumarLista(lista, pos - 1, suma);
            return suma;
        }
        #endregion

    }
}
