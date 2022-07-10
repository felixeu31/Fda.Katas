# Introduction

This is a [Kata](https://www.codewars.com/kata/514b92a657cdc65150000006/train/csharp) from [CodeWars](https://www.codewars.com/)

# Dev journal

- Create a test for the simplest case, make it run, make it pass
- Raw thoughts:
  - I have to implement a functionality that evaluates if a number is multiple of 3 or 5
  - I have to iterate or list over all the numbers bellow the given number
  - Finally I have to sum the numbers that complies with the evaluation
- Possible solutions:
  - For loop, evaluating and aggregating
  - Get list of numbers bellow, perform a linq sum with a condition
- It seems prettier to obtain a list of natural numbers and sum the ones that complies with the evaluation. A way to obtain that list is using a Enumerable.Range