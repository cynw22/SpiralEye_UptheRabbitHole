=== chapter_tutorial === 
#noskip_start
//Have Constance character slowly open her eyes, write the tags here when you figure out how to do that lol

#speaker: Constance
#mood: Constance : ClosedEyes
Ugh… Where am I…?
Alice? Alice, are you here?

#speaker: Narrator
The silence answers Constance...

#speaker: Constance
#mood: Constance : OpenEyes
How far did I fall? And where’s Alice? I hope she isn’t hurt…? Alice? Alice!! Alice, answer me, where are you!?

#speaker: Narrator
Silence.

#speaker: Alice
I’m here! I’m here, Con!

//Add reaction or popup here if it works

#speaker: Constance 
Oh, thank goodness, I thought I’d lost you. Come here so I can see you, please?

#speaker: Tutorial
Press the space bar to switch perspectives…

#speaker: Alice
Haha, you’re such a worrywart, Con.

#speaker: Constance
I’ll be the judge of that, thank you.

#speaker: Alice
Oh my god, you don’t need to check me over for injuries, I’m fine! Who are you, Mom?

#speaker: Constance
I’ll be just as grey as her within a year if you keep running off like you just did, that’s for sure.

#speaker: Constance
//Add a mood tag here
Speaking of running off…
 
#speaker: Alice
Wuh oh.

#speaker: Constance
Care to tell me where we are? And why?

#speaker: Alice
I saw a rabbit! Con, it had a vest on! And– and a pocketwatch! And so I followed it, of course. Now we’re at the bottom of a rabbit hole, I think. Isn’t it amazing?

#speaker: Constance
A rabbit. A rabbit. You jumped down a rabbit hole, chasing a vest-wearing rabbit.

#speaker: Alice
…Yes?

#speaker: Alice
Constance? Helloooo, Constance?
…Did I break her?

#speaker: Constance
…Okay. Sure. Alright. That makes no sense. I tripped on the rabbit hole chasing you across a field, cracked my skull open on a rock, and now I’m dead. Right?

#speaker: Alice
No, silly! We’re just in a huge, otherworldly lobby at the bottom of an unfathomably deep rabbit hole. Look, they even have refreshments, how nice!

#speaker: Alice 
Ooh, mystery tea, my favourite! It’s even asking me to drink it!

#speaker: Narrator
Already enamoured with the world of Wonderland, Alice reaches enthusiastically for the bottle.

#speaker: Constance
Ohh, no you don’t. Alice, if you drink “mystery tea” again, I am disowning you. Put it down.

#speaker: Alice
Okay but the last mystery tea incident was just riverwater, I was only sick for like a day. This is real mystery tea! The genuine article!

#speaker: Constance
//Have Constance squint again? 
I said put it down. You don’t know what’s in that, it could be poison for all you know.

#speaker: Alice
In Wonderland? Unlikely.

#speaker: Constance 
Wonder– what? Hey, wait, stop–!

#speaker: Narrator
Alice gulps down the ‘Drink Me’ labelled bottle, looking entirely too self-satisfied.

//Show Alice drinking the bottle by having it disapper and sound or something

+ [Scold Alice]
    ~ C_Alice -= 1
    # speaker: Constance
    Alice, no! Are you stupid!? Spit it out, now!
    
    # speaker: Alice
    Am I st–? Constance, you are such a jerk, I’m fine! Ugh, let go of me!
    
    # speaker: Constance
    Hang on, I didn’t–!
    …I didn’t mean it like that, I was just–

    # speaker: Constance
    …Whatever. She’s fine.
    
    #speaker: Narrator
    A tension weighs in the air… The sisters’ relationship is damaged.

    ->after_choice 

+ [Check on Alice]
    ~ C_Alice += 1
    # speaker: Constance
    Alice– Alice, look at me. Do you feel well? Do you feel sick? Are you okay?
    
    # speaker: Alice
    Am I okay–? I’m– I’m good, Constance, don’t worry. See? Totally fine!
    I don’t feel sick at all! I promise, okay?
    
    # speaker: Alice
    I won’t do it again, alright? Don’t look so scared.
    
    # speaker: Constance
    …Alright.
    
    #speaker: Narrator
    A sense of relief fills the air. The sisters’ relationship improves.
    ->after_choice

===after_choice===
#speaker: Alice
Alright, enough of that! Let’s go explore!

#speaker: Constance
Don’t think I don’t know what you’re doing.
#noskip_end

#ending: Tutorial
-> DONE

