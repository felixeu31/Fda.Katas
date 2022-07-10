﻿# Intro

This is a [Kata](https://www.codewars.com/kata/523a86aa4230ebb5420001e1) from codewars.

# Interestign learning

## List.FindAll

https://stackoverflow.com/questions/1938204/linq-where-vs-findall 

```
FindAll() is a function on the List<T> type, it's not a LINQ extension method like Where. 
The LINQ extension methods work on any type that implements IEnumerable, whereas FindAll can only be used on List<T> instances (or instances of classes that inherit from it, of course).

Additionally, they differ in actual purpose. 
Where returns an instance of IEnumerable that is executed on-demand when the object is enumerated. 
FindAll returns a new List<T> that contains the requested elements. 
FindAll is more like calling Where(...).ToList() on an instance of IEnumerable.
```

## Enumerable.SequenceEqual

https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Enumerable.SequenceEqual?view=net-6.0