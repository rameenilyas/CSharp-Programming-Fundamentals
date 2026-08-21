





```csharp
using System;

class ForLoop
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }
    }
}
```

### Output:

```text
1
2
3
4
5
```

### Simple Explanation:

* `int i = 1` → Counting starts from **1**
* `i <= 5` → Continue as long as `i` is **5 or less**
* `i++` → Increase `i` by **1** after each iteration
* `Console.WriteLine(i)` → **Print the current value of `i`**
