

### Step 3 — `Module-07.md` mein ye notes add karo

````markdown
# Module 7: Loops

Loops are used to repeat a block of code multiple times.

## Topics

- for Loop
- while Loop
- do-while Loop
- Nested Loops
- break
- continue

---

## 1. for Loop

The `for` loop is used when we know how many times we want to repeat a block of code.

### Syntax

```csharp
for (initialization; condition; increment)
{
    // code
}
````

### Example

```csharp
using System;

class Program
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

### Output

```text
1
2
3
4
5
```

### Explanation

* `int i = 1` → Starting value
* `i <= 5` → Condition
* `i++` → Increase value by 1

---

## 2. while Loop

The `while` loop repeats code as long as the condition is true.

### Syntax

```csharp
while (condition)
{
    // code
}
```

### Example

```csharp
using System;

class Program
{
    static void Main()
    {
        int i = 1;

        while (i <= 5)
        {
            Console.WriteLine(i);
            i++;
        }
    }
}
```

### Output

```text
1
2
3
4
5
```

---

## 3. do-while Loop

The `do-while` loop executes the code at least once before checking the condition.

### Syntax

```csharp
do
{
    // code
}
while (condition);
```

### Example

```csharp
using System;

class Program
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

### Output

```text
1
2
3
4
5
```

---

## 4. Nested Loops

A loop inside another loop is called a nested loop.

### Example

```csharp
using System;

class Program
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

---

## 5. break

The `break` statement completely stops the loop.

### Example

```csharp
for (int i = 1; i <= 10; i++)
{
    if (i == 5)
    {
        break;
    }

    Console.WriteLine(i);
}
```

### Output

```text
1
2
3
4
```

---

## 6. continue

The `continue` statement skips the current iteration and moves to the next iteration.

### Example

```csharp
for (int i = 1; i <= 5; i++)
{
    if (i == 3)
    {
        continue;
    }

    Console.WriteLine(i);
}
```

### Output

```text
1
2
4
5
```

Here, `3` is skipped because `continue` skips the current iteration.

---

## Loop Keywords Summary

| Keyword     | Purpose                                     |
| ----------- | ------------------------------------------- |
| `for`       | Repeat code a specific number of times      |
| `while`     | Repeat while a condition is true            |
| `do-while`  | Execute at least once, then check condition |
| Nested Loop | A loop inside another loop                  |
| `break`     | Completely stop the loop                    |
| `continue`  | Skip the current iteration                  |

---

## Key Difference

### break

```text
Loop → Stop completely
```

### continue

```text
Current iteration → Skip
Next iteration → Continue
```

```

