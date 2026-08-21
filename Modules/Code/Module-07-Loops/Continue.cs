
```csharp
using System;

class Continue
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            if (i == 3)
            {
                continue;
            }

            Console.WriteLine(i);
        }
    }
}
```

### Output

```text
1
2
4
5
```


File bana ke **done** bolo.
