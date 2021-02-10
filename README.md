# CSharp-StringBuilder

## Test Normal

C# Code

```c#
private static void Test_Normal()
{
    Console.WriteLine($"Start Normal: {DateTime.Now.ToLongTimeString()}");

    Stopwatch sw = new Stopwatch();
    sw.Start();

    string text = "";
    for (int i = 0; i < 250_000; i++)
    {
        text += "a";
    }

    Console.WriteLine($"End Normal: {DateTime.Now.ToLongTimeString()} ({sw.Elapsed.TotalSeconds} seconds)");
}
```

Console Output

```console
Start Normal: 23:25:02
End Normal: 23:25:07 (4.9547419 seconds)
```

---------------------------------------

## Test with StringBuilder

C# Code

```c#
private static void Test_StringBuilder()
{
    Console.WriteLine($"Start StringBuilder: {DateTime.Now.ToLongTimeString()}");

    Stopwatch sw = new Stopwatch();
    sw.Start();

    StringBuilder sb = new StringBuilder();

    string text = "";
    for (int i = 0; i < 250_000; i++)
    {
        sb.Append("a");
    }

    Console.WriteLine($"End StringBuilder: {DateTime.Now.ToLongTimeString()} ({sw.Elapsed.TotalSeconds} seconds)");
}
```

Console Output

```console
Start StringBuilder: 23:28:32
End StringBuilder: 23:28:32 (0.0009752 seconds)
```
