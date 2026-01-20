using System;

namespace CsBases.Fundamentals;

// en un interfaz va la firma de las propiedad y metodo que necesitamos
public interface IProduct
{
    void ApplyDiscount(decimal percentage);
    string GetDescription();
}
