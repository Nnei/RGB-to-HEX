internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Kata.Rgb(95, 205, 122));
    }
}
public class Kata
{
    
    public static string Rgb(int r, int g, int b)
    {
        string hexR, hexG, hexB;
        if (r > 255) r = 255; if (g > 255) g =255; if (b > 255) b =255;
        if (r < 0) r = 0; if (g < 0) g = 0; if (b < 0) b = 0;
        hexR = r.ToString("X2");
        hexG = g.ToString("X2");
        hexB = b.ToString("X2");
        return hexR + hexG + hexB;
    }
}
