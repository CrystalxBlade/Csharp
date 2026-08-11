# async Keyword

## Definition:
### The async keyword marks a method as asynchronous.

## Purpose:
- Allows the use of await.
- Indicates the method performs asynchronous work.

## Syntax:

```
async Task MethodName()
{
}

```

## Common Return Types:
- Task
- Task< T >

## Important:
- async alone does not create a new thread.
- async is usually used together with await.
- An async method typically returns Task or Task<T>.


```
Main()

   │

   ▼

PrintMessage()

   │

   ▼

async Method

   │

   ▼

Contains Asynchronous Code

   │

   ▼

Returns Task

```