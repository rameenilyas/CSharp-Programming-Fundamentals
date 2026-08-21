

### `NestedLoop.cs`

```csharp
using System;

class NestedLoop
{
    static void Main()
    {
        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= 3; j++)
            {
                Console.WriteLine("i = " + i + ", j = " + j);
            }
        }
    }
}
```

### Output

```text
i = 1, j = 1
i = 1, j = 2
i = 1, j = 3
i = 2, j = 1
i = 2, j = 2
i = 2, j = 3
i = 3, j = 1
i = 3, j = 2
i = 3, j = 3
```

### Simple Explanation

The **outer loop** runs 3 times.

For **each** outer loop, the **inner loop** runs 3 times.

So:

**3 × 3 = 9 executions** 🔥


