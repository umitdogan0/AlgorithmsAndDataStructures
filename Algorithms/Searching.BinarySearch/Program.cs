bool BinarySearch(int[] array , int value)
{
    int left = 0;
    int right = array.Length - 1;
    

    while (left <= right)
    {
        
        int mid = left + (right - left) / 2;
        if (array[mid] == value)
        {
            return true;
        }
        if (array[mid] < value )
        {
            left = mid + 1;
        }
        else
        {
            right = mid + 1;
        }
    }

    return false;
}


Console.WriteLine(BinarySearch(new []{1,2,3,4,5} , 7));
