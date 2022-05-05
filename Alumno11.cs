using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    internal class Alumno11
    {

        private double _promedio;
        private string _nombre;
        private double _parcial1;
        private double _parcial2;
        private double _parcial3;


        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public double parcial1
        {
            get { return _parcial1; }
            set { _parcial1 = value; }
        }
        public double parcial2
        {
            get { return _parcial2; }
            set { _parcial2 = value; }
        }
        public double parcial3
        {
            get { return _parcial3; }
            set { _parcial3 = value; }
        }
        public double promedio
        {
           get { return _promedio; }
           
        }

        public Alumno11()
        {

        }

        public void Completar()
        {
            Random n = new Random();
            bool error; 
            do
            {
                error = false;
                try
                {
                    string nom = "";
                    do
                    {
                        Console.Write("Nombre: ");
                        nom = Console.ReadLine();
                        if (nom.Length <= 20)
                            nombre = nom;
                    } while (nom.Length > 20);

                    do
                    {
                        parcial1 = n.Next(0,11);
                    } while (parcial1 < 0 || parcial1 > 10);

                    do { 
                    parcial2 = n.Next(0, 11);
                    } while (parcial2 < 0 || parcial2 > 10) ;

                    do{ 
                    parcial3 = n.Next(0, 11);
                    } while (parcial3 < 0 || parcial3 > 10);

                    _promedio = (parcial1+parcial2+parcial3)/3;

                }
                catch (Exception)
                {
                    Console.WriteLine("Error, vuelva a cargar");
                    error = true;
                }
            } while (error);
        }

        public void MostrarPromedio()
        {
            Console.WriteLine($"Nombre: {nombre} - Promedio:{promedio}");

        }


    }
}
