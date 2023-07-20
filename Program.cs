// Решение заданий к семинару №5
// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
int[] Massiv(int length)
{
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

void CountArray(int[] array)
{
    int count = 0;
    int size = 5;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.Write(" Число четных чисел в массиве:  " + count);
}

int[] randomArray = Massiv(5);
PrintArray(randomArray);
CountArray(randomArray);
*/

// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
/*
int[] Massiv(int length)
{
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}
void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

void CountArray(int[] array)
{
    int sumElem = 0;
    int size = 5;
    for (int i = 1; i < size; i = i + 2)
    {
        sumElem += array[i];
    }
    Console.Write(" Сумма элементов на нечетных позициях:  " + sumElem);
}

int[] randomArray = Massiv(5);
PrintArray(randomArray);
CountArray(randomArray); 
*/
// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] Massiv(int length)
{
    double[] array = new double[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 100) + new Random().NextDouble();
    }
    return array;
}
void PrintArray(double[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(Math.Round(arrayToPrint[i], 2));
        if (i < arrayToPrint.Length)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

void RazArray(double[] array)
{
    double maxElem = array[0];
    double minElem = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxElem)
            maxElem = array[i];
        
        if (array[i] < minElem)
            minElem = array[i];
    }
    
    double raznisa = maxElem - minElem;
    Console.WriteLine($" Max: {maxElem:f2}");
    Console.WriteLine($" Min: {minElem:f2}");
    Console.WriteLine($"Разница между Max и Min: {raznisa:f2}");
}

double[] randomArray = Massiv(5);
PrintArray(randomArray);
RazArray(randomArray);

// Console.WriteLine($" Max: {maxElem:f2}");
// Console.WriteLine($" Min: {minElem:f2}");
// Решение заданий к семинару №4
/*
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
int Stepen(int A, int B)
{
int result = 1;
for (int i = 0; i < B; i++)
{
    result *= A;
}
return result;
}
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int result2 = Stepen(A , B);
Console.WriteLine("Число A в степени B: " + result2);
*/
/*
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
int CummNum(int number)
{
int sum = 0;
while (number > 0)
{
    int digit = number % 10;
    sum = sum + digit;
    number /= 10;
}
return sum;
}
Console.WriteLine($"Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = CummNum (num);
Console.WriteLine($"Сумма цифр числа: {result}"); 
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
/*
int[] Massiv(int length)
{
int[] array = new int[length]; 

for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(0, 100);
}
return array;
}
void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}
int[] randomArray = Massiv(8);
PrintArray(randomArray);
*/
// Задача на 4 семинаре
/*
int[] GetRandomArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(0, 21);
    }
    return result;
}

void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }

    }
    Console.Write("]");
}
int[] randomArray = GetRandomArray(8);
PrintArray(randomArray);
*/
// Решение заданий к семинару №3
// Задача 19
// принимает пятизначное число и проверяет является ли оно палиндромом
/*
void Method(int number)
{
  int num1 = number / 10000;
  int num2 = number / 1000 % 10;
  int num3 = number / 100 % 10;
  int num4 = number / 10 % 10;
  int num5 = number % 10;
  
  if (number > 9999 && number < 100000)
  {
    if (num1 == num5 && num2 == num4)
      Console.WriteLine("Число является палиндромом");
  
    else
      Console.WriteLine("Число не является палиндромом");
  }
  else 
    Console.WriteLine("Число не является пятизначным"); 
  
  }

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Method(num);
*/
/*
// Задача 21
// вход координаты двух точек и найти расстояние между ними в 3D пространстве
double Method(int x1, int y1, int z1, int x2, int y2, int z2)
{
  double rastoanie = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
  return rastoanie;
}

Console.WriteLine("Введите координаты первой точки А: ");
Console.Write("xA: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("yA: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("zA: ");
int zA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки В: ");
Console.Write("xВ: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("yВ: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("zВ: ");
int zB = Convert.ToInt32(Console.ReadLine());

double dist = Method(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Расстояние между двумя точками: {dist:f2}");
*/
/*
// Задача 23
// вход число N и выдает таблицу кубов чисел от 1 до N

void Method(int number)
{
  for (int i = 1; i <= number; i++)
  {
    int N = i * i * i;
    Console.WriteLine($"{i}^3={N}");
  }
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Method(num);
*/

// решение заданий к семинару №2

//Задача 10
/*

void SecondNum(int number)
{
    int SecondNum = (number / 10) % 10;
    Console.WriteLine ("Вторая цифра числа: " + SecondNum);
} 

Console.WriteLine("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());

SecondNum (number);
*/

// Задача №13
/*
void ThirdNum(int number)
{
  if (number > 99 && number <= 999)
  {
    number = number % 10;
    Console.WriteLine("Третье число: " + number);
  }
  else if (number > 999 && number <= 9999)
    {
         number = (number / 10) % 10;
         Console.WriteLine("Третье число: " + number);
    }
       else if (number > 9999 && number <= 99999)
       {
              number = (number / 100) % 10;
              Console.WriteLine("Третье число: " + number);
       }
            else if (number < 100)
                   Console.WriteLine("Третья цифра числа отсутствует");
                 else 
                   Console.WriteLine("Число имеет более 5 цифр");
}
Console.WriteLine("Укажите число: ");
int Tnumber = Convert.ToInt32(Console.ReadLine());
ThirdNum(Tnumber);
*/

/*
// Задача № 15

void Week(int Day)
{
  if (Day == 6) 
    Console.WriteLine ($"является выходным днем {Day}");
  else if (Day == 7) 
    Console.WriteLine ($"является выходным днем {Day}");
       else
         Console.WriteLine ($"не является выходным днем {Day}");
}

Console.WriteLine ("Укажи день недели: ");
int userNum = Convert.ToInt32(Console.ReadLine());
Week(userNum);

*/