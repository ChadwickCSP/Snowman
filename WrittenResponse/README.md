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
this.guessedLetters.Add(guess[0]);
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
foreach (char c in this.guessedLetters)
            {
                letters += $" {c}";
            }
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

"The list is stored in the variable this.guessedLetters"

### 3b iv.

Describes what the data contained in the list represents in your program

This list contains the data of each letter the player guesses.

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

Without this list, which letters have been guessed could not be tracked and the player could just guess the same letter multiple times. Also, the game could not be won without the list because the method that decides if the game is won checks if each letter in the word that must be guessed has been guessed.

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
public int CountLetter(char guess)
        {
            if (!char.IsLetter(guess))
            {
                throw new ArgumentException("Invalid character: {guess}.");
            }
            else
            {
                guess = char.ToUpper(guess);
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
        }
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
int count = this.CountLetter(guess[0]);
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

CountLetter checks how many times a letter appears in the full word so that when the player guesses this letter, it will be accounted for however many times it is in the word and so the letter must not be guessed multiple times.

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

The method first selects if the character guessed by the player is a valid guess, specifically a letter, and if it is a letter, after making sure the program ignores the case of the letter, the method iterates through the list of characters in the word the player must guess and counts the amount of times the guess made by the player appears in the word, only if the guess is a correct one.

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:
 ```csharp
guess = "."
```
This call tells the code that the players guess is a period ".".


Second call:
 ```csharp
guess = "d"
```
This call tells the code that the players guess is a d "d".

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
If the player guesses a non-letter such as a period " . " the code would run this:
```csharp
if (!char.IsLetter(guess))
            {
                throw new ArgumentException("Invalid character: {guess}.");
            }
```
which tells the player that their guess is invalid due to it not being a character.
 


Condition(s) tested by the second call:

If the player guesses a real letter such as a "d" this piece of code would run:
 ```csharp
 else
            {
                guess = char.ToUpper(guess);
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



### 3d iii.

Result of the first call:
The result of the first call is a message to the player telling them that their guess is invalid due to it not being a character



Result of the second call:
The result of the second call is the number of that letter that appears in the word that the player is trying to guess.

