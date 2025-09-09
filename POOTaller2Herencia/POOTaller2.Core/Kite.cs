namespace POOTaller2.Core;      //Is important to define the namespace, because you need to use it in other parts of the project

public class Kite : Rhombus     //Kite inherits from lass Rhombus

{
    public Kite(string name, double a, double d1, double d2, double b) : base(name, a, d1, d2) //The parameters are inherited in parentheses
    {                                                                                          //from the base class constructor (Rhombus)..
        Name = name;                                                                           //Inherited parameters: name, 'a' (side A), d1 and d2 (diagonals)
        A = a;
        D1 = d1;
        D2 = d2;
        B = b;
        
    }
    private double _b;                  // private field for the side B
    public double B                     //public property for the side B
    {
        get => _b;
        set => _b = ValidateB(value);
    }
    public override double GetArea() => (D1 * D2) / 2;      //the area is calculated the same way as in Rhombus
    public override double GetPerimeter() => 2 * (A + B);   //Perimeter is calculated with the sum of sides A and B, multiplied by 2

    private double ValidateB(double b)                      //Method to validate that side B is greater than zero
    {
        if (b <= 0)
        {
            throw new Exception($"The side {b} is less or equals than zero, it cannot be.");    
        }
        return b;
    }
}