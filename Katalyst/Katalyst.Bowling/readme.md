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
- I create all basics tests for just one frame calculation

>In this point I realize that frame number could be necessary:
> 
  > - strike/spare plays needs consecutive frames to calculate their score
  > - also the frame 10 has a special behaviour

Following the TDD rules I could not write code if a test is not failing. I think i should not implement than functionality before writing a test. I will come back later

## Revisiting the concept of shot and frame

I now think that a shot could not be a spare on its own. What defines if a shot completes a spare is the concept of frame: only when you throw all the pins left by a previous shot in the same frame is considered a spare. So I am gonna to remove the concept of spare or strike in a shot, and take it to the frame. 

Doing so I think a shot should only know how many pins have it thrown, and nothing else. The rest of the logic should be part of the Frame and the Bowling Game classes

- I rewrite shot tests to create shots from scalar. Then when I refactor the Shot constructor, then all breaks apart. Frame depends on shots constructors to function properly, so all frame tests stopped working

> Is it something wrong with my progress? a faulty design? 

- I fix one test at a time and keep moving forward till all return to green

## Some refactorings
- Include tests in frame to avoid strikes on second shot
- Include functionality of several frames
- Include functionality of sum next shoots to a strike or a spare

## ..End of session. Next Steps:

- ¿Refactor frame class to have a list of shots?

- Include functionality to final frame wich will be special