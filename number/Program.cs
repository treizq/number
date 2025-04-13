using number;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Простые числа до 20:");
        foreach (int prime in PrimeNumbers.GetPrimes(20))
        {
            Console.Write(prime + " ");
        }
        Console.WriteLine();

        //метод GetAllPrimes (первые 10 простых чисел)
        Console.WriteLine("Первые 10 простых чисел:");
        int count = 0;
        foreach (int prime in PrimeNumbers.GetAllPrimes())
        {
            Console.Write(prime + " ");
            count++;
            if (count == 10) break;
        }
        Console.WriteLine();

        //метод SkipPrimes
        Console.WriteLine("Простые числа, начиная с 5-го:");
        foreach (int prime in PrimeNumbers.SkipPrimes(4))
        {
            Console.Write(prime + " ");
            if (prime > 20) break;
        }
        Console.WriteLine();
    }
}