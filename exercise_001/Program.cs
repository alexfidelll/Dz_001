System.Console.WriteLine("Введите 3х значное число");
int number = Convert.ToInt32(Console.ReadLine());

int result = number % 100 / 10;
System.Console.WriteLine(result);