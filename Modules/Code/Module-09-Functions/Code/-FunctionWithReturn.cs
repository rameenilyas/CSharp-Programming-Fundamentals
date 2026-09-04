### 05-FunctionWithReturn.cs

```csharp
using System;

class Program
{
    static void Main()
    {
        int result = AddNumbers(10, 20);

        Console.WriteLine("Sum = " + result);
    }

    static int AddNumbers(int a, int b)
    {
        return a + b;
    }
}
```

### Explanation

**1. `AddNumbers(10, 20)`**
The function is called with two values: `10` and `20`.

**2. `static int AddNumbers()`**
The `int` means that this function will **return an integer value**.

**3. `return a + b;`**
The function adds the two numbers and returns the result.

**4. `int result = AddNumbers(10, 20);`**
The returned value is stored in the `result` variable.

**5. `Console.WriteLine()`**
It displays the returned result.

### Output

```text
Sum = 30
```

### Key Concept

A **return value** allows a function to send a result back to the place where the function was called.

**Flow:**

```text
AddNumbers(10, 20)
       ↓
    10 + 20
       ↓
      30
       ↓
   result = 30
```
