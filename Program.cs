Console.WriteLine("Введите пример");
string[] input = Console.ReadLine().Split(' ');

char act = Convert.ToChar(input[1]);
double num1 = Convert.ToDouble(input[0]);
double num2 = Convert.ToDouble(input[2]);

double res;

if(act == Convert.ToChar("+")) { 
    res = num1 + num2;
    Console.WriteLine($"{num1} {act} {num2} = {res}");
}
else if (act == Convert.ToChar("+")){
    res = num1 - num2;
    Console.WriteLine($"{num1} {act} {num2} = {res}");
}

else if (act == Convert.ToChar("/")){
    res = num1 / num2;
    if(num2 == 0)
    {
        Console.WriteLine("Деление на ноль невозможно!");
    }
    else
    {
        Console.WriteLine($"{num1} {act} {num2} = {res}");
    }                
}
else if(act ==  Convert.ToChar("*")){
    res = num1 * num2;
    Console.WriteLine($"{num1} {act} {num2} = {res}");
}
else {
    Console.WriteLine("Такого выражения нет!");
}