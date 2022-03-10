int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int a = Promt("Введите число; ");
int b = 1;
Console.Write(b + " ");
while (b < a)
{
    b = b + 1;
    Console.Write(b*b*b + " ");
}
