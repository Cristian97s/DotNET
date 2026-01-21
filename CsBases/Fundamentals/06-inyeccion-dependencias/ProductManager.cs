// Inyeccion de dependencias

using CsBases.Fundamentals;

public class ProducManager
{
    private readonly ILabelService _labelService;

    public ProducManager(ILabelService labelService)
    {
        _labelService = labelService;
    }

    public void PrintLabel(Product product)
    {
        var label = _labelService.GenerateLabel(product);
        Console.WriteLine(label);
    }
}