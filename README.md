# Name Sorter

## Purpose
To demonstrate the SOLID principles when sorting a list of people from an unsorted file.

## Setup and run

1. Clone the repo
   ```sh
   git clone https://github.com/ShaunGittins/name-sorter.git
   ```
2. Execute
   ```cmd
   cd ...\repos\name-sorter\name-sorter\bin\Debug\net5.0
   name-sorter ./unsorted-names-list.txt
   ```
3. Run tests
   ```cmd
   cd ...\repos\name-sorter
   dotnet test
   ```
   
## SOLID Principles Showcased

1. Single Responsibility
   * 'Person.cs' stores a full name split up into a last name string and given names string.
   * 'FilePersonConverter.cs' gives static methods to convert List<string> (from FILE) to List<Person> and vice-versa.
   * All 'Comparers' only take in two people, and compares them in anyway they like, returning an int value for Sort() to use.
   * 'Program.cs' uses all of the other classes in order to read the file, sort them, write to the new file and print to screen.

2. Open-Closed
```C#
  CompareByLastnameFirst comparer = new();
  people.Sort(comparer);
```
Sorting people can be changed through extension, by creating a new class that inherits from IComparer.
We could do:
```C#
  CompareByLastnameVowelCount comparer = new();
  people.Sort(comparer);
```
Without modifiying people or the Sort function.

3. Liskov Substitution

4. Interface Segregation
 We don't want to throw a bunch of NotImplementedExceptions because IComparer forces the comparers to implement parts of the interface they won't use.
 All 'CompareByLastnameFirst' and other comparers including mocks only want to use int Compare(x, y).
   
5. Dependency Inversion
```C#
  CompareByLastnameFirst comparer = new();
  people.Sort(comparer);
```
Passing in an IComparer to people.Sort() rather than initializing it inside the class.
Because of this we can easily swap out the type of IComparer, or even in the case of testing we can create a mock IComparer.
```C#
  internal class MockFirstNameOnlyComparer : IComparer<Person>
  {
      public int Compare(Person x, Person y)
      {
          return x.FirstNames.CompareTo(y.FirstNames);
      }
  }
```
This means we can test the function in isolation without worrying about it's dependency IComparer behaviour.
