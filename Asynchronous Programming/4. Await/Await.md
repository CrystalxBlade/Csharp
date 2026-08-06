# await Keyword

## Definition:
### The await keyword pauses an async method until the awaited Task completes.

## Syntax:

```
await Task.Delay(1000);

// or

await SomeAsyncMethod();

```
## Purpose:
- Wait for asynchronous operations.
- Does not block the current thread.
- Resumes execution after the Task completes.

## Important:
- Can only be used inside an async method.
- Works with Task and Task<T>.
- Makes asynchronous code easier to read.



## With await

```
Start

↓

Wait for Download

↓

Continue

```

## Without await

```
Start

↓

Start Download

↓

Continue Immediately

↓

Download Finishes Later

```