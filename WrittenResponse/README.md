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
foreach (char c in this.fullWord)
            {
                if (this.guesses.Contains(c))
                {
                    word += $"{c} ";
                }
                else
                {
                    word += "_ ";
                }
            }
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

The list is stored in the variable {guesses}.

### 3b iv.

Describes what the data contained in the list represents in your program

**TODO: The letters that the player guesses are stored in this list.**

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

Without a list, you would have to write more lines of codes to track and call the player's guesses.

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

This method tells how many letters have been guessed by the player, it is used to show the player how many times they've guessed.

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

**It starts by determining if the players input is a letter, if not then it returns "invalid character". If the input is a letter the code then converts it into capital letters. For every letter the player guessed, it gets added to the count. After all of the guesses have been made, the code returns the number of guesses made by the player.**

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:

An example would be CountLetter('.')

Second call:

Another example would be CountLetter('A')

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
Testing if input is not a letter.

Condition(s) tested by the second call:

Testing if input is a letter

### 3d iii.

Result of the first call:

The program will return "Invalid character: .

Result of the second call:

Assume the word is apple, the program will return the number 1.
