using AnonymousMethods.App;

NumberGenerator numberGenerator = new();

numberGenerator.AddNumberHandler(delegate(object sender, NumberEventArgs args)
{
    Console.WriteLine($"Generated number: {args.Number}");
});

numberGenerator.Start();