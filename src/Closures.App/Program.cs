var actions = new Action[5];

for (int i = 0; i < 5; i++)
{
    actions[i] = () => Console.WriteLine(i);
}

PrintActions(actions);

//After
Console.WriteLine("--------");

for (int i = 0; i < 5; i++)
{
    int j = i;
    actions[i] = () => Console.WriteLine(j);
}

PrintActions(actions);

void PrintActions(Action[] actions)
{
    foreach (Action action in actions)
    {
        action();
    }
}