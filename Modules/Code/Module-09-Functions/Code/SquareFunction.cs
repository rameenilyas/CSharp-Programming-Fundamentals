### 06-SquareFunction.cs

```csharp
using System;

class Program
{
    static void Main()
    {
        int result = Square(5);

        Console.WriteLine("Square = " + result);
    }

    static int Square(int number)
    {
        return number * number;
    }
}
```

### Explanation

**1. `Square(5)`**
The function is called with `5` as the argument.

**2. `int number`**
`number` is the parameter that receives the value `5`.

**3. `return number * number;`**
The function calculates the square of the number.

**4. `int result = Square(5);`**
The returned value is stored in the `result` variable.

### Output

```text
Square = 25
```

### Key Concept

A function can take a number as a parameter, perform a calculation, and **return the result**.

**Flow:**

```text
Square(5)
   ↓
5 × 5
   ↓
 25
   ↓
result = 25
```
