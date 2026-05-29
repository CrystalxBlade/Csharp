
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

calling the function in the same class must use static 