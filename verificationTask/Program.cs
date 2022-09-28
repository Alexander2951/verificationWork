Console.WriteLine("Введите количество строк массива");
int n = Convert.ToInt32(Console.ReadLine());
string [] text = new string [n];
Console.WriteLine("Вводите строки нажимая 'Enter' после каждой строки");
for (int i = 0; i < n; i++)
{
    text[i] = Convert.ToString(Console.ReadLine());
}
Console.WriteLine(text[2]);