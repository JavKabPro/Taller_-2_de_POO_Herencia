namespace POOTaller2.Core;              //Is important to define the namespace, because you need to use it in other parts of the project
public class Parallelogram : Rectangle  //parallelogram class inherits from Rectangle

{
     public Parallelogram(string name, double a, double b, double h) : base(name, a, b) //Inherits from rectangle, the parameters 'a' and 'b'
    {
        Name = name;
        A = a;
        H = h;
        B = b;
    }


    private double _h;                  //private field for the height H
    public double H                     //public property for the height H
    {
        get => _h;
        set => _h = ValidateH(value);
    }
    public override double GetArea() => (B * H);            //the area is calculated the same way as in Rectangle
    public override double GetPerimeter() => 2 * (A + B);   //Perimeter is calculated with the sum of sides A and B, multiplied by 2
    private double ValidateH(double h)                      //Method to validate that height H is greater than zero
    {
        if (h <= 0)
        {
            throw new Exception($"The side {h} is less or equals than zero, it cannot be.");
        }
        return h;
    }
}