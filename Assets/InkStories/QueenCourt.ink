=== QueenCourt === 
#speaker: Narrator
The girls are dragged up to the stand and deposited in the box. The room fills quickly as the cards leave them.

#speaker: Alice
Oh man, look at all the people...

#speaker: Constance
Just stay calm, don't panic,  we're going to be fine. 

#speaker: Narrator
The girls lapse into silence as they watch faces new and familiar fill the stand. The Rabbit walks quickly without looking at either of them.

#speaker: White Rabbit
Quiet, please! Court will be in session now. All rise for her honorable judge and ruler The Red Queen.

#speaker: Narrator
The room falls into an uneasy hush as the Queen takes her place on the stand, she exudes enough power to command the room.

#speaker: Queen
Continue...

#speaker: White Rabbit
Y-yes of course. We gather here today to witness the trial of Alice and Constance, two girls who came to challenge the Queen's authority and undermine her influence.

#speaker: Narrator
Gasps were heard among the crowd, the place was going to get rowdy!

#speaker: White Rabbit
Their- crimes include: disrespecting our beloved ruler, questioning her authority, undermining her decisions and destroying her party with their foul attitudes.

#speaker: Alice
Those aren't even real charges!

#speaker: Constance
Alice? Now is not the time.

#speaker: Alice
Con did you hear what he's saying, it's utter nonsense-

#speaker: Queen
QUIET! YOU WILL GET YOUR TURN TO SPEAK.

#speaker: Narrator
The buzzing in the room fades, everyone sits silent, their stares pinning both girls down.

#speaker: White Rabbit
As I was saying... We now gather here today to hear their story, and decide what punishment is appropriate for crimes of this magnitude.

#speaker: Alice
You hear that, they've already decided we're guilty before we've started.

#speaker: Constance
Quiet, don't let them hear you.

#speaker: Alice
What are we supposed to do, the whole thing is rigged.

#speaker: Constance
Fight, like we always do, your logic and reasoning. When the truth is on your side you will always prevail.

#speaker: Narrator
For the first time Alice feels a wave of relief wash over her. They were both here, fighting, that's all that mattered.

#speaker: Alice
Alright let's do this!

#speaker: Queen
Let us start. We will go down the list of your crimes, who they pertain to and you will be given a chance to defend yourself. Use it wisely...

#speaker: White Rabbit
Charge One: Guilty of blatant disrespect against our monarch.

#speaker: Queen
Correct, I opened my arms to these girls, let them in, took the time to show them around and this is the thanks I get.

#speaker: White Rabbit
Alice, your actions at the party were cruel and unjust. You cornered our Queen, forced question upon question on her and misrepresented her attitude. How do you plead?

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
    However you act like my questions were malicious. I was curious about this world and its people, so I asked the one person who should know about them.
    
    #speaker: Alice
    If the answers you gave made you feel bad that's not a reflection on me but yourself.
    
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
    Tensions are rising, Alice feels confident boosting Constance's morale.
    
    -> Queen_Choice_2
    
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
    Do you hear that! She admits she has set me up from the start.
    
    #speaker: Narrator
    The crowd's roar of anger drowns Alice's response. She watches helplessly as they move to the next item.
    
     -> Queen_Choice_2
     
=== Queen_Choice_2===
#speaker: White Rabbit
We move to the second crime. The crime of disrespecting the Queen's decision. In this case Constance set the Queen up, ambushing her with a banned article and opening her up to public scrutiny.

#speaker: Queen
Yes, how dare you bring that filth into my home and let others see it. I had that spoof piece outlawed the moment it came out and yet a mere child defies my orders? 

#speaker: Queen
That is out of the question. How do you plead to this crime?

#speaker: Constance
I have already given you my reason, I suppose I can tell you once again.

+ [Be Apologetic to the Queen]
    ~ C_RedQueen += 1
    ~ C_Alice += 1
    #speaker: Constance
    First I'll acknowledge the fact that it was inappropriate of me to bring this up during the party. I should have brought you aside first.
    
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
    Learn. I wanted to hear your side of the story. I believed that you weren't capable of this level of callousness because you had people who needed you.
    
    #speaker: Constance
    In the end I'm the fool, for looking past the truth right in front of me. 
    
    #speaker: Queen
    There you go again, making horrible insinuations.
    
    #speaker: Constance
    Is it really an insinuation if the proof exists right there? You act like none of this concerns you but your garden tells the truth.
    
    #speaker: Queen
    ...that has nothing to do with this.
    
    #speaker: Constance
    It has everything to do with this. The quicker you realize that makes it easier for you to atone.
    
    #speaker: Queen
    You're wrong. I have nothing to atone for. I am the Queen.
    
    #speaker: Narrator
    Constance only shakes her head, her stare never leaving the Queen, it makes her uneasy. Has the dynamic shifted?
    
    -> Queen_Choice_3
    
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
    It's not just the newspaper, it's everything, the mistreatment of your staff, the wreckage you caused to the villages, the cards who've lost their lives to your tirade.
    
    #speaker: Queen
    HOW DARE YOU! YOU SPEAK NOTHING BUT LIES.
    
    #speaker: Constance
    I speak the truth, you're just too scared to admit it.
    
    #speaker: Queen
    STOP NO MORE!
    
    #speaker: Constance
    What afraid? You should be the truth will haunt you harder than the lies you spread.
    
    #speaker: Queen
    You're wrong, I'm nothing like that, I am the Queen, all powerful, the best!
    
    #speaker: Constance
    For someone who claims to be the best you sure are a selfish cow.
    
    #speaker: White Rabbit
    That's enough. We do not tolerate name calling in these sacred halls. 
    
    #speaker: Narrator
    Constance surprisingly calms down. She settles, giving the White Rabbit a glare.
    
    #speaker: Narrator
    That pathetic little thing just shakes it off as he continues reading.
    
    -> Queen_Choice_3
    
=== Queen_Choice_3 ===
#speaker: White Rabbit
Crime number three. The crime of ruining this joyous celebration. Constance how will you answer to the people, for the crime of breaking in, antagonizing the Queen and destroying the party.

#speaker: Alice
You're getting tried for this?

#speaker: Constance
Alice please...

#speaker: Queen
SILENCE. Only the accused can speak in defence of their crimes.

+ [Refute the claims]
    ~ C_RedQueen -= 1
    ~ C_Alice += 1
    #speaker: Constance
    I cannot accept this verdict. I'm being accused of ruining a party for talking?
    
    #speaker: Queen
    No, your crime involves taking me forcefully from my subjects and torturing me!
    
    #speaker: Constance
    Except for the fact that you took me with you. There's no point in lying if everyone saw it.
    
    #speaker: Queen
    I don't lie.
    
    #speaker: Constance
    You can deny it all you want, the truth will get out one way or another. The point is you took me.
    
    #speaker: Queen
    Even so it doesn't mean you can just accuse me of-
    
    #speaker: Constance
    I didn't accuse you of anything. I showed you the newspaper. I asked for your side of the story.
    
    #speaker: Constance
    You got shifty with me and wouldn't give a straight answer. If that hurts your feelings it's on you. 
    
    #speaker: Queen
    I- well I didn't want to hear those horrible things again.
    
    #speaker: Constance
    And for that I am sorry. If I had known the paper had bothered you so much I would have left it behind.
    
    #speaker: Queen
    ... really?
    
    #speaker: Constance
    Yes, I'm not cruel enough to weaponize something someone dislikes to hurt them.
    
    #speaker: Queen
    You speak as if it's wrong to do that. Gaining the upper hand by any means necessary is important in combat.
    
    #speaker: Constance
    Not if you can't look yourself in the mirror the next day. No victory is worth sacrificing your peace of mind and health.
    
    #speaker: Constance
    A victory won on the backs of breaking those around you rings hollow. Who will celebrate with you if you stab everyone around you?
    
    #speaker: Narrator
    How strange. The Queen appears troubled by this statement, yet she says nothing only urges the White Rabbit to move on.
    
    -> Queen_Choice_4
    
+ [Acknowledge the claims]
    ~ C_RedQueen -= 1
    ~ C_Alice -= 1

    #speaker: Constance
    So that's how you're spinning it. Poor Miss Queen, bullied by Constance and her silly little newspaper.
    
    #speaker: Queen
    You're mocking me. I won't stand for that. 
    
    #speaker: Constance
    You can barely stand for anything. Everything pushes those buttons of yours.
    
    #speaker: Queen
    Careful now, you're getting ahead of yourself. It is I who pulls the strings around here.
    
    #speaker: Constance
    Oh really? I guess that's in line with what I've learned so far.
    
    #speaker: Queen
    And what might that be.
    
    #speaker: Constance
    That you're spoiled, selfish, have little regard for those around you and live off the high of the little power you hold over these people.
    
    #speaker: Queen
    LITTLE-
    
    #speaker: Constance
    See. Even now you only focus on the details that hurt you. A good leader would prioritize the well being of their people over hurt feelings.
    
    #speaker: Queen
    A kingdom cannot prosphere without a head to lead it.
    
    #speaker: Constance
    You're wrong. A kingdom cannot be built by one person. Anyone can claim a crown, the people build a community and form a place worth protecting.
    
    #speaker: Constance
    But you can't see that. You never will. Doing that would require any amount of empathy, something you sorely lack.
    
    #speaker: Narrator
    The Queen glares at Constance and grinds her teeth together. She orders the White Rabbit to continue forward.
    
    #speaker: Narrator
    It's quite surprising actually. Who knew little old Constance had it in her. Maybe she just needed a little push in the right direction.
    
    -> Queen_Choice_4
    
+ {A_MadMarch >= 0} [Have the Mad Hatter vouch for you]
    ~ C_Alice += 1
    #speaker: Constance
    You think we broke in here just to ruin your silly little party! We have more important things to do.
    
    #speaker: Queen
    Oh and here we go again, insulting my party. 
    
    #speaker: Constance
    I'm not insulting your party, I just don't like being judged for things I didn't do.
    
    #speaker: Queen
    Then answer this, is it or is it not true that you broke into the castle with the intent of meeting me.
    
    #speaker: Constance
    We had every intention of meeting you but we didn't break in. The guards let us through.
    
    #speaker: Queen
    Without an ID?
    
    #speaker: Constance
    With an invite, one that we won fair and square. Isn't that right Mr. Mad Hatter.
    
    #speaker: Narrator
    All eyes turn to the Mad Hatter who tenses and quickly begins whispering to the air around him.
    
    #speaker: Queen
    Mad Hatter.
    
    #speaker: Mad Hatter
    Yes your royal highness.
    
    #speaker: Queen
    Is it true that the girls got a ticket? Was it yours?
    
    #speaker: Mad Hatter
    Yes, it's true. I challenged the girls to a duel and they beat me fair and square.
    
    #speaker: Queen
    And the tickets?
    
    #speaker: Mad Hatter
    Our wager, we decided that we would bet on who would go today.
    
    #speaker: Queen
    I see... and what did you think of these two girls? Did they behave as barbarically as they did here?
    
    #speaker: Mad Hatter
    No. In fact they found something I've been looking for, something precious to me.
    
    #speaker: Queen
    Precious? How so?
    
    #speaker: Mad Hatter
    I owe these girls a debt of gratitude, after all I was able to reunite with an old friend thanks to them.
    
    #speaker: Narrator
    The Mad Hatter smiles down at the March Hare sitting beside him, both seem happier than usual.
    
    #speaker: Queen
    ... I see. Very well you are dismissed.
    
    #speaker: Narrator
    As everyone returns to their places the Queen looks noticeably more put off. Something is changing.
    
    -> Queen_Choice_4

=== Queen_Choice_4 ===
#speaker: White Rabbit
The final crime. The crime of threatening the Queen's existence. Alice you showed little regard for the Queen's wellbeing with your onslaught of questions.

#speaker: Alice
Is that seriously what you think?

#speaker: White Rabbit
I- well, it's -

#speaker: Queen
Rabbit. Focus on reading the list, nothing more, nothing less.

#speaker: White Rabbit
Yes, of course your majesty.

#speaker: White Rabbit
The questions pertaining to a certain banned individual were particularly harming. Did you intend to go this far with your cruelty?

+ [Defend your line of Questioning]
    ~ C_RedQueen -= 1
    ~ C_Alice += 1
    #speaker: Alice
    I didn't attack the Queen, I didn't even know she had issue with the-
    
    #speaker: Queen
    NO! You are never to speak that thing's name. Do you understand?
    
    #speaker: Alice
    Uhhh. okay I guess.
    
    #speaker: Queen
    Good. 
    
    #speaker: Alice
    Well either way I didn't know that was gonna happen. If I did I would have been more careful.
    
    #speaker: Queen
    Are you saying that I'm an ill-tempered child?
    
    #speaker: Alice
    Wha?? Nooo, who said that, was it someone in the crowd. Boooo shame on you.
    
    #speaker: Constance
    Alice, focus, please. 
    
    #speaker: Alice
    Oh right! Yeah back to business.
    
    #speaker: Queen
    Did you or did you not intend to harm my standing with your line of questioning.
    
    #speaker: Alice
    I didn't mean to harm you or your standing.
    
    #speaker: Narrator
    Silence filled the room.
    
    #speaker: Queen
    What? How can you possibly say that after the way you acted?
    
    #speaker: Alice
    Listen, I may not have phrased it nicely and I might have been a little suspicious of your motives but I didn't do it out of malice.
    
    #speaker: Alice
    I just wanted to know what kind of ruler you were. Everyone's so shifty here, is it so wrong of me to try and seek answers at the source?
    
    #speaker: Queen
    I, well I suppose you make a good point.
    
    #speaker: Alice
    I always do! Now if I hurt your feelings by bringing him up then I'm sorry. It wasn't my intention to do that. I only wanted to talk to you.
    
    #speaker: Queen
    Why do you apologize? The strong don't do that.
    
    #speaker: Alice
    Yeah no it doesn't work like that. That's something a weak person would say. To be strong means acknowledgeing when you make mistakes and hurt people.
    
    #speaker: Alice
    And when you do realize that you have to take the first step to mend that bridge by apologizing for what you did.
    
    #speaker: Queen
    Bowing before someone feels deeming.
    
    #speaker: Alice
    No, it takes true strength and courage to put yourself out there and acknowledge you did wrong.
    
    #speaker: Alice
    Right?
    
    #speaker: Constance
    Right. I'm glad something stuck.
    
    #speaker: Alice
    Hey! I try my best to listen, it's not my fault lessons are boring.
    
    #speaker: Narrator
    The Queen watches as the two girls devolve into bickering. It hurts, something in her chest stings.
    
    #speaker: Queen
    What is this longing? Why do I want what they have, what reason could I need for wanting this.
    
    #speaker: Narrator
    Oh my! What a surprise, the stone cold Queen really does have a heart buried deep down there.
    
    #speaker: Narrator
    I guess a couple snot-nosed brats was all it took to bring that house of cards down. How tragic…

    -> Final_Check
    
+ [Bring up the Cat]
    ~ C_RedQueen -= 1
    ~ C_Alice -= 1

    #speaker: Alice
    That's what this is about. The Cat?
    
    #speaker: Queen
    I told you never speak that name in front of me ever!
    
    #speaker: Alice
    What are you, my mom? You don't get to police me on what I can and can't say.
    
    #speaker: Queen
    I am the Queen. What I say goes, and I command you to stop talking about that insufferable thing.
    
    #speaker: Alice
    Hmmmmm, no I don't want to. 
    
    #speaker: Queen
    What?
    
    #speaker: Alice
    What? Is the big bad Queen really that surprised by someone standing up for themselves. Wow it must not happen around here if you're that shocked.
    
    #speaker: Queen
    Such insolence.
    
    #speaker: Alice
    I don't even know what that means. Pleaes tell me it means we can go now, cause I'm getting bored.
    
    #speaker: Constance
    ALICE!
    
    #speaker: Alice
    What you're gonna act like isn't one of the most boring things we've ever done?
    
    #speaker: Constance
    I know it's boring but that doesn't mean you say it out loud.
    
    #speaker: Narrator
    The Queen glares at the girls, the noise is truly grating. She hates it and wishes for it to stop quickly.
    
    #speaker: Narrator
    Though she thinks she should thank the noise, after all it's just made her decision a lot easier.
    
    -> Final_Check
    
+ {A_WhiteRabbit >= 0} [Have the White Rabbit vouch for you]
    ~ C_Alice += 1
    #speaker: Alice
    So the entire basis of your claim is that I got all this secret information on the Red Queen and used it as a way to do what?
    
    #speaker: Queen
    Attack me, ruin my day, hurt me with your sharp words. 
    
    #speaker: Alice
    Yeahhh except none of that happened. I asked you questions and you answered them.
    
    #speaker: Queen
    That still doesn't answer how you knew about me and my people. Or the standings they hold in this castle.
    
    #speaker: Alice
    I asked the one person who knows more about this place than you do.
    
    #speaker: Narrator
    All eyes turn to the White Rabbit who somehow grows paler at the attention.
    
    #speaker: Queen
    Rabbit, you've chosen to betray me?
    
    #speaker: White Rabbit
    Heavens no! No, of course not. The child is merely referring to the questions she asked me when we met.
    
    #speaker: Queen
    She asked you questions?
    
    #speaker: White Rabbit
    Yes your highness, several. I believe the child is naturally curious at heart.
    
    #speaker: Queen
    Be that as it may, she's old enough to read a room and not know when to stop.
    
    #speaker: Narrator
    They all turn to look at Alice, who's currently preoccupied with something moving in the stands.
    
    #speaker: Queen
    ...perhaps I overestimated the intelligence of this creature. 
    
    #speaker: Mad Hatter
    Well that's just harsh my dear.
    
    #speaker: Queen
    No one asked you... AND STOP LISTENING TO MY CONVERSATIONS. It's creepy and weird.
    
    #speaker: Mad Hatter
    But it's so much fun to get a rise out of you.
    
    #speaker: Queen
    How do you feel about spending a night in the cellars? I hear it's pretty cold this time of year.
    
    #speaker: Mad Hatter
    And shutting up now...
    
    #speaker: Queen
    Good. I just want this meeting to be over.
    
    #speaker: Narrator
    With her piece said the Queen slumps in her chair and begins to think. What does she do now?
    
    -> Final_Check

=== Final_Check ===
#speaker: Narrator
Everything comes down to this... everyone waits in tense silence as the Queen deliberates with the jury on what to do.

{ C_Alice < 0:
    -> Bad_End_Time
}

{ C_Alice >= 0 and (A_MadMarch >= 0 or A_WhiteRabbit >= 0):
    -> Good_End_Time
}

{ C_Alice >= 0 and A_MadMarch <= 0 and A_WhiteRabbit <= 0:
    -> Bad_End_Time
}

=== Good_End_Time ===
#speaker: Narrator
Finally after what feels like forever the Queen returns but not as whole as before.

#speaker: Narrator
Her rich and vibrant parlor seems to have dulled and her face feels cracked, like emotion is leaking from it for the first time in awhile.

#speaker: Queen
I, after much thought and deliberation have come to a conclusion.

#speaker: Narrator
The Queen is shaken up, the feeling fills the air. This has never happened before.

#speaker: Queen
You girls are strange. You care very little for propriety or basic rules, yet you speak with such conviction and power.

#speaker: Queen
I don't know what I am supposed to do with the fire you have lit inside me.

#speaker: Constance
Let it out.

#speaker: Alice
Don't bottle it in, just let the words go.

#speaker: Queen
Am I wrong?

#speaker: Narrator
Come now Queenie, was that a question or a statement. You need to deliver the verdict, everyone's waiting.

#speaker: Queen
I. Fine. I acknowledge that some of what you said has merit, and for that reason-

#speaker: Queen
In the case of Alice and Constance the final verdict stands as: NOT Guilty.

#ending: GoodEnding

-> DONE

=== Bad_End_Time ===
#speaker: Narrator
The Queen towers angrily over both girls. It's over. They've messed it all up.

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
The Queen is angry, angrier than anyone has ever seen. She storms off after giving her command, clearly tired of the scene.

#speaker: Constance
What just happened?

#speaker: Narrator
The girls stand shell shocked as rush over ready to flank them.

#speaker: Narrator
Suddenly a soft grin appears in the corner of the room.

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

#speaker: Constance
This isn't the time to be making crazy decisions.

#speaker: Cheshire Cat
Well time isn't something that you guys have anymore. So who's it gonna be, me or the angry looking Queen over there.

#speaker: Narrator
The girls can feel the tension build between them. They'd done it this time. Talk about being caught between a rock and a hard place.

+ [Choose Cat]
    #ending: Bad End Cat
    -> DONE

+ [Choose Queen]
    #ending: Bad End Queen
    -> DONE
