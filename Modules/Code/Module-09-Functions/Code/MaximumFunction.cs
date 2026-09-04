### 08-MaximumFunction.cs

```csharp
using System;

class Program
{
    static void Main()
    {
        int result = FindMaximum(15, 25);

        Console.WriteLine("Maximum = " + result);
    }

    static int FindMaximum(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}
```

### Explanation

**1. `FindMaximum(15, 25)`**
The function is called with two numbers: `15` and `25`.

**2. `int FindMaximum(int a, int b)`**
The function accepts two integer parameters: `a` and `b`.

**3. `if (a > b)`**
The function checks whether `a` is greater than `b`.

**4. `return a;`**
If `a` is greater, the function returns `a`.

**5. `return b;`**
Otherwise, the function returns `b`.

**6. `int result = FindMaximum(15, 25);`**
The returned maximum value is stored in the `result` variable.

### Output

```text
Maximum = 25
```

### Key Concept

A function can use **parameters, conditions, and return values** together to solve a problem and return the required result.

### Function Flow

```text
FindMaximum(15, 25)
        ↓
   15 > 25 ?
      ↓
     No
      ↓
   return 25
      ↓
 result = 25
```
