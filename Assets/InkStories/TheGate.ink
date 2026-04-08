=== TheGate === 
#speaker: Narrator
The girls watch as the White Rabbit quickly disappears out of view. The forest gives way to a towering castle.

#speaker: Alice
Oh my god, it's huge!

#speaker: Constance
We need to hurry, we're going to lose the Rabbit.

#speaker: Narrator
They reach the Gate and two guards stand strong, checking people's IDs. 

#speaker: White Rabbit
White Rabbit reporting for duty!

#speaker: Card
Ahh, hello sir, the Queen is waiting for you.

#speaker: Alice
Hang on we're coming!

#speaker: Card
Hold on, not you. You need to present an ID to get in.

#speaker: Narrator
The girls are confused at first but quickly realize they need to do something before they get locked out.

{hatterWon:

+ [Present the Queen’s invitation]
    #speaker: Alice
    We have an invitation.
    
    #speaker: Narrator
    The guards are suspicious of both girls. They take the invite and look closely.

    #speaker: Card
    ...Very well. You may enter.
    
    #speaker: Narrator
    The girls excitedly rush in. The White Rabbit is long gone so they rush to catch up.
    
    #ending: QueenCastle
    -> DONE
}

{puzzleWon: 
+ [Ask the White Rabbit for help]
    #speaker: Alice
    Wait Mr.Rabbit, can you help us?
    
    #speaker: White Rabbit
    ... alright fine. Just this once.
    
    #speaker: Card
    They're with you sir?
    
    #speaker: White Rabbit
    Yes, both girls are with me. Let them in once you check them.
    
    #speaker: Narrator 
    With that the White Rabbit disappears through the large gate.
    
    #speaker: Card
    Alright girls you got any weapons or harmful objects on you?
    
    #speaker: Constance
    No?
    
    #speaker: Card
    Alright you're good to go.
    
    #speaker: Alice
    That's it!?
    
    #speaker: Constance
    What she means is, thank you! And have a nice day.
    
    #speaker: Narrator
    Constance grabs her sister and bolts through the door, the White Rabbit is nowhere to be seen.
    
    #ending: QueenCastle
    -> DONE
}

 //{not hatterWon and not puzzleWon} 

+ [Present Nothing]
    #speaker: Narrator
    The guard stares at you expectantly. You have nothing to offer.
    
    #speaker: Narrator
    The Rabbit has gone through the door and there is no invite.
    
    #speaker: Alice
    Sooo, what do we do now?
    
    #speaker: Constance
    If you could just give us a moment of your time maybe we could-
    
    #speaker: Card
    There are no exceptions to the rule. If you don't have ID you cannot enter.
    
    #speaker: Narrator
    Ever stands silently staring at each other. Eventually Constance breaks and grabs her sister.
    
    #speaker: Constance
    Come on, let's just go?
    
    #speaker: Alice
    Go where?
    
    #speaker: Constance
    We'll find another way in. Let's go. There's nothing here for us.
     #ending: Bad End Three
    -> DONE
#ending: Bad End Three

-> DONE

