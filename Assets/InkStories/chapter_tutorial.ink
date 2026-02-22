=== tutorial_chapter === 
#noskip_start
//Have Constance character slowly open her eyes, write the tags here when you figure out how to do that lol

#speaker: Constance
#mood: Constance : ClosedEyes
Owww. My head… That fall was crazy. Why did you have to go chasing after something?

#speaker: Constance
Alice? Did you hear me?

#speaker: Narrator
...............

#speaker: Constance
#mood: Constance : OpenEyes
Alice? What's going on, where are you?

#speaker: Narrator
................

#speaker: Constance
Oh god, Alice. ALICE??? Where are you? 

#speaker: Constance
PLEASE ANSWER ME WHERE ARE YOU?

#speaker: Alice
I’M HEREEEEEE.

#speaker: Constance 
Where? I don’t see you. 

#speaker: Alice
I’M COMINNGGGG. HANG ONNNN.

#speaker: Constance
Alice this isn’t funny, you’re scaring me.

//Player is asked to switch perspective
// Make Alice character pop up out of seemingly nowhere.

#speaker: Constance
ALICE. My god, please stop doing that.

#speaker: Alice
But whyyyy. It’s funny.

#speaker: Constance
To who?  

#speaker: Alice
To me.

#speaker: Constance
#mood: Constance : ClosedEyes
Nevermind that, tell me where we are.
 
#speaker: Alice
I don’t know. I followed the rabbit and now we’re here.

#speaker: Constance
The rabbit. You followed a rabbit?

#speaker: Alice
Yeah!!

#speaker: Constance
Why?

#speaker: Alice
Because.

#speaker: Narrator
...........

#speaker: Alice
OHHHHH LOOK!!!

#speaker: Alice
Sissss, look, don’t you think that’s a funny looking bottle.

#speaker: Constance
Bottle?

#speaker: Alice
Yeahhh, it looks silly. Look even the writing looks weird. It looks like Aunty Vicky’s Christmas cards.

#mood: Constance : ClosedEyes
#speaker: Constance
First, that’s a very rude thing to say. Second, there is no bottle, its just a glass table. 

#speaker: Alice 
What? No there isn’t.

#speaker: Constance
Alice I have eyes, there's nothing on the table.

#spekaer: Alice
Uhhhh no that's not true. Are you sure you didn’t hit your head on the way down?

#speaker: Constance
//Have Constance squint again? 
I feel perfectly fine. At least as fine as someone can be after falling down 100ft or so.

#speaker: Alice
Okayyy, well I just see the pretty bottle.
//Maybe have Alice do an eye roll?

#speaker: Constance 
Alright fine have it your way. I know better than to argue a silly point with you. It never ends well.

#speaker: Alice
MEANIE!!!

#speaker: Narrator
The girls fall into silence...

#speaker: Alice
I’m gonna drink it.

#speaker: Constance
…What?

#speaker: Alice
The bottle. I’m gonna drink it.

#speaker: Constance
And why would you do that?

#speaker: Alice
It looks yummy.

#speaker: Constance
Alice, that is the dumbest thing I’ve heard all day. Why would you ever drink something out of an unmarked bottle???

#speaker: Alice
Because it looks yummy?

#speaker: Constance
ALICE! For god’s sake what is wrong with you, it could be poison for all you know, or anything else for that matter, you have no way of knowing-

//Show Alice drinking the bottle by having it disapper and sound or something

+ [Get upset with Alice for drinking the bottle]
    ~ C_Alice -= 1
    # speaker: Constance
    ALICE! What is wrong with you? Why would you do that???
    
    ->after_choice 

+ [Gently scold Alice for drinking the bottle]
    ~ C_Alice += 1
    # speaker: Constance
   Alice, oh my god why in the world would you drink that? What if it hurt you!
    
    ->after_choice

===after_choice===
#speaker: Alice
Because I wanted to.

#speaker: Constance
And you didn’t stop to think that could have been very dangerous.

#speaker: Alice
Nope.

//Change sprite to Alice smiling
#speaker: Alice
Sooo, where are we going now?

#speaker: Constance
Alice, are you sure you’re okay?

#speaker: Alice
Sis stop worrying I’m fine. 

#speaker: Alice
Come on, let's go and check this place out. Maybe there’s a way to get out of here.

#speaker: Constance
Don’t think I don’t know what you are doing right now.

#speaker: Alice
Come onnnn, you were the one who said we needed to get out of here.

#speaker: Alice
Woahhhhh this place is huge. Everything looks like a mountain. 

#speaker: Alice
Even that chest over there looks massive! I wonder if it’s got treasure!

#speaker: Constance
Huh? What chest?

#speaker: Alice
OHHH SIS LOOK IT’S A DOOR! 

#speaker: Constance
Alice please one thing at a time.

//Prompt player to click on the door

#speaker: Constance
It’s locked.

#speaker: Alice
Bummer. I think we need to find a key.

#speaker: Constance
Alright, let’s look around the room and see if there’s something we can use to get out. 

(Relationship value: {C_Alice}) //REMOVE AFTER TESTING

#noskip_end

-> DONE