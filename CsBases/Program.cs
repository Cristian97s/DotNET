// See https://aka.ms/new-console-template for more information

using CsBases.Fundamentals;

class Program
{
    static async Task Main()
    {
        var laptop = new Product("Laptop", 1200);
        Console.WriteLine(laptop.GetDescription());
        var soporte = new ServiceProduct("Soporte tecnico", 300, 30);
        Console.WriteLine(soporte.GetDescription());
        var product = new Product("Mouse Gamer", 300);
        var productDto = ProductAdapter.ToDto(product);
        Console.WriteLine($"{productDto.Name} - {productDto.Price:C} - Codigo: {productDto.Code}");

        //Inyeccion de dependencia
        ILabelService labelService = new LabelService();
        var manager = new ProducManager(labelService);
        var monitor = new Product("Monitor",100);
        var installation = new ServiceProduct("Instalacion de monitor",20,30);
        manager.PrintLabel(monitor);
        manager.PrintLabel(installation);
        var firstProduct = await new ProducRepository().GetProduct(1);
        Console.WriteLine($"{firstProduct.Name} - {firstProduct.Price}");
    }
}
