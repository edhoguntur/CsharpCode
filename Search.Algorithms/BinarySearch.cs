
static int Search(int[] arr, int x)
{
    var i = 0;
    var j = arr.Length;
    while (i != j)
    {
        var m = (i + j) / 2;
        if (x == arr[m])
        {
            return m;
        }
        if ( x < arr[m])
        {
            j = m;
        } else
        {
            i = m + 1;
        }
    }
    return -1;
}


// items in array need to be sorted first to use this method
var items = new[] { 2, 3, 7, 8, 19, 23, 22 };

Console.WriteLine(Search(items, 3));
Console.WriteLine(Search(items, 4));
Console.WriteLine(Search(items, 19));