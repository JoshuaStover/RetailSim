using System;
using System.Collections.Generic;
using System.Text;

namespace DataGenerator
{
    class Name
    {
        const int FIRST_NAME_SIZE = 300;
        const int LAST_NAME_SIZE = 300;

        #region StringArrays
        static string[] firstNames = 
        {
            "Stephnie", "Manie", "Janette", "Titus", "Lindsy", "Alvina", "Jovan", "Rob",
            "Salina", "Dusty", "Jannet", "Judson", "Bell", "Zaida", "Laticia", "Britany",
            "Claretha", "Barney", "Rocco", "Nan", "Berna", "Gail", "Portia", "Priscila",
            "Therese", "Marquerite", "Sharee", "Shantel", "Hiroko", "Leeanne", "Violet",
            "Donnie", "Despina", "Cynthia", "Caterina", "Regina", "Kaci", "Samantha",
            "Clementina", "Preston", "Karleen", "Brandee", "Asha", "Tenesha", "Marcelo",
            "Allyn", "Merideth", "Agnes", "Margery", "Leticia", "Tommy", "Wyatt", "Tina",
            "Chung", "Judie", "Antonette", "Dawne", "Wally", "Zoila", "Ngoc", "Latosha",
            "Oda", "Merlyn", "Susy", "Yasuko", "Raven", "Barb", "Clarita", "Shanon",
            "Nathanael", "Beverley", "Angelyn", "Chery", "Stewart", "Stefany", "Deja",
            "Norbert", "Cassaundra", "Erline", "Ping", "Roland", "Latesha", "Cari",
            "Jerica", "Eveline", "Marilou", "Elinor", "Ayako", "Ursula", "Mariko", "Tom",
            "Carlita", "Fannie", "Magan", "Alice", "Roscoe", "Lincoln", "Sunny", "Tim",
            "Belkis", "Gwendolyn", "Rosaura", "Lula", "Solange", "Sueann", "Kaleigh",
            "Lakesha", "Pennie", "Cassandra", "Ulrike", "Sommer", "Sonny", "Laure",
            "Rebekah", "Al", "Burma", "Takako", "Landon", "Svetlana", "Ingeborg", "Jack",
            "Mckenzie", "Elli", "Tiana", "Cassidy", "Cheryle", "Danyelle", "Tobias",
            "Mauro", "Felton", "Velda", "Allegra", "Mozella", "Aiko", "Lucinda", "Loyd",
            "Elicia", "Lenita", "Maryalice", "Kari", "Shenika", "Kitty", "Silvia",
            "Forest", "Marge", "Cammy", "Whitley", "Amos", "Winnifred", "Hui", "Cassie",
            "Faye", "Lorita", "Vonda", "Ebony", "Camille", "Sherise", "Cheri", "Gabriel",
            "Marilee", "Mendy", "Andria", "Beau", "Neoma", "Danuta", "Pansy", "Alden",
            "Dennis", "Rosendo", "Traci", "Fidelia", "Lang", "Mandy", "Jeanmarie",
            "Donny", "Piper", "Sheree", "Bobbie", "Olinda", "Bronwyn", "Joel", "Lucila",
            "Taylor", "Melissia", "Dave", "Rubie", "Kalyn", "Librada", "Verda", "Julie",
            "Norberto", "Lowell", "Denise", "Maricruz", "Nancy", "Lynetta", "Amparo",
            "Germaine", "Carita", "Hoa", "Justa", "Raleigh", "Joannie", "Albertha",
            "Clark", "Yee", "Lynsey", "Latonya", "Lawanda", "Crissy", "Sanda", "Tisha",
            "Elva", "Yesenia", "Elane", "Tonda", "Sharda", "Lessie", "Sherie", "Nolan",
            "Lemuel", "Jim", "Tomika", "Leroy", "Serafina", "Kaylee", "Evelia", "Emely",
            "Serina", "Kyoko", "Lai", "Charlsie", "Shera", "Jeana", "Miles", "Velma",
            "Nellie", "Jackie", "Angle", "Luz", "Ronny", "Gertude", "Hiram", "Marquetta",
            "Albina", "Dannette", "Helen", "Delilah", "Raymond", "Willetta", "Tomoko",
            "Kristian", "Tamara", "Patrica", "Matilda", "Ines", "Sebastian", "Jina",
            "Marilu", "Shaniqua", "Maire", "Veola", "Velvet", "Jenee", "Craig", "Felisa",
            "Manuel", "Stanley", "Alfonzo", "Shanel", "Lakisha", "Sarita", "Alycia",
            "Jenny", "Gisela", "Adriane", "Kayce", "Annett", "Emelda", "Elin", "Shirly",
            "Lewis", "Bobbi", "Alison", "Delisa", "Leila", "Brandon", "Marcelino",
            "Matt", "Tiara", "Linnie", "Glenda", "Zella", "Quinton", "Arron", "Mittie",
            "Mirtha", "Nancey", "John", "Thom"
        };

        static string[] lastNames =
        {
            "Callender", "Mcfadin", "Shellhammer", "Reel", "Reddix", "Mclamb", "Arnone",
            "Kerekes", "Canning", "Brouse", "Galan", "Emerick", "Vernon", "Lu", "Ginter",
            "Holliman", "Pridgen", "Bewley", "Nevius", "Mcsorley", "Caruana", "Palmieri",
            "Arteaga", "Colosimo", "Straughan", "Zabriskie", "Rabe", "Cluff", "Corbett",
            "Houge", "Tibbetts", "Shehorn", "Covell", "Palmore", "Ruffner", "Erskine",
            "Doyon", "Vales", "Fails", "Fripp", "Kirschner", "Bunde", "Eberhard", "Oda",
            "Archibald", "Dalke", "Huggard", "Willaert", "Ostrem", "Ching", "Alcocer",
            "Boardman", "Blatt", "Prim", "Rickel", "Blasko", "Rust", "Kinghorn", "Bracy",
            "Kaba", "Clifford", "Ivory", "Ruppel", "Scheidler", "Pickrell", "Pressley",
            "Goldstein", "Mccotter", "Boller", "Fujii", "Clemans", "Heine", "Riter",
            "Robichaud", "Mohn", "Bailer", "Hisey", "Hilley", "Texeira", "Bergey",
            "Herbert", "Fullerton", "Such", "Samsel", "Marsh", "Alexandre", "Mixon",
            "Knickerbocker", "Feldmann", "Browder", "Rudie", "Heister", "Sandlin",
            "Mckeighan", "Dezern", "Stabile", "Woodring", "Czapla", "Roloff", "Kasprzak",
            "Jorgenson", "Kardos", "Pascale", "Slay", "Glancy", "Broaden", "Kossman",
            "Reiher", "Desouza", "Feola", "Belin", "Boykins", "Salim", "Stickle",
            "Mattes", "Pacheo", "Crotts", "Learned", "Mccracken", "Hanning", "Price",
            "Bolte", "Paulino", "Islam", "Palka", "Jefferson", "Farabee", "Bizier",
            "Raine", "Poovey", "Spiess", "Strock", "Danko", "Lanphear", "Rounds", "Giel",
            "Brousseau", "Mckeithan", "Hibbs", "Goforth", "Uchida", "Brummitt", "Anwar",
            "Kroon", "Tremaine", "Saunder", "Marvel", "Garling", "Bradsher", "Deblasio",
            "Billingsly", "Walla", "Bickett", "Sheroan", "Goya", "Derry", "Ottman",
            "Bane", "Ordway", "Abrams", "Kubacki", "Gaertner", "Gleaton", "Hulsey",
            "Maser", "Paik", "Breeden", "Naugle", "Neer", "Johannsen", "Felton", "Eger",
            "Leyden", "Keane", "Cerutti", "Ancheta", "Buckler", "Reuben", "Consiglio",
            "Porco", "Marotta", "Maciejewski", "Derbyshire", "Stein", "Parmelee", "Row",
            "Letellier", "Helberg", "Bausch", "Cato", "Matsumura", "Heyen", "Krupp",
            "Lacasse", "Perfecto", "Gaytan", "Brandenberger", "Sprankle", "Pierpont",
            "Kearns", "Mendivil", "Delmont", "Lashbrook", "Jonson", "Kawamoto", "Unrein",
            "Bobadilla", "Gardella", "Sassman", "Brier", "Hu", "Balentine", "Krieg",
            "Molter", "Strachan", "Draheim", "Dahlke", "Goetsch", "Bucci", "Nuckolls",
            "Buchheit", "Haake", "Dudas", "Sonnenberg", "Sypher", "Macauley", "Basden",
            "Orona", "Evins", "Stump", "Norcross", "Turnage", "Mchone", "Mullenax",
            "Manna", "Mcquiggan", "Depp", "Soja", "Brownfield", "Rudisill", "Fegley",
            "Coulombe", "Yarnall", "Rubino", "Hepfer", "Baysinger", "Koffler","Crick",
            "Stransky", "Spriggs", "Vanmatre", "Genovese", "Cajigas", "Daves", "Garces",
            "Arrowsmith", "Shanklin", "Lamberson", "Pokorny", "Corlew", "Castaldi",
            "Amoroso", "Stoughton", "Voorhies", "Hutchens", "Gauthier", "Pryor", "Tobin",
            "Mcmains", "Proctor", "Fillmore", "Ellett", "Jin", "Branum", "Sillman",
            "Bakos", "Enoch", "Hypolite", "Abels", "Warfield", "Behan", "Peppler",
            "Hopper", "Malbon", "Navarro", "Gettings", "Spurrier", "Bilal", "Rochelle",
            "Mccay", "Scholze", "Pitcock", "Judy", "Leone", "Grillo", "Tienda",
            "Hammersley", "Tavernier", "Cowans", "Strang"
        };
        #endregion

        public static string GetFirst()
        {
            Random rand = new Random();
            return firstNames[rand.Next(0, FIRST_NAME_SIZE)];
        }

        public static string GetLast()
        {
            Random rand = new Random();
            return lastNames[rand.Next(0, LAST_NAME_SIZE)];
        }

        public static string Get()
        {
            Random rand = new Random();
            return firstNames[rand.Next(0, FIRST_NAME_SIZE + 1)] +
                " " + lastNames[rand.Next(0, LAST_NAME_SIZE + 1)];
        }
    }
}
