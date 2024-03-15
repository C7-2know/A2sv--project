public abstract class Shape
{
    public string Name {get;set;}
    public abstract double CalculateArea();
}

public class Circle:Shape 
{
    private double radius;
    public Circle(double radius,string name="Circle"){
        Name=name;
        this.radius= radius;
    }
    public override double CalculateArea(){
        return Math.PI*this.radius*this.radius;
    }
}

public class Rectangle:Shape{
    public double width;
    public double height;

    public Rectangle(double height, double width){
        Name="Rectangle";
        this.height=height;
        this.width=width;
    }

    public override double CalculateArea(){
        return this.height*this.width;
    }
}

public class Triangle:Shape{

    public double tbas;
    public double height;

    public Triangle(double height , double bas){
        Name="Triangle";
        this.height=height;
        this.tbas=bas;
    }

    public override double CalculateArea(){
        double area= this.height*this.tbas;
        area=area/2;
        return area;
    }
}

public class Runner{
    public static void Main(){
        Circle circle1=new Circle(2);
        Console.WriteLine($"{circle1.CalculateArea()}");
        PrintShapeArea(circle1);

        Rectangle rectangle1=new Rectangle(3,4);
        PrintShapeArea(rectangle1);

        Triangle triangle=new Triangle(4,6);
        PrintShapeArea(triangle);
    }
    public static void PrintShapeArea(Shape? shape){
        Console.WriteLine(shape.Name);
        double area= shape.CalculateArea();
        Console.WriteLine($"area of the shape: {area}");
    }
}
