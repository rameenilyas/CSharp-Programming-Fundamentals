
````markdown
# Module 5: User Input & Output

## 1. cin

`cin` ka use user se input lene ke liye hota hai.

### Syntax

```cpp
cin >> variable;
````

### Example

```cpp
int age;

cout << "Enter your age: ";
cin >> age;

cout << "Your age is: " << age;
```

### Explanation

* `cin` → user se input leta hai.
* `>>` → input ko variable mein store karta hai.
* `age` → input store karne wala variable hai.

---

## 2. cout

`cout` ka use screen par output display karne ke liye hota hai.

### Syntax

```cpp
cout << value;
```

### Example

```cpp
int marks = 85;

cout << marks;
```

### Output

```text
85
```

### Text + Variable

```cpp
int age = 20;

cout << "Age: " << age;
```

### Output

```text
Age: 20
```

---

## 3. Multiple Inputs

Multiple inputs ka matlab hai user se ek se zyada values lena.

### Example

```cpp
int age;
int marks;

cout << "Enter your age: ";
cin >> age;

cout << "Enter your marks: ";
cin >> marks;

cout << "Age: " << age << endl;
cout << "Marks: " << marks;
```

### Multiple Inputs in One Line

Hum ek hi `cin` statement mein bhi multiple values le sakte hain:

```cpp
int age;
int marks;

cin >> age >> marks;
```

Agar user enter kare:

```text
20 85
```

To:

```text
age = 20
marks = 85
```

---

## 4. Formatting Output

Formatting output ka matlab hai output ko clean aur readable way mein display karna.

### Using `endl`

`endl` output ko next line par move karta hai.

### Example

```cpp
int age = 20;
int marks = 85;

cout << "Age: " << age << endl;
cout << "Marks: " << marks << endl;
```

### Output

```text
Age: 20
Marks: 85
```

Without `endl`:

```cpp
cout << "Age: " << age;
cout << "Marks: " << marks;
```

Output:

```text
Age: 20Marks: 85
```

---

## Important Operators

| Operator | Meaning                                |
| -------- | -------------------------------------- |
| `>>`     | Input lena / variable mein store karna |
| `<<`     | Output display karna                   |
| `endl`   | Next line par jana                     |

## Quick Summary

* `cin` → Input 📥
* `cout` → Output 📤
* `>>` → Input ko variable mein store karta hai
* `<<` → Output display karta hai
* `endl` → Next line
* Multiple `cin` values → `cin >> age >> marks;`

```


