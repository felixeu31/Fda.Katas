
[Roman Numerals Encoder
](https://www.codewars.com/kata/51b62bf6a9c58071c600001b/train/csharp)

Difficulty: 6 kyu

Solution 1:
- Integer to digit array
- Build a roman symbol dictionary
- Convert every digit to roman symbol
  - Solution 1.1: add or subtract from pivots
  - Solution 1.2: Model all the digits matrix, use direct conversion

After further thinking about the final design I decided to adhere to the solution 1.2.

With this solution, the logic becomes simpler and I do not need to reinvent the one digit mapping of roman numbers which is invariant.

> Solution 1.2 is simpler and reduce innecesary logic

With that solution in hand I can remove some unnecessary classes that I created premature