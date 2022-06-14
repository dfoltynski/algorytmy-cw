using System;

class Program
{
  public static Random rand = new Random();

  public static void Main(string[] args)
  {

    System.Console.Write("Podaj ilosc miast: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int[] cities = populate(num);
    int[] gene = cities.OrderBy(_ => rand.Next()).Take(cities.Length).ToArray();

    int[,] costTable = generateRandomCostTable(num);
    int? currentMinCost = 0;
    int currentCost = 0;
    int counter = 1;
    displayArray(cities);
    displayArray(gene);
    displayArray(costTable, num);

    while (counter != num)
    {
      currentCost = 0;
      counter++;

      for (int j = 0; j < num; j++)
      {
        if ((j + 1) >= num)
        {
          break;
        }
        else
        {
          if (currentMinCost == 0)
            currentMinCost += costTable[gene[j] - 1, gene[j + 1] - 1];
          else
          {
            currentCost += costTable[gene[j] - 1, gene[j + 1] - 1];
          }
        }
      }
      System.Console.Write($"Current gene: ");
      displayArray(gene);
      System.Console.WriteLine($"Current minimum cost: {currentCost}");

      if (currentCost < currentMinCost)
        currentMinCost = currentCost;
      swapGenes(gene);

    }
    System.Console.Write($"The best gene is: ");
    displayArray(gene);
  }

  private static void swapGenes(int[] arr)
  {
    int firstIndexToSwap = rand.Next(0, arr.Length - 1);
    int secondIndexToSwap = rand.Next(0, arr.Length - 1);
    int firstElement = arr[firstIndexToSwap];
    int secondElement = arr[secondIndexToSwap];

    arr[firstIndexToSwap] = secondElement;
    arr[secondIndexToSwap] = firstElement;
  }

  private static void displayArray(int[] arr)
  {
    foreach (var item in arr)
    {
      System.Console.Write($"{item}, ");
    }
    System.Console.WriteLine();
  }

  private static void displayArray(int[,] arr, int length)
  {
    for (int i = 0; i < length; i++)
    {
      for (int j = 0; j < length; j++)
      {
        System.Console.Write($"{arr[i, j]},");
      }
      System.Console.WriteLine();
    }
  }

  private static int[,] generateRandomCostTable(int num)
  {
    int[,] twoDimArr = new int[num, num];
    for (int i = 0; i < num; i++)
    {
      for (int j = 0; j < num; j++)
      {
        twoDimArr[i, j] = rand.Next(1, 30);
      }
    }

    return twoDimArr;
  }

  private static int[] populate(int num)
  {
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
      arr[i] = i + 1;
    }

    return arr;
  }

  // private static int[] generateRandomGene(int num, int[] cities)
  // {
  //   Random rand = new Random();

  //   int[] arr = new int[num];
  //   for (int i = 0; i < num; i++)
  //   {
  //     // arr[i] = cities.OrderBy(_ => rand.Next()).Take(4).ToArray();
  //   }

  //   return arr;
  // }
}