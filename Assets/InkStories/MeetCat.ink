=== MeetCat === 
#noskip_start
#speaker: Narrator 
The girls wander outside the room, a vast and lush forward stretches on for what seems like forever.

#speaker: Narrator
Realizing there’s nowhere else to go, the girls tread carefully down the pathway. They walk until their feet feel sore and everything starts to ache.
#noskip_end

#speaker: Alice
Con, I’m done, no more please.

#speaker: Constance 
What? 

#speaker: Alice
I cannot walk a single step further, my feet hurt and my head’s starting to spin.

#speaker: Narrator
Constance feels like her sister looks like a wilted flower, she wisely chooses not to voice this aloud in hopes of keeping Alice calm.

#speaker: Constance
I don’t like it but I suppose we can take a quick break. 

#speaker: Alice
Yes!!!

#speaker: Constance
But only a small one, five minutes that’s it.

#speaker: Narrator
Alice nods and happily parks herself down on the path, much to Constance’s disgust. Silence fills the area around them.

#speaker: Narrator
It’s unsettling, Constance wonders why she can’t hear the wildlife here despite it being midday.

#speaker: Alice
Maybe it’s cause of the heat? All the creatures went into hibernation?

#speaker: Narrator
Constance looks at her sister in confusion.

#speaker: Constance
What where did this come from?

#speaker: Alice
The animals, you said that it was weird you couldn’t hear the wildlife right?

#speaker: Constance
Alice I didn’t say that out loud???

#speaker: Alice
Really? Oh... it must have been the voices.

#speaker: Constance
The voices…

#speaker: Alice
yeahhh it sounds pretty nice though, so don’t worry about it.

#speaker: Constance
Yeah no thank you, I’ll worry however I please. Knowing you whatever this is will be plenty of trouble.

#speaker: Narrator
Constance lets out a little sigh, something that makes Alice giggle softly. 

#speaker: Narrator
Oh but look here something sits in the distance, just beyond the tree?

#speaker: Alice
What? Where?

#speaker: Narrator
A cheeky grin beacons you forward.

#speaker: Alice
Con look! There’s something over there.

#speaker: Constance
Okay hang on, let’s think this through before we jump head first-

#speaker: Narrator
Alice takes off after the mysterious thing.

#noskip_start
+ [Call out to Alice gently]
    ~ C_Alice += 1
    #speaker: Constance
    Oh my god Alice no!!! Not again    
    #speaker: Alice
    Connnnn come quickly, it looks interesting!
    
    #speaker: Constance
    ALICE!!!

    #speaker: Narrator
    Exhausted but amused by her sister's lively attitude Constance shelves her worry to chase after her quickly.

    -> after_choice_2 

+ [Yell at Alice for running]
    ~ C_Alice -= 1
    #speaker: Constance
    ALICE I SWEAR TO GOD IF YOU LEAD US DOWN ANOTHER RABBIT HOLE I WILL NOT BE RESPONSIBLE FOR THE THINGS I SAY.
    
    #speaker: Alice
   Oh my god Con you worry way too much, it’s fine!

   Come on it's time for adventure!
    
    #speaker: Narrator
    Alice disappears from view.

    #speaker: Constance
    …Why can’t I have one day, just one normal day to myself?
    
    #speaker: Narrator
    Frustrated by her sister's carelessness Constance quickly gives chase to her wayward sibling.

    ->after_choice_2

===after_choice_2===
#speaker: Narrator
The game of cat and mouse has begun. A strange smile that had appeared in the distance materializes once more, a sharp looking feline now attached to that sporting grin.

#ending: MeetCatPuzzle
#noskip_end
-> DONE

