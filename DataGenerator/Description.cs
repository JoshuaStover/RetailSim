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
            "fast", "round", "skinny", "acidic", "detailed", "daily", "quizzical", "two",
            "cynical", "bashful", "flawless", "normal", "obnoxious", "homely", "vague",
            "mountainous", "resolute", "instinctive", "animated", "cruel", "absorbed",
            "disgusted", "cold", "thin", "tacky", "lively", "puzzling", "satisfying",
            "rough", "boiling", "puzzled", "tall", "sore", "able", "abrasive", "curvy",
            "ubiquitous", "pathetic", "spiritual", "obese", "long-term", "ambiguous",
            "jagged", "defeated", "alleged", "warm", "lyrical", "wet", "pink", "fresh",
            "gorgeous", "optimal", "warlike", "impolite", "thinkable", "garrulous",
            "tedious", "fascinated", "ordinary", "innocent", "foregoing", "few", "mean",
            "axiomatic", "same", "receptive", "belligerent", "elfin", "many", "spicy",
            "expensive", "alive", "mammoth", "wacky", "waiting", "unique", "envious",
            "clumsy", "loving", "dead", "furtive", "thankful", "useless", "low", "lame",
            "aromatic", "frequent", "towering", "secret", "loutish", "safe", "dear",
            "reminiscent", "adjoining", "somber", "yummy", "certain", "snobbish", "sad",
            "weary", "robust", "rural", "far", "productive", "sable", "outrageous",
            "strong", "material", "boundless", "infamous", "deeply", "lying", "green",
            "screeching", "laughable", "terrific", "smooth", "bawdy", "whispering",
            "temporary", "ruddy", "fabulous", "abusive", "fixed", "spectacular", "cute",
            "fortunate", "violent", "various", "rhetorical", "uninterested", "obscene",
            "acrid", "steep", "curved", "rambunctious", "mute", "obeisant", "fanatical",
            "faded", "hanging", "probable", "unwritten", "terrible", "disgusting", "odd",
            "finicky", "ready", "maddening", "cuddly", "makeshift", "scattered", "teeny",
            "piquant", "adaptable", "last", "annoying", "clever", "aggressive", "known",
            "numerous", "profuse", "ratty", "cooing", "macho", "ugly", "numberless",
            "decorous", "squeamish", "oceanic", "tranquil", "neat", "ad hoc", "vengeful",
            "overrated", "superficial", "female", "rabid", "empty", "ill informed",
            "future", "absurd", "efficacious", "quickest", "malicious", "open", "gentle",
            "greasy", "fearless", "mixed", "cheerful", "obedient", "phobic", "repulsive",
            "lewd", "fancy", "abnormal", "jolly", "second", "left", "ajar", "assorted",
            "mature", "foamy", "poised", "steady", "mere", "long", "immense", "colorful",
            "dispensable", "elated", "grubby", "ashamed", "husky", "well groomed",
            "eminent", "aboriginal", "wary", "sudden", "troubled", "toothsome", "orange",
            "upbeat", "placid", "waggish", "aquatic", "handy", "unruly", "ill fated",
            "overwrought", "perpetual", "eight", "selective", "full", "dreary", "raspy",
            "observant", "steadfast", "vivacious", "nonchalant", "wanting", "paltry",
            "roomy", "subsequent", "purring", "cagey", "skillful", "lackadaisical",
            "real", "maniacal", "shrill", "calm", "adhesive", "early", "trashy", "one",
            "auspicious", "colossal", "scientific", "obsequious", "historical", "high",
            "gaping", "capricious", "equal", "earthy", "bustling", "womanly", "scarce",
            "dark", "chilly", "soft", "grandiose", "sour", "neighborly", "hurt", "tidy",
            "vulgar", "enthusiastic", "pushy", "pleasant", "cowardly", "humdrum", "pale",
            "woebegone", "substantial", "aspiring", "offbeat", "crooked", "testy",
            "unbiased", "well-to-do", "hulking", "dizzy", "giddy", "coherent", "purple",
            "spotty", "futuristic", "fearful", "vagabond", "snotty", "exultant", "gabby",
            "deranged", "romantic", "debonair", "wistful", "lacking", "unkempt", "loud",
            "dynamic", "dazzling", "peaceful", "precious", "superb", "flashy", "broad",
            "stimulating", "tacit", "famous", "flaky", "encouraging", "ignorant", "rude",
            "omniscient", "noiseless", "ten", "greedy", "quack", "glorious", "right",
            "super", "moldy", "ablaze", "painful", "hissing", "elastic", "minor", "fat",
            "hot", "used", "homeless", "humorous", "cultured", "parched", "unused",
            "lavish", "cooperative", "taboo", "inexpensive", "depressed", "royal", "shy",
            "uttermost", "closed", "successful", "living", "acceptable", "sneaky",
            "hypnotic", "proud", "quick", "knowing", "longing", "solid", "lazy", "slim",
            "holistic", "lovely", "tiny", "cool", "bright", "relieved", "thirsty",
            "unequaled", "common", "nice", "subdued", "kaput", "ruthless", "jealous",
            "physical", "male", "redundant", "naive", "fierce", "bored", "jittery",
            "drunk", "nasty", "available", "milky", "marked", "near", "ethereal", "sore",
            "responsible", "different", "devilish", "aberrant", "irritating", "useful",
            "divergent", "powerful", "clean", "jumbled", "abashed", "gifted", "idiotic",
            "secretive", "delicate", "ceaseless", "truthful", "kindly", "silky", "goofy",
            "unnatural", "vacuous", "drab", "savory", "fair", "utopian", "sharp", "vast",
            "obtainable", "draconian", "meaty", "square", "elite", "grouchy", "angry",
            "noxious", "uptight", "spiffy", "cautious", "faulty", "blue eyed", "uneven",
            "glistening", "familiar", "voiceless", "unwieldy", "flowery", "aboard",
            "absent", "scary", "equable", "hallowed", "upset", "public", "defective",
            "excellent", "mysterious", "verdant", "special", "unequal", "whimsical",
            "hateful", "brief", "level", "utter", "simple", "jobless", "tense", "breezy",
            "plucky", "puffy", "quirky", "petite", "erect", "sulky", "actually", "nifty",
            "better", "prickly", "youthful", "gainful", "judicious", "abstracted", "red",
            "workable", "exclusive", "lethal", "defiant", "staking", "chivalrous", "wry",
            "rebel", "limping", "sordid", "chunky"
        };

        static string[] nouns =
        {
            "crib", "hall", "pen", "question", "month", "test", "baseball", "event",
            "observation", "flowers", "jewel", "shake", "point", "nut", "seashore",
            "blade", "cat", "spade", "crate", "queen", "dog", "mark", "zoo", "route",
            "dad", "rings", "scarf", "wilderness", "railway", "way", "zebra", "feeling",
            "hair", "number", "selection", "box", "cellar", "copper", "chess", "anger",
            "minister", "thunder", "beds", "unit", "cherry", "boy", "hands", "thumb",
            "airport", "mass", "fact", "kittens", "actor", "taste", "corn", "women",
            "burst", "cannon", "plot", "walk", "yam", "hole", "invention", "pleasure",
            "key", "apparatus", "cave", "name", "mist", "control", "bridge", "jeans",
            "calculator", "fang", "push", "plane", "furniture", "rabbit", "move", "bag",
            "scent", "meeting", "skirt", "room", "canvas", "level", "riddle", "crook",
            "wave", "grip", "fairies", "need", "impulse", "regret", "flight", "frog",
            "board", "building", "writer", "dust", "birds", "humor", "motion", "pin",
            "exchange", "trousers", "calendar", "cable", "vein", "sink", "letters",
            "payment", "rose", "rate", "plantation", "rainstorm", "wax", "trouble",
            "bike", "sack", "guitar", "celery", "amusement", "bubble", "song", "earth",
            "screw", "throat", "lumber", "form", "jam", "blow", "steel", "beginner",
            "cakes", "sneeze", "writing", "zinc", "attack", "war", "spark", "slip",
            "plastic", "quarter", "cobweb", "lace", "sheep", "sheet", "basketball",
            "toothpaste", "protest", "position", "reaction", "jelly", "place", "amount",
            "cub", "smash", "curtain", "offer", "wind", "rabbits", "ladybug", "camera",
            "servant", "scene", "temper", "bell", "brick", "flag", "van", "substance",
            "title", "wire", "wool", "year", "bomb", "rod", "support", "shirt", "plant",
            "kick", "rule", "quill", "library", "cracker", "growth", "mountain", "coal",
            "view", "discussion", "army", "jar", "collar", "receipt", "balance", "dress",
            "hat", "punishment", "request", "fowl", "food", "maid", "cabbage", "uncle",
            "table", "bear", "yak", "coach", "bedroom", "book", "stem", "watch", "whip",
            "distribution", "fruit", "wrench", "trail", "star", "caption", "stew", "fog",
            "lettuce", "quicksand", "adjustment", "wheel", "mask", "road", "swing",
            "vacation", "letter", "wall", "club", "stream", "dirt", "minute", "planes",
            "chance", "picture", "ring", "end", "change", "loss", "pigs", "secretary",
            "gate", "store", "time", "dime", "territory"
        };

        static string[] colors =
        {
            "aqua", "medium slate blue", "medium aquamarine", "pale turquoise", "violet",
            "medium spring green", "orange red", "ghost white", "cornflower blue", "tan",
            "bisque", "saddle brown", "green", "blue", "chartreuse", "mint cream", "red",
            "lavender", "navajo white", "peach puff", "light salmon", "medium sea green",
            "blanched almond", "navy", "coral", "yellow", "dark slate blue", "black",
            "white smoke", "silver", "ivory", "cadet blue", "lawn green", "royal blue",
            "pale goldenrod", "lime", "gold", "cornsilk", "moccasin", "amethyst", "cyan",
            "orchid", "brown", "light goldenrod yellow", "medium violet red", "pink",
            "light sea green", "olive drab", "hot pink", "tomato", "steel blue", "olive",
            "alice blue", "crimson", "dark khaki", "dark blue", "sienna", "goldenrod",
            "dark slate gray", "light blue", "medium purple", "chocolate", "light pink",
            "medium turquoise", "old lace", "dark sea green", "dark orchid", "sea green",
            "lime green", "sandy brown", "khaki", "snow", "light steel blue", "white",
            "medium orchid", "honeydew", "spring green", "wheat", "magenta", "linen",
            "light salmon", "dark turquoise", "dodger blue", "dark violet", "fuchsia",
            "light yellow", "lemon chiffon", "plum", "powder blue", "gray", "misty rose",
            "blue violet", "forest green", "light green", "antique white", "azure",
            "thistle", "midnight blue", "indian red", "beige"
        };
        #endregion

        /// <summary>
        /// Generates a random product description following the pattern:
        /// adjective color - adjective noun
        /// </summary>
        /// <returns>
        /// Random product description as a string.
        /// </returns>
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
