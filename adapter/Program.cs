using adapter;
using static adapter.CircleFitChecker;

class Program
{
    public static void Main()
    {
        CircleService circle = new CircleService(9);
        TriangleService triangle = new TriangleService(60, 6);
        SquareService square = new SquareService(6);

        AdapterFactory adapterFactory = new AdapterFactory();
        IAdapter converter = adapterFactory.getAdapter(square);
        CircleService adaptedSquare = converter.ConvertToCircle();
        converter = adapterFactory.getAdapter(triangle);
        CircleService adaptedTriangle = converter.ConvertToCircle();

        Console.WriteLine("Passt der Kreis ins Loch? " + Fit(circle.radius));
        Console.WriteLine("Passt das Dreieck ins Loch? " + Fit(adaptedTriangle.radius));
        Console.WriteLine("Passt das Viereck ins Loch? " + Fit(adaptedSquare.radius));
    }
}