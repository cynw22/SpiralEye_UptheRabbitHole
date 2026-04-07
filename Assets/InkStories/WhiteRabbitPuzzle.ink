=== WhiteRabbitPuzzle === 
#speaker: Narrator
Alice sees the White Rabbit sitting in the chair by himself. He looks haggard.

#speaker: Alice
Hello. How are you doing?

#speaker: White Rabbit
Hello Alice. What are you doing here?

#speaker: Alice
I got a little turned around. Sorry about that.

#speaker: White Rabbit
Hmmm. No harm done.

#speaker: Alice
What are you doing here?

#speaker: White Rabbit
Simply taking a moment to myself, it's not easy at my age.

#speaker: Alice
How old are you?

#speaker: White Rabbit
Now that's quite the impolite question young lady.

#speaker: Alice
Oops, sorry. I didn't mean it like that.

#speaker: Narrator
Alice looks down embarrassed as the White Rabbit chuckles.

#speaker: White Rabbit
Well it's not like I'm offended by the question. Still you should be careful, you never know who you'll meet.

#speaker: Alice
Hmmm, I'll keep that in mind. Con's always telling me to watch my mouth.

#speaker: White Rabbit
Your sister's right, one of these days it's going to get you in trouble.

#speaker: Alice
Ehhh I'll deal with it if I ever get to that point.

#speaker: White Rabbit
Oh my, you're quite the free spirit. I suppose it's refreshing to see someone as optimistic as you down here.

#speaker: Alice
Oh? Are people usually negative here?

#speaker: White Rabbit
Something like that...

#speaker: Narrator
Alice can tell the topic is sensitive, should she push?

+ [Ask the Rabbit for Clarification]
    ~ A_WhiteRabbit -= 1
    #speaker: Alice
    I don't get it? Why's everyone so shifty around here?
    
    #speaker: Narrator
    The White Rabbit appears tense, perhaps this was the wrong choice...
    
    #speaker: White Rabbit
    You should be careful Alice. Don't go sticking your nose in places it doesn't belong,
    
    #speaker: Alice
    But why? No one ever gives a straight answer here. It's always wrapped up in twisted riddles.
    
    #speaker: White Rabbit
    Because that's how it works down here. Nothing is free, everything comes with a price.
    
    #speaker: Alice
    Even this? Do you want something from me, for sitting down and talking to you?
    
    #speaker: Narrator
    Alice can feel herself getting upset at the thought. She liked the old man.
    
    #speaker: White Rabbit
    I wouldn't want your things, I doubt a little girl such as yourself even has anything to offer.
    
    #speaker: Alice
    HEY! I'm plenty smart, Con says I'm old enough to do school work on my own.
    
    #speaker: White Rabbit
    ... that is not what I meant. This conversation is leading nowhere, perhaps it's time you leave.
    -> Alice_choices
    
+ [Leave it Alone]
    ~ A_WhiteRabbit += 1
    #speaker: Alice 
    Alice decides to leave the conversation alone, the mood seems to lighten.
    
    -> Alice_choices
    
=== Alice_choices ===
#speaker: Alice
I have more questions though. I thought you would answer them.

#speaker: Narrator
The White Rabbit stays silent for a moment before deciding.

#speaker: White Rabbit
Fine, ask your questions but please be quick about it. I don't have all day.

#speaker: Alice
Okay got it!

#speaker: Alice
What should I ask him?

* {not askedQueen} [Ask about his relationship with the Queen]
    ~ askedQueen = true
     ~ A_WhiteRabbit += 1
    #speaker: Alice
    What’s your relationship with the Queen?

    #speaker: White Rabbit
    I serve her... loyally.
    
    #speaker: Alice
    That's it? You serve her loyally?
    
    #speaker: White Rabbit
    What else is there? She is our Queen, we watch over her as she watches us.
    
    #speaker: Alice
    But why? Everyone we've talked to either talks about her like she's a god or a nuisance.
    
    #speaker: Alice
    So which is it?
    
    #speaker: White Rabbit
    Please, don't ever say that out loud, never! You don't know who could be listening.
    
    #speaker: Alice
    ... is it dangerous?
    
    #speaker: White Rabbit
    Just please, trust me this once, the Queen is not someone to be trifled with.
    
    #speaker: White Rabbit
    She is as powerful as the whispers and she rules these lands.
    
    #speaker: Alice
    If she rules these lands then why does everyone hold a sense of sadness for them.
    
    #speaker: White Rabbit
    That is something I cannot answer. Please do not ask me again...
    
    #speaker: Narrator
    Alice wants to push forward but she feels it won't do anything. Back to the drawing board.

    -> Alice_choices

* {not askedWonderland} [Ask about Wonderland]
    ~ askedWonderland = true
     ~ A_WhiteRabbit += 1
    #speaker: Alice
    What is this place?

    #speaker: White Rabbit
    This is Wonderland... a place of wonder and joy.
    
    #speaker: Alice
    Everyone says that, it's this amazing place filled with possibilities. 
    
    #speaker: White Rabbit
    And they would be correct.
    
    #speaker: Alice
    So why does it feel like no one truly believes that?
    
    #speaker: White Rabbit
    What do you mean?
    
    #speaker: Alice
    Everywhere we go it feels like people are missing parts of themselves, like important bits have been taken.
    
    #speaker: White Rabbit
    ... why would you think that?
    
    #speaker: Alice
    I don't know... just a feeling?
    
    #speaker: White Rabbit
    Ahhh children, always looking for puzzles that don't exist. 
    
    #speaker: Alice
    What's that supposed to mean?
    
    #speaker: White Rabbit
    It means not everything is a complicated picture you need to put back together, sometimes simplicity is beauty.
    
    #speaker: Alice
    And that's what this place is, simple?
    
    #speaker: White Rabbit
    This place holds beauty in its rules, it keeps order and maintains this paradise.
    
    #speaker: Alice
    I don't understand?
    
    #speaker: White Rabbit
    You will learn little one, and when you do I hope we don't teach you that lesson.
    
    #speaker: Narrator
    He leaves Alice confused but it appears the White Rabbit has no more answers as he is checked out now.
    
    -> Alice_choices
    
* {not askedCat} [Ask about Cheshire Cat]
    ~ askedCat = true
     ~ A_WhiteRabbit -= 1
    #speaker: Alice
    What about The Cheshire Cat? What's your relationship with him?

    #speaker: White Rabbit
    That mangy scoundrel, I don't ever want to talk about him again. 
    
    #speaker: Alice
    Really? You hate him?
    
    #speaker: White Rabbit
    More than anything in this world. I will never forgive that creature.
    
    #speaker: Alice
    But, he seemed so nice? He even helped us find the Hatter and get the ticket.
    
    #speaker: White Rabbit
    Make no mistake, that thing doesn't care, he only does what he pleases.
    
    #speaker: White Rabbit
    It doesn't matter who he hurts, it's all a game to him in the end.
    
    #speaker: Alice
    And has he hurt you? Is that why you're angry?
    
    #speaker: Narrator
    The White Rabbit's face goes cold. He does not answer the question. This topic has come to a close.

    -> Alice_choices
    
//{allKeysFound:

    * [Ask about the locket]
     ~ A_WhiteRabbit += 1
        #speaker: Alice
        What about this? Do you recognize them?

        #speaker: White Rabbit
        W-where did you get those...?
        
        #speaker: Narrator
        The White Rabbit stares at the locket shining in Alice's palm.
        
        #speaker: Alice
        I found it, it was inside a room. A baby room?
        
        #speaker: White Rabbit
        ...
        
        #speaker: Alice
        I didn't mean to snoop, I just saw it was on the list and thought you might want it.
        
        #speaker: White Rabbit
        So, you figured it out. I didn't think you would to be honest.
        
        #speaker: Alice
        Who are they?
        
        #speaker: White Rabbit
        ... my family.
        
        #speaker: Alice
        Family?
        
        #speaker: White Rabbit
        Yes, they're the most precious people in my life. At least they were until that thing took them away.
        
        #speaker: Alice
        Is that why you're angry?
        
        #speaker: White Rabbit
        Yes. I feel angry, and hurt and pained.
        
        #speaker: Narrator
        They sit in the silence, Alice doesn't know how to fix this.
        
        #speaker: Alice
        Is this why you work for her?
        
        #speaker: White Rabbit
        ...yes. She promised, she said she would help me get them back.
        
        #speaker: Alice
        And you believed her?
        
        #speaker: White Rabbit
        What choice did I have? It's the only option left.
        
        #speaker: Alice
        There's always an option, you just have to look for it.
        
        #speaker: White Rabbit
        Spoken like a true child, one that still believes the good in this world.
        
        #speaker: White Rabbit
        The world is not as kind to you when you grow to understand it.
        
        #speaker: Alice
        Is that why you chose to lock it away? Lock them up along with a piece of your heart?
        
        #speaker: Alice
        The reason you chose to serve her, even if it kills you inside.
        
        #speaker: White Rabbit
        Yes, I pushed it away, locked it somewhere I could never touch so this pain would no longer hurt me.
        
        #speaker: White Rabbit
        I chose this path, because it was all I had left, all I had to numb the hurt.
        
        #speaker: White Rabbit
        And I hoped I could keep this piece locked away in the only place that has meaning here.
        
        #speaker: Narrator
        The white rabbit gazes sadly at the locket in her palm. It feels heavy, like she shouldn't have it.
        
        #speaker: Narrator
        The White Rabbit holds her hand in silence. Their eyes never leave the locket.
    -> Alice_choices


{askedQueen and askedWonderland and askedCat and allKeysFound:
    -> continue_story
}

=== continue_story ===

#speaker: Narrator
After a moment of silence the White Rabbit speaks once more.

#speaker: White Rabbit
Is that all?

#speaker: Alice
Yeah, that's all I wanted to ask.

#speaker: White Rabbit
Well I hope I satisfied your curiosity one way or another.

#speaker: Alice
I still don't know why you bothered to help me or answer my questions.

#speaker: White Rabbit
I- it just felt, like the right thing to do.

#speaker: Alice
The right thing to do?

#speaker: White Rabbit
Nevermind that, we're running out of time. You should hurry and help your sister.

#speaker: White Rabbit
We will have to leave soon.

#speaker: Alice
Will I be able to come back? If I have more questions.

#speaker: White Rabbit
I will be here, as long as I have time, I will sit here. 

#speaker: Narrator
Alice nods realizing the conversation is over. 

-> DONE

