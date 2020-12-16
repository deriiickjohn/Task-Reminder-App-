using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2.Models
{
    class Joke
    {
        public string FirstLine { get; set; }
        public string SecondLine { get; set; }

    }

    class JokeManager {

        public static List<Joke> Jokes = new List<Joke>()
        {

            new Joke() { FirstLine = "I told my wife she was drawing her eyebrows too high.",SecondLine = "She looked surprised." },
            new Joke() { FirstLine = "And the Lord said unto John,\"Come forth and you will receive eternal life.\"",SecondLine = "But John came fifth, and won a toaster." },
            new Joke() { FirstLine = "I threw a boomerang a few years ago.",SecondLine = "I now live in constant fear." },
            new Joke() { FirstLine = "Parallel lines have so much in common.",SecondLine = "It's a shame they'll never meet." },
            new Joke() { FirstLine = "My grandfather has the heart of a lion and a lifetime ban at the zoo.",SecondLine = "" },
            new Joke() { FirstLine = "Women only call me ugly until they find out how much money I make.",SecondLine = "Then they call me ugly and poor." },
            new Joke() { FirstLine = "You're not completely useless, you can always serve as a bad example.",SecondLine = "" },
            new Joke() { FirstLine = "I broke my finger last week. On the other hand, I'm okay",SecondLine = "" },
            new Joke() { FirstLine = "Someone stole my Microsoft Office and they're gonna pay.",SecondLine = "You have my Word." },
            new Joke() { FirstLine = "I tried to catch fog yesterday,Mist.",SecondLine = "" },
            new Joke() { FirstLine = "Working in a mirror factory is something I can totally see myself doing.",SecondLine = "" },
            new Joke() { FirstLine = "Why do cows wear bells?",SecondLine = "Because their horns don't work." },
            new Joke() { FirstLine = "What's the difference between a well dressed man on a bike and a poorly dressed man on a unicycle?",SecondLine = "Attire." },
            new Joke() { FirstLine = "I entered 10 puns in a pun contest hoping one would win, but no pun in ten did.",SecondLine = "" },
            new Joke() { FirstLine = "I took the shell off my racing snail, thinking it would make him run faster.",SecondLine = "If anything, it made him more sluggish." },
            new Joke() { FirstLine = "Why should you never date a tennis player?",SecondLine = "Because love means nothing to them." },
            new Joke() { FirstLine = "You know what they say about cliffhangers...",SecondLine = "" },
            new Joke() { FirstLine = "Recently took a poll.",SecondLine = "99% of people were annoyed when their tent fell down." },
            new Joke() { FirstLine = "The universe is just free parking.",SecondLine = "There" },
            new Joke() { FirstLine = "What's yellow and hurts when it gets in your eye?",SecondLine = "A bulldozer." },
            new Joke() { FirstLine = "Why do scuba drivers fall backwards off of the boat?",SecondLine = "Because if they fell forward, they'd still be on the boat." },
            new Joke() { FirstLine = "What's the difference between a bird and a fly?",SecondLine = "A bird can fly but a fly can't bird." },
            new Joke() { FirstLine = "What's orange and sounds like a parrot?",SecondLine = "A carrot." },
            new Joke() { FirstLine = "What's red that smells like blue paint?",SecondLine = "Red paint." },
            new Joke() { FirstLine = "Why do cows have hooves instead of feet?",SecondLine = "They lactose." },
            new Joke() { FirstLine = "Thanks for telling me the definition of the word many.",SecondLine = "It means a lot." },
            new Joke() { FirstLine = "Why couldn't the bicycle stand up?",SecondLine = "Because it was two tired!" },
            new Joke() { FirstLine = "Patient: Oh doctor, I'm just so nervous. This is my first operation.",SecondLine = "Don't worry. Mine too." },
            new Joke() { FirstLine = "My wife told me I need to quit playing Wonderwall on guitar.",SecondLine = "I said maybe..." },
            new Joke() { FirstLine = "When somebody asks my dad how he feels, he always replies..",SecondLine = "With my hands." },
            new Joke() { FirstLine = "Dear Algebra, Please stop asking us to find your x.",SecondLine = "She is not coming back." },
            new Joke() { FirstLine = "Stairs cannot be trusted.",SecondLine = "They're always Up to something." },
            new Joke() { FirstLine = "Why is the math book so sad?",SecondLine = "It's got too many problems." },
            new Joke() { FirstLine = "Jokes about unemployed people are not funny.",SecondLine = "They just don't work." },
         

            
        };

    }
}
