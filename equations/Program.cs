using System;

class Program
{
  public static void Main(string[] args)
  {
    Console.Clear();

    bool exit = false;

    while (!exit)
    {
      Console.WriteLine("Prosze wybrać równanie do rozwiązania");
      Console.WriteLine("1. Równanie trzeciego stopnia [3]");
      Console.WriteLine("2. Równanie czwartego stopnia [3.5]");
      Console.WriteLine("3. Równanie piątego stopnia / Metoda połowienia przedziałów [4]");
      Console.WriteLine("4. Algorytm genetyczny [4.5]");
      Console.WriteLine("5. ???? [5]");
      Console.WriteLine("");
      Console.WriteLine("Aby wyjść proszę wpisać exit / e, albo kliknąć ctrl+c");

      System.Console.Write("Wybór: ");
      string answer = Console.ReadLine();

      if (answer == "e" || answer == "exit")
      {
        exit = true;
      }
      else if (int.TryParse(answer, out int a))
      {
        Console.Clear();
        switch (a)
        {
          case 1:
            System.Console.WriteLine("Rownanie 3 stopnia");
            break;

          case 2:
            System.Console.WriteLine("Rownanie 4 stopnia");
            break;

          case 3:
            System.Console.WriteLine("Rownanie 5 stopnia / metoda polowienia przedzialow");
            break;

          case 4:
            System.Console.WriteLine("Algorytm genetyczny");
            break;

          case 5:
            System.Console.WriteLine("????");
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