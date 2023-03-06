using Microsoft.VisualBasic;

internal class Program
{
    static int CalculaDias(int firstYear, int lastYear)
    {
        return (lastYear - firstYear + 1) * 365;
    }

    static int AnoBissexto(int firstYear, int lastYear)
    {
        int diasBissexto = 0, count = firstYear;

        do
        {
            if ((count % 4 == 0) && (count % 100 != 0) || (count % 400 == 0))
            {
                diasBissexto++;
            }

            count++;
        } while (count <= lastYear);

        return diasBissexto;
    }

    private static void Main(string[] args)
    {
        int first_year, last_year, days;
        Console.WriteLine("informe o primeiro ano: ");
        first_year = int.Parse(Console.ReadLine());

        last_year = first_year - 1;

        while (first_year > last_year)
        {
            Console.WriteLine("informe o segundo ano: ");
            last_year = int.Parse(Console.ReadLine());
        }

        days = CalculaDias(first_year, last_year);
        days += AnoBissexto(first_year, last_year);


        Console.WriteLine(days);
    }
}