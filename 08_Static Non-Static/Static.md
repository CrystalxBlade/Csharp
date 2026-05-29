
```
class Program
    {
        static void Main(string[] args)
        {
            Welcome();
        }

        static void Welcome()                  ✅
        {
            Console.WriteLine("Welcome Blade");
        }

        void Welcome()                         ❌ 
        {
            Console.WriteLine("Welcome Blade");
        }
    }

```

### calling the function in the same class must use static in front of method 

```
 class Testing
    {
        public static void something()
        {
            Console.WriteLine("Something");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Testing.something();              
        }

```
### static allows calling function from different class wihtout creating new instance 