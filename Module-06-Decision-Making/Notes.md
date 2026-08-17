

# Module 6: Decision Making

## Introduction

Decision making allows a program to execute different code based on conditions.

C# provides several decision-making statements:

* `if`
* `if-else`
* `else if`
* Nested `if`
* `switch`

---

## 1. if Statement

The `if` statement executes a block of code when a condition is `true`.

### Syntax

```csharp
if (condition)
{
    // code
}
```

### Example

```csharp
int age = 20;

if (age >= 18)
{
    Console.WriteLine("You are an adult.");
}
```

### Output

```text
You are an adult.
```

---

## 2. if-else Statement

The `if-else` statement provides two possible paths.

* If the condition is `true`, the `if` block executes.
* If the condition is `false`, the `else` block executes.

### Example

```csharp
int marks = 40;

if (marks >= 50)
{
    Console.WriteLine("Pass");
}
else
{
    Console.WriteLine("Fail");
}
```

### Output

```text
Fail
```

---

## 3. else if Statement

The `else if` statement is used when there are multiple conditions to check.

### Example

```csharp
int marks = 75;

if (marks >= 80)
{
    Console.WriteLine("A Grade");
}
else if (marks >= 70)
{
    Console.WriteLine("B Grade");
}
else if (marks >= 60)
{
    Console.WriteLine("C Grade");
}
else
{
    Console.WriteLine("Fail");
}
```

### Output

```text
B Grade
```

---

## 4. Nested if

A nested `if` means an `if` statement inside another `if` statement.

### Example

```csharp
int age = 20;
bool hasID = true;

if (age >= 18)
{
    if (hasID)
    {
        Console.WriteLine("Entry allowed.");
    }
}
```

### Output

```text
Entry allowed.
```

---

## 5. switch Statement

The `switch` statement is used to select one block of code from multiple cases.

### Example

```csharp
int day = 2;

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;

    case 2:
        Console.WriteLine("Tuesday");
        break;

    case 3:
        Console.WriteLine("Wednesday");
        break;

    default:
        Console.WriteLine("Invalid day");
        break;
}
```

### Output

```text
Tuesday
```

### break

`break` stops the `switch` statement after a matching case is executed.

### default

`default` executes when none of the cases match.

---

## Decision Making Summary

| Statement   | Purpose                           |
| ----------- | --------------------------------- |
| `if`        | Checks one condition              |
| `if-else`   | Handles two possibilities         |
| `else if`   | Checks multiple conditions        |
| Nested `if` | Places one `if` inside another    |
| `switch`    | Selects from multiple fixed cases |

---

## Key Points

* Conditions usually produce `true` or `false`.
* `if` executes code when a condition is true.
* `else` executes when the `if` condition is false.
* `else if` allows multiple conditions.
* Nested `if` means an `if` inside another `if`.
* `switch` is useful for multiple fixed values.
* `break` exits a `switch` case.
* `default` handles unmatched cases.

