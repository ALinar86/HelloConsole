// string[,] table = new string[2, 5];
// // String.Empty
// // table[0,0]   table[0,1]   table[0,2]
// // table[1,0]   table[1,1]   table[1,2]


// table[1, 2] = "слово";
// for(int rows = 0; rows < 2; rows++)
// {
//     for(int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

// int[,] matr = new int[3, 4];

// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 4; j++)
//     {
//         Console.Write($" {matr[i, j]} ");
//     }
// Console.WriteLine();
// }





// int[,] matr = new int[3, 4];

//  void PrintArray(int[,] matr)
//  {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($" {matr[i, j]} ");
//         }
//     Console.WriteLine();
//     }
// }


// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1,10);
//         }
//     }
// }

// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);





// int[,] pic = new int[,]
// {
//     {0, 0, 0, 0, 0, 0, 0, 0, 0,},
//     {0, 0, 0, 0, 1, 1, 0, 0, 0},
//     {0, 0, 0, 1, 0, 0, 1, 0, 0},
//     {0, 0, 1, 0, 0, 0, 0, 1, 0,},
//     {0, 0, 0, 1, 0, 0, 1, 0, 0},
//     {0, 0, 0, 0, 1, 1, 0, 0, 0},
// };

// void PrintImage(int[,] image)   // Метод, который рисует картинку
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             if(image[i,j] == 0) Console.Write($" ");
//             else Console.Write($"+");
//         }
//         Console.WriteLine();
//     }
// }

// void FillImage(int row, int col)           // Метод, который закрашивает картинку. Аргументом является пиксель или точка, откуда будет начинаться закрашивание
// {
//     if(pic[row, col] == 0)
//     {
//         pic[row, col] = 1;
//         FillImage(row-1, col);
//         FillImage(row, col-1);
//         FillImage(row+1, col);
//         FillImage(row, col+1);
//     }
// }
// PrintImage(pic);
// FillImage(3, 4);
// PrintImage(pic);





// double Factorial (int n)       // Рекурсия
// {
//     if(n == 1) return 1;
//     else return n * Factorial(n - 1);

// }

// for (int i = 1; i < 40; i++)
// {
//    Console.WriteLine($"{i}! = {Factorial(i)}"); 
// }





// Код Фибоначчи
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

// double Fibonacci(int n)
// {
//     if(n == 1 || n == 2) return 1;
//     else return Fibonacci(n-1) + Fibonacci(n-2);
// }

// for (int i = 1; i < 30; i++)
// {
//     Console.WriteLine($"f({i}) ={Fibonacci(i)}");
// }

/*List numbers = new List();
int m = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < m; i++) {
numbers.Add(Convert.ToInt32(Console.ReadLine()));
}
Console.WriteLine(numbers.Where(n => n > 0).Count());
Console.ReadKey();*/






/*Random random = new Random();       // НЕ из лекции (задача на нахождении среднего значения в каждом столбце массива).
int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(1, 10);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("---------------------------");
Console.WriteLine(arr.GetLength(0));
for (int j = 0; j < arr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    Console.Write($"{ sum / arr.GetLength(0)} ");
}
Console.ReadLine();*/