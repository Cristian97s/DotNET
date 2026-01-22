using CsBases.Fundamentals;

public class ProducRepository
{
    public async Task<Product> GetProduct(int id)
    {
        // Obtener de la base de datos
        // llamada de una api externa
        // Informacion de un archivo
        Console.WriteLine("Buscando un producto...");
        await Task.Delay(2000);
        return new Product("Producto simulado",500);
    }
}