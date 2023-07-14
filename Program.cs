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

// Задача 21
// вход координаты двух точек и найти расстояние между ними в 3D пространстве
void Method(int x1, int y1, int z1)
{
  int num1 = number / 10000;
    
  if (number )
  {
    if ()
      Console.WriteLine("");
  
    else
      Console.WriteLine("");
  }
  else 
    Console.WriteLine(""); 
  
  }

Console.WriteLine($"Введите координаты: {x}, {y}, {z}");
int num = Convert.ToInt32(Console.ReadLine());

Method(num);


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