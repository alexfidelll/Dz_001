Console.WriteLine("Введите ваше число");

string number = Console.ReadLine();

int checkUserNumber;
                         
bool userNumber = int.TryParse(number, out checkUserNumber);          

if (userNumber == false)
{
    Console.WriteLine("Болбес введи число !!!");
}
while (userNumber)
{
    for (int i = 0; i < number.Length; i++)
    {
        if (i == 2)
            {
                Console.WriteLine(number[i]);
            }
            else if (i >= number.Length - 1)
            {
                Console.WriteLine("третьей цифры нет!!!");
            }
    }
    userNumber = false;
}