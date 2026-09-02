
# Module 8 — Patterns

## 1. Introduction to Patterns

Patterns are shapes or designs printed using characters such as `*`, numbers, or letters.

In C#, patterns are commonly created using **nested loops**.

### Basic Structure

```csharp
for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j <= columns; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}
```

* Outer loop → controls **rows**
* Inner loop → controls **columns**
* `Console.Write()` → prints on the same line
* `Console.WriteLine()` → moves to the next line

---

## 2. Square Pattern

### Output

```text
****
****
****
****
```

### Code

```csharp
for (int i = 1; i <= 4; i++)
{
    for (int j = 1; j <= 4; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}
```

---

## 3. Rectangle Pattern

A rectangle has a fixed number of rows and columns.

### Output

```text
*****
*****
*****
```

### Code

```csharp
for (int i = 1; i <= 3; i++)
{
    for (int j = 1; j <= 5; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}
```

---

## 4. Right Triangle Pattern

### Output

```text
*
**
***
****
*****
```

### Code

```csharp
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}
```

### Important Concept

Here the inner loop uses:

```csharp
j <= i
```

So the number of stars increases with every row.

---

## 5. Inverted Right Triangle

### Output

```text
*****
****
***
**
*
```

### Code

```csharp
for (int i = 5; i >= 1; i--)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}
```

The number of stars decreases after every row.

---

## 6. Number Pattern

### Output

```text
1
12
123
1234
12345
```

### Code

```csharp
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j);
    }

    Console.WriteLine();
}
```

---

## 7. Repeated Number Pattern

### Output

```text
1
22
333
4444
55555
```

### Code

```csharp
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(i);
    }

    Console.WriteLine();
}
```

---

## 8. Character Pattern

Patterns can also be created using letters.

### Output

```text
A
AB
ABC
ABCD
ABCDE
```

### Code

```csharp
for (char i = 'A'; i <= 'E'; i++)
{
    for (char j = 'A'; j <= i; j++)
    {
        Console.Write(j);
    }

    Console.WriteLine();
}
```

---

## 9. Pattern Using User Input

The number of rows can be taken from the user.

### Code

```csharp
Console.Write("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}
```

---

## 10. Key Points

* Patterns are usually created using **nested loops**.
* The **outer loop controls rows**.
* The **inner loop controls columns/items in each row**.
* `Console.Write()` stays on the same line.
* `Console.WriteLine()` moves to the next line.
* `j <= i` is commonly used for increasing patterns.
* `i--` is commonly used for decreasing patterns.
* Changing the loop conditions changes the pattern.

## Quick Formula

```text
Outer Loop  → Rows
Inner Loop  → Columns / Stars / Numbers
Write()     → Same Line
WriteLine() → New Line
```
