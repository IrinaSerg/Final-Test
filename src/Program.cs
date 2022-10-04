string[] Filter(string[] strs)
{
   string[] result = new string[strs.Length];
   for(int i = 0; i < strs.Length; i++)
   {
        if(strs[i].Length <= 3)
        {
            result[i] = strs[i];
        }
   } 
   return result;
}

void PrintArray(string[] strs)
{
    Console.Write("[");
    for(int i = 0; i < strs.Length; i++)
    {
        Console.Write($"{strs[i]}, ");
    }
    Console.WriteLine("]"); 
}

Console.WriteLine("Введите строки, отделяя их запятыми без пробелов:");
string[] input = Console.ReadLine().Split(",");
string[] result = Filter(input);
PrintArray(result);
