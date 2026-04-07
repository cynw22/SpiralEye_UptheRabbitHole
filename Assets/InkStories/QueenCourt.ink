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
    
    -> Good_End_Time
    
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
    
    -> Bad_End_Time

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
    #speaker: Constance
    First I'll acknowledge the fact that it was inapporpaite of me to bring this up during the party. I should have broght you aside first.
    
    #speaker: Queen
    Yes, you had no right to ambush me out of nowhere.
    
    #speaker: Constance
    However my reasons for concern were valid. You knew I wasn't from around here, stating that I'm in the wrong for bringing items I didn't even know were banned is foolish.
    
    #speaker: Queen
    Excuse me?
    
    #speaker: Constance
    The papers, the treatment of your staff, the subtle tension everywhere you go. I wanted so badly to turn a blind eye to it, that this was all a misunderstanding.
    
    #speaker: Queen
    It is a misunderstanding. You came at me, you intended to-
    
    #speaker: Constance
    To learn, I wanted to hear your side of the story. I believed that you weren't capable of this level of calousness because you had people who needed you.
    
    #speaker: Constance
    In the end I'm the fool, for looking past the truth right in front of me. 
    
    #speaker: Queen
    There you go again, making horrible insinutaions.
    
    #speaker: Constance
    Is it really an insinuation if the proof exists right there? You act like none of this concenrs you but your garden tells the truth.
    
    #speaker: Queen
    ...that, has nothing to do with this.
    
    #speaker: Constance
    It has everything to do with this. The quicker you realize that makes it easier for you to atone.
    
    #speaker: Queen
    You're wrong. I have nothing to atone for. I am the Queen.
    
    #speaker: Narrator
    Constance only shakes her head, her stare never leaving the Queen, it makes her uneasy. Has the dynamic shifted?
    
    -> Good_End_Time
    
+ [Attack the Queen]
    ~ C_RedQueen -= 1
    ~ C_Alice -= 1

    #speaker: Constance
    You sit there on your high horse acting like you did nothing wrong. But you, you're just selfish.
    
    #speaker: Queen
    Ohhh, finally you're showing your true colors. 
    
    #speaker: Constance
    I could say the same for you. You act like you've done nothing wrong but there's blood on your hands.
    
    #speaker: Queen
    You're delusional, all of this from what, a silly little newspaper?
    
    #speaker: Constance
    It's not just the newspaper, its everything, the mistreatment of your staff, the wreckage you caused to the villages, the cards who've lost their lives to your tirade.
    
    #speaker: Queen
    HOW DARE YOU! YOU SPEAK NOTHING BUT LIES.
    
    #speaker: Constance
    I speak the truth, you're just too scared to admit it.
    
    #speaker: Queen
    We're done here. I don't need to hear anything else. GUARDS
    
    #speaker: Alice
    Hey! That's not fair, we aren't done here.
    
    #speaker: Queen
    But I am. It's over, you're both finished.
    
    -> Bad_End_Time

=== Good_End_Time ===
#speaker: Narrator
The Queen sits shell shocked, unable to say anything. She can't understand why this hurts?

#speaker: Queen
You, I- what?

#speaker: Narrator
The Queen is shaken up, this has never happened before.

#speaker: Queen
I was wrong?

#speaker: Narrator
Well come now Queenie, you need to deliever the verdict, everyone's waiting.

#speaker: Queen
I. Fine. I acknowledge that some of what you said has merit, and for that reason-

#speaker: Queen
In the case of Alice and Constance I decree you're NOT Guilty.

#ending: Good_Ending
-> DONE

=== Bad_End_Time ===
#speaker: Narrator
The Queen towers angrily over you. It's over. They've messed it all up.

#speaker: Queen
DO YOU SEE MY LOYAL SUBJECTS. THIS IS WHAT YOU GET WHEN YOU SHOW LENIANCE.

#speaker: Narrator
The Queen bellows loudly, shaking the room.

#speaker: Queen
I've had enough of this farce, there isn't an ounce of good between either of you.

#speaker: Narrator
The Queen appears as cold as ever as she delivers the final blow.

#speaker: Queen
In this case I pronounce the both of you GUILTY.

#speaker: Narrator
The girls stand shell shocked as guards flank them, dragging them away.

#speaker: Cheshire Cat
Well, well well we meet again.

#speaker: Alice
Cat?

#speaker: Cheshire Cat
Well you've certainly gotten yourself into a pickle.

#speaker: Constance
What do we do?

#speaker: Cheshire Cat
Simple you pick, me or her?

#speaker: Alice
What?

#speaker: Cheshire Cat
Come on short stack you don't have the time to think. The guards are coming.

#speaker: Cheshire Cat
So who's it gonna be, me or the angry looking Queen over there.

+ [Choose Cat]
#ending: Bad End Cat
-> DONE

+ [Choose Queen]
#ending: Bad End Queen
-> DONE

