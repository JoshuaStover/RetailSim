using System;

namespace DataGenerator
{
    class Description
    {
        const int ADJECTIVES_SIZE = 500;
        const int COLORS_SIZE = 100;
        const int NOUNS_SIZE = 250;

        #region StringArrays
        static string[] adjectives = 
        {
            "functional", "dull", "unsuitable", "wooden", "shallow", "possessive", "bad",
            "fast", "round", "skinny", "acidic", "detailed", "daily", "quizzical", "cynical",
            "bashful", "flawless", "normal", "obnoxious", "homely", "mountainous", "resolute",
            "instinctive", "animated", "vague", "cruel", "absorbed", "disgusted", "cold",
            "thin", "tacky", "lively", "puzzling", "satisfying", "rough", "two", "boiling",
            "puzzled", "tall", "sore", "able", "abrasive", "ubiquitous", "pathetic",
            "spiritual", "curvy", "obese", "long-term", "ambiguous", "jagged", "defeated",
            "alleged", "warm", "lyrical", "wet", "pink", "gorgeous", "fresh", "optimal",
            "warlike", "impolite", "thinkable", "garrulous", "tedious", "fascinated",
            "ordinary", "innocent", "foregoing", "few", "mean", "axiomatic", "same",
            "receptive", "belligerent", "elfin", "many", "expensive", "spicy", "alive",
            "mammoth", "wacky", "waiting", "unique", "envious", "clumsy", "loving", "dead",
            "furtive", "thankful", "useless", "low", "aromatic", "lame", "frequent",
            "towering", "secret", "loutish", "safe", "dear", "reminiscent", "adjoining",
            "somber", "yummy", "certain", "snobbish", "weary", "robust", "rural", "sad",
            "far", "productive", "sable", "outrageous", "strong", "material", "boundless",
            "infamous", "deeply", "lying", "screeching", "laughable", "terrific", "smooth",
            "bawdy", "green", "whispering", "temporary", "ruddy", "fabulous", "abusive",
            "fixed", "spectacular", "fortunate", "violent", "cute", "various", "rhetorical",
            "uninterested", "obscene", "acrid", "steep", "curved", "rambunctious", "mute",
            "obeisant", "fanatical", "faded", "hanging", "probable", "unwritten", "terrible",
            "disgusting", "finicky", "ready", "maddening", "cuddly", "makeshift", "scattered",
            "piquant", "adaptable", "last", "annoying", "clever", "aggressive", "numerous",
            "profuse", "ratty", "cooing", "macho", "ugly", "numberless", "decorous", "known",
            "squeamish", "oceanic", "tranquil", "neat", "ad hoc", "vengeful", "overrated",
            "superficial", "female", "rabid", "empty", "ill - informed", "future", "absurd",
            "efficacious", "quickest", "malicious", "open", "gentle", "greasy", "fearless",
            "mixed", "cheerful", "obedient", "phobic", "repulsive", "lewd", "fancy",
            "abnormal", "jolly", "second", "left", "ajar", "assorted", "mature", "foamy",
            "poised", "steady", "mere", "long", "immense", "colorful", "dispensable",
            "elated", "grubby", "ashamed", "husky", "well - groomed", "eminent", "aboriginal",
            "wary", "sudden", "troubled", "toothsome", "orange", "upbeat", "placid",
            "waggish", "aquatic", "handy", "unruly", "ill - fated", "overwrought",
            "perpetual", "eight", "selective", "full", "teeny", "dreary", "observant",
            "raspy", "steadfast", "vivacious", "nonchalant", "wanting", "paltry", "roomy",
            "subsequent", "purring", "cagey", "skillful", "lackadaisical", "real", "maniacal",
            "shrill", "calm", "adhesive", "early", "trashy", "auspicious", "colossal",
            "scientific", "obsequious", "historical", "high", "gaping", "capricious", "equal",
            "earthy", "bustling", "womanly", "scarce", "dark", "chilly", "soft", "grandiose",
            "sour", "odd", "neighborly", "hurt", "vulgar", "enthusiastic", "pushy",
            "pleasant", "cowardly", "humdrum", "woebegone", "substantial", "aspiring",
            "offbeat", "one", "crooked", "testy", "unbiased", "pale", "well-to-do", "hulking",
            "dizzy", "giddy", "coherent", "spotty", "futuristic", "fearful", "vagabond",
            "snotty", "exultant", "deranged", "romantic", "debonair", "tidy", "wistful",
            "lacking", "unkempt", "dynamic", "dazzling", "gabby", "purple", "peaceful",
            "precious", "superb", "flashy", "broad", "stimulating", "tacit", "famous",
            "flaky", "encouraging", "ignorant", "omniscient", "noiseless", "ten", "greedy",
            "glorious", "right", "super", "moldy", "quack", "ablaze", "painful", "hissing",
            "elastic", "minor", "fat", "hot", "used", "homeless", "humorous", "cultured",
            "parched", "unused", "lavish", "cooperative", "taboo", "inexpensive", "depressed",
            "royal", "uttermost", "closed", "successful", "loud", "living", "rude",
            "acceptable", "sneaky", "hypnotic", "proud", "quick", "knowing", "longing",
            "solid", "lazy", "holistic", "lovely", "tiny", "cool", "bright", "relieved",
            "thirsty", "unequaled", "common", "nice", "subdued", "kaput", "ruthless",
            "jealous", "physical", "male", "slim", "shy", "redundant", "naive", "fierce",
            "bored", "jittery", "drunk", "nasty", "available", "milky", "marked", "near",
            "ethereal", "responsible", "different", "devilish", "aberrant", "irritating",
            "useful", "divergent", "powerful", "clean", "jumbled", "abashed", "gifted",
            "idiotic", "secretive", "delicate", "ceaseless", "truthful", "kindly", "silky",
            "goofy", "unnatural", "vacuous", "drab", "savory", "fair", "utopian", "sharp",
            "obtainable", "draconian", "meaty", "square", "elite", "grouchy", "angry",
            "noxious", "uptight", "spiffy", "cautious", "faulty", "blue - eyed", "glistening",
            "familiar", "voiceless", "unwieldy", "flowery", "aboard", "absent", "uneven",
            "scary", "equable", "hallowed", "upset", "public", "defective", "excellent",
            "mysterious", "verdant", "special", "unequal", "whimsical", "hateful", "brief",
            "level", "utter", "simple", "jobless", "tense", "breezy", "plucky", "puffy",
            "quirky", "sore", "petite", "erect", "sulky", "actually", "better", "prickly",
            "youthful", "gainful", "judicious", "abstracted", "workable", "exclusive",
            "lethal", "defiant", "red", "staking", "chivalrous", "rebel", "nifty", "vast",
            "limping", "wry", "sordid", "chunky"
        };

        static string[] nouns =
        {
            "crib", "hall", "pen", "question", "month", "test", "baseball", "observation",
            "event", "flowers", "jewel", "shake", "point", "nut", "seashore", "blade", "cat",
            "spade", "crate", "queen", "dog", "mark", "zoo", "route", "dad", "rings", "scarf",
            "wilderness", "railway", "way", "zebra", "feeling", "hair", "number", "selection",
            "box", "cellar", "copper", "chess", "minister", "thunder", "beds", "unit", "cherry",
            "boy", "anger", "hands", "thumb", "airport", "mass", "fact", "kittens", "actor",
            "taste", "corn", "women", "burst", "cannon", "plot", "walk", "yam", "hole",
            "invention", "pleasure", "key", "apparatus", "cave", "name", "mist", "control",
            "bridge", "jeans", "calculator", "fang", "push", "plane", "furniture", "rabbit",
            "move", "scent", "meeting", "skirt", "room", "canvas", "level", "riddle", "crook",
            "wave", "grip", "fairies", "need", "impulse", "regret", "flight", "frog", "bag",
            "board", "building", "writer", "dust", "birds", "humor", "motion", "exchange",
            "trousers", "calendar", "pin", "cable", "vein", "sink", "letters", "payment", "rose",
            "rate", "plantation", "rainstorm", "wax", "trouble", "bike", "sack", "guitar",
            "celery", "amusement", "bubble", "song", "earth", "screw", "throat", "lumber",
            "form", "jam", "blow", "steel", "beginner", "cakes", "sneeze", "writing", "zinc",
            "attack", "war", "spark", "slip", "plastic", "quarter", "cobweb", "lace", "sheep",
            "sheet", "basketball", "toothpaste", "protest", "position", "reaction", "jelly",
            "place", "amount", "cub", "smash", "curtain", "offer", "wind", "rabbits", "ladybug",
            "camera", "servant", "scene", "temper", "bell", "brick", "flag", "van", "substance",
            "title", "wire", "wool", "year", "bomb", "rod", "support", "shirt", "plant", "kick",
            "rule", "quill", "library", "cracker", "growth", "mountain", "coal", "view",
            "discussion", "army", "jar", "collar", "receipt", "balance", "dress", "hat",
            "punishment", "request", "fowl", "food", "maid", "cabbage", "uncle", "table", "bear",
            "yak", "coach", "bedroom", "book", "stem", "watch", "distribution", "fruit", "whip",
            "wrench", "trail", "star", "caption", "stew", "lettuce", "quicksand", "adjustment",
            "wheel", "mask", "road", "swing", "vacation", "letter", "wall", "club", "stream",
            "dirt", "minute", "planes", "chance", "picture", "fog", "ring", "end", "change",
            "loss", "pigs", "secretary", "gate", "store", "time", "dime", "territory"
        };

        static string[] colors =
        {
            "aqua", "medium slate blue", "medium aquamarine", "pale turquoise", "medium spring green",
            "orange red", "ghost white", "cornflower blue", "tan", "bisque", "saddle brown", "violet",
            "green", "blue", "chartreuse", "mint cream", "lavender", "navajo white", "peach puff",
            "light salmon", "medium sea green", "blanched almond", "navy", "coral", "yellow",
            "dark slate blue", "white smoke", "silver", "ivory", "black", "cadet blue", "lawn green",
            "pale goldenrod", "lime", "gold", "cornsilk", "moccasin", "amethyst", "cyan", "orchid",
            "brown", "light goldenrod yellow", "medium violet red", "pink", "light sea green",
            "olive drab", "hot pink", "tomato", "steel blue", "royal blue", "alice blue", "crimson",
            "dark khaki", "dark blue", "sienna", "goldenrod", "dark slate gray", "light blue",
            "medium purple", "olive", "chocolate", "light pink", "medium turquoise", "old lace",
            "dark sea green", "red", "dark orchid", "lime green", "sandy brown", "khaki", "snow",
            "light steel blue", "white", "medium orchid", "honeydew", "spring green", "wheat", "magenta",
            "light salmon", "dark turquoise", "dodger blue", "dark violet", "linen", "light yellow",
            "lemon chiffon", "plum", "powder blue", "gray", "fuchsia", "blue violet", "misty rose",
            "forest green", "light green", "antique white", "azure", "thistle", "midnight blue",
            "indian red", "beige", "sea green"
        };
        #endregion

        public static string Get()
        {
            Random rand = new Random();
            string a1, a2, c, n;

            a1 = adjectives[rand.Next(ADJECTIVES_SIZE)];
            a2 = adjectives[rand.Next(ADJECTIVES_SIZE)];
            c = colors[rand.Next(COLORS_SIZE)];
            n = nouns[rand.Next(NOUNS_SIZE)];

            return a1 + " " + c + " - " + a2 + " " + n;
        }
    }
}
