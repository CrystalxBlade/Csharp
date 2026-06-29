# Exception Handling in C#

## What is an Exception?

An **Exception** is an unexpected problem or error that occurs while a program is running. If an exception is not handled properly, it can cause the application to crash.

### Example

```csharp
int number = int.Parse("abc");
```

Output:

```
System.FormatException: Input string was not in a correct format.
```

This happens because `"abc"` cannot be converted into an integer.

---

# What is a Compile-Time Error?

A **Compile-Time Error** is an error that occurs **before the program runs**. These errors are detected by the compiler and must be fixed before the application can be executed.

### Example

```csharp
int number = "Hello";
```

Output:

```
Cannot implicitly convert type 'string' to 'int'
```

The program will not compile until the error is fixed.

### Common Compile-Time Errors

- Missing semicolon (`;`)
- Incorrect data type
- Undefined variable
- Missing method
- Syntax errors

---

# What is a Runtime Error?

A **Runtime Error** is an error that occurs **while the program is running**. The code compiles successfully, but an exception is thrown during execution.

### Example

```csharp
int number = int.Parse("abc");
```

Output:

```
System.FormatException
```

The program starts running, but crashes because `"abc"` is not a valid integer.

### Common Runtime Errors

- DivideByZeroException
- NullReferenceException
- FormatException
- IndexOutOfRangeException
- FileNotFoundException

---

# Why Do We Use Exception Handling?

Exception handling allows a program to deal with runtime errors gracefully instead of crashing.

It helps to:

- Prevent application crashes
- Display user-friendly error messages
- Continue program execution when possible
- Improve application reliability

---

# Summary

| Compile-Time Error | Runtime Error (Exception) |
|--------------------|---------------------------|
| Occurs before execution | Occurs during execution |
| Detected by the compiler | Detected while the program is running |
| Program cannot start | Program starts but may crash |
| Example: Syntax error | Example: Divide by zero |