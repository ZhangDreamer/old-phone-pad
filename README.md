# Old Phone Pad

A simple project written in C#, simulating an old phone keypad. With each key corresponding to a series of characters/letters that can be cycled by consecutive presses. It takes in an input with a sequence from the phone pad and produces an output from it.

### Assumption:
 - The program assumes that the user will always input a correct sequence of keypad pressess and always ending it with `#`.

![Old Keypad](https://st3.depositphotos.com/10361312/13346/v/450/depositphotos_133464146-stock-illustration-aluminium-phone-circle-buttons.jpg)

# Solution

The program loops through the input and depending on it's key, it will handle it until it detects the end of the input with the character '#'. The program includes a Dictionary/Hashmap for the keys with it's corresponding pair of characters, replicating the old phone keypad.

_Dictionary mapping_:
| Key | Characters       |
|-----|------------------|
| 1   | `&,',(`          |
| 2   | `A, B, C`        |
| 3   | `D, E, F`        |
| 4   | `G, H, I`        |
| 5   | `J, K, L`        |
| 6   | `M, N, O`        |
| 7   | `P, Q, R, S`     |
| 8   | `T, U, V`        |
| 9   | `W, X, Y, Z`     |
| 0   | ` `    |


## Example:
| _Input_                    | _Output_        |
|----------------------------|-----------------|
| **`"8 88777444666*664#"`** | **`TURING`**    |
| **`"33#"`**                | **`E`**         |
