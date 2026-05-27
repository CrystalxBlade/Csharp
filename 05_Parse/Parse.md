## All three convert a string to an integer, but they behave differently when input is invalid:

## 1. int.Parse
```
input = "123";
int number = int.Parse(input);
Console.WriteLine(number); // Output: 123

```
### ❌ Throws an exception if input is invalid

```
Parse("abc");  // FormatException
int.Parse(null);   // ArgumentNullException
int.Parse("99999999999"); // OverflowException
```
Use when you are 100% sure the input is a valid number

## 2. int.TryParse

```
input = "123";
int number;

if (int.TryParse(input, out number))
{
    Console.WriteLine("Converted: " + number); // Output: 123
}
else
{
    Console.WriteLine("Invalid input");
}

```