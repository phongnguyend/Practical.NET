## Basic Concepts
- Collections let us treat multiple objects as a single object
- Collections group items together
- Item or Element is an object (or struct) in a collection
- Enumerate or Iterate is to go through each item in turn in a collection
- Look up an Item is to access an individual item in a collection

## Commonly Used Collections
### Array
- Fixed size
- Can never change the size after instantiation
- Zero-based indexing
- Identifying (for looking up or replacing) an item using []
- IndexOutOfRangeException
- Enumerating/iterating items using for/foreach/while
- Number of items: .Length
- Array initializers

### List
- Size can be resized
- Use when don't know how many items at instantiation
- Starts empty, then add values
- Adding goes to the end of the list
- Inserting/removing in the middle of the list -> everything beyond moves (fine for small lists, be careful of big lists)
- Enumerate/iterate/lookup just like arrays
- Number of items: .Count
- List initializers

### Dictionary
- Keyed data
- Look up items with a key
- Great for unordered data
- Great for direct look up
- Dictionary vs Array/List
  + Array/List:
    + Items in order
    + Lookup using index: [index]
    + Easy to tell what indices are valid: 0 to number of items - 1
  + Dictionary
    + Think of as 'random bag'
    + Key gives access to the item
    + Inserting makes no sense because items not ordered
    + Identifying an item using: [key]
    + KeyNotFoundException and .ContainsKey() method
- Add/Remove methods
- Lookup/enumerate: same syntax as lists and arrays
- KeyValuePair<,>
- .Keys and .Values properties
- Dictionary initializers

...
