
// Решение заданий к семинару №9 (Рекурсия)
//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
void ShowNumber(int numN)
{
    Console.Write(numN + ", ");
    if (numN > 1) ShowNumber(numN - 1);
}
ShowNumber(8);
*/
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
/*
int SumNumber(int numM, int numN)
{
    if (numM > numN) return 0;
    if (numM == numN) return numM;
    else  return numM + SumNumber(numM + 1, numN);
}

int result = SumNumber(1, 15);
Console.Write(result);
*/
//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int FunAkk(int m, int n)
{
    if (m == 0) return n + 1;
    else
    if (n == 0) return FunAkk(m - 1, 1);
    else
        return FunAkk(m - 1, FunAkk(m, n - 1));

}

int result = FunAkk(3, 5);
Console.Write(result);

// Решение заданий к семинару №8
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива
//
/*
int[,] Array2d()
{
    Console.WriteLine("Введите количество строк: ");
    int strok = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов: ");
    int stolb = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите мах число: ");
    int numMax = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите мин число: ");
    int numMin = Convert.ToInt32(Console.ReadLine());

    int[,] num2dArray = new int[strok, stolb];
    for (int i = 0; i < strok; i++)
    {
        for (int j = 0; j < stolb; j++)
        {
            num2dArray[i, j] = new Random().Next(numMin, numMax + 1);
        }
    }
    return num2dArray;
}

void Print2dArray(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] new2dArray = Array2d();
Print2dArray(new2dArray);
*/
/*
for (int i = 0; i < new2dArray.GetLength(0); i++)
{
    for (int j = 0; j < new2dArray.GetLength(1); j++)
    {
        int num = new2dArray[i, j];
        int x = j - 1;
        while (x >= 0 && new2dArray[i, x] < num)
        {
            new2dArray[i, x + 1] = new2dArray[i, x];
            x = x - 1;
        }
        new2dArray[i, x + 1] = num;
    }
}

Console.WriteLine("Массив по убыванию:");
for (int i = 0; i < new2dArray.GetLength(0); i++)
{
    for (int j = 0; j < new2dArray.GetLength(1); j++)
    {
        Console.Write(new2dArray[i, j] + " ");
    }
    Console.WriteLine();
}
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Массив задан  и распечатан в задании 54.
/*
void SumMatrix(int[,] matrix)
{
    int index = 0;
    int minSum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        if (i == 0)
        {
            minSum = sum;
        }
        else if (sum < minSum)
        {
            minSum = sum;
            index = i;
        }
    }
    Console.WriteLine($" Строка с минимальной суммой элементов: {index + 1} ");
}

SumMatrix(new2dArray);
*/
//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
/*
int[,] ArrayA = { {2, 4}, {3, 2} };
int[,] ArrayB = { {3, 4}, {3, 3} };

int strok1 = ArrayA.GetLength(0);
int stolb1 = ArrayA.GetLength(1);
int strok2 = ArrayB.GetLength(0);
int stolb2 = ArrayB.GetLength(1);

int[,] proizvedMatrix = new int[strok1, stolb2];
for (int i = 0; i < strok1; i++)
{
    for (int j = 0; j < stolb2; j++)
    {
        for (int x = 0; x < stolb1; x++)
        {
            proizvedMatrix[i, j] += ArrayA[i, x] * ArrayB[x, j]; 
        }
    }
}
Console.WriteLine("Произведение 2-х матриц:");
Print2dArray(proizvedMatrix);

void Print2dArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
*/
//Задача 60....Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
/*
void PrintArray(int[,,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < arrayToPrint.GetLength(2); k++)
            {
                Console.Write($"{arrayToPrint[i, j, k]} ({i},{j},{k}) ");
            }
        }
    }
}

int[] UniqArray(int size)
{
    int[] unArr = new int[size];
    for (int i = 0; i < size; i++)
    {
        unArr[i] = new Random().Next(10, 100);
        if (i != 0)
        {
            for (int j = 0; j < i; j++)
            {
                while (unArr[j] == unArr[i])
                {
                    unArr[i] = new Random().Next(10, 100);
                }
            }
        }
    }
    return unArr;
}
void FillArray(int[,,] array)
{
    int[] tempArr = UniqArray(8); // Вместо 8 надо бы переменную
    int step = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (step >= 0 && step < 8)
                {
                    array[i, j, k] = tempArr[step];
                    step++;
                }
            }
        }
    }
}

int[,,] create3dArray = new int[2, 2, 2];
FillArray(create3dArray);
PrintArray(create3dArray);
*/
//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/*Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
/*
int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      
      Console.Write($" {array[i,j]} ");
      
    }
    Console.WriteLine();
  }
}
*/



// Решение заданий к семинару №7
/*
double[] sumColumn = new double[new2dArray.GetLength(1)];
for (int i = 0; i < new2dArray.GetLength(1); i++)
{
    double sum = 0;
    for (int j = 0; j < new2dArray.GetLength(0); j++)
    {
        sum = sum + new2dArray[j, i];
        sumColumn[i] = Math.Round(sum / new2dArray.GetLength(0), 2);
    }
    Console.Write(sumColumn[i] + "; ");
}
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
/*
double[,] Array2d()
{
    Console.WriteLine("Введите количество строк: ");
    int strok = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов: ");
    int stolb = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите мах число: ");
    double numMax = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите мин число: ");
    double numMin = Convert.ToDouble(Console.ReadLine());

    double[,] num2dArray = new double[strok, stolb];
    for (int i = 0; i < strok; i++)
    {
        for (int j = 0; j < stolb; j++)
        {
            num2dArray[i, j] = Math.Round(new Random().Next(-10, 20) + new Random().NextDouble(), 2);
            //(new Random().NextDouble() * (numMax - numMin) + numMin, 2);
            // (new Random().Next(задать границы) + new Random().NextDouble(), 2);
        }
    }
    return num2dArray;
}

void Print2dArray(double [,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double [,] new2dArray = Array2d();
Print2dArray(new2dArray);
*/
/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание,
 что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
/*
int[,] Array2d()
{
    Console.WriteLine("Введите количество строк: ");
    int strok = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов: ");
    int stolb = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите мах число: ");
    int numMax = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите мин число: ");
    int numMin = Convert.ToInt32(Console.ReadLine());

    int[,] num2dArray = new int[strok, stolb];
    for (int i = 0; i < strok; i++)
    {
        for (int j = 0; j < stolb; j++)
        {
            num2dArray[i, j] = new Random().Next(numMin, numMax + 1);
        }
    }
    return num2dArray;
}

void Print2dArray(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] new2dArray = Array2d();
Print2dArray(new2dArray);
*/
/*
Console.WriteLine("Введите позицию элемента в массиве по строке:  ");
int numStr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию элемента в массиве по столбцу:  ");
int numStolb = Convert.ToInt32(Console.ReadLine());
if (numStr < new2dArray.GetLength(0) && numStolb < new2dArray.GetLength(1))
    Console.WriteLine($"Число в массиве:{new2dArray[numStr, numStolb]}");
else
    Console.WriteLine("Число с такой позицией в массиве отсутствует");
*/
/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
// метод для формирования и печати массива задан в предыдущей задаче 51:

/*
double[] sumColumn = new double[new2dArray.GetLength(1)];
for (int i = 0; i < new2dArray.GetLength(1); i++)
{
    double sum = 0;
    for (int j = 0; j < new2dArray.GetLength(0); j++)
    {
        sum = sum + new2dArray[j,i];
        sumColumn[i] = Math.Round(sum / new2dArray.GetLength(0), 2);
    }
    Console.Write(sumColumn[i] + "; ");
}
*/

// Решение заданий к семинару №6
// Задача 41: 
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл 
//пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
/*
void Massiv(int count)
{
    int[] array = new int[count];
    int countPos = 0;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0)
            countPos++;
        Console.WriteLine($"Количество чисел больше 0: {countPos}");
    }
}
Console.Write("Введите количество чисел, которое хотите ввести: ");
int M = Convert.ToInt32(Console.ReadLine());
Massiv(M);
*/
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// 1 способ без массива
/*
void Metod()
{
    Console.Write("Введите значение k1: ");
    double k1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите значение b1: ");
    double b1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите значение k2: ");
    double k2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите значение b2: ");
    double b2 = Convert.ToInt32(Console.ReadLine());

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    Console.WriteLine($"Точка пересечения: ({x}, {y})");
}
Metod();
*/
//2 способ с массивом
/*
void Method(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.Write($"Координаты точки пересечения двух линий: {x}, {y}");
}

Method();

*/
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
/*
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
*/
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