using System;

namespace POOTaller2.Core;                      //Is important to define the namespace, because you need to use it in other parts of the project

public class Circle : GeometricFigure           //circle class inherits from GeometricFigure

{
    private double _r;                          //private field for radius.               
    public double R                             //public property for radius with get and set
    {
        get => _r;
        set => _r = ValidateR(value);
    }
    public Circle(string name, double r)        //constructor that takes name and radius as parameters
    {       
        Name = name;
        R = r;
    }
    public override double GetArea()            //Override method to calculate thr area
    {
        return Math.PI * Math.Pow(R, 2);
    } 
    public override double GetPerimeter()       //Override method to calculate the perimeter
    {
        return 2 * Math.PI * R;
    }
    private double ValidateR(double r)          //Method to validate radius
    {
        if (r <= 0)
        {
            throw new Exception($"The radius {r} is less or equals than zero, it cannot be.");
        }
        return r;
    }

}
