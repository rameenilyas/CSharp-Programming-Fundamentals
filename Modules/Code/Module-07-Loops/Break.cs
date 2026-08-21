

```csharp
using System;

class Break
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            if (i == 3)
            {
                break;
            }

            Console.WriteLine(i);
        }
    }
}
```

### Output:

```text
1
2
```

For Break.cs:

for loop starts from 1 and goes toward 5.
When i = 1 → prints 1
When i = 2 → prints 2
When i = 3 → break runs and stops the entire loop.
So 3, 4, and 5 are not printed.
