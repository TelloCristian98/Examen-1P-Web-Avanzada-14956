using System;

namespace Examen_1P
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1: Variables y Operadores en C#
            int numero1 = 0;
            Console.WriteLine("Ingrese un numero entero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            int numero2 = 0;
            Console.WriteLine("Ingrese un numero entero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            int resultado = numero1 + numero2;
            Console.WriteLine($"La suma de los numeros {numero1} y {numero2} es: {resultado}\n");

            //Ejercicio 2: Estructuras de Control en C#
            int numero_edad = 0;
            Console.WriteLine("Ingrese su edad: ");
            numero_edad = Convert.ToInt32(Console.ReadLine());
            if (numero_edad >= 18)
            {
                Console.WriteLine("Usted es mayor de edad\n");
            }
            else
            {
                Console.WriteLine("Usted es menor de edad\n");
            }

            //Ejercicio 3: Programación Orientada a Objetos - Clases y Objetos
            Estudiante estudiante1 = new Estudiante();
            estudiante1.Nombre = "Juan";
            estudiante1.Edad = 20;
            estudiante1.Calificacion = 8.5f;
            Console.WriteLine($"Nombre: {estudiante1.Nombre}");
            Console.WriteLine($"Edad: {estudiante1.Edad}");
            Console.WriteLine($"Calificacion: {estudiante1.Calificacion}\n");

            //Ejercicio 4: Programación Orientada a Objetos - Métodos
            estudiante1.MostrarInformacion();

            //Ejercicio 5: Programación Orientada a Objetos - Herencia
            EstudianteGraduado graduado1 = new EstudianteGraduado("Pedro", 25, 9.5f, "Ingeniero");
            graduado1.MostrarInformacion();
        }
    }
}