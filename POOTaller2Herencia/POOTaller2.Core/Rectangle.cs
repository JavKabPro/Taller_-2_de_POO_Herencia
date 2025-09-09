namespace POOTaller2.Core;          //Is important to define the namespace, because you need to use it in other parts of the project
public class Rectangle : Square     //rectangle class inherits from Square

{
    public Rectangle(string name, double a, double b) : base(name, a)   //The parameters are inherited in parentheses from the base class constructor (Square).
    {                                                                   //Inherited parameters: name and 'a' (the side of the square)
        Name = name;
        A = a;
        B = b;
    }

  
    private double _b;                                  //private field for side B
    public double B                                     //public property for side B
    {
        get => _b;
        set => _b = ValidateB(value);
    }
    public override double GetArea() => (A * B);        //Get value of the area
    public override double GetPerimeter() => 2*(A+B);   //Get value of the perimeter
    private double ValidateB(double b)                  //Method to validate that side B is greater than zero
    {
        if (b <= 0)
        {
            throw new Exception($"The side {b} is less or equals than zero, it cannot be.");
        }
        return b;
    }
}