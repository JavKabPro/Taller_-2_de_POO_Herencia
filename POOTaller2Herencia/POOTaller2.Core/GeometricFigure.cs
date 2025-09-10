using System;
namespace POOTaller2.Core;                      //Is important to define the namespace, because you need to use it in other parts of the project

public abstract class GeometricFigure           //abstract class
{
    public string Name { get; set; } = null!;          //property name

    public abstract double GetArea();           //abstract method to get area
    public abstract double GetPerimeter();      //abstract method to get perimeter
    public override string ToString()           //override method to string
    {
        return $"{Name,-15} => Area....:  {GetArea(),15:N5}  " + $" Perimeter: {GetPerimeter(),15:N5}";
    }
}
