public class Cylinder
{
    double r, h;
    public Cylinder()
    { }

    public Cylinder(double radius, double height)
    { r = radius; h = height; }

    public void Print()
    { Console.WriteLine("r={0} h={1}", r, h); }

    public double Area()
    {
        double area = (2 * Math.PI * Math.Pow(r, 2))+(2*Math.PI*r*h);
        return area;
    }

    public double Volume()
    {
        double volume = Math.PI * Math.Pow(r, 2) * h;
        return volume;
    }

    public bool Correct()
    {
        bool correct = false;
        if ( r>0 && h>0 ) correct = true;
        return correct;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        double radius, height;
        try
        {
            Console.Write("Radius= "); radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height= "); height = Convert.ToDouble(Console.ReadLine());

            Cylinder c = new Cylinder(radius, height);

            c.Print();

            if (c.Correct())
            {
                double area = c.Area();
                double volume = c.Volume();

                Console.WriteLine("Area={0:F4} Volume={1:F3}", area, volume);
            }
            else Console.WriteLine("Такий циліндер не існує");
        }
        catch
        {
            Console.WriteLine("Помилка!");
        }
        Console.ReadKey();
    }
}