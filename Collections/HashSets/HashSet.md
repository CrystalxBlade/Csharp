## Why does HashSet<T> exist?

### The main purpose of a HashSet is to store only unique values.

### If you try to add the same item twice, it ignores the duplicate.

### Example:

```
HashSet<string> names = new HashSet<string>();

names.Add("Blade");
names.Add("Crystal");
names.Add("Blade");

```
### Output

```
Blade
John

```