## Functions are basically set of instructions and reusable blocks of code 📦 
- Instead of writing the same code again and again, you put it inside a function and call it whenever needed.

## 🔷 Basic Structure of a Function

```
returnType FunctionName(parameters)
{
    // code
}

```
## Example

```
void Greet()
{
    Console.WriteLine("Hello");
}

```
## 📊 Tiny Diagram

```
Call Function
      ↓
┌────────────┐
│  Function  │
│  runs code │
└────────────┘
      ↓
Returns back

```

## 🔥 Types of Functions
### 1️⃣ Function with no return value

Uses:

```
void

```
Example:

```
void PrintName()
{
    Console.WriteLine("Blade");
}

```

### 2️⃣ Function with return value

- Returns something back.

```
int Add()
{
    return 5 + 5;
}

```
Usage:

```
int result = Add();

```

### 🔷 Parameters

Functions can take input.

```
void Greet(string name)
{
    Console.WriteLine(name);
}

```
Call:

```
Greet("Blade");

```

### 🔷 Function with Parameters + Return

```
int Add(int a, int b)
{
    return a + b;
}

```
Call:

```
int sum = Add(2, 3);

```
### 🔥 Main Function Types You Should Learn

| Type                    | Example                   |
| ----------------------- | ------------------------- |
| No parameter, no return | `void Hello()`            |
| Parameter, no return    | `void Hello(string name)` |
| No parameter, return    | `int GetNum()`            |
| Parameter + return      | `int Add(int a, int b)`   |