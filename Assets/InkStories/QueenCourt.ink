=== QueenCourt === 
#speaker: Narrator
The girls are dragged up to the stand and deposited in the box. The room fills quickly as the cards leave them.

#speaker: Alice
Oh man look at all the people...

#speaker: Constance
Just stay calm, don't panic,  we're going to be fine. 

#speaker: Narrator
The girls lapse into silence as they watch faces new and familiar fill the stand. The Rabbit walks quickly without looking at either of them.

#speaker: White Rabbit
Quiet, please! Court will be in session now. All rise for her honorable judge and ruler The Red Queen.

#speaker: Narrator
The room falls into an uneasy hush as the Queen takes her place on the stand, she's exudes enough power to command the room.

#speaker: Queen
Continue...

#speaker: White Rabbit
Y-yes of course. We gather here today to witness the trial of Alice and Constance two girls who came to challenge the Queen's authority and undermine her influence.

#speaker: Narrator
Gasps are heard among the crowd, the place was going to get rowdy!

#speaker: White Rabbit
Their- crimes include: Disrespecting our beloved ruler, questioining her authority, undermining her decisions and destorying her party with their foul attuides.

#speaker: Alice
Those aren't even real charges!

#speaker: Constance
Alice? Now is not the time.

#speaker: Alice
Con did you hear what he's saying, it's utter nonsense-

#speaker: Queen
QUIET! YOU WILL GET YOUR TURN TO SPEAK.

#speaker: Narrator
The buzzing in the room fades, everyone sits silent their stares pinning both girls down.

#speaker: White Rabbit
As I was saying... we now gather here today to here their story, and decide what punishment is apporiate for crimes of this magnintude.

#speaker: Alice
You here that, they've already decided we're guilty before we've started.

#speaker: Constance
Quiet, don't let them hear you.

#speaker: Alice
What are we supposed to do, the whole thing is rigged.

#speaker: Constance
Fight, like we always do, you logic and reasoning. When the truth is on your side you will always prevail.

#speaker: Narrator
For the first time Alice feels a wave of relief wash over her. They were both here, fighting that's all that mattered.

#speaker: Alice
Alright let's do this!

#speaker: Queen
Let us start. We will go down the list of your crimes, who they pertain to and you will be given a chance to defend yourself. Use it wisely...

#speaker: White Rabbit
Charge One: Guilty of Blantent disrespect against our monarch.

#speaker: Queen
Correct, I opened my arms to these girls, let them in, took the time to show them around and this is the thanks I get.

#speaker: White Rabbit
Alice your actions at the party were cruel and unjust. You cornered our Queen, forced question upon question on her and misrepresented her attitude. How do you plead?

#speaker: Alice
Not guilty! I didn't force her to do anything!

#speaker: Queen
Did you not ask me questions related to the way I rule my people? I'm certain several partygoers heard you.

+ [Answer Yes]
    ~ C_RedQueen -= 1
    ~ C_Alice += 1
    
    #speaker: Alice
    Yes I did.
    
    #speaker: Narrator
    The crowd gasps, startled by Alice's bluntness.
    
    #speaker: Alice
    However you act like my questions were malicious. I was curious about this world and it's people, so I asked the one person who should know about them.
    
    #speaker: Alice
    If the answers you gave made you feel bad that's not a refelction on me but yourself.
    
    #speaker: Queen
    How dare you.
    
    #speaker: Alice
    You can't expect people to respect you when all you do is flaunt yourself to the world.
    
    #speaker: Alice
    You need to learn to let others in. It can't always revolve around you.
    
    #speaker: Queen
    I am the Queen, the world does revolve around me.
    
    #speaker: Alice
    Then you'll stay stuck where you are. Someone who's unable to admit their own faults will never learn to move ahead.
    
    #speaker: Alice
    I learned that lesson the hard way from someone very dear to me-
    
    #speaker: Queen
    Spare me the sob story, I have no use listening to those things. Next sentence.
    
    #speaker: Narrator
    Tensions are rising, Alice feels condifient boosting Constance's moral.
    
    -> DONE
    
+ [Answer No]
    ~ C_RedQueen -= 1
    ~ C_Alice -= 1

    #speaker: Alice
    No it wasn't like that.
    
    #speaker: Queen
    No? You're going to act like you didn't accuse me of hurting my own people?
    
    #speaker: Alice
    I didn't say it like that, stop twisting my words.
    
    #speaker: Queen
    But you admit that you did say something!
    
    #speaker: Alice
    Yes, but-
    
    #speaker: Queen
    Do you hear that! She admits, she has set me up from the start.
    
    #speaker: Narrator
    The crowd's roar of anger drowns Alice's response. She watches helplessly as they move to the next item.
    
    -> DONE

#speaker: White Rabbit
We move to the second crime. The crime of disrespecting the Queen's decision. In this case Constance set the Queen up, ambushing her with a banned article and opening her up to public scrutiny.

#speaker: Queen
Yes, how dare you bring that filth into my home and let others see it. I had that spoof piece outlawed the moment it came out and yet a mere child defy's my orders? 

#speaker: Queen
That is out of the question. How do you plead to this crime.

#speaker: Constance
I have already given you my reason, I suppose I can tell you once again.

+ [Be Apologetic to the Queen]
    ~ C_RedQueen += 1
    ~ C_Alice += 1
    #speaker: Alice
    Yes I did.
    
    #speaker: Narrator
    The crowd gasps, startled by Alice's bluntness.
    
    #speaker: Alice
    However you act like my questions were malicious. I was curious about this world and it's people, so I asked the one person who should know about them.
    
    #speaker: Alice
    If the answers you gave made you feel bad that's not a refelction on me but yourself.
    
    #speaker: Queen
    How dare you.
    
    #speaker: Alice
    You can't expect people to respect you when all you do is flaunt yourself to the world.
    
    #speaker: Alice
    You need to learn to let others in. It can't always revolve around you.
    
    #speaker: Queen
    I am the Queen, the world does revolve around me.
    
    #speaker: Alice
    Then you'll stay stuck where you are. Someone who's unable to admit their own faults will never learn to move ahead.
    
    #speaker: Alice
    I learned that lesson the hard way from someone very dear to me-
    
    #speaker: Queen
    Spare me the sob story, I have no use listening to those things. Next sentence.
    
    #speaker: Narrator
    Tensions are rising, Alice feels condifient boosting Constance's moral.
    
    -> DONE
    
+ [Attack the Queen]
    ~ C_RedQueen -= 1
    ~ C_Alice -= 1

    #speaker: Alice
    No it wasn't like that.
    
    #speaker: Queen
    No? You're going to act like you didn't accuse me of hurting my own people?
    
    #speaker: Alice
    I didn't say it like that, stop twisting my words.
    
    #speaker: Queen
    But you admit that you did say something!
    
    #speaker: Alice
    Yes, but-
    
    #speaker: Queen
    Do you hear that! She admits, she has set me up from the start.
    
    #speaker: Narrator
    The crowd's roar of anger drowns Alice's response. She watches helplessly as they move to the next item.
    
    -> DONE


    
    

  
    
    
    

#ending:GoodEnding
-> DONE

