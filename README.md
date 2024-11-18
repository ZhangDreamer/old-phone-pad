# Old Phone Pad

A simple project written in C#, simulating an old phone keypad. With each key corresponding to a series of characters/letters that can be cycled by consecutive presses.

![Old Keypad](https://st3.depositphotos.com/10361312/13346/v/450/depositphotos_133464146-stock-illustration-aluminium-phone-circle-buttons.jpg)

# Solution

The program loops through the input and depending on it's key, it will handle it until it detects the end of the input with the character '#'. The program includes a Dictionary/Hashmap for the keys with it's corresponding pair of characters, replicating the old phone keypad.

## Example:
_Input_: **"8 88777444666*664#"**
_Output_: **TURING**
