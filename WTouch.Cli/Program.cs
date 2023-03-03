if (args.Length == 0)
{
    Console.WriteLine("To use this, you must inform the file you want to touch.");
    Environment.Exit(-1);
}

if (args[0].StartsWith("-"))
{
    Console.WriteLine("Defining the file's timestamp is not yet supported.");
    Environment.Exit(0);
}

var cwd = Directory.GetCurrentDirectory();
foreach (var file in args)
{
    var fullFileName = Path.Join(cwd, file);
    var fileInfo = new FileInfo(fullFileName);

    if (!fileInfo.Exists)
    {
        fileInfo.Create();
        continue;
    }

    File.SetLastWriteTime(fullFileName, DateTime.Now);
}