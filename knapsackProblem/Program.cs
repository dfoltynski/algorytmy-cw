using System;
class Program
{
  static Sequence sequence = new Sequence();
  static int v = 2500;
  static int n = 100;
  static int limit = 10;
  static int randomGene;
  static int[] vArr;
  static int[] geneArr;
  static int[] geneArrChild;
  static Dictionary<int, Sequence> generations = new Dictionary<int, Sequence>();
  static Random random = new Random();

  public static void Main(string[] args)
  {
    vArr = (int[])generateRandom(1, 101, limit).Clone();
    geneArr = (int[])generateRandom(0, 2, limit).Clone();

    for (int i = 1; i <= limit; i++)
    {

      randomGene = random.Next(0, limit);
      geneArrChild = (int[])geneArr.Clone();
      geneArrChild[randomGene] = geneArrChild[randomGene] == 0 ? 1 : 0;
      geneArr = (int[])calcBetterOne(vArr, geneArr, geneArrChild, limit, v).Clone();

      sequence.Generation = i;
      sequence.GeneSequence = geneArr;
      sequence.VSequence = vArr;
      Console.WriteLine(sequence.ToString());
    }

    Console.WriteLine("--------- THE BEST SEQUENCE ---------");
    Console.WriteLine(sequence.ToString());
  }

  public static int[] calcBetterOne(int[] vArr, int[] geneArr, int[] geneArrChild, int limit, int v)
  {
    int oldManSum = sumV(vArr, geneArr, limit);
    int sum = sumV(vArr, geneArrChild, limit);

    if (Math.Abs(oldManSum - v) > Math.Abs(sum - v))
    {
      sequence.Value = sum;
      return geneArrChild;
    }
    else
    {
      sequence.Value = oldManSum;
      return geneArr;
    }
  }

  public static int[] generateRandom(int min, int max, int limit)
  {
    int[] randomArray = new int[limit];
    for (int i = 0; i < limit; i++)
    {
      randomArray[i] = (random.Next(min, max));
    }

    return randomArray;
  }

  public static int sumV(int[] vArr, int[] geneArr, int limit)
  {
    int sum = 0;
    for (int i = 0; i < limit; i++)
    {
      if (geneArr[i] == 1)
      {
        sum += vArr[i];
      }
    }
    return sum;
  }
}