### 07-EvenOddFunction.cs

```csharp
using System;

class Program
{
    static void Main()
    {
        CheckEvenOdd(7);
    }

    static void CheckEvenOdd(int number)
    {
        if (number % 2 == 0)
        {
            Console.WriteLine("The number is Even.");
        }
        else
        {
            Console.WriteLine("The number is Odd.");
        }
    }
}
```

### Explanation

**1. `CheckEvenOdd(7);`**
This calls the function and passes `7` as an argument.

**2. `int number`**
`number` is the parameter that receives the value `7`.

**3. `number % 2 == 0`**
The `%` operator finds the remainder after division by `2`.

* If the remainder is `0` → the number is **Even**.
* Otherwise → the number is **Odd**.

**4. `if-else`**
The `if` statement checks whether the number is even. If the condition is false, the `else` block runs.

### Output

```text
The number is Odd.
```

### Key Concept

A function can contain **decision-making statements** such as `if-else` to perform different actions based on a condition.
