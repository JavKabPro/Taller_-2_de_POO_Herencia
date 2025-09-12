namespace POOTaller2.Core;      //Is important to define the namespace, because you need to use it in other parts of the project
public class Square : GeometricFigure               //square class inherits from GeometricFigure

{
       public Square(string name, double a)            //Constructor with parameters
    {
        Name = name;
        A = a;
    }
    private double _a;                              //Private field for side A.
    public double A
    {
        get => _a;
        set => _a = ValidateA(value);
    }

    public override double GetArea() => (A*A);          //Get value of the area
    public override double GetPerimeter() => (4 * A);   //Get value of the perimeter
    private double ValidateA(double a)                  //Method to validate that the side is greater than zero.
    {
        if (a <= 0)
        {
            throw new Exception($"The side {a} is less or equals than zero, it cannot be.");
        }
        return a;
    }
}