using System.Text.Json;

// Time Complexity O(n^2)
// Space Complexity O(1)

static int[] Sort(int[] arr)
{
    var items = new int[arr.Length];
    arr.CopyTo(items, 0);
    for (int i = 0; i < items.Length; i++)
    {
        for (int j = i +1; j < items.Length; j++)
        {
            if ( items[j] < items[i])
            {
                int temp = items[j];
                items[j] = items[i];
                items[i] = temp;
            }
        }
    }
    return items;
}

var items = new[] { 4, 5, 1, 3, 9, 20, 7, 6, 6 };
var sortItems = Sort(items);

Console.WriteLine(JsonSerializer.Serialize(sortItems));