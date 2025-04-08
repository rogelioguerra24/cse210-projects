using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");


        List<Shape> shapes = new List<Shape>();
        
        Square aSquare = new Square(8.2);
        Square bSquare = new Square(4.2);
        Square cSquare = new Square(5.2);
        Square dSquare = new Square(7.2);

        aSquare.SetColor("Yellow");
        bSquare.SetColor("Blue");
        cSquare.SetColor("Red");
        dSquare.SetColor("Black");

       
        Rectangle aRectangle = new Rectangle(8, 4);
        Rectangle bRectangle = new Rectangle(4, 4);
        Rectangle cRectangle = new Rectangle(5, 4);
        Rectangle dRectangle = new Rectangle(6, 9);

        aRectangle.SetColor("Yellow");
        bRectangle.SetColor("Blue");
        cRectangle.SetColor("Red");
        dRectangle.SetColor("Black");

        
        
        
        Circle aCircle = new Circle(8.2);
        Circle bCircle = new Circle(4.2);
        Circle cCircle = new Circle(5.2);
        Circle dCircle = new Circle(7.2);

        aCircle.SetColor("Yellow");
        bCircle.SetColor("Blue");
        cCircle.SetColor("Red");
        dCircle.SetColor("Black");

        

        shapes.Add(aSquare);
        shapes.Add(bSquare);
        shapes.Add(cSquare);
        shapes.Add(dSquare);

        shapes.Add(aRectangle);
        shapes.Add(bRectangle);
        shapes.Add(cRectangle);
        shapes.Add(dRectangle);
        
        shapes.Add(aCircle);
        shapes.Add(bCircle);
        shapes.Add(cCircle);
        shapes.Add(dCircle);
        
        
        DisplayData(shapes);
    }
    static void DisplayData(List<Shape> shape){
        foreach(Shape form in shape){
            Console.WriteLine($"The area for this {form.GetColor()} {form.TypeOfShape()} is {form.GetArea():F2}");
        }
    }
}