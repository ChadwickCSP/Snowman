# Guessing Game Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

This program's purpose is to create an entertaining guessing game for a player. The player has to guess the random word generated.

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
this.lettersGuessed.Add(guess[0]);
```

### 3b ii.

The second program code segment must show the data in the same list being used, such as creating new data from the existing data or accessing multiple elements in the list, as part of fulfilling the program's purpose.

```csharp
foreach (char c in this.lettersGuessed)
            {
                letters += $"{c} ";
            }
### 3b iii.
```

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

The list is stored in the variable {letters Guessed}

### 3b iv.

Describes what the data contained in the list represents in your program

**TODO: Write a sentence describing what is stored in the list** The List contains the players guessed letters

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

**TODO: Explain why it would be very difficult (or impossible) to write 
the guessing game without using the list.**
The list manages the guessed letters. If these guesses were not stored then the player would infinitely guess the right or wrong letters without ever being able to win the game. Without this list, you would have to have a lot more variables to store each guess or each letter, but with this code you don't need to do that. 

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
public int CountLetter(char guess)
        {

            if (!char.IsLetter(guess))
            {
                throw new ArgumentException($"Invalid character: {guess}.");
            }
            guess = char.ToUpper(guess);
            int count;
            count = 0;
            foreach (char c in this.fullWord)
            {
                if (c == guess)
                {
                    count++;
                }
            }

            return count;
        }
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
            count = this.CountLetter(guess[0]);
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

Counts the number of times the specified character appears in the word to be guessed. The case of the letter specified is ignored
### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

**TODO: In English, explain step by step what your procedure does. Be sure to use the word `Selection` and `Iteration` to explain what it does.**

First the code checks if the `guess` is a letter through a selection. If it is not a letter it throws an `ArgumentException`. If `guess` is a character then the program makes it uppercase. Once the letter has been made uppercase, the code counts the number of times that the character appears. The code does this by iterating through every character to see if the character is in the word being guessed. If the character is the guess then the count goes up. After the iteration is complete and the characters have all been check, the program returns the count. 

1. Check that `guess` is a letter. If it is not a letter, throw an `ArgumentException`.
2. Sanitize the `guess` character by making it uppercase.
3. Initialize an integer to count the number of appearances.
4. Iterate through every character in the word being guessed.
   * If it is the guess, increment the count.
5. After checking every letter, return the count. 

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:

This code makes the player's guess uppercase.

Second call:

The count increments when the guess is part of the word 

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
Is the guess a letter

Condition(s) tested by the second call:

How many times is the guess part of the word.

### 3d iii.

Result of the first call:

The player's guess is sanitized and uppercase.

Result of the second call:

The number of times a guessed letter appears in the word has been determined and stored