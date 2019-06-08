using System;

namespace PruebaPaEstudiar
{
    class Program
    {
        static int a,b,c;
        static string nombre = "Magic Johnson";
        static string nombre2 = "Michael";
        static string nombre3 = "Tim";
        static string nombre4 = "Steve";
        static string  curso1 = "Matematica1";
        static string  curso2 = "Estructuras1";
        static string  curso3 = "Programacion1";
        static string  curso4 = "Fisica 1";
        static void Main(string[] args)
        {
            Console.WriteLine("1.Nombre");
           Console.WriteLine("2.Carnet");
           Console.WriteLine("3.Curso");
           Console.WriteLine("4.Toda la tabla");
           b = int.Parse(Console.ReadLine());
            switch (b)
            {
                case 4:
Console.WriteLine("Elige a un estudiante para ver sus datos eligiendo el numero de estudiante");
            System.Console.WriteLine("");
           Console.WriteLine("1.Estudiante NO1");
           Console.WriteLine("2.Estudiante NO2");
           Console.WriteLine("3.Estudiante NO3");
           Console.WriteLine("4.Estudiante NO4");
           a = int.Parse(Console.ReadLine());
           Console.WriteLine(" ");
           int nota11 = 99,nota12= 99,nota13 = 99, nota1fin = 100;
           int nota21 = 99,nota22= 99,nota23 = 98, nota2fin = 99;
           int nota31 = 85,nota32= 85,nota33 = 90, nota3fin = 95;
           int nota41 = 99,nota42= 100,nota43 = 98, nota4fin = 99;
           switch (a)
           {
               case 1:
               Console.WriteLine("NOMBRE: " + nombre);
               Console.WriteLine("CARNET: " + 120120120);
               System.Console.WriteLine("Curso " + curso1);
System.Console.WriteLine("El sistema de notas obtenidas es: ");
               Console.WriteLine("NOTA 1|NOTA 2|NOTA 3|NOTA FINAL|PROMEDIO|APROBACION|");
               Console.Write("| " + nota11 + " |");
               Console.Write("  " + nota12 + " |");
               Console.Write("   " + nota13 + "   |");
               Console.Write("    " + nota1fin + "   |");
               hola(nota11,nota12,nota13,nota1fin);

               break;

               case 2:
               Console.WriteLine("NOMBRE: " + nombre2);
               Console.WriteLine("CARNET: " + 121121121);
               System.Console.WriteLine("Curso " + curso2);
System.Console.WriteLine("El sistema de notas obtenidas es: ");
               Console.WriteLine("NOTA 1|NOTA 2|NOTA 3|NOTA FINAL|PROMEDIO|APROBACION|");
               Console.Write("| " + nota21 + " |");
               Console.Write("  " + nota22 + " |");
               Console.Write("   " + nota23 + "   |");
               Console.Write("    " + nota2fin + "   |");
               hola(nota21,nota22,nota23,nota2fin);
               break;

               case 3:
               System.Console.WriteLine("NOMBRE: " + nombre3);
               Console.WriteLine("CARNET: " + 122122122);
               System.Console.WriteLine("Curso " + curso3);
               System.Console.WriteLine("El sistema de notas obtenidas es: ");
               Console.WriteLine("NOTA 1|NOTA 2|NOTA 3|NOTA FINAL|PROMEDIO|APROBACION|");
               Console.Write("| " + nota31 + " |");
               Console.Write("  " + nota32 + " |");
               Console.Write("   " + nota33 + "   |");
               Console.Write("    " + nota3fin + "   |");
               hola(nota31,nota32,nota33,nota3fin);
               break;

               case 4:
               System.Console.WriteLine("NOMBRE: " + nombre4);
               Console.WriteLine("CARNET: " + 123123123);
               System.Console.WriteLine("Curso " + curso4);
System.Console.WriteLine("El sistema de notas obtenidas es: ");
               Console.WriteLine("NOTA 1|NOTA 2|NOTA 3|NOTA FINAL|PROMEDIO|APROBACION|");
               Console.Write("| " + nota41 + "  |");
               Console.Write("  " + nota42 + " |");
               Console.Write("   " + nota43 + "   |");
               Console.Write("   " + nota4fin + "   |");
               hola(nota41,nota42,nota43,nota4fin);
               break;

               default:
               Console.WriteLine("Ingresa un  nuemero de la lista no seas mamon");
               break;
           }
               break;

               case 1:
               System.Console.WriteLine("GERSON DANIEL PAC DE LEON");
               Console.ReadLine();
               break;
               case 2:
               System.Console.WriteLine("1902002030");
               Console.ReadLine();
               break;
               case 3:
               System.Console.WriteLine("PROGRAMACION");
               Console.ReadLine();
               
               break;
            }
    }
    static private void hola(int h,int j,int k,int l){
               float z = 0;
               z = h + j + k + l;
               z = z/4;
               Console.Write("   " + z + "   |");
               if (z > 61)
               {
                   System.Console.WriteLine("     SI   |");
               }
               else{
                   System.Console.WriteLine("     NO   |");
               }
           }
}
}