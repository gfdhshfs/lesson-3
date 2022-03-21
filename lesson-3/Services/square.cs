namespace Services
{
    public class square;
    {
        public static string Square(double a, double b, double c) 
    {
        double d = (b * b) - (4 * a* c);

        if (d > 0)
        {
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x1 = (-b - Math.Sqrt(d)) / (2 * a);
            return $"Корень x1 = {x1}, x2 = {x2}";
        }

        else if (d == 0)
        {
            double x1 = -b / (2 * a);
            return $"Корень x ={x1}";
        }
        else
        {
            return "Корни отсутствуют";
        }
    }
    
}
     

    



