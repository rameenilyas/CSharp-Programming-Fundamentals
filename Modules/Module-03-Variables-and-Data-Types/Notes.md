


`markdown
# Module 3: Variables & Data Types

This module covers the basic concepts of variables, constants, naming rules, and common C# data types.

---

## Topics

1. Variables
2. Constants
3. Naming Rules
4. int
5. float
6. double
7. char
8. bool
9. string

---

## 1. Variables

A variable is a container used to store data in a program.

### Syntax

```csharp
dataType variableName = value;
````

### Example

```csharp
int age = 20;
string name = "Ali";
```

Here:

* `int` = data type
* `age` = variable name
* `20` = value

---

## 2. Constants

A constant is a value that cannot be changed during the execution of a program.

In C#, the `const` keyword is used to create a constant.

### Example

```csharp
const double PI = 3.14;
```

The value of `PI` cannot be changed.

---

## 3. Naming Rules

The following rules should be followed when naming variables:

* A variable name must start with a letter or underscore.
* A variable name cannot start with a number.
* Spaces are not allowed.
* Special characters are generally not allowed.
* C# is case-sensitive.
* Keywords cannot be used as variable names.

### Valid Examples

```csharp
int age;
int studentName;
int marks1;
string city;
```

### Invalid Examples

```csharp
int 1marks;
int student-name;
int student name;
```

---

# 4. int

`int` is used to store whole numbers.

### Examples

```csharp
int age = 20;
int marks = 85;
int students = 50;
```

It is used for numbers without decimal points.

---

# 5. float

`float` is used to store decimal numbers.

### Example

```csharp
float price = 99.5f;
float temperature = 36.5f;
```

The letter `f` is normally added at the end of a float value.

---

# 6. double

`double` is used to store decimal numbers and provides more precision than `float`.

### Example

```csharp
double percentage = 87.56;
double price = 99.99;
```

---

# 7. char

`char` is used to store a single character.

### Example

```csharp
char grade = 'A';
char gender = 'M';
```

A `char` value uses single quotes.

```csharp
'A'
```

---

# 8. bool

`bool` is used to store only two values:

* `true`
* `false`

### Example

```csharp
bool isStudent = true;
bool isPassed = false;
```

---

# 9. string

`string` is used to store text, words, and sentences.

### Example

```csharp
string name = "Ali";
string city = "Karachi";
string message = "Hello World";
```

A string uses double quotes.

---

# Complete Example

```csharp
using System;

class Program
{
    static void Main()
    {
        int age = 20;
        float temperature = 36.5f;
        double percentage = 87.56;
        char grade = 'A';
        bool isStudent = true;
        string name = "Ali";

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Temperature: " + temperature);
        Console.WriteLine("Percentage: " + percentage);
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Student: " + isStudent);
    }
}
```

---

# Quick Revision Table

| Data Type | Used For                            | Example |
| --------- | ----------------------------------- | ------- |
| `int`     | Whole numbers                       | `20`    |
| `float`   | Decimal numbers                     | `20.5f` |
| `double`  | Decimal numbers with more precision | `20.55` |
| `char`    | Single character                    | `'A'`   |
| `bool`    | True or False                       | `true`  |
| `string`  | Text                                | `"Ali"` |

---

# Key Points

* Variable stores a value.
* `const` creates a value that cannot be changed.
* `int` stores whole numbers.
* `float` stores decimal numbers.
* `double` stores decimal numbers with more precision.
* `char` stores one character.
* `bool` stores `true` or `false`.
* `string` stores text.
* C# is case-sensitive.






