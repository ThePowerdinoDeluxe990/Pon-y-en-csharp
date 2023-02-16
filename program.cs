using System;
namespace calculadora_c_;
class Program
{
    static void Main(string[] args)
    {
        int a = 0;
        Console.WriteLine("Para sumar 1 pon Y,pon reset para volver a cero, si quieres salir pulsa otra cosa");
        do {
            Console.WriteLine("Has puesto Y "+ a++ + " Veces");
            
        }while (Console.ReadLine().ToUpper() == "Y");
        Console.WriteLine("Adios! ");
        Console.ReadKey();


    }
}
