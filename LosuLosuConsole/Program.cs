string[] options = args;
        
Random.Shared.Shuffle(options);
Console.WriteLine(options[Random.Shared.Next(0, options.Length)]);