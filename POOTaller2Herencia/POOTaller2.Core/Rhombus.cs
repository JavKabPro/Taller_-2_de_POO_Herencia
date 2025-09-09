namespace POOTaller2.Core;          //Is important to define the namespace, because you need to use it in other parts of the project

public class Rhombus : Square

{
   
    public Rhombus(string name, double a, double d1, double d2) : base(name, a) // Call to the base class constructor(Square), equivalent to
    {                                                                           //super in Java. Inherited parameters: name and 'a' (the side of the square)
        Name = name;
        A = a;
        D1 = d1;
        D2 = d2;
    }
    private double _d1;                     // Diagonal 1
    private double _d2;                     // Diagonal 2


    public double D1                        // Property for Diagonal 1
    {
        get => _d1;
        set => _d1 = ValidateD1(value);
    }
    public double D2                        // Property for Diagonal 2
    {
        get => _d2;
        set => _d2 = ValidateD2(value);     // Using the validation method
    }
    public override double GetArea() => (D1 * D2) / 2;  //Get value of the area
    public override double GetPerimeter() => (4 * A);   //Get value of the perimeter

    private double ValidateD1(double d1)                // Validation method for Diagonal 1, you must put values in greater than 0
    {
        if (d1 <= 0)
        {
            throw new Exception($"The diagonal {d1} is less than zero, it cannot be.");
        }
        return d1;
    }
    private double ValidateD2(double d2)                //Validation method for Diagonal 2, you must put values in greater than 0
    {
        if (d2 <= 0)
        {
            throw new Exception($"The diagonal {d2} is less than zero, it cannot be.");
        }
        return d2;
    }
}
