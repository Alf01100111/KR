string[] array = { "hello", "2", "world", ":-)" };
string[] resultArray = new string[array.Length];
int j = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        resultArray[j] = array[i];
        j++;
    }
}

System.Console.WriteLine(string.Join("\t", resultArray));