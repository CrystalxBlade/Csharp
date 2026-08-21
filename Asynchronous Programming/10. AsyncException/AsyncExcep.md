==================================================
Exception Handling
==================================================

### Exceptions can also occur inside asynchronous methods.

### Use try-catch to handle exceptions from Tasks.

## Example:

```
try
{
    await SomeAsyncMethod();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

```
## Execution:

```
Async Method
     │
     ▼
Exception occurs
     │
     ▼
Task becomes Faulted
     │
     ▼
await
     │
     ▼
catch
     │
     ▼
Handle Exception

```

## Important:

- async methods can throw exceptions.
- Use try-catch with await.
- await propagates the exception to the caller.
- finally can be used for cleanup.
- Task.WhenAll() can also be handled with try-catch.
- Do not use empty catch blocks.


## Common Exception Types:


- Exception
- TimeoutException
- ArgumentException
- ArgumentNullException
- InvalidOperationException
- IOException


```
       Async Operation
             │
             ▼
       ┌───────────┐
       │ Successful│
       └─────┬─────┘
             │
             ▼
          Continue

             OR

       ┌───────────┐
       │   Error   │
       └─────┬─────┘
             │
             ▼
           catch
             │
             ▼
          Handle

```
