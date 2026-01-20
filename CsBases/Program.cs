// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main()
    {
        //Console.WriteLine("Hello, World!");

        //Declaracion explicita
        int quantity = 5;
        string message = "Hello World";
        decimal price = 19.99m;
        Console.WriteLine($" Cantidad: {quantity}, Saludo: {message}, Precio: {price:C}");

        //Declaracion con var
        var gretting = "Hola";
        var percentage = 20.00m;
        Console.WriteLine($" Saludo: {gretting}, Porcentaje: {percentage}");
    }
}
