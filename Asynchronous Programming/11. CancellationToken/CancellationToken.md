==================================================
CancellationToken
==================================================

## Definition:

### CancellationToken provides a way to request that an asynchronous operation should be cancelled.


## Main Components:

```
CancellationTokenSource
        ↓
Creates and controls cancellation

CancellationToken
        ↓
Passed to the asynchronous operation

cts.Cancel()
        ↓
Requests cancellation

```

## Example:

```
using CancellationTokenSource cts =
    new CancellationTokenSource();

await SomeMethod(cts.Token);

cts.Cancel();

```
## Checking Cancellation:

```
token.ThrowIfCancellationRequested();

Task.Delay with Cancellation:

await Task.Delay(1000, token);

```
## Exception:

OperationCanceledException


## Important:

- Cancellation is cooperative.
- CancellationToken does NOT forcibly kill a thread.
- The operation must support/check the token.
- CancellationTokenSource is used to request cancellation.
- CancellationToken is passed to the operation.
- OperationCanceledException can be caught when cancellation occurs.




```
          CancellationTokenSource
                    │
                    │
              cts.Token
                    │
                    ▼
          ┌─────────────────┐
          │ Async Operation │
          └────────┬────────┘
                   │
                   ▼
             Doing Work...
                   │
                   │
          cts.Cancel() called
                   │
                   ▼
        Cancellation requested
                   │
                   ▼
       Operation checks token
                   │
             ┌─────┴─────┐
             │           │
             ▼           ▼
          Continue      Stop
                         │
                         ▼
            OperationCanceledException
                         │
                         ▼
                       catch

```


```
CancellationTokenSource
        ↓
"I control cancellation."

CancellationToken
        ↓
"Here's the cancellation signal."

cts.Cancel()
        ↓
"Please stop."

ThrowIfCancellationRequested()
        ↓
"Should I stop?"

OperationCanceledException
        ↓
"The operation was cancelled."

```