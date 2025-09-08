using AZapp;

public class ModelView
{
    public string member { get; set; }
    public List<List<string>> ListPCMember = new List<List<string>>();
    public List<PCs> ListPCs = new List<PCs>();
    public WishList UploadedWL = new WishList();
    public Dictionary<string, string> Color = new Dictionary<string, string>();
    public Dictionary<string, string> IntroPage = new Dictionary<string, string>();

    public ModelView()
    {
        Color.Add("International Album", "#a6cee3");
        Color.Add("Japenese Album", "#fb9a99");
        Color.Add("4nologue", "#b2df8a");
        Color.Add("Allmd", "#fdbf6f");
        Color.Add("Apple Music", "#cab2d6");
        Color.Add("B&B exclusive", "#ffff99");
        Color.Add("Dear my muse", "#4aa1dbff");
        Color.Add("Digipack", "#73d36dff");
        Color.Add("DMC music", "#e23134ff");
        Color.Add("EU exclusive", "#fa9b3dff");
        Color.Add("Everline", "#9467bd");
        Color.Add("Fromm store", "#f4a261");
        Color.Add("Hello82", "#e377c2");
        Color.Add("Hellolive", "#bcbd22");
        Color.Add("HMV", "#17becf");
        Color.Add("Japan Fanclub", "#df5153ff");
        Color.Add("Jump up ENT", "#5e91bbff");
        Color.Add("KNPOPS", "#71d66dff");
        Color.Add("Kpop Store", "#984ea3");
        Color.Add("KTOWN4U", "#f781bf");
        Color.Add("Makestar", "#fc8d62");
        Color.Add("Mini Record", "#999999");
        Color.Add("MK Media", "#66c2a5");
        Color.Add("MMT", "#8da0cb");
        Color.Add("Mokketshop", "#e78ac3");
        Color.Add("Music Art", "#a6d854");
        Color.Add("Music Plant", "#ffe261ff");
        Color.Add("Pop-up exclusive", "#e5c494");
        Color.Add("Rakuten", "#1b9e77");
        Color.Add("Soundwave", "#7570b3");
        Color.Add("Synnara", "#f053a4ff");
        Color.Add("Target exclusive", "#72a537ff");
        Color.Add("Toktoq", "#f3cd65ff");
        Color.Add("Tower Records", "#2a9d8f");
        Color.Add("Travel Package", "#61b4e7ff");
        Color.Add("Universal", "#ec7ae7ff");
        Color.Add("US exclulsive", "#b3b3b3");
        Color.Add("Walmart Exclusive", "#d18c57ff");
        Color.Add("Withmuu", "#666666");
        Color.Add("Wonderwall", "#ffff6dff");
        Color.Add("Yes24", "#874aa3ff");
        Color.Add("YZY", "#e76caaff");
        Color.Add("KHJ-fond", "#feae69");
        Color.Add("KHJ-tour", "#dd7155");
        Color.Add("PSH-fond", "#f9d4e5");
        Color.Add("PSH-tour", "#f484b6");
        Color.Add("JYH-fond", "#ffecc1");
        Color.Add("JYH-tour", "#e4b57cff");
        Color.Add("KYS-fond", "#fefef2");
        Color.Add("KYS-tour", "#e0c3b0ff");
        Color.Add("CSN-fond", "#d6c5e5");
        Color.Add("CSN-tour", "#8479b8ff");
        Color.Add("SMG-fond", "#fff78a");
        Color.Add("SMG-tour", "#f1c24aff");
        Color.Add("JWY-fond", "#5f5f61ff");
        Color.Add("JWY-tour", "#322c2c");
        Color.Add("CJH-fond", "#d78766");
        Color.Add("CJH-tour", "#8f513dff");

        IntroPage.Add("KHJ-name", "Kim Hongjoong");
        IntroPage.Add("KHJ-prg", "Here is the list of PCs of Kim Hongloong, our captain. He's born November the 7th 1998, in Anyang, South Korea. He's the leader of Ateez but also main rapper, singer and composer. His Aniteez is a squirrel named Jjoongrami. Hongjoong has been the global brand ambassador of the renowned French fashion brand Balmain since September 5th, 2023.");
        IntroPage.Add("PSH-name", "Park Seonghwa");
        IntroPage.Add("PSH-prg", "Here is the list of PCs of Park Seonghwa");
        IntroPage.Add("JYH-name", "Jeong Yunho");
        IntroPage.Add("JYH-prg", "Here is the list of PCs of Jeong Yunho");
        IntroPage.Add("KYS-name", "Kang Yeosang");
        IntroPage.Add("KYS-prg", "Here is the list of PCs of Kang Yeosang");
        IntroPage.Add("CSN-name", "Choi San");
        IntroPage.Add("CSN-prg", "Here is the list of PCs of Choi San");
        IntroPage.Add("SMG-name", "Song Mingi");
        IntroPage.Add("SMG-prg", "Here is the list of PCs of Song Mingi");
        IntroPage.Add("JWY-name", "Jung Wooyoung");
        IntroPage.Add("JWY-prg", "Here is the list of PCs of Jung Wooyoung");
        IntroPage.Add("CJH-name", "Choi Jongho");
        IntroPage.Add("CJH-prg", "Here is the list of PCs of Choi Jongho");
    }

}