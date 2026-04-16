using System.Globalization;
Console.WriteLine("Введите пример: ");
string input = Console.ReadLine().Replace(" ", ""); 

char[] ops = { '+', '-', '*', '/', '^' };
List<double> numbers = input.Split(ops)
    .Select(s => double.Parse(s, CultureInfo.InvariantCulture))
    .ToList();
List<char> operators = input.Where(c => ops.Contains(c)).ToList();
double result = numbers[0];

for (int i = 0; i < operators.Count; i++)
{
    double nextNumber = numbers[i + 1];
    char op = operators[i];

    
    if (op == '+') result += nextNumber;
    else if (op == '-') result -= nextNumber;
    else if (op == '*') result *= nextNumber;
    else if (op == '/') result /= nextNumber;
    else if (op == '^') result = Math.Pow(result, nextNumber);
}

Console.WriteLine($"= {result}");
Console.ReadKey();