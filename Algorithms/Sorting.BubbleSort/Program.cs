T[] BubbleSort<T>(T[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (Comparer<T>.Default.Compare(array[j],array[j + 1]) > 0)
            {
                (array[j], array[j + 1]) = (array[j + 1], array[j]);
            }
        }
    }

    return array;
}

foreach (var item in BubbleSort<int>(new[]{15,8,55,0,7,-1}))
{
    Console.WriteLine(item);
}

Console.WriteLine("-----------------------------------------");

foreach (var item in BubbleSort<string>(new[]{"Ahmet" , "Zeynep" , "Emre" , "Barış" , "ümit"}))
{
    Console.WriteLine(item);
}