List<int> l = BuildList(1, 100, x => x * 2);

foreach (int i in l) 
{ 
    Console.WriteLine(i); 
}
Console.ReadKey();

static List<int> BuildList(int start, int end, ItemHandler handler)
{
    List<int> list = new() { start };

    int n = handler(start);

    while (n <= end)
    {
        list.Add(n);
        n= handler(n);
    }

    return list;
}

delegate int ItemHandler(int n);