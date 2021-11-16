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

**TODO: Write, "The list is stored in the variable {INSERT VARIABLE NAME
HERE}"**

### 3b iv.

Describes what the data contained in the list represents in your program

**TODO: Write a sentence describing what is stored in the list**

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

**TODO: Explain why it would be very difficult (or impossible) to write 
the guessing game without using the list.**

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.
```csharp

        public int CountLetter(char guess)
        {
            guess = char.ToUpper(guess);
            if (!char.IsLetter(guess))
            {
                throw new ArgumentException("Invalid character: {guess}.");


            }
            int count;
            count = 0;
            foreach (char c in fullWord)
            {
                if (c == guess)
                {
                    count++;
                }
            }
            return count;
        }



         count = this.CountLetter(guess[0]); //Called here in Check Guess Code





public string GetFullWord()
        {
            return this.fullWord;
        }

         else if (!this.fullWord.Contains(guess)) 
```

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
public int CountLetter(char guess)
        {
            guess = char.ToUpper(guess);
            if (!char.IsLetter(guess))
            {
                throw new ArgumentException("Invalid character: {guess}.");


            }
            int count;
            count = 0;
            foreach (char c in fullWord)
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

Count Letter is a procedure that analyses and formats each letter guessed. First, it makes any character guessed, and makes it uppercase. Second it takes into account an invalid guess. Third, it uses a foreach loop in order to assaign each guess to full word to store it to the list. Count Letter is called in check guess when the number of guesses is required.

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

**TODO: In English, explain step by step what your procedure does. Be sure to use the word `Selection` and `Iteration` to explain what it does.**

a public integer of Count Letter in the variable guess is created.
that guess is turned into an uppercase letter.
if it is not a letter, "Invalid Guess" is stated.
the integer for number of guesses is set to zero.
an iteration is created.
- for each guess that is a letter, store in full word.
- A selection is created in the iteration.
- - for each valid guess, add to the integer count of guesses, otherwise return count.

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:

**TODO: Complete this section**

Second call:

**TODO: Complete this section**

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
**TODO: Complete this section**

Condition(s) tested by the second call:

**TODO: Complete this section**

### 3d iii.

Result of the first call:

**TODO: Complete this section**

Result of the second call:

**TODO: Complete this section**
