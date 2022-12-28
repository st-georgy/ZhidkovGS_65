char action = ' ';
Console.Write("Введите число: ");
var result = Convert.ToDouble(Console.ReadLine());
while (action != '=')
{
    while (action != '='
        && action != '+'
        && action != '-'
        && action != '/'
        && action != '*')
    {
        Console.Write("Введите действие: ");
        action = Convert.ToChar(Console.ReadLine());
    }
    if (action == '=') break;
    Console.Write("Введите число: ");
    var num = Convert.ToDouble(Console.ReadLine());
    switch (action)
    {
        case '+':
            result += num;
            break;
        case '-':
            result -= num;
            break;
        case '*':
            result *= num;
            break;
        case '/':
            result /= num;
            break;
    }
    action = ' ';
}

Console.WriteLine($"Ответ: {result}");