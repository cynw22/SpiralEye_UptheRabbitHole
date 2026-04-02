=== MeetCatPuzzle === 
#noskip_start

#speaker: Cheshire Cat 
Well, well, well, hello my dear.

#speaker: Alice
A cat, oh my gosh it’s a talking cat!!!

#speaker: Constance
It's a talking cat???

#speaker: Cheshire Cat
How rude. I'm not just any talking cat. I'm quite the step up from your average house pet.

#speaker: Narrator
His grin feels a little toothy but Alice doesn't seem to mind. She looks enamored by what she sees.

#speaker: Cheshire Cat
 Me? Just your average run of the mill neighbor, nothing new to see. Though if it’s a name you are seeking, the Cheshire Cat is just fine.
 
 #speaker: Alice
Cheshire Cat? That’s an odd name… but I like it. Nice to meet you!

#speaker: Narrator
Alice’s enthusiasm is quite infectious. It’s hard not to smile around her. The cat gives her another cheeky grin.

#speaker: Cheshire Cat
So now then, who might you be deary? 

#speaker: Alice
Oh yeah I’m -

#speaker: Constance
Leaving. We were leaving.

#speaker: Alice
Huh?

#noskip_end
#speaker: Constance
Come on, enough of this, we have places to be so lets get going. Sorry to bother you again.

#speaker: Alice
We do?

#speaker: Cheshire Cat
Oh my what’s the rush, I was hoping we could stay and have a quick little chat!

#speaker: Constance
No need, we have no interest in chatting.

#speaker: Alice
Speak for yourself, I’ve got plenty of questions-

#speaker: Constance
No you don’t, you and I are leaving.

#speaker: Cheshire Cat
So soon? We haven’t even sat down for tea yet? It’s quite rude don’t you think?

#speaker: Narrator
Perhaps poor Constance feels uneasy around this new creature. It’s quite the intimidating foe, sometimes people get scared without it even trying. 

#speaker: Alice
Con, are you-

#speaker: Constance
Not now, please just not now Alice.

#speaker: Narrator
Constance tugs her sister down the road they came from, her legs rushing forward, ears trying to drown out Alice’s pleas to stop and talk to the Cat.

#speaker: Narrator
The Cat, seemingly unaware of its unwantedness simply tags along, gently trotting along the path with the girls. This only seems to agitate poor Constance.

#speaker: Cheshire Cat
Oh come now, it’s no fun if you ignore me the whole time. I don’t want to talk to your backs for the rest of the walk.

#speaker: Constance
Then perhaps this is a sign you need to find a path of your own, We’re quite busy after all.

#speaker: Cheshire Cat
Oh yes, of course I’m sure you're very busy. It must be difficult, walking up in a strange world, unsure what’s up and what’s down.

#speaker: Narrator
He watches in delight as this causes both girls to freeze in their path, eyes wide seemingly spooked by what they just heard.

#speaker: Alice
Wait wha? How’d you know that?

#speaker: Cheshire Cat
Well I’ve certainly never seen you here before, and I know everybody, so that means you're new.

#speaker: Alice
That’s awesome! You know everyone here in Wonderland?

#speaker: Cheshire Cat
Of course I do. There isn't a person here I don't know. I'm quite sought out here.

#speaker: Alice
That's awesome!!

#speaker: Cheshire Cat
So it seems I’ve finally peaked your interest! How wonderful.

#speaker: Alice
So what is this place? Where is everyone? Are there more people like you here? Are-

#speaker: Cheshire Cat
My aren’t we eager. Well it's all in good fun so I suppose there's no harm in letting you know this once.

#speaker: Narrator
The cat appears thrilled by this latest discovery. Alice seems puzzled by this revelation.

#speaker: Cheshire Cat
I’m more than happy to answer your questions my dear I only ask that you give me something in return for my troubles.

#speaker: Narrator
Something strange seems to cross Constance's face, her hand tightening on her sisters. She looks ready to bolt.

#speaker: Constance
No thank you, I’m sure we’ll find our way to a village or somewhere with more people.

#speaker: Constance
Really? You think you can make it out of these enchanted woods without a guide? I can’t tell if you’re foolish or brave.

#speaker: Narrator
The cat lets out a cackle that feels strange and pitchy, the air shifts uncomfortably around them.

#speaker: Constance
You mentioned that people do exist here. I’m sure we’ll stumble upon them soon. So thank you for your concern however we’re okay for now.

#speaker: Narrator
Constance begins to pull her sister forward, intending to put more distance between them and the strange creature.

#speaker: Cheshire Cat
What a shame… and here I thought you’d be interested in what I wanted to tell you. After all, it's not often you meet someone associated with our Queen.

#speaker: Narrator
This causes both girls to freeze and turn again. Alice looks shocked and excited while Constance holds a look between relief and suspicion.

#noskip_start
+ [Ignore the Cat]
    ~ C_Alice -= 1
    ~ C_Cheshire -= 1

    #speaker: Constance
    Oh my god Alice no!!! Not again    
    #speaker: Alice
    Connnnn come quickly, it looks interesting!
    
    #speaker: Constance
    ALICE!!!

    #speaker: Narrator
    Exhausted but amused by her sister's lively attitude Constance shelves her worry to chase after her quickly.

    -> after_choice_3 

+ [Stop and Listen to the Cat]
    ~ C_Alice += 1
    ~ C_Cheshire += 1
    #speaker: Constance
    ALICE I SWEAR TO GOD IF YOU LEAD US DOWN ANOTHER RABBIT HOLE I WILL NOT BE RESPONSIBLE FOR THE THINGS I SAY.
    
    #speaker: Alice
   Oh my god Con you worry way too much, it’s fine!

    I don’t feel sick at all! I promise, okay?
    
    #speaker: Narrator
    Alice disappears from view.

    #speaker: Constance
    …Why can’t I have one day, just one normal day to myself?
    
    #speaker: Narrator
    Frustrated by her sister's carelessness Constance quickly gives chase to her wayward sibling.

    ->after_choice_3

===after_choice_3===
#speaker: Narrator
The game of cat and mouse is ready to begin. A strange smile that had appeared in the distance materializes once more, a sharp looking feline now attached to that sporting grin.

#noskip_end

#ending: PartyFight
-> DONE

