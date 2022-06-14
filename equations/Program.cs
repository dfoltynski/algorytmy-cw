// int[] b = new int[] { 1, 2, 3, 4 };
// int[] a = new int[] { 5, 6, 7, 8 };


// Stack<int> S = new Stack<int>(a);
// Queue<int> Q = new Queue<int>(b);

// // Q.Enqueue(S.Peek()); S.Pop();
// // S.Push(Q.Peek()); Q.Dequeue();
// // S.Push(Q.Peek()); Q.Dequeue();
// // Q.Enqueue(S.Peek()); S.Pop();
// // Q.Enqueue(S.Peek()); S.Pop();
// // S.Push(Q.Peek()); Q.Dequeue();

// S.Push(Q.Peek()); Q.Dequeue();
// S.Push(Q.Peek()); Q.Dequeue();
// S.Push(Q.Peek()); Q.Dequeue();
// Q.Enqueue(S.Peek()); S.Pop()

// foreach (var item in S)
// {
//   System.Console.Write($"{item} ");
// }
// System.Console.WriteLine();
// foreach (var item in Q)
// {
//   System.Console.Write($"{item} ");
// }

// int wynik = 0;

// int oblicz(int a, int b, int c) {

// }

// int[] tab;
// System.Console.WriteLine(tab.Count());
// namespace asdd{
// private interface asd {

// }
// }

// int[] a = Array.ConvertAll<string, int>(Console.ReadLine().Split(" "), int.Parse);

// int n = a.Length;

// string answer = "";

// int i = 0;
// int j = 0;
// int minindex = 0;
// int tmp;
// while (i < n - 1)
// {
//   if (i < n - 1)
//   {
//     minindex = i;
//     j = i + 1;

//     if (j < n)
//     {
//       if (a[j] < a[minindex])
//       {
//         minindex = j;
//       }
//       j++;
//     }
//     else
//     {
//       tmp = a[i];

//       a[i] = a[minindex];
//       a[minindex] = tmp;
//       i++;
//     }
//   }
//   if (!(i < n - 1))
//     foreach (var item in a)
//     {
//       answer += $"{a}, ";
//       System.Console.Write($"{item}, ");
//     }
//   // {
//   n--;
// }
// }

// answer = answer.Trim();
// System.Console.WriteLine(answer.Remove(answer.Length - 1));

int[] arr = Array.ConvertAll<string, int>(Console.ReadLine().Split(" "), int.Parse);
int temp;
for (int j = 0; j <= arr.Length - 2; j++)
{
  for (int i = 0; i <= arr.Length - 2; i++)
  {
    if (arr[i] > arr[i + 1])
    {
      temp = arr[i + 1];
      arr[i + 1] = arr[i];
      arr[i] = temp;
    }
  }
}
for (int i = 0; i < arr.Length; i++)
{
  if (i != arr.Length - 1)
  {
    Console.Write(arr[i] + ", ");
  }
  else
    Console.Write(arr[i]);
}




// int fun(int n)
// {
//   if (n < 2) return n;
//   if (n % 2 == 1) return fun(n - 1) + 1;
//   else return fun(n - 1);
// }

// System.Console.WriteLine(fun(7));
// System.Console.WriteLine(fun(8));
// System.Console.WriteLine(fun(9));

// System.Console.WriteLine("1" + " " == "1");

// using System;

// class Program
// {
//   public static void Main(string[] args)
//   {
//     Console.Clear();

//     bool exit = false;

//     while (!exit)
//     {
//       Console.WriteLine("Prosze wybrać równanie do rozwiązania");
//       Console.WriteLine("1. Równanie trzeciego stopnia [3]");
//       Console.WriteLine("2. Równanie czwartego stopnia [3.5]");
//       Console.WriteLine("3. Równanie piątego stopnia / Metoda połowienia przedziałów [4]");
//       Console.WriteLine("4. Algorytm genetyczny [4.5]");
//       Console.WriteLine("5. ???? [5]");
//       Console.WriteLine("");
//       Console.WriteLine("Aby wyjść proszę wpisać exit / e, albo kliknąć ctrl+c");

//       System.Console.Write("Wybór: ");
//       string answer = Console.ReadLine();

//       if (answer == "e" || answer == "exit")
//       {
//         exit = true;
//       }
//       else if (int.TryParse(answer, out int a))
//       {
//         Console.Clear();
//         switch (a)
//         {
//           case 1:
//             System.Console.WriteLine("Rownanie 3 stopnia");
//             break;

//           case 2:
//             System.Console.WriteLine("Rownanie 4 stopnia");
//             break;

//           case 3:
//             System.Console.WriteLine("Rownanie 5 stopnia / metoda polowienia przedzialow");
//             break;

//           case 4:
//             System.Console.WriteLine("Algorytm genetyczny");
//             break;

//           case 5:
//             System.Console.WriteLine("????");
//             break;

//           default:
//             break;
//         }
//       }
//       else
//       {
//         System.Console.Clear();
//         System.Console.WriteLine("Podano złą wartość");
//       }
//     }
//   }
// }