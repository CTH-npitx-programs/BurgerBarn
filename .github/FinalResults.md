## GENERAL INFO
the general concept/ explanation

## VIA DIRECT RENAME
info and procedure on direct
## VIA AN INTERMEDIARY
info and procedure on intermediary

## final conclusions
final conclusions

## direct from .txt
temporary section! Contain direct quotes from the .txt file
### Info.txt
There are 2 ways to rename an event I can think of

One of them has 1 less steps, but it is unknown if any differences exist besides that.
So, to test that, we have no option but to do both

### Procedure- Intermediary.txt
The first is to go into the form, and find the event they are bound to.
Then, you type a new event. That will create a second event, and all of them are bound to it.
Meanwhile, the original one is no longer bound to anything, but by copying the name of the event, it will now be bound. Then delete the intermediary.

By doing this, you can always see there is a refference, but a forseeable downside is that it will end up somehow containing both events

### Procedure- Rename.txt
The second is to go and directly rename the event.
This means you never have to even go to the form designer, nor unbind it from the current event.

I could, however, see a refference possibly getting damaged in the process

### Results.txt
This is where the results shall go:

Firstly, the intermediar:
It worked. The first event destroyed the old refferences, and the second step was basically the same as if I had moved the code into the new event, even though technically I edited the name of the old event and deleted the new one completly.
No excess code was left behind, nor was any (noticible) harm done to the refferences

secondly, the rename:
It also worked, changeing all refferences, and no noticible harm. The "diff" between the 2 methods was none, the resultant files where identical.


So, the second method is less effective and redundent
