string[] FillArray(int size)
{
    string[] strings = new string[size];

    for(int i=0; i<strings.Length; i++)
    {
        Console.Write("Enter string: ");
        var text = Console.ReadLine(); // Выдавал ошибку, что может быть null (правда так и не понял как), пришлось пойти таким путём, хотя и без того всё работает.
        if(text is null) strings[i] = String.Empty;
        else strings[i] = text;
    }
    return strings;
}

string[] SelectStrings(string[] array)
{
    string[] newStrings = new string[array.Length];
    for(int i=0; i<array.Length; i++)
    {
        if(array[i].Length < 4) newStrings[i] = array[i];
        else newStrings[i] = String.Empty;
    }
    return newStrings;
}

void WriteArray(string[]array)
{
    Console.Write("[");
    for(int i=0; i<array.Length; i++)
        if(array[i] != String.Empty) Console.Write("\"" + array[i] + "\", ");
    Console.Write("\b" + "\b" + "]");
    Console.WriteLine();
}