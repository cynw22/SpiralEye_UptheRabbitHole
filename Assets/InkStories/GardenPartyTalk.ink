=== GardenPartyTalk === 
#speaker: Card
Thank you so much for helping us. I don't know what the Red Queen would have done to us or you.

#speaker: Constance
To you? To us? The queen wouldn’t…

#speaker: Alice
Yeah right…

#speaker: Narrator
Constance chooses to ignore the remark in favor of asking the card a couple questions.

#speaker: Constance
Mr. Seven of Hearts, can I ask you about something? It’s about some weird stuff in the maze. It just reminded me of an article I found saying awful things about -

#speaker: Card
Attention, All Garden Party Guests, Your Majesty, The Red Queen, Saviour, Beacon of Brilliance has arrived! 

#speaker: Narrator
The Red Queen strides down from her glamorous castle. She acts like her presence is a blessing on this party.

#speaker: Alice
Con! She's coming this way. What do we do?

#speaker: Constance
Um, I’m not sure…

#speaker: Narrator
The Red Queen walks up next to the rose maze.

#speaker: Queen
Mr. Seven of Hearts, wonderful job on the hedge trimming. 

#speaker: Card
Thank you! I take your compliment with gratitude!

#speaker: Queen
First thing you’ve done correctly in all your card forsaken life. 

#speaker: Card
…

#speaker: Queen
Well! Keep this up, Mr Seven. I despise disappointment. You sevens should know this by now.

#speaker: Narrator
After leveling the man with a glare that could kill, the Queen turns to her party guests and smiles.

#speaker: Queen
Well then, with this sorted, the Queen is ready to mingle! Let the music commence. 

#speaker: Constance
Um, excuse me, miss - Her majesty, The Red Queen. I need to speak to you about something.

#speaker: Queen
Shoo, go away, little troglodyte. 

#speaker: Card
Your Majesty, may I speak?

#speaker: Queen
Did I give you permission to speak to me? What is it now??

#speaker: Card
I cannot in good faith take all the praise. These girls assisted in the maze clean up, all I ask is that you give them a moment of your time..

#speaker: Queen
WHO ARE YOU TO TELL ME WHAT TO DO WITH MY TIME!?

#speaker: Narrator
The queen promptly turns away from Mr. Seven of Hearts to the girls.

#speaker: Card
But your majesty. These girls fought viciously to free your garden of those pesky white flowers. Look, not a single flower remains. 

#speaker: Narrator
At this the Queen’s beady little eyes scan the outer maze. True to the card’s words it’s finally devoid of white.

#speaker: Queen
Is that right?

#speaker: Constance
…yes.

#speaker: Queen
Then I must offer you my thanks. Oh my sweets. I apologize for the outburst. 

#speaker: Queen
Bless his heart, Mr. Seven doesn't know his place. Anyway, I really do appreciate you both for helping with the trimming. 

#speaker: Narrator
The Queen, basking in all her glory, smiles upon the garden party. She thinks its “brilliance” is only rivaled by her own.

#speaker: Alice
Your Majesty, your party, it’s very…decadent and exquisite! It seems like everyone loves you.

#speaker: Queen
Ahh, they do. My humble subjects. Each and every one of them. 

#speaker: Alice
Can I ask you about some of them?

#speaker: Queen
Well ask. Hurry up, The Queen doesn’t have all day.

-> Alice_Queen_Choices

=== Alice_Queen_Choices ===

{askedRabbit and askedQWonderland and askedQCat:
    -> continue_story_2
}

#speaker: Alice
What should I ask her?

* {not askedRabbit} [Ask about their relationship with the Rabbit]
     ~ askedRabbit = true
     ~ C_RedQueen -= 1
     #speaker: Alice		
    What is your connection to Mr. Rabbit?
    
    #speaker: Queen
    Oh, he’s just around. Helping run errands. He looks old, but is as energetic as a rabbit! I guess he is a rabbit. I've never realized that before. HA HA!
    
    #speaker: Alice
    It seems like he waits on you, hand and foot.
    
    #speaker: Queen
    He is my right-hand man after all.
    
    #speaker: Narrator
    Alice appears shocked by this information.
    
    #speaker: Alice
    You’re that close to each other?
    
    #speaker: Queen
    Of course, this party was organized by him. Though every detail was hand picked by your’s truly!
    
    #speaker: Narrator
    Alice feels sick, she tries hard to swallow down the bile and focus on the woman in front of her.
    #speaker: Narrator
    Why does this cut deeper than the others? 

    -> Alice_Queen_Choices

* {not askedQWonderland} [Ask about Wonderland]
    ~ askedQWonderland = true
     ~ C_RedQueen += 1
    #speaker: Alice
    What are your thoughts on Wonderland?
    
    #speaker: Queen
    Ah what a wonderful place. My sweet, sweet home. Did you know I was born to be Queen? Truly a heroic feat. And I did it myself. 
    
    #speaker: Alice
    You were born by yourself?
    
    #speaker: Queen
    Out of all the Queens, I am the best one. Queen of Spades does nothing all day but whine and cry. Clearly, she’s dealt a hand of misery. 
    
    #speaker: Queen
    My kingdom has celebrations all the time! I mean, look at the garden party. I am a great Ruler-. 
    
    #speaker: Alice
    Well I was hoping to hear your thoughts on the people of Wonderland.
    
    #speaker: Queen
    Oh! Well yes! I mean, this party is for them after all. Mostly…
    
    #speaker: Alice
    That’s it? Anything else?
    
    #speaker: Queen
    What else is there to say?

    -> Alice_Queen_Choices
    
* {not askedQCat} [Ask about Cheshire Cat]
    ~ askedQCat = true
     ~ C_RedQueen -= 1
    #speaker: Alice
    What about the Cheshire Cat?
    
    #speaker: Queen
    We do not SPEAK THAT NAME IN THIS KINGDOM.
    
    #speaker: Alice
    Oh what? Why would - 
    
    #speaker: Queen
    I do not want to participate in this conversation. If we keep talking about this, I will throw you in the dungeon! OFF WITH - 
    
    #speaker: Alice
    I’m sorry!...Your brilliance.
    
    #speaker: Queen
    Good. Fine. See, I am a very forgiving person. HA HA!

-> Alice_Queen_Choices

=== continue_story_2 ===
#speaker: Constance
Hi, I’m sorry, one more question, 

#speaker: Queen
Yes, my dear child?

#speaker: Constance
This newspaper…

#speaker: Narrator
Constance pulls out the newspaper clipping she wasn’t supposed to find at the White Rabbit’s house. 

#speaker: Constance
I- I know I shouldn’t read it but the things in here are strange. I’m honestly not sure what to believe anymore.

#speaker: Queen
Hush, child, here is not the place to discuss this. Come with me now. 

#ending: GardenPartyPuzzle
-> DONE
