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
// TODO: Copy The line of code here for which you are adding data to a list
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
// TODO: Show a foreach loop accessing each element of the list from 3bi
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

 "The list is stored in the variable {this.lettersGuessed}"

### 3b iv.

Describes what the data contained in the list represents in your program

In the list, the different guesses the player makes are stored. 

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

Without the ability to store each guess the player makes, the code could not keep track of how many guesses were made or if you already guessed a specific letter. The code would then probably have to ask if each individual letter was already guessed which would make the code much longer and more complex than it needs to be. 

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

CountLetter('#')

Second call:

CountLetter('D')


### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call: The condition tested by the first call is checking if the input isn't a letter. 
 

Condition(s) tested by the second call:

The second condition that is tested is checking if it is a letter and counting the number of times it shows up

### 3d iii.

Result of the first call: Throws an error



Result of the second call: Spits out the number of times the letter shows up. 


