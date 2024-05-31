using System;

namespace Herencia_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool intentar = false;
            Caballo miCaballo = new Caballo("Paso Largo", 5);
            Humano miHumano = new Humano("Hamel", 19);
            Perro miPerro = new Perro("Chivi", 3);

            Console.WriteLine("Elije un número para ver las características de los mamíferos:\n1.Caballo \n2.Humano \n3.Perro");

            while (!intentar)
            {
                try
                {
                    int miOpcion = Convert.ToInt32(Console.ReadLine());
                    if (miOpcion == 1)
                    {
                        Console.WriteLine($"\nEl caballo se llama: {miCaballo.GetDatos()}");
                        miCaballo.Respirar();
                        miCaballo.Comer();
                        miCaballo.Galopar();

                        intentar = true;
                    }
                    else if (miOpcion == 2)
                    {
                        Console.WriteLine($"\nEl caballo se llama: {miHumano.GetDatos()}");
                        miHumano.Respirar();
                        miHumano.Comer();
                        miHumano.Hablar();

                        intentar = true;
                    }
                    else if (miOpcion == 3)
                    {
                        Console.WriteLine($"\nEl caballo se llama: {miPerro.GetDatos()}");
                        miPerro.Respirar();
                        miPerro.Comer();
                        miPerro.Ladrar();

                        intentar = true;
                    }
                    else
                    {
                        throw new IndexOutOfRangeException();
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine("Haz cometido un excepción de tipo: " + e.Message + " al elegir una opción");
                    Console.WriteLine("Vuelva a intentarlo-Introduzca un numero del 1 al 3");
                    intentar = false;
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("Haz cometido un excepción de tipo: " + e.Message + " al elegir una opción");
                    Console.WriteLine("Vuelva a intentarlo-Introduzca un numero del 1 al 3");
                    intentar = false;
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("Haz cometido un excepción de tipo: " + e.Message + " al elegir una opción");
                    Console.WriteLine("Vuelva a intentarlo-Introduzca un numero del 1 al 3");
                    intentar = false;
                }

            }
        }
    }
    class Mamiferos
    {
        private string nombre;
        private int edad;

        public Mamiferos(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public String GetDatos()
        {
            return nombre + " y tiene: " + edad + " años";
        }
        public void Respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }
        public void Comer()
        {
            Console.WriteLine("Soy capaz de comer");
        }

    }
    class Humano : Mamiferos
    {
        public Humano(string nombre, int edad) : base(nombre, edad)
        {

        }
        public void Hablar()
        {
            Console.WriteLine("Soy capaz de hablar");
        }
    }
    
    class Caballo : Mamiferos
    {
        public Caballo(string nombre, int edad):base(nombre, edad)
        {

        }
        public void Galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
    }

    class Perro : Mamiferos
    {
        public Perro(string nombrePerro, int edadPerro):base(nombrePerro, edadPerro)
        {

        }        
        public void Ladrar()
        {
            Console.WriteLine("Soy capaz de ladrar");
        }
    }
}
