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
