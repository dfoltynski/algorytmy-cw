
using System;

class Program
{
  public static void Main(string[] args)
  {
    Console.Clear();

    bool exit = false;

    while (!exit)
    {
      double a, b, c, d, e, f;
      Console.WriteLine("Prosze wybrać równanie do rozwiązania");
      Console.WriteLine("1. Równanie trzeciego stopnia");
      Console.WriteLine("2. Równanie czwartego stopnia");
      Console.WriteLine("3. Kalkulator rownego podziału (algorytm bisekcji)");
      Console.WriteLine("");
      Console.WriteLine("Aby wyjść proszę wpisać exit / e, albo kliknąć ctrl+c");

      System.Console.Write("Wybór: ");
      string answer = Console.ReadLine();

      if (answer == "e" || answer == "exit")
      {
        exit = true;
      }
      else if (int.TryParse(answer, out int choice))
      {
        Console.Clear();
        switch (choice)
        {
          case 1:
            System.Console.Write("Podaj a: ");
            a = Double.Parse(Console.ReadLine());
            System.Console.Write("Podaj b: ");
            b = Double.Parse(Console.ReadLine());
            System.Console.Write("Podaj c: ");
            c = Double.Parse(Console.ReadLine());
            System.Console.Write("Podaj d: ");
            d = Double.Parse(Console.ReadLine());
            CubicEquation cubicEquation = new CubicEquation(a, b, c, d);
            System.Console.WriteLine(cubicEquation.ToString() + "\n");
            break;

          case 2:
            System.Console.Write("Podaj a: ");
            a = Double.Parse(Console.ReadLine());
            System.Console.Write("Podaj b: ");
            b = Double.Parse(Console.ReadLine());
            System.Console.Write("Podaj c: ");
            c = Double.Parse(Console.ReadLine());
            System.Console.Write("Podaj d: ");
            d = Double.Parse(Console.ReadLine());
            System.Console.Write("Podaj e: ");
            e = Double.Parse(Console.ReadLine());
            FourthDegreeEquation fourthDegreeEquation = new FourthDegreeEquation(a, b, c, d, e);
            System.Console.WriteLine(fourthDegreeEquation.ToString() + "\n"); break;
            break;

          case 3:
            System.Console.Write("Podaj a: ");
            a = Double.Parse(Console.ReadLine());
            System.Console.Write("Podaj b: ");
            b = Double.Parse(Console.ReadLine());
            System.Console.Write("Podaj c: ");
            c = Double.Parse(Console.ReadLine());
            System.Console.Write("Podaj d: ");
            d = Double.Parse(Console.ReadLine());
            System.Console.Write("Podaj e: ");
            e = Double.Parse(Console.ReadLine());
            System.Console.Write("Podaj f: ");
            f = Double.Parse(Console.ReadLine());
            BisectionMethod bisectionMethod = new BisectionMethod(a, b, c, d, e, f);
            System.Console.WriteLine(bisectionMethod.ToString() + "\n"); break;
            break;

          default:
            break;
        }
      }
      else
      {
        System.Console.Clear();
        System.Console.WriteLine("Podano złą wartość");
      }
    }
  }
}