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

✅ Never throws an exception — returns true or false
✅ If conversion fails, number is set to 0 automatically

```
int.TryParse("abc", out number);  // returns false, number = 0
int.TryParse(null, out number);   // returns false, number = 0

```
Use when input is coming from user and may or may not be valid

## 3. Convert.ToInt32

```
string input = "123";
int number = Convert.ToInt32(input);
Console.WriteLine(number); // Output: 123

```
✅ Handles null — returns 0 instead of exception
❌ Throws exception for invalid strings

```
Convert.ToInt32(null);   // returns 0  ✅
Convert.ToInt32("abc");  // FormatException ❌
Convert.ToInt32("99999999999"); // OverflowException ❌

```
Use when input might be null but is otherwise valid

## Bottom line:

- Taking input from user → always use int.TryParse
- Data is guaranteed valid → use int.Parse
- Data might be null but otherwise valid → use Convert.ToInt32