bool BinarySearch<T>(T[] array , T value)
{
    int left = 0;
    int right = array.Length - 1;
    

    while (left <= right)
    {
        
        int mid = left + (right - left) / 2;
        if (array[mid].Equals(value))
        {
            return true;
        }
        if (Comparer<T>.Default.Compare(value , array[mid]) > 0)
        {
            left = mid + 1;
        }
        else
        {
            right = mid - 1;
        }
    }

    return false;
}


Console.WriteLine(BinarySearch(new []{1,2,3,4,5} , 2));
Console.WriteLine(BinarySearch(new []{"Ahmet","Erdem" , "Faruk" } , "Faruk"));
