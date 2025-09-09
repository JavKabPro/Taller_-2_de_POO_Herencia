using POOTaller2.Core;                                  //Using the namespace, thi is the core of the project.

var circle = new Circle(nameof(Circle), 5);             //Parameters for circle.
var square = new Square(nameof(Square), 10);            //Parameters for square.
var rhombus = new Rhombus(nameof(Rhombus), 5, 7, 10);   //Parameters for rhombus.
var kite = new Kite(nameof(Kite), 7, 6, 5, 8);          //Parameters for kite.
var rectangle = new Rectangle(nameof(Rectangle), 4.568, 67.790);                    //Parameters for rectangle.
var parallelogram = new Parallelogram(nameof(Parallelogram), 14.65, 54.67, 23.09);  //parameters for parallelogram
var triangle = new Triangle(nameof(Triangle), 45.56, 12.34, 27.09, 15);             //Parameters for triangle.
var trapeze = new Trapeze(nameof(Trapeze), 10, 20, 30, 40, 20);                     //Parameters for trapeze.
var figures = new List<GeometricFigure> { circle, square, rhombus, kite, rectangle, parallelogram, triangle, trapeze }; //List of figures.
foreach (var figure in figures)
{ 
    Console.WriteLine(figure); 
}
