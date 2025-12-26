namespace SOLID;
public abstract class Shape
{
    public abstract double CalculateArea();
}
//Before as LSP violation
//public class Rectangle : Shape
//{
//    public virtual double Width { get; set; }
//    public virtual double Height { get; set; }
//    public override double CalculateArea()
//    {
//        return Width * Height;
//    }
//}
//public class Square : Rectangle
//{
//    public override double Width
//    {
//        get => base.Width;
//        set => base.Width = base.Height = value;
//    }
//    public override double Height
//    {
//        get => base.Height;
//        set => base.Height = base.Width = value;
//    }
//}

//LSP-adhering refactoring
public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public override double CalculateArea()
    {
        return Width * Height;
    }
}
public class Square : Shape
{
    public double SideLength { get; set; }
    public override double CalculateArea()
    {
        return SideLength * SideLength;
    }
}