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
        {
                if (!char.IsLetter(guess))
                {
                    throw new ArgumentException($"Invalid Character {guess}.");
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

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
        {
            // throw new System.NotImplementedException();
            string letters;
            letters = string.Empty;
            foreach (char c in this.lettersGuessed)
            {
                letters += $"{c} ";
            }

            return letters.Trim();
        }
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

The list is stored in the variable lettersGuessed

### 3b iv.

Describes what the data contained in the list represents in your program

Each letter of the guess that the player made

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

It would be almost impossible because it would be hard to code a way to store every single letter in it's own area
also it would be hard to make it fetch the guesses later in the code. 

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
        {
                if (!char.IsLetter(guess))
                {
                    throw new ArgumentException($"Invalid Character {guess}.");
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
        {
            // throw new System.NotImplementedException();
            string letters;
            letters = string.Empty;
            foreach (char c in this.lettersGuessed)
            {
                letters += $"{c} ";
            }

            return letters.Trim();
        }

```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

What this does is that it checks the guess that is provided to see if it's a valid guess, even before it's correct, 
then the code will display how many times the player guessed incorrectly. 

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

The program is able to display for each letter that is guessed, it will display the certain amount of guesses the 
player made. It will  then repeat itself until there are no more guesses that are left. The first segment is meant to have it where if a guess is incorrect, it will make the player re-type their guess again until they have an actual answer
even if it's incorrect. Then it will take the guess and add it to the guesses that are needed for the final word. 

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:

**TODO: Complete this section**
```csharp
CountLetter('!')
```

Second call:

**TODO: Complete this section**
```csharp
CountLetter('i')
```

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
**TODO: Complete this section**
If there are any '!' in 'Emiliano'.

Condition(s) tested by the second call:

**TODO: Complete this section**
If there are any 'i' in 'Emiliano'.

### 3d iii.

Result of the first call:

**TODO: Complete this section**
Invalid Character "!"

Result of the second call:

**TODO: Complete this section**
2
