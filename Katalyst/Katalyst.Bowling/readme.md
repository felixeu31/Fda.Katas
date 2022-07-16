# Introduction

Kata: https://katalyst.codurance.com/bowling

# Dev Journal

## BowlingGame with simple shots
- First test: score from one simple play
  - Implement BowlingGame class
  - Implement Shot class, having a BowlingGame a list of shots
  - Implement bowlingGame Score method
- As I have to be able to calculate the score from each shot I create another unit test for ShotTests
  - Implement Shot class
  - Implement Shot.Score for test ShotTests.Score

## BowlingGame with especial shots: spare

> I realize that I cannot simple sum a sequence of shots. They are related to the frame play. 
> Ex: 3/ is then points (just without taking into account following shots)
> In this case I can not sum 3 + /, because they are not independent shots, but shots of the same frame

- In this point I create the Frame class to test the behaviour of a frame (spare play, maximum shots per frame, etc..)