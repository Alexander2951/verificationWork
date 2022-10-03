Console.WriteLine("Введите количество строк массива");
int n = Convert.ToInt32(Console.ReadLine());
string [] text = new string [n];
Console.WriteLine("Вводите строки нажимая 'Enter' после каждой строки");
for (int i = 0; i < n; i++)
{
    text[i] = Convert.ToString(Console.ReadLine());
}
int k=0;
for (int i = 0; i < n; i++)
{
    if  (text[i].Length <=3 )
    {
        k++;
    }
}
string[] text2 = new string [k];
int l=0;
for (int i = 0; i < n; i++)
{
    if (text [i].Length <=3)
    {
        text2[l] = text[i];
        l++;
    }
}
Console.WriteLine (text);