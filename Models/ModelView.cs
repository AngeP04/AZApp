using AZapp;

public class ImageQuestion
{
    public string Name { get; set; }
    public string Selection { get; set; } // "I","H","W","P"
    public PCs pc { get; set; }
}

public class ModelView
{
    public string member { get; set; }
    public List<ImageQuestion> Questions { get; set; } = new();
    public WishList UploadedWL = new WishList();
    public Dictionary<string, string> Color = new Dictionary<string, string>();
    public Dictionary<string, string> IntroPage = new Dictionary<string, string>();
    public List<string> Albums = ["Treasure Ep.1: All to Zero", "Treasure Ep.2: Zero to One", "Treasure Ep.3: One to All",
    "Treasure Ep.Fin: All to Action", "Treasure Epilogue: Action to Answer", "Treasure Ep.Extra: Shift The Map", "Treasure Ep. Map to Answer",
    "Zero : Fever Part 1", "Zero : Fever Part 2", "Season Songs", "Into the A to Z", "Zero : Fever Part 3",
    "Dreamers", "BEYOND : ZERO", "Zero : Fever Epilogue", "Travel Package", "The World Ep.1: Movement", "THE WORLD EP.PARADIGM",
    "LIMITLESS", "Spin Off: From the Witness", "The World Ep.2: OUTLAW", "THE WORLD EP.FIN : WILL ", "GOLDEN HOUR : Part. 1",
    "NOT OKAY", "Birthday", "GOLDEN HOUR : Part. 2", "Aniteez", "Merch"];

    public ModelView()
    {

        Color.Add("2nd Anniversary", "#F4A7A7");
        Color.Add("4nologue", "#F4B6A7");
        Color.Add("Allmd", "#F4C6A7");
        Color.Add("Aniteez", "#F4D6A7");
        Color.Add("Apple Music", "#F4E6A7");
        Color.Add("Atiny Fankit", "#E6F4A7");
        Color.Add("Atiny Room", "#dcf086ff");
        Color.Add("Atiny's voyage fanmeeting", "#D6F4A7");
        Color.Add("B&B exclusive", "#C6F4A7");
        Color.Add("Beatroad", "#B6F4A7");
        Color.Add("Bonus exclusive", "#A7F4AD");
        Color.Add("BStage", "#A7F4BD");
        Color.Add("Cafe BOMBOM", "#A7F4CD");
        Color.Add("Cashbee", "#7be0c2ff");
        Color.Add("Cawaii! Men magazine", "#A7F4ED");
        Color.Add("CGV", "#7ae4f0ff");
        Color.Add("CREA", "#A7DCF4");
        Color.Add("CU", "#A7CCF4");
        Color.Add("Dear my muse", "#A7BCF4");
        Color.Add("DelMundo", "#A7ACF4");
        Color.Add("Destiny's Memories", "#a18eebff");
        Color.Add("DICON", "#C7A7F4");
        Color.Add("Digipack", "#D7A7F4");
        Color.Add("DMC music", "#E7A7F4");
        Color.Add("EU exclusive", "#fa75eaff");
        Color.Add("Everline", "#F4A7DB");
        Color.Add("Fanplee", "#d869b5ff");
        Color.Add("Fnac exclusive", "#f084ceff");
        Color.Add("Fromm store", "#F4A7CB");
        Color.Add("Harajuku XYZ", "#f17596ff");
        Color.Add("Hello82", "#F4A7AB");
        Color.Add("Hellolive", "#F4BFA7");
        Color.Add("HMV", "#f5af65ff");
        Color.Add("HotTracks", "#F4DFA7");
        Color.Add("House of Kpop", "#F4EFA7");
        Color.Add("Idol Radio", "#E9F4A7");
        Color.Add("Indie exclusive", "#D9F4A7");
        Color.Add("In Dreamland", "#c982ebff");
        Color.Add("In Illusion", "#80c7ddff");
        Color.Add("In Treasure", "#f3b564ff");
        Color.Add("Interasia", "#C9F4A7");
        Color.Add("International Album", "#9ddb6eff");
        Color.Add("Japan Fanclub", "#B9F4A7");
        Color.Add("Japenese Album", "#6cc8d4ff");
        Color.Add("Joeun Music", "#A7F4B8");
        Color.Add("John Varvatos", "#78ecaaff");
        Color.Add("Jump up ENT", "#A7F4C8");
        Color.Add("KAURA", "#A7F4D8");
        Color.Add("Kcon", "#79e9d8ff");
        Color.Add("Kmonstar", "#A7E4F4");
        Color.Add("KNPOPS", "#A7D4F4");
        Color.Add("Kpop Store", "#A7C4F4");
        Color.Add("KQ shop", "#A7B4F4");
        Color.Add("KTOWN4U", "#AFA7F4");
        Color.Add("Makestar", "#BFA7F4");
        Color.Add("MBC Music Festival", "#CFA7F4");
        Color.Add("Merch", "#d375f5ff");
        Color.Add("Mernel", "#cb86e4ff");
        Color.Add("Mini Record", "#EFA7F4");
        Color.Add("MK Media", "#F4A7E3");
        Color.Add("MMT", "#F4A7D3");
        Color.Add("Mokketshop", "#F4A7C3");
        Color.Add("Mukbang", "#F4A7B3");
        Color.Add("Music Art", "#f0888cff");
        Color.Add("Music Korea", "#F4B7A9");
        Color.Add("Music Plant", "#F4C7A9");
        Color.Add("Nacific", "#F4D7A9");
        Color.Add("Neotokyo", "#F4E7A9");
        Color.Add("Neowing", "#E7F4A9");
        Color.Add("Olive Young", "#D7F4A9");
        Color.Add("OTK Music", "#C7F4A9");
        Color.Add("OWHAT", "#B7F4A9");
        Color.Add("Pepsi", "#A9F4B3");
        Color.Add("Perrier", "#7af3a5ff");
        Color.Add("Picture Vinyl", "#6ce7b2ff");
        Color.Add("Pop-up exclusive", "#A9F4E3");
        Color.Add("POTTS", "#A9E3F4");
        Color.Add("Rakuten", "#A9D3F4");
        Color.Add("Shop in shop", "#A9C3F4");
        Color.Add("Soundwave", "#A9B3F4");
        Color.Add("Subk shop", "#B7A9F4");
        Color.Add("Summer vacation Camp", "#af85f0ff");
        Color.Add("Superstar", "#D7A9F4");
        Color.Add("Synnara", "#E7A9F4");
        Color.Add("Target exclusive", "#F4A9E9");
        Color.Add("The Fellowship Tour", "#F4A9D9");
        Color.Add("The Sandbox", "#f58bb9ff");
        Color.Add("Tokopedia", "#F4A9B9");
        Color.Add("Toktoq", "#F4A9A9");
        Color.Add("Toward the Light Tour", "#F4B9A9");
        Color.Add("Tower Records", "#f3bb91ff");
        Color.Add("Travel Package", "#F4D9A9");
        Color.Add("TreasureCafe", "#F4E9A9");
        Color.Add("Unikon", "#e7f792ff");
        Color.Add("Universal", "#d0fa88ff");
        Color.Add("Urban Outfitters", "#C9F4A9");
        Color.Add("US exclusive", "#B9F4A9");
        Color.Add("Walmart Exclusive", "#8bf5a2ff");
        Color.Add("Whosfan cafe", "#A9F4C9");
        Color.Add("WithDrama", "#A9F4D9");
        Color.Add("Withmuu", "#83dacdff");
        Color.Add("Wonderwall", "#A9E9F4");
        Color.Add("WW", "#9fcbe6ff");
        Color.Add("XR concert", "#A9C9F4");
        Color.Add("Yes24", "#F4A7A7");
        Color.Add("Y Global", "#e76caaff");
        Color.Add("YZY", "#874aa3ff");
        Color.Add("Zero: Fever Series", "#7acee7ff");
        Color.Add("KHJ-fond", "#feae69");
        Color.Add("KHJ-tour", "#dd7155");
        Color.Add("PSH-fond", "#f9d4e5");
        Color.Add("PSH-tour", "#f484b6");
        Color.Add("JYH-fond", "#ffecc1");
        Color.Add("JYH-tour", "#c59b67ff");
        Color.Add("KYS-fond", "#fefef2");
        Color.Add("KYS-tour", "#c4a895ff");
        Color.Add("CSN-fond", "#d6c5e5");
        Color.Add("CSN-tour", "#8479b8ff");
        Color.Add("SMG-fond", "#fff78a");
        Color.Add("SMG-tour", "#f1c24aff");
        Color.Add("JWY-fond", "#5f5f61ff");
        Color.Add("JWY-tour", "#322c2c");
        Color.Add("CJH-fond", "#d78766");
        Color.Add("CJH-tour", "#8f513dff");

        IntroPage.Add("KHJ-name", "Kim Hongjoong");
        IntroPage.Add("KHJ-prg", "Here is the list of PCs of Kim Hongloong, our captain. He's born November the 7th 1998. He's the leader of Ateez but also the main rapper, singer and composer. His Aniteez is a squirrel named Jjoongrami. Hongjoong has been the global brand ambassador of the renowned French fashion brand Balmain since September 5th, 2023. He loves listening to music and composing. His speciality is reforming clothes. He is considered the dad of the group. He writes all of his own raps. Uses a laugh/giggle to introduce his rapping in most of Ateez's songs. Hongjoong is a member of the Matz line with Seongwha. He is a strong advocate for social justice issues, which led Ateez to become ambassadors of the Polished Male campaign which brings awareness to violence against children. Someone stole his Macbook during KQ Fellaz US training, he got it back but all the data was erased so he had to record everything again. He has 7 (even more now) ear piercings. His microphone is white.");
        IntroPage.Add("PSH-name", "Park Seonghwa");
        IntroPage.Add("PSH-prg", "Here is the list of PCs of Park Seonghwa. His dream is to become a model. He always grew his hair long during pre-debut to cover his face because he was insecure. He is considered the mom of the group. He’s a vocalist and visual of the group. He’s born April the 3rd 1998. His nicknames are Mars, Angrybird and Toothless. He is the oldest member. He likes to watch dramas, build action action figures, clean and play games. He was supposed to debut as a rapper but changed to vocalist. He’s a member of the Matz line with Hongjoong.  Seongwha is aware of Atiny's comments on social media and will often reference them in lives. He acted in Imitation as Sparkling member Nam Se Young. Seonghwa described his fashion style as « genderless, slender, and sleek ». He loves Star Wars and doing LEGO. His Aniteez is a rabbit named Ddeongbyeoli. His microphone is silver. ");
        IntroPage.Add("JYH-name", "Jeong Yunho");
        IntroPage.Add("JYH-prg", "Here is the list of PCs of Jeong Yunho. He has a high rank in Valorant, on par with pro players. He is a vocalist and a performer. He is born March 23rd 1999. His nicknames are Yunhogizer and Golden retriever. He loves playing with other members, gaming, sport and Spiderman. He is long time friend with Mingi.  Yunho’s lifetime motto is « Let’s do our best rather than being the best ». He is the second member to join Ateez. Yunho acted in Imitation as the second male lead and Sparkling member, Lee You Jin. He’s the tallest of the group (186 cm). He’s also the energizer of the group. His Aniteez is a golden retriever named Tyudeongi. His secret talent is that he can juggle. Yunho is a Potterhead and even has a wand that he bought in Japan.  Yunho's microphone color is blue. He originally wanted white but decided to let Hongjoong have it. According to the members, Yunho is the hardest one to wake up in the morning. ");
        IntroPage.Add("KYS-name", "Kang Yeosang");
        IntroPage.Add("KYS-prg", "Here is the list of PCs of Kang Yeosang. He is a vocalist, performer and visual. He’s born June 15th 1999. He has a birthmark on his left eye. Yeosang releases his anger by skateboarding. He used to be a cheerleader. He has a dry sense of humor and is known as the « speaker of facts ». He likes drones. When he was young, he wanted to be a novelist. His Aniteez is a dog named Hetmongi. His microphone is red. His hobbies are flying drones, snowboarding, and applying facial masks. He loves sweet foods. He used to be insecure about his voice due to his lisp but he’s getting more confident. Wooyoung joined kq to follow Yeosang and even though they dont mention it much yeosang was really grateful for him. If he seems so reserved, it’s because he’s actually an introvert. Yeosang maintains a count on his phone of how many times he's practicing and everyday he tries to up that number.");
        IntroPage.Add("CSN-name", "Choi San");
        IntroPage.Add("CSN-prg", "Here is the list of PCs of Choi San. He is the lead vocalist and lead dancer. He’s born July 10th 1999. He likes to sleep and do sports. He really likes plushies and often carries with him one named Shiber. San is fluent in English. He used to write songs but stopped in order to focus on getting better at dance because when he started out he was not a good dancer. San is good friends with Wooyoung and their friendship name is Woosan. They have a moto, « Amicus Ad Aras », which means a friend until the very end, which they have tatooed. Acted in Imitation as Sparkling member, Min Soo. He’s good at taekwondo (black belt) since his dad owns a studio. He has a cat named Byeol (Star). His Aniteez is a cact named Sandeoki. His microphone is gold.");
        IntroPage.Add("SMG-name", "Song Mingi");
        IntroPage.Add("SMG-prg", "Here is the list of PCs of Song Mingi. In 2020, Mingi went on hiatus for 8 months due to anxiety disorders. He is the main rapper, lead dancer and performer. He’s born August 9th 1999. Was friends with Yunho prior to joining Ateez as they attended Seungri's Dance Academy together. He is scared of bugs. Mingi writes all of his own raps. HE begins most of them with « Fix on » so listeners focus in and also as a play on his last name, Song. He showed his abs for the first time after his hiatus at MAMA 2019. His Aniteez is a bird named Bbyongming. His microphone is grey.");
        IntroPage.Add("JWY-name", "Jung Wooyoung");
        IntroPage.Add("JWY-prg", "Here is the list of PCs of Jung Wooyoung. He is a vocalist and main dancer. He’s born November 26th 1999. Former BigHit trainee with Yeosang, he moved to KQ Entertainment with him so they could debut together. He’s good friends with San and their friendship name is Woosan. They have a moto, « Amicus Ad Aras », which means a friend until the very end, which they have tatooed. He is the noisiest member. He cooks really well. His Aniteez is a cat named Wooyonyang. His microphone is black. According to Yunho, Wooyoung gives a sexy aura on stage, but is very playful and very cool offstage. Wooyoung' skills include touching his nose with his tongue and having a stretchable skin. Wooyoung’s motto is « Don't rush, don't give up ». His previous one was « Let’s be happy ».");
        IntroPage.Add("CJH-name", "Choi Jongho");
        IntroPage.Add("CJH-prg", "Here is the list of PCs of Choi Jongho. He is the main vocalist and Maknae of the group. He’s born October 12th 2000. He likes playing pool. His speciality is arm wrestling, singing, playing soccer, splitting apples and acting. He is left-handed. If he didn’t become a singer he would have become a sport star. Jongho’s lifetime motto is « Do not be afraid if you have not even tried ». He likes to be known as the « Maknae on top ». Although he is the Maknae, he is one of the most mature members of the group. Jongho has an incredibly large vocal range A2 to C6. He is incredibly strong and can break apples in half with his hands, often while singing beautifully. He likes to read. His member said that he’s loud because he’s always singing. His Aniteez is a bear named Jjongbear. His microphone is purple.");
    }

}