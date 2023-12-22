// See https://aka.ms/new-console-template for more information
using BarajaEspañola;
public class Program
{
    /// <summary>
    /// Iniciar el programa a traves del método main
    /// </summary>
    static void Main()
    {

        Console.WriteLine("Initalizing program....");
        Baraja baraja = new Baraja(); //initializar objeto



        //imprimir cartas inicializadas
        Console.WriteLine("");
        Console.WriteLine($"# de cartas inicializadas {baraja.naipes.Count()}....");
        baraja.Imprimir(); //baraja inicializada

        //desordenar lista
        Console.WriteLine("");
        baraja.Revuelva();//revolver
        Console.WriteLine($"# de cartas desordenadas {baraja.naipes.Count()}....");
        baraja.Imprimir();


        //reordenar lista
        Console.WriteLine("");
        baraja.Ordenar();//reordenar
        Console.WriteLine($"# de cartas reordenadas {baraja.naipes.Count()}....");
        baraja.Imprimir();
        Console.WriteLine("");
    }
}
