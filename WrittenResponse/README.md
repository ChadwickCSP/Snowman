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
 this.lettersGuessed = new List<char>();
 
```
```csharp
 this.lettersGuessed.Add(guess[0]);
 ```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
foreach (char c in this.lettersGuessed)
            {
                letters += $"{c} ";
            }
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

**TODO: Write, "The list is stored in the variable {INSERT VARIABLE NAME
HERE}"**

### 3b iv.

Describes what the data contained in the list represents in your program

In this list we are storing all the letter that the player has guessed

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

If the list was not used, an infinite amount of variables would need to be made to keep track of the infinite guesses a player could make. This would make writing the code impossible since infinite variables can not be made, so the only other option would be to limit the players guesses. Creating a list is the most convenient way to track all the players guessed without limiting the amount of guesses a player can have.

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
        }

```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
 count = this.CountLetter(guess[0]);
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

This procedure counts the number of times a character is in the word trying to be guessed. For example: if the generated word was pizza, and the character was z, the procedure would return 2. This is used to determine how many times, if at all, the letter appears in teh word. 


### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

**TODO: In English, explain step by step what your procedure does. Be sure to use the word `Selection` and `Iteration` to explain what it does.**

1. The algorithm checks that `guess` is a letter and if it is not it throws an `ArgumentException`.
2. It makes the `guess` character uniform by making it all upper case.
3. Initializes and integer to count the amount of appearances of a letter in the word.
4. Iterate through every character in the word that is being guessed.
    * If the character appears in the word increment the count.
5. After checking every letter, return the count. 


## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call: 

A call might be CountLetter('4')

Second call:

A call might be CountLetter('S')

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
If the player entered something that was not a letter.

Condition(s) tested by the second call:

If the player entered something that is a letter.

### 3d iii.

Result of the first call:

The result would be an error saying "Invalid character: {guess}." 

Result of the second call:

Assuming the word being guessed is suspect, this would result in the number 2. 

