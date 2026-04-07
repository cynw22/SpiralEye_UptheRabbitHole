=== ThePoster === 
#speaker: Narrator
The girls finally reconvene in the lobby. What should they do now?

#speaker: Narrator
As the girls wonder what to do next, Alice spots a poster hanging on the wall.

#speaker: Alice
Hey! What's that thing doing here?

#speaker: Constance
Well that certainly wasn't here before...

#speaker: Alice
You think! I would have noticed something that creepy by now.

#speaker: Constance
Creepy? It doesn't look creepy. Maybe a little dreamy but not creepy.

#speaker: Alice
Are you kidding me?? Look at her face, that's like the face of evil right there.

#speaker: Constance
Evil? But she looks so serene here?

#speaker: Alice
Do your eyes work? What are you talking about?

#speaker: Narrator
Before the girls can argue more the White Rabbit rushes in clearly frazzled.

#speaker: White Rabbit
You girls ready to leave? We're going to be late if we don't leave now.

#speaker: Constance
We're coming!

#speaker: Narrator
The Rabbit rushes to greet them only to see the poster in question and freeze.

#speaker: White Rabbit
What. Is. That.

#speaker: Alice
Uhhh not sure, we just saw it now. Con says it wasn't here when we came in.

#speaker: White Rabbit
That rat, that no good conniving snake! Of course, of course he would come here just to ruin my day?

#speaker: Narrator
Both Alice and Constance are shocked by the outburst in question.

#speaker: White Rabbit
That thing, it just wants me to suffer. That's what this is isn't it? You want to see me cry?

#speaker: White Rabbit
Maybe you want me to beg, plead, tell you to leave me alone. BUt I WILL NEVER BREAK FOR YOU.

#speaker: Narrator
The Rabbit runs around the house, shouting into corners about standing strong against these attacks.

#speaker: Narrator
The girls both look at each other in confusion.

#speaker: Alice
I'm just gonna go- and like get him.

#speaker: Constance
Okay, yeah you go do that. I'll just stay here I guess.

#speaker: Narrator
Alice takes off after the White Rabbit and leaves Constance in the silence. Though that doesn't last long.

#speaker: Cheshire Cat
Mannnn that old thing really doesn't know when to give up.

#speaker: Constance
Cat? What are you doing here?

#speaker: Cheshire Cat
Rude, first of all I have a name. Second, I go wherever I please.

#speaker: Constance
I- that doesn't explain why you're here now?

#speaker: Cheshire Cat
It doesn't? Oh well it doesn't really matter to me, I just thought it would be fun.

#speaker: Constance
To mess with the poster.

#speaker: Cheshire Cat
To mess with that old fool. He really doesn't know when to quit.

#speaker: Constance
That's no way to treat your elder!

#speaker: Cheshire Cat
HAHAHAAHAH. Elder?! Oh my that's a good one.

#speaker: Cheshire Cat
Little girl, you have no idea what I am or what I can do. Don't give me a lecture.

#speaker: Constance
Is that a threat?

#speaker: Cheshire Cat
No. A promise. One that could show you more. If you're curious that is.

#speaker: Constance
Show me what?

#speaker: Cheshire Cat
The answers, the ones you seek so desperately.

#speaker: Constance
What's the catch?

#speaker: Cheshire Cat
My, you really are so quick to judge. I just don't see the need to fuss? Do you want answers or not?

#speaker: Constance
Nothing in this world is free. Everything comes at a cost.

#speaker: Cheshire Cat
I suppose that's true... well I guess all I want for you to do is follow me through the poster.

#speaker: Constance
And what exactly will that do?

#speaker: Cheshire Cat
Give me a sense of closure, knowing someone finally took the chance to learn the truth.

#speaker: Constance
...

#speaker: Cheshire Cat
Think about it. There's a world full of answers just waiting for you. All it takes is one step forward!

#speaker: Constance
One step forward?

#speaker: Cheshire Cat
Yes! One step forward and all the troubles you've had will wash away.

#speaker: Narrator
A war wages inside Constance. What is she to do here?

+ [Follow the Cat]
    ~ C_Alice -= 1
    ~ A_Cheshire += 1
   
    #speaker: Narrator
Constance decides to follow The Cat through the poster. Somehow this feels easier than it should.
    
    #ending: Bad End Two
    -> DONE

+ [Stay here]
    ~ C_Alice += 1
    ~ A_Cheshire -= 1
    
    #speaker: Narrator
    Constance decides to trust her gut and stay behind. The Cat appears annoyed by the choice.
    
    #speaker: Narrator
    Before he can comment, they hear Alice and the White Rabbit returning.
    
    #speaker: Cheshire Cat
    Well I suppose that's my cue to leave.
    
    #speaker: Constance
    Leave?
    
    #speaker: Cheshire Cat
    Of course, it's your loss sweetie, I told you I could show you something amazing!
    
    #speaker: Narrator
    Constance only gives the thing a scowl as it disappears into the painting once more.
    
{puzzleWon: 
    #speaker: Narrator
    Alice and the Rabbit come back just as The Cat leaves. They appear calmer now.

    #ending: WhiteRabbitWin

- else:
  #speaker: Narrator
    Alice and the Rabbit come back just as The Cat leaves. They appear calmer now.

    #ending: WhiteRabbitLose
}

-> DONE

