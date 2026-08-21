

```csharp
using System;

class DoWhileLoop
{
    static void Main()
    {
        int i = 1;

        do
        {
            Console.WriteLine(i);
            i++;
        }
        while (i <= 5);
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
* `do` → Runs the code **at least once**
* `Console.WriteLine(i)` → Prints the current value
* `i++` → Increases `i` by **1**
* `while (i <= 5)` → Continues while `i` is **5 or less**

