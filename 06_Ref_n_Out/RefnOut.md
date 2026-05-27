## ref — Read and Write

```
void AddTen(ref int number)
{
    number = number + 10;
}

int x = 5;
AddTen(ref x);
Console.WriteLine(x); // Output: 15

```
✅ Variable must be initialized before passing
✅ Method can read and modify the value

```
int x;
AddTen(ref x); // ❌ Error — x must be initialized first

```
## out — Write Only

```
void GetValue(out int number)
{
    number = 50; // must assign inside method
}

int x;
GetValue(out x);
Console.WriteLine(x); // Output: 50

```
✅ Variable does not need to be initialized before passing
✅ Method must assign a value before returning

```
void GetValue(out int number)
{
    // do nothing
} // ❌ Error — number must be assigned inside method

```
## Real world example — int.TryParse uses out:

```
int result;
bool success = int.TryParse("123", out result);
// result doesn't need to be initialized before
// TryParse assigns it internally
Console.WriteLine(result); // Output: 123

```

### Simple way to remember:

- ref → you give a value, method modifies it
- out → you give nothing, method fills it for you