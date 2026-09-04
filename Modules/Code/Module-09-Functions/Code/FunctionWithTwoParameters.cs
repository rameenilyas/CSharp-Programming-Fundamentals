### 04-FunctionWithTwoParameters.cs

```csharp
using System;

class Program
{
    static void Main()
    {
        AddNumbers(10, 20);
    }

    static void AddNumbers(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine("Sum = " + sum);
    }
}
```

### Explanation

**1. `AddNumbers(10, 20);`**
This calls the function and passes two values: `10` and `20`.

**2. `int a, int b`**
`a` and `b` are two parameters that receive the values `10` and `20`.

**3. `int sum = a + b;`**
The two numbers are added and the result is stored in `sum`.

**4. `Console.WriteLine()`**
It displays the calculated sum.

### Output

```text
Sum = 30
```

### Key Concept

A function can have **multiple parameters**. Each parameter receives a value when the function is called.
