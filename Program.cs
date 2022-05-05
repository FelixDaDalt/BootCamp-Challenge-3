﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Challenge3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio1();
            //Ejercicio3();
            //EJercicio5();
            //Ejercicio7();
            //Ejercicio11();
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

        public static void Ejercicio3()
        {
            List<int> lista = new List<int>(); /// creo lista
            Random num = new Random();

            for(int i = 0;i<10;i++) /// cargo con random 
            {
                lista.Add(num.Next(0,5));
            }

            foreach(int value in lista) /// muestro lista
            {
                Console.WriteLine(value);
            }
            Console.Write("Numero a eliminar: "); /// pido numero a eliminar
            int eliminar = Convert.ToInt32(Console.ReadLine());
            eliminarLista(lista, eliminar); /// metodo eliminar
            
            foreach (int value in lista) /// muestro
            {
                Console.WriteLine(value);
            }
        }

        public static void EJercicio5()
        {
            List<int> lista1 = new List<int>();
            List<int> lista2 = new List<int>();
            List<int> mezcla = new List<int>();

            LlenarLista(lista1);
            Thread.Sleep(1000);
            LlenarLista(lista2);

            lista1.Sort();
            Console.WriteLine("Lista 1");
            MostrarLista(lista1);

            lista2.Sort();
            Console.WriteLine("\nLista 2");
            MostrarLista(lista2);

            mezcla = Mezcla2(lista1, lista2);
            Console.WriteLine("\nLista Final");
            MostrarLista(mezcla);

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

            // muestro la lista,usado para comprobar
            foreach (int value in numero)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine($"Total: {sumarLista(numero, numero.Count - 1, 0)}");

        }

        public static void Ejercicio11()
        {
            List<Alumno11> alumnos = new List<Alumno11>();
            
            for (int x = 0; x < 10; x++)
            {
                alumnos.Add(new Alumno11());
                alumnos[x].Completar();

            }

            Console.Clear();
            CuatroMejores(alumnos);
            Console.WriteLine();
            OrdenaNota(alumnos);
        }


        #region Metodos 1
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

        #region Metodos 3
        static void eliminarLista(List<int> lis, int x)
        {
            lis.RemoveAll(eliminar => eliminar == x);
        }
        #endregion

        #region Metodos 5
        public static void LlenarLista(List<int>l)
        {
            Random num = new Random();
            for (int x = 0; x < num.Next(0, 10); x++)
            {
                l.Add(num.Next(0, 1000));

            }
        }

        public static void MostrarLista(List<int> l)
        {
            foreach(int value in l)
            {
                Console.WriteLine(value);
            }
        }

        public static List<int> Mezcla2(List<int> l1, List<int> l2)
        {
            List<int> listafinal = l1;

            for(int x = 0;x < l2.Count;x++)
            {
                listafinal.Add(l2[x]);
            }          

            return listafinal;
        }
        #endregion

        #region Metodos 7
        public static int sumarLista(List<int> lista,int pos,int suma)
        {
            if(pos >= 0)
            suma += lista[pos] + sumarLista(lista, pos - 1, suma);
            return suma;
        }
        #endregion

        #region Metodos 11
        public static void CuatroMejores(List<Alumno11> lista)
        {
            Console.WriteLine("Cuatro mejores promedios:");
            lista.Sort((x, y) => x.promedio.CompareTo(y.promedio)); // Ordeno segun promedio
            lista.Reverse();
            for (int x = 0; x < 4; x++) //muestro los primero 4
            {
               Console.WriteLine($"Alumno: {lista[x].nombre} - Promedio: {lista[x].promedio}");
            }
        }

        public static void OrdenaNota(List<Alumno11> lista)
        {
            Console.WriteLine("Alumnos por ultima nota");
            lista.Sort((x, y) => x.parcial3.CompareTo(y.parcial3)); // Ordeno segun nota 
            lista.Reverse();
            for (int x = 0; x < lista.Count; x++) // muestro todos
            {
                Console.WriteLine($"{lista[x].nombre} - {lista[x].parcial3}");
            }
        }
        #endregion

    }
}
