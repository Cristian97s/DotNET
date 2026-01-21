/*
El Patron Adaptador es un patron de diseño estructural que permite 
que dos classes con interfaces incompatibles trabajen juntas
*/

using CsBases.Fundamentals;

public class ProductAdapter
{
    public static ProductDto ToDto(Product product)
    {
        return new ProductDto
        {
            Name = product.Name ?? "Sin Nombre",
            Price = product.Price,
            Code = $"P-{product.Id}-{product.UniqueCode.ToString().Substring(0, 8)}"
        };
    }
}