# Guessing Game Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

This program's purpose is to create an entertaining guessing game for a player.

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

Not applicable for this project.

### 3a iii.

Describes the input and output of the program demonstrated in the video.

Not applicable for this project

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
this.guesses.Add(guess[0]);
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
  foreach (char c in this.guesses)
            {
                letters += $"{c} ";
            }
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

**The list is stored in the variable guesses.**

### 3b iv.

Describes what the data contained in the list represents in your program

**This list stores the letters guessed and then displays each character.**

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

**TODO: it would be very difficult to write the guessing game without using the list. With out a list we would have to define a bo\ol variable for each individual letter that is set to false, and when the player guesses that letter the bool would be set true. At the end of the game when the program return every letter the player has guessed the program would have to check if each of our bool variables are set to true. Then the program would return the true bools as char guessed. 

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
// TODO: Select a method that meets all of the requirements.
// I recommend your Constructor or CountLetter
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
// TODO: Add code showing where the procedure is being called
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

**TODO: Explain at a high level what this method does and when it is called**

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

**TODO: In English, explain step by step what your procedure does. Be sure to use the word `Selection` and `Iteration` to explain what it does.**

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call: 
```csharp
count = a non char value
count = this.CountLetter(guess[0]);
```

**TODO: Complete this section**

Second call:
```csharp
count = a char value
count = this.CountLetter(guess[0]);
```



**TODO: Complete this section**

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
this calls if the player input a value other than a char type 

Condition(s) tested by the second call:
this calls if the input of the value is a char value

**TODO: Complete this section**

### 3d iii.

Result of the first call:

```
this prints "Invalid character: {guess}."
```

Result of the second call:
``` 
this runs a the char value through a foreach loop which checks if the guessed value was in our wordToGuess variable. If it is, then the count var is increased, the program then returns count regardless if the foreach loop is confirmed. 
``` 
