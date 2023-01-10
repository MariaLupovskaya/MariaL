string[] array = {"Hello", "2", "world", ":-)"};
int x = array.Length;
string result = "";
for (int i = 0; i < x; i++)
{
    if (array[i].Length <= 3)
    {
        result = array[i];
        Console.Write(result + " ");
    }
}