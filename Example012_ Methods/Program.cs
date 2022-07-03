// Вид 1

// void Method1()
// {
//     Console.WriteLine("Author...");
// }
// Method1();



// Вид 2

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg:"Text of message");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
//     Console.WriteLine(msg);
// }
// Method21(count: 4, msg: "new text"); // Method21(msg: "Text", count: 4); // Method21("Text", 4);





// Вид 3

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);





// Вид 4

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty; // string result = "";

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "asdf");
// Console.WriteLine(res);





// f(x) = x2 + 1

// double f(double x)
// {
//     double result = (x*x + 1);
//     return result;
// }
// double res = f(9);
// Console.WriteLine(res);





// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
        
//     }
//     Console.WriteLine();
// }





// ====== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить на черточки,
// маленькие буквы "к" заменить на большими "К",
// а большие "С" заменить маленькими "с".

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадиме мне чаю? СССссс";

// string s = "qwerty"
//             012
// s[3]  // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int lenght = text.Length;
//     for (int i = 0; i < lenght; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result; 
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// Console.WriteLine();

// newText = Replace(newText, 'к', 'K');
// Console.WriteLine(newText);
// Console.WriteLine();
// Console.WriteLine();

// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);





int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};


void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)  // нахождение минимального числа
        {
            if(array[j] > array[minPosition]) minPosition = j;  //  меняя знак больше или меньше будет сортироваться массив от меньшего к большему и наоборот
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
