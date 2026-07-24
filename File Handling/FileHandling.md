# File Handling in C#

## Definition

File Handling is the process of creating, reading, writing, updating, copying, moving and deleting files and directories.

---

## Namespace

```csharp
using System.IO;
```

---

## Topics Covered

- Create File
- Write File
- Read File
- Append File
- Check File Exists
- Copy File
- Move File
- Delete File
- Create Directory
- Delete Directory
- Get Files
- FileInfo

---

## Common Classes

- File
- FileInfo
- Directory
- DirectoryInfo

---

## Common Methods

| Method | Description |
|---------|-------------|
| File.Create() | Creates a file |
| File.WriteAllText() | Writes text |
| File.ReadAllText() | Reads text |
| File.AppendAllText() | Adds text |
| File.Exists() | Checks file existence |
| File.Copy() | Copies file |
| File.Move() | Moves file |
| File.Delete() | Deletes file |
| Directory.CreateDirectory() | Creates folder |
| Directory.GetFiles() | Gets all files |

---

## Real World Uses

- Save application settings
- Store logs
- Export reports
- Read configuration files
- Upload and download files


- 
@ (Verbatim String Literal)

Definition:
The @ symbol tells C# to treat a string exactly as it is written.

Why use it?
✔ Makes Windows file paths easier to write.
✔ No need to escape backslashes (\\).
✔ Supports multi-line strings.

Without @
"C:\\Users\\Blade\\Notes.txt"

With @
@"C:\Users\Blade\Notes.txt"