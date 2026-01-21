// See https://aka.ms/new-console-template for more information

using CsBases.Fundamentals;

class Program
{
    static void Main()
    {
        var laptop = new Product("Laptop", 1200);
        Console.WriteLine(laptop.GetDescription());
        var soporte = new ServiceProduct("Soporte tecnico", 300, 30);
        Console.WriteLine(soporte.GetDescription());
        var product = new Product("Mouse Gamer", 300);
        var productDto = ProductAdapter.ToDto(product);
        Console.WriteLine($"{productDto.Name} - {productDto.Price:C} - Codigo: {productDto.Code}");
    }
}
