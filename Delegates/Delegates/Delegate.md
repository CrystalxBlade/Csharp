## Delegates: It's a type safe function pointer.

### A delegates holds the reference of a method and then calls the method for execution.


## To call a method by using a delegate we have 3 steps:

### 1. Define a delegate
### [<modifiers>] delegate void <Name>([<parameter list>])

- public delegate void AddDelegate(int a, int b); // return type should be same as method

public void AddNums(int a, int b); // Normal method 

- public delegate string SayDelegate(string str); // no need to use static when method is already static
public static string SayHellp(string name);
