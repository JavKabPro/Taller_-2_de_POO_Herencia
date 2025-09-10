namespace POOTaller2.Core;          //Is important to define the namespace, because you need to use it in other parts of the project.
public class Triangle : Rectangle   //Triangle class inherits from Rectangle.

{
    public Triangle(string name, double a, double b, double c, double h) : base(name, a, b) //Inherits from rectangle, the parameters 'a' and 'b'
    {                                                                                       //the parameters are inherited in parentheses from the 
                                                                                            //base class constructor (Rectangle).
        Name = name;
        A = a;
        B = b;
        C = c;
        H = h;
    }
    private double _c;                  //Private field for the side C.
    public double C                     //Public property for the side C.
    {
        get => _c;
        set => _c = ValidateC(value);   //Method to validate that side C is greater than zero.
    }

    private double _h;                  //Private field for the height H.
    public double H                     //Public property for the height H.
    {
        get => _h;
        set => _h = ValidateH(value);   //Method to validate that height H is greater than zero.
    }
    public override double GetArea() => (B * H) / 2;        //Get value of the area.
    public override double GetPerimeter() => (A + B + C);   //Get value of the perimeter.
    private double ValidateC(double c)                      //Method to validate that side C is greater than zero.
    {
        if (c <= 0)
        {
            throw new Exception($"The side {c} is less or equals than zero, it cannot be.");
        }
        return c;
    }
    private double ValidateH(double h)                      //Method to validate that height H is greater than zero.
    {
        if (h <= 0)
        {
            throw new Exception($"The side {h} is less or equals than zero, it cannot be.");
        }
        return h;
    }
}