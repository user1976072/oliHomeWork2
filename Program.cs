void SecondNum(int number)
{
    int SecondNum = (number / 10) % 10;
    Concole.WriteLine ("Вторая цифра числа" + SecondNum);
} 

Concole.WriteLine("Enter your number: ");
int number = Convert.ToInt32(Concole.RedLain());

