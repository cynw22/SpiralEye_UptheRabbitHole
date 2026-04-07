=== chapter_tutorial_V2 === 
//Show Alice drinking the bottle by having it disapper and sound or something

+ [Scold Alice]
    ~ C_Alice -= 1
    #speaker: Constance
    Alice, no! Are you stupid!? Spit it out, now!
    
    #speaker: Alice
    Am I st–? Constance, you are such a jerk, I’m fine! Ugh, let go of me!
    
    #speaker: Constance
    Hang on, I didn’t–!
    …I didn’t mean it like that, I was just–

    # speaker: Constance
    …Whatever. She’s fine.
    
    #speaker: Narrator
    A tension weighs in the air… The sisters’ relationship is damaged.

    ->after_choice 

+ [Check on Alice]
    ~ C_Alice += 1
    #speaker: Constance
    Alice– Alice, look at me. Do you feel well? Do you feel sick? Are you okay?
    
    #speaker: Alice
    Am I okay–? I’m– I’m good, Constance, don’t worry. See? Totally fine!
    I don’t feel sick at all! I promise, okay?
    
    #speaker: Alice
    I won’t do it again, alright? Don’t look so scared.
    
    #speaker: Constance
    …Alright.
    
    #speaker: Narrator
    A sense of relief fills the air. The sisters’ relationship improves.
    ->after_choice

===after_choice===
#speaker: Alice
Alright, enough of that! Let’s go explore!

#speaker: Constance
Don’t think I don’t know what you’re doing.

#ending: Tutorial
-> DONE
