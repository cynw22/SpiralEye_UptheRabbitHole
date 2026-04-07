=== MeetCat === 
#speaker: Narrator 
The girls wander outside the room; a vast and lush forest stretches on for what seems like forever.

#speaker: Narrator
Realizing there’s nowhere else to go, the girls tread carefully down the pathway. They walk until their feet feel sore and everything starts to ache.

#speaker: Alice
Con, I’m done, no more please.

#speaker: Alice
I cannot walk a single step further, my feet hurt and my head’s starting to spin.

#speaker: Narrator
Constance notices her sister looks too tired to continue, but she wisely chooses not to voice this aloud in hopes of keeping Alice calm.

#speaker: Constance
I suppose we can take a quick break. 

#speaker: Alice
Yes!!!

#speaker: Narrator
Alice smiles gratefully and happily parks herself down on the path. Silence fills the area around them.

#speaker: Narrator
It’s unsettling and Constance wonders why she can’t hear the wildlife here despite it being midday.

#speaker: Alice
Maybe it’s cause of the heat? Maybe all the creatures went into hibernation?

#speaker: Narrator
Constance looks at her sister in confusion.

#speaker: Constance
Pardon?

#speaker: Alice
The animals, you said that it was weird you couldn’t hear the wildlife right?

#speaker: Constance
Alice I didn’t say that out loud???

#speaker: Alice
Ohhh.. must have been the voices.

#speaker: Constance
The voices…

#speaker: Alice
yeahhh it sounds pretty nice though, so don’t worry about it.

#speaker: Constance
I always worry about you…

#speaker: Narrator
Alice spots something in the distance, just beyond the tree.

#speaker: Alice
What is that?

#speaker: Narrator
A handsome grin materialized out of thin air.

#speaker: Alice
Con, look! There’s something over there.

#speaker: Constance
Okay hang on, let’s think this through before we jump head first-

#speaker: Narrator
Alice takes off running after the mysterious thing.


+ [Call out to Alice gently]
    ~ C_Alice += 1
    #speaker: Constance
    Oh my gosh Alice! No!!! Not again!    
    #speaker: Alice
    Connnnn, come quickly, it looks interesting!
    
    #speaker: Constance
    ALICE!!!

    #speaker: Narrator
    Exhausted, but amused by her sister's lively attitude, Constance shelves her worry to chase after Alice quickly.

    -> after_choice_2 

+ [Yell at Alice for running]
    ~ C_Alice -= 1
    #speaker: Constance
    ALICE I SWEAR, IF YOU LEAD US DOWN ANOTHER RABBIT HOLE, I WILL NOT BE RESPONSIBLE FOR THE THINGS I SAY.
    
    #speaker: Alice
   Oh my gosh Con you worry way too much! It’s fine!

   Come on, it's time for adventure!
    
    #speaker: Narrator
    Alice disappears from view.

    #speaker: Constance
    …Why can’t I have one day, just one normal day to myself?
    
    #speaker: Narrator
    Frustrated by her sister's carelessness, Constance quickly gives chase to her wayward sibling.

    -> after_choice_2

===after_choice_2===
#speaker: Narrator
The game of cat and mouse has begun. The strange smile sitting in the distance materializes once more, a sharp looking feline now attached to its grin.

#ending: MeetCatPuzzle

-> DONE


