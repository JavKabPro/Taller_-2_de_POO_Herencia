namespace POOTaller2.Core;
public class Trapeze : Triangle

{
    public Trapeze(string name, double a, double b, double c, double d, double h) : base(name, a, b, c, h) //Inherits from rectangle a and b
    {
        Name = name;
        A = a;
        B = b;
        C = c;
        D = d;
        H = h;
    }
    private double _d;                          //This is a private field for the side D
    public double D                             //This is a public property for the side D
    {
        get => _d;
        set => _d = ValidateD(value);
    }

    public override double GetArea() => (B + D) * H / 2;        //Get value of the area
    public override double GetPerimeter() => (A + B + C + D);   //Get value of the perimeter
    private double ValidateD(double d)                          //Method to validate that side D is greater than zero
    {
        if (d <= 0)
        {
            throw new Exception($"The side {d} is less or equals than zero, it cannot be.");
        }
        return d;
    }
}