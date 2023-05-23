namespace Packt.Shared;

public class Square: Shape
{
    public new void Shape(decimal initial)
    {
        this.Height = initial;
        this.Weight = initial;
    }
}