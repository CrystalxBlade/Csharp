# async Main

## Definition:

### async Main() allows the application's entry point
### to use await directly.


### Normal Main:

```
static void Main()
{
}

```

### Async Main:

```
static async Task Main()
{
    await SomeOperation();
}

```

### Why use async Main?

- Allows await inside Main()
- Useful when the application needs asynchronous work
- Common in modern C# applications


## Return Type:

```
static async Task Main()

Task = Main() performs asynchronous work
        but does not return a value.

```

### Important:

- async Main() does not create a new thread.
- Main() can directly use await.
- Main() can return Task or Task<int>.



```
static async Task Main()
        │
        ▼
   await DownloadData()
        │
        ▼
   Task.Delay(3000)
        │
        │  3 seconds
        ▼
 Download Finished
        │
        ▼
 Program Finished

```