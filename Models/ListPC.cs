public class ListPC
{
    public List<List<string>> KHJ = new List<List<string>>();
    public List<List<string>> PSH = new List<List<string>>();
    public List<List<string>> JYH = new List<List<string>>();
    public List<List<string>> KYS = new List<List<string>>();
    public List<List<string>> CSN = new List<List<string>>();
    public List<List<string>> SMG = new List<List<string>>();
    public List<List<string>> JWY = new List<List<string>>();
    public List<List<string>> CJH = new List<List<string>>();

    public ListPC()
    {
        List<string> albums = ["PirateKing", "SayMyName", "IllusionVer", "WaveVer", "TreasureFinAVer", "TreasureFinZVer",
        "1stAnnivAdult", "1stAnnivBaby", "Treasure1AVer", "Treasure1ZVer", "Inception1", "Inception2", "Thanxx1",
        "Thanxx2", "ZeroFever1Diary", "ZeroFever2A1", "ZeroFever2A2", "ZeroFever2ALimited", "ZeroFever2Diary1",
        "ZeroFever2Diary2", "ZeroFever2DiaryLimited", "ZeroFever2Z1", "ZeroFever2Z2", "ZeroFever2ZLimited", "SeasonSongs1",
        "SeasonSongs2", "SeasonSongsUnit", "ZeroFever3A1", "ZeroFever3A2", "ZeroFever3ALimited", "ZeroFever3Diary1", "ZeroFever3Diary2",
        "ZeroFever3DiaryLimited", "ZeroFever3Z1", "ZeroFever3Z2", "ZeroFever3ZLimited", "ZeroFeverEpilogueA1", "ZeroFeverEpilogueA2",
        "ZeroFeverEpilogueALimited", "ZeroFeverEpilogueDiary1", "ZeroFeverEpilogueDiary2", "ZeroFeverEpilogueDiaryLimited",
        "ZeroFeverEpilogueZ1", "ZeroFeverEpilogueZ2", "ZeroFeverEpilogueZLimited", "World1A1", "World1A2", "World1ALimited",
        "World1Diary1", "World1Diary2", "World1DiaryLimited", "World1Z1", "World1Z2", "World1ZLimited", "World1AID",
        "World1DiaryID", "World1ZID", "World1Digipack", "SpinOffA1", "SpinOffA2", "SpinOffAQR", "SpinOffAFave", "SpinOffZ1", "SpinOffZ2",
        "SpinOffZQR", "SpinOffZFave", "SpinOffWitness1", "SpinOffWitness2", "SpinOffWitness3", "World2A1", "World2A2", "World2A3",
        "World2Diary1", "World2Diary2Unit1", "World2Diary2Unit2", "World2Diary3Unit1", "World2Diary3Unit2", "World2Z1", "World2Z2",
        "World2Z3", "World2AAction", "World2DiaryAction", "World2ZAction", "World2Digipack1", "World2Digipack2", "World2Mini1",
        "World2Mini2", "World2Mini3", "World2Image1", "World2Image2", "World2Image3", "World2Image4", "World2Image5",
        "World2Image6", "World2PC1V1", "World2PC1V2", "World2PC1V3", "World2PC1V4", "World2PC2V1", "World2PC2V2", "World2PC3V1",
        "World2PC3V2", "WorldFinAVA", "WorldFinAVZ", "WorldFinDiaryVA", "WorldFinDiaryVZ", "WorldFinZVA", "WorldFinZVZ",
        "WorldFinDigipack", "WorldFinDigipackUSEU", "WorldFinStanding", "WorldFinMini", "WorldFinPhotocard", "WorldFinImage",
        "WorldFinPolaroid1", "WorldFinPolaroid2", "GoldenHour1AVA", "GoldenHour1AVZ", "GoldenHour1DiaryA", "GoldenHour1DiaryZ",
        "GoldenHour1ZVA", "GoldenHour1ZVZ", "GoldenHour1PocaQR", "GoldenHour1PocaImage", "GoldenHour1PocaPCA", "GoldenHour1PocaPCZ",
        "GoldenHour1PlatformMini", "GoldenHour1PlatformImage", "GoldenHour1PlatformPCA", "GoldenHour1PlatformPCZ", "GoldenHour1Digipack1",
        "GoldenHour1Digipack2", "GoldenHour1Digipack3", "GoldenHour1Digipack4", "GoldenHour1Digipack5", "GoldenHour1Digipack6",
        "GoldenHour1Digipack7", "GoldenHour1Digipack8", "GoldenHour2ToA", "GoldenHour2ToZ", "GoldenHour2DiaryA", "GoldenHour2DiaryZ",
        "GoldenHour2ForA", "GoldenHour2ForZ", "GoldenHour2PocaToQR", "GoldenHour2PocaToImage", "GoldenHour2PocaToA", "GoldenHour2PocaToZ",
        "GoldenHour2PocaDiaryQR", "GoldenHour2PocaDiaryImage", "GoldenHour2PocaDiaryA", "GoldenHour2PocaDiaryZ", "GoldenHour2PocaForQR",
        "GoldenHour2PocaForImage", "GoldenHour2PocaForA", "GoldenHour2PocaForZ", "GoldenHour2Digipack1", "GoldenHour2Digipack2",
        "GoldenHour2Digipack3", "GoldenHour2Digipack4", "GoldenHour2Digipack5", "GoldenHour2Digipack6"];
        List<string> POBs = ["OneToAllIllusion", "OneToAllWave","AllToActionA", "AllToActionZ", "ActionToAnswerA", "ActionToAnswerZ", "ZeroFever1Inception",
        "ZeroFever1Thanxx", "ZeroFever1DiaryMmt", "ZeroFever1KTOWN4U", "ZeroFever1Apple", "ZeroFever1Beatroad", "ZeroFever1Tokopedia",
        "ZeroFever1Soundwave", "ZeroFever1MusicKorea", "ZeroFever1HotTracks","ZeroFever1WithDrama", "ZeroFever1Yes24","ZeroFever1Mmt",
        "ZeroFever2AMmt", "ZeroFever2DiaryMmt", "ZeroFever2ZMmt", "ZeroFever2KTOWN4U", "ZeroFever2Apple", "ZeroFever2Makestar",
        "ZeroFever2MakestarHolo", "ZeroFever2Yes24", "ZeroFever2Synnara", "ZeroFever2OTK", "ZeroFever2YGlobalHolo", "ZeroFever2JoeunUnit1",
        "ZeroFever2JoeunUnit2", "ZeroFever2MusicKorea", "ZeroFever2MusicPlant", "ZeroFever2HotTracks", "ZeroFever2Mokketshop", "ZeroFever2Makestar2",
        "ZeroFever2Makestar2Holo", "ZeroFever2Mmt2", "ZeroFever2MKMediaUnit1", "ZeroFever2MKMediaUnit2", "ZeroFever2MKMediaUnit3", "ZeroFever2MusicArt",
        "ZeroFever2Beatroad2", "ZeroFever2Makestar3", "ZeroFever2Makestar3Holo", "ZeroFever2Mmt3", "ZeroFever2Yes242", "ZeroFever2MusicArt2",
        "ZeroFever2Rakuten", "SeasonSongsHello82", "SeasonSongsHello822", "ZeroFever3Mmt", "ZeroFever3KTOWN4U", "ZeroFever3Apple",
        "ZeroFever3MakestarHolo", "ZeroFever3Synnara", "ZeroFever3Mokketshop", "ZeroFever3Everline1", "ZeroFever3Everline2", "ZeroFever3KpopstoreHolo",
        "ZeroFever3Wonderwall", "ZeroFever3Hello82", "ZeroFever3SoundwaveLD", "ZeroFever3SoundwaveLD2", "ZeroFever3YGlobalHolo", "ZeroFever3SoundwaveLD20",
        "ZeroFever3SoundwaveLD202", "ZeroFever3Everline20", "ZeroFever3MusicArtLD", "ZeroFever3OWHAT", "ZeroFever3KTOWN4U2", "ZeroFever3KpopstoreHolo2",
        "ZeroFever3DearMyMuse", "ZeroFever3Makestar2", "ZeroFever3Hello822", "ZeroFever3Apple2", "ZeroFever3Mmt2", "ZeroFever3KpopstoreHolo3",
        "ZeroFever3Wonderwall2", "ZeroFever3Soundwave", "ZeroFever3WhosfanCafe", "ZeroFever3WhosfanCafeLD", "ZeroFever3Everline3", "ZeroFever3Apple3",
        "ZeroFever3Makestar3", "ZeroFever3KpopstoreHolo4","ZeroFever3Wonderwall3", "ZeroFever3Everline4", "ZeroFever3Mmt3", "ZeroFever3Soundwave2",
        "ZeroFever3Everline51", "ZeroFever3Everline52", "ZeroFever3Makestar4", "ZeroFever3HMV", "ZeroFever3Tower1", "ZeroFever3Tower2",
        "ZeroFeverEpilogueKTOWN4U", "ZeroFeverEpilogueApple", "ZeroFeverEpilogueMakestar", "ZeroFeverEpilogueSynnara", "ZeroFeverEpilogueKpopstoreHolo",
        "ZeroFeverEpilogueHello82", "ZeroFeverEpilogueWondewall", "ZeroFeverEpilogueMakestar2", "ZeroFeverEpilogueEverline", "ZeroFeverEpilogueMakestar3",
        "ZeroFeverEpilogueMakestar4", "ZeroFeverEpilogueMakestar5", "ZeroFeverEpilogueApple2", "ZeroFeverEpilogueKpopstoreHolo2",
        "ZeroFeverEpilogueWonderwall2", "ZeroFeverEpilogueMakestar6", "ZeroFeverEpilogueMakestarLD1", "ZeroFeverEpilogueMakestarLD2",
        "ZeroFeverEpilogueMakestarLD3", "ZeroFeverEpilogueKpopstoreHolo3", "ZeroFeverEpilogueWonderwall3", "ZeroFeverEpilogueMakestarHolo7",
        "ZeroFeverEpilogueMakestar8", "ZeroFeverEpilogueWonderwall4", "ZeroFeverEpilogueHello822", "ZeroFeverEpilogueTower", "TravelPackageChicago",
        "TravelPackageNY", "TravelPackageLA",
            "World1Hello82", "World1US", "World1Indie", "World1Bonus", "World1Hello82NY",
        "World1Apple", "World1Synnara", "World1Everline", "World1Soundwave", "World1Wonderwall1", "World1Wonderwall2", "World1Beatroad",
        "World1BeatroadHolo", "World1Makestar", "World1MakestarHolo", "World1WithmuuHolo", "World1KpopstoreHolo", "World1Tokopedia",
        "World1KQShop", "World1Beatroad2", "World1MokketShop", "World1SoundwaveLD", "World1SoundwaveLD2", "World1Withmuu2", "World1EverlinePopup1",
        "World1EverlinePopup2", "World1Makestar2", "World1Makestar2Holo", "World1Soundwave2", "World1Wonderwall20", "World1Synnara2",
        "World1Yes241", "World1Yes242", "World1Apple2", "World1Makestar31", "World1Makestar32", "World1Kpopstore2", "World1Kpopstore2Holo",
        "World1Makestar4", "World1Soundwave3", "World1Everline2", "World1Wonderwall3", "World1Makestar5", "World1Makestar5Holo",
        "World1Everline3","World1Beatroad3", "World1Wonderwall4", "World1WonderwallUnit", "World1Yes2420", "World1Everline4", "World1Wonderwall5",
        "World1Apple3", "World1SoundwaveLD3", "World1WonderwallLD", "World1SoundwaveLD4", "World1SoundwaveLD5", "World1Beatroad41",
        "World1Beatroad42", "World1Yes2431", "World1Yes2432", "World1WonderwallLD2", "World1Makestar6", "World1Tower", "World1TowerPolaroid",
        "World1JFanclub", "TravelPackage1", "TravelPackage2", "TravelPackage3", "SpinOffUS", "SpinOffHello82Jewelry", "SpinOffHello82Glass",
        "SpinOffHello82Sun", "SpinOffHello82Torn", "SpinOffHello82Faded", "SpinOffHello82Celebration", "SpinOffHello82Hug", "SpinOffMakestar",
        "SpinOffMakestarHolo", "SpinOffWonderwall", "SpinOffSoundwave", "SpinOffEverline", "SpinOffBeatroad", "SpinOffMakestar2", "SpinOffMakestar31",
        "SpinOffMakestar32", "SpinOffMakestar4", "SpinOffMakestar51", "SpinOffMakestar52", "SpinOffMakestarLD1", "SpinOffMakestarLD2",
        "SpinOffMakestarLDUnit", "SpinOffMakestarLDSpecial", "SpinOffHello82London", "SpinOffHello82Madrid", "SpinOffHello82Copenhagen",
        "World2US", "World2EU", "World2Hello82O", "World2PopupU", "World2TargetT", "World2TargetL", "World2B&BA", "World2WalmartW",
        "World2MakestarHolo", "World2MakestarPolaroid", "World2Withmuu", "World2Apple", "World2Soundwave", "World2SoundwaveFilm", "World2Yes24",
        "World2Everline", "World2Fromm", "World2Mokket", "World2BStage", "World2MiniRecord", "World2MiniRecordLenti", "World2OliveYoung",
        "World2Makestar2", "World2Everline2", "World2Soundwave2", "World2MiniRecord2", "World2Withmuu2", "World2Fromm2", "World2Everline3",
        "World2MiniRecord3", "World2Makestar31", "World2Makestar32", "World2EverlineLD1", "World2EverlineLD2", "World2EverlineLD3", 
            "World2EverlineLD", "World2EverlineSpecial", "World2Kmonstar", "World2MiniRecordLD1", "World2MiniRecordLD2", "World2FrommLD1",
        "World2FrommLD2", "World2MiniRecord4", "World2SoundwaveLD1", "World2SoundwaveLD2", "World2Everline4", "World2WithmuuLD1",
        "World2WithmuuLD2", "World2WhosfancafeLD", "World24nologue", "World2SoundwaveLD21", "World2SoundwaveLD22", "World2FrommLD21",
        "World2FrommLD22", "World2MiniRecordLD20", "World2MiniRecordLD2Unit", "World2HouseOfKpop", "WorldHello82LA", "World2MiniRecordLD3",
        "World2MiniRecordLDSpecial", "World2MakestarLD", "World2MakestarLD1", "World2MakestarLDUnit", "World2Mmt", "World2EverlineLD21",
        "World2EverlineLD22", "World2MiniRecordLD41", "World2MiniRecordLD42", "World2Mmt2", "World2Mmt3", "World2Yzy1", "World2Yzy2",
        "World2MiniRecordLD5", "World2MiniRecordLD6", "World2MiniRecordLD7", "World2MiniRecordLD8", "World2MiniRecordLD9", "World2Universal",
        "World2UniversalLD", "World2Tower", "World2TowerLD", "World2Rakuten", "World2RakutenLD", "WorldFinHello82", "WorldFinHello82Exclusive",
        "WorldFinUS", "WorldFinEU", "WorldFinPopup", "WorldFinTarget", "WorldFinWalmart", "WorldFinB&B", "WorldFinUrbanOutfitters",
        "WorldFinHmvUK", "WorldFinVinyl", "WorldFinIndie", "WorldFinDigipackLimited", "WorldFinApple", "WorldFinAppleDigipack",
        "WorldFinSoundwave", "WorldFinSoundwaveDigipack", "WorldFinSoundwaveSpecial", "WorldFinKtown4u", "WorldFinKtown4uDigipack",
        "WorldFinMakestar", "WorldFinMakestarPolaroid", "WorldFinEverline", "WorldFinWithmuu", "WorldFinDearMyMuse", "WorldFinFromm",
        "WorldFinToktoq", "WorldFinToktoqDigipack", "WorldFinYes24", "WorldFinYes24Digipack", "WorldFinYzy", "WorldFinMiniRecord",
        "WorldFinMiniRecordTCA", "WorldFinMiniRecordTCB", "WorldFinMiniRecordTCC", "WorldFinMiniRecordTCD", "WorldFinMiniRecordDigipack",
        "WorldFinToktoqPlatform", "WorldFinToktoqSpecialUnit", "WorldFinDearMyMuseDigipack", "WorldFinMokket", "WorldFinMokketDigipack",
        "WorldFinOliveYoung", "WorldFinMakestar21", "WorldFinMakestar22", "WorldFinKnpops", "WorldFinSoundwave2", "WorldFinFromm2",
        "WorldFinPlantDigipack", "WorldFinEverline2", "WorldFinSoundwaveLD11", "WorldFinSoundwaveLD12", "WorldFinSoundwaveLD21", "WorldFinSoundwaveLD22",
        "WorldFinMiniRecord3", "WorldFinApple2", "WorldFinMakestarLD1", "WorldFinMakestarLD2", "WorldFinMakestarLD3", "WorldFinMakestarLDUnit1",
        "WorldFinMakestarLDUnit2", "WorldFinDearMyMuse2", "WorldFinWithmuu21", "WorldFinWithmuu22", "WorldFinWithmuuPolaroid", "WorldFinKnpops2",
        "WorldFinKtown4u2", "WorldFinArtLD", "WorldFinArtLDUnit", "WorldFinWithmuu3", "WorldFinYzy2", "WorldFinMakestar3", "WorldFinMiniRecord4",
        "WorldFinFromm3", "WorldFinEverlineLD", "WorldFinEverlineLDUnit", "WorldFinMokket2", "WorldFinSoundwave3", "WorldFinArt2", "WorldFinHellolive",
        "WorldFinFrommLD", "WorldFinFrommLDSpecial",
            "WorldFinEverline3", "WorldFinEverlineLD21", "WorldFinEverlineLD22", "WorldFinMiniRecordLD2",
        "WorldFinMiniRecordLDUnit", "WorldFinToktoqDigipack2", "WorldFinToktoqDigipackSpecial1", "WorldFinToktoqDigipackSpecial2", "WorldFinMakestar4",
        "WorldFinMakestarUnit", "WorldFinApple3", "WorldFinSoundwaveLD31", "WorldFinSoundwaveLD32", "WorldFinSoundwaveLDUnit", "WorldFinMiniRecord5",
        "WorldFinMokketLD1", "WorldFinMokketLD2", "WorldFinMokketDigipack3", "WorldFinMakestarLD20", "WorldFinFromm4", "WorldFinMiniRecord6",
        "WorldFinFromm5", "WorldFinNeotokyo", "WorldFinInterasia", "WorldFinDMC", "WorldFinMiniRecord7", "WorldFinYzy3", "WorldFinHelloliveLD",
        "WorldFinMakestar5", "WorldFinFromm6", "WorldFinMiniRecordLD3", "WorldFinMiniRecordLDID", "WorldFinHello82LA", "WorldFinToktoqLD",
        "WorldFinMiniRecordLD4", "WorldFinHMV", "WorldFinRakutenLD", "WorldFinTower", "WorldFinTowerLD", "WorldFinJFanclub", "WorldFinUniversalA",
        "WorldFinUniversalB", "WorldFinUniversalC", "WorldFinUniversalD", "GH1Hello82Hug", "GH1Hello82Bow", "GH1US", "GH1EU", "GH1PopupMukbang",
        "GH1TargetBite", "GH1TargetGolden", "GH1WalmartTanghulu", "GH1B&BDoodle", "GH1FnacIcecream", "GH1HMVHeart", "GH1DigipackPalm",
        "GH1ArtDigipack", "GH1Hellolive", "GH1Withmuu", "GH1Toktoq", "GH1ToktoqDigipack", "GH1Apple", "GH1Fromm", "GH1Knpops", "GH1DMC",
        "GH1SoundwaveDigipack", "GH1SoundwaveSpecial", "GH1Makestar", "GH1Allmd", "GH1Yes24", "GH1DearMyMuse", "GH1Jumpup", "GH1Minirecord",
        "GH1Makestar2", "GH1MakestarUnit", "GH1ToktoqPlatform", "GH1ToktoqPocaa", "GH1ToktoqUnit", "GH1Everline", "GH1Makestar3",
        "GH1Soundwave2", "GH1Fromm2", "GH1Hellolive2", "GH1Art2", "GH1Allmd2", "GH1Plant", "GH1Minirecord2", "GH1Everline2", "GH1Jumpup2",
        "GH1Makestar4", "GH1Apple2", "GH1MakestarLD1", "GH1MakestarLD2", "GH1MakestarLDSpecial1", "GH1MakestarLDSpecial2", "GH1MakestarLDSpecial3",
        "GH1MakestarLDSpecial4", "GH1Soundwave3", "GH1Makestar5", "GH1DMC2", "GH1Knpops2", "GH1Makestar6", "GH1MakestarUnit2", "GH1Fromm3",
        "GH1Fromm32", "GH1Makestar71", "GH1Makestar72", "GH1MakestarUnit3", "GH1AppleLD11", "GH1AppleLD12", "GH1HelloliveLD", "GH1EverlineLD",
        "GH1EverlineLD2", "GH1EverlineLDUnit", "GH1AllmdLD", "GH1Fromm4", "GH1ArtLD", "GH1Soundwave4", "GH1JumpupLD", "GH1JumpupLDUnit",
        "GH1AppleLD2", "GH1ApplePolaroid", "GH1Hello82LA", "GH1MakestarLD3", "GH1MakestarLD4", "GH1MakestarUnit4", "GH1Soundwave5",
        "GH1KnpopsLD", "GH1Soundwave6", "GH1Fromm5",
            "GH1AllmdLD2", "GH1AllmdLDUnit", "GH1EverlineLD21", "GH1EverlineLD22", "GH1JumpupLD21",
        "GH1JumpupLD22", "GH1JFanclub", "GH1Tower", "GH1TowerLD", "GH1RakutenLD", "GH1Universal", "GH1HMV", "TravelPackNY", "GH2Hello82Chain", "GH2USPearl",
        "GH2EULove", "GH2PopupSadpotato", "GH2TargetBullseye", "GH2TargetGolden", "GH2WalmartDestiny", "GH2B&BToast", "GH2FnacSparkling", "GH2HMVRacer",
        "GH2VinylRomantic", "GH2DigipackKiss", "GH2Toktoq", "GH2ToktoqDigipack", "GH2ToktoqPocaa", "GH2Fromm", "GH2FrommDigipack", "GH2Soundwave",
        "GH2Hellolive", "GH2HelloliveLenti", "GH2Makestar", "GH2Everline", "GH2Apple", "GH2Art", "GH2Fanplee", "GH2Yes24", "GH2Withmuu", "GH2Fromm2",
        "GH2Makestar2", "GH2Art2", "GH2Everline2", "GH2Apple2", "GH2Soundwave2", "GH2Hellolive2", "GH2Fanplee2", "GH2Plant", "GH2CU", "GH2MakestarLD1",
        "GH2MakestarLD2", "GH2MakestarLDUnit", "GH2AppleLD1", "GH2AppleLD2", "GH2ApplePolaroid", "GH2Jumpup", "GH2MinirecordLD1", "GH2MinirecordLD2",
        "GH2MinirecordLD3", "GH2Soundwave3", "GH2Apple3", "GH2AppleUnit", "GH2Makestar3", "GH2Fromm3", "GH2MakestarLD21", "GH2MakestarLD22",
        "GH2MakestarLDUnit2", "GH2JumpupLD1", "GH2JumpupLD2", "GH2JumpupLDUnit", "GH2Jumpup3", "GH2Fromm4", "GH2FrommUnit", "GH2DearMyMuse", "GH2ArtLD1",
        "GH2ArtLD2", "GH2Soundwave4", "GH2SoundwaveUnit", "GH2Makestar4", "GH2Fromm5", "GH2FanpleeLD1", "GH2FanpleeLD2", "GH2Makestar5", "GH2Fromm6",
        "GH2MinirecordLD20", "GH2MinirecordLDUnit", "GH2HelloliveLD", "GH2HelloliveLDSpecial", "GH2Withmuu21", "GH2Withmuu22", "GH2MinirecordLD30",
        "GH2MinirecordLDUnit2", "GH2Soundwave5", "GH2Fromm71", "GH2Fromm72", "GH2FrommUnit2", "GH2Makestar6", "GH2Art21", "GH2Art22", "GH2Makestar7",
        "GH2Soundwave6", "GH2Makestar8", "GH2Hello82Berlin", "GH2Makestar91", "GH2Makestar92", "GH2MakestarSpecial", "GH2JFanclub", "GH2Universal", "GH2Tower",
        "GH2TowerLD", "GH2HMV", "GH2HMVLD", "GH2Rakuten", "GH2RakutenLD"];
        List<string> Jalbums = ["TreasureFinA", "TreasureFinZ", "TreasureShiftA", "TreasureShiftZ", "TreasureMapA", "TreasureMapZ", "IntoAtoZRegular",
        "IntoAtoZLimited1", "IntoAtoZLimited2", "DreamersA", "DreamersB", "DreamersAtiny", "BeyondZeroA", "BeyondZeroB", "BeyondZeroAtiny",
        "ParadigmLimitedA", "ParadigmLimitedB", "ParadigmRegularA", "ParadigmRegularB", "ParadigmSoloA", "ParadigmSoloB", "ParadigmAtiny",
        "LimitlessA1", "LimitlessA2", "LimitlessB1", "LimitlessB2", "LimitlessNormalUnit1", "LimitlessNormalUnit2", "LimitlessAtiny1",
        "LimitlessAtiny2", "NotOkayA1", "NotOkayA2", "NotOkayB1", "NotOkayB2", "NotOkayC", "NotOkayD", "NotOkayE1", "NotOkayE2", "NotOkayAtiny1",
        "NotOkayAtiny2", "NotOkayAtinyUnit","BirthdayASolo", "BirthdayBSolo", "BirthdayAtiny1", "BirthdayAtiny2", "BirthdayAtiny3", 
        "BirthdayAtiny4", "BirthdayFlashPrice", "BirthdayRegular", "BirthdayALimited1", "BirthdayALimited2", "BirthdayBLimited1",
        "BirthdayBLimited2"];
        List<string> Jpobs = ["AllToActionTower", "IntoAToZPopUp1", "IntoAToZPopUp2", "DreamersTower", "DreamersShop1", "DreamersShop2",
        "BeyondZeroTowerClear", "BeyondZeroTowerPrizeA", "BeyondZeroTowerPrizeD", "BeyondZeroHMVHolo", "ParadigmTowerOfflineA", "ParadigmTowerOfflineB",
        "ParadigmTowerOnline", "ParadigmTowerOffline", "ParadigmTowerPolaroid", "ParadigmTowerLuckyDraw", "ParadigmHMVHolo", "LimitlessTowerClear",
        "LimitlessTowerPopUp", "LimitlessTowerPolaroid", "LimitlessTowerBadge", "LimitlessHMVHolo", "LimitlessHMVPolaroid", "LimitlessHMVCoupon",
        "NotOkayTower", "NotOkayTowerLuckyDraw", "NotOkayTowerShibuyaLD", "NotOkayFJFanClub", "NotOkayJFanClubSolo", "NotOkayRakuten",
        "NotOkayHMV", "NotOkayHMVLuckyDrawOnline", "NotOkayHMVLuckyDrawExclusive", "NotOkayHMVCoupon", "NotOkayGUniversal", "NotOkayUniversalLuckyDraw",
        "NotOkayUniversalVenue1", "NotOkayUniversalVenue2", "NotOkayTarget", "BirthdayJFanclubSolo", "BirthdayJFanclub", "BirthdayTower",
        "BirthdayTowerLuckyDraw", "BirthdayTowerShibuyaLD", "BirthdayUniversal", "BirthdayUniversalLuckyDraw", "BirthdayHMVOfflineLD",
        "BirthdayRakutenLuckyDraw", "BirthdayNeowing", "BirthdayTowerVenue1", "BirthdayTowerVenue2", "BirthdayHMVClear", "BirthdayHMVOnlineLD"];
        List<string> merch = ["KconJapan", "TreasureCafe", "DelMundoTreasureStamp", "KQshop20ID", "Perrier", "KQshopStar1117Perfume",
        "ZeroFever1MMTNametag", "ZeroFever1PopupLottery", "KQshopLightstick", "KQshopFellowshiptourDVD", "2ndAnniversaryPortofcallT",
        "2ndAnniversaryPortofcall2", "KQshopSG21", "KQshopSG21ID", "KQshopWishbracelet", "Atiny2FankitPolaroid1", "Atiny2FankitPolaroid2",
        "Atiny2FankitPolaroid3", "SubkshopA", "SubkshopDiary", "SubkshopZ", "SubkshopPolaroid1", "SubkshopPolaroid2", "KQshopCromerKeyring",
        "SummerVacCampLotteryClear1", "SummerVacCampLotteryClear2", "SummerVacCampLimited1", "SummerVacCampLimited2", "PepsiTasteofKorea",
        "WonderwallA", "WonderwallB","WonderwallC","KQshopHiddenMap11", "KQshopHiddenMap12", "KQshopHiddenMap13", "KQshopHiddenMap21",
        "KQshopHiddenMap22", "KQshopHiddenMap23", "KQshopSummerDecoBinder", ""];

        KHJ.Add(albums.Select(name => name + "KHJ").ToList());
        KHJ.Add(POBs.Select(name => name + "KHJ").ToList());
        KHJ.Add(Jalbums.Select(name => name + "KHJ").ToList());
        KHJ.Add(Jpobs.Select(name => name + "KHJ").ToList());
        KHJ.Add(merch.Select(name => name + "KHJ").ToList());

        PSH.Add(albums.Select(name => name + "PSH").ToList());
        PSH.Add(POBs.Select(name => name + "PSH").ToList());
        PSH.Add(Jalbums.Select(name => name + "PSH").ToList());
        PSH.Add(Jpobs.Select(name => name + "PSH").ToList());
        PSH.Add(merch.Select(name => name + "PSH").ToList());

        JYH.Add(albums.Select(name => name + "JYH").ToList());
        JYH.Add(POBs.Select(name => name + "JYH").ToList());
        JYH.Add(Jalbums.Select(name => name + "JYH").ToList());
        JYH.Add(Jpobs.Select(name => name + "JYH").ToList());
        JYH.Add(merch.Select(name => name + "JYH").ToList());

        KYS.Add(albums.Select(name => name + "KYS").ToList());
        KYS.Add(POBs.Select(name => name + "KYS").ToList()); 
        KYS[1].Remove("ZeroFever2MKMediaUnit3KYS");
        KYS.Add(Jalbums.Select(name => name + "KYS").ToList());
        KYS.Add(Jpobs.Select(name => name + "KYS").ToList());
        KYS.Add(merch.Select(name => name + "KYS").ToList());

        CSN.Add(albums.Select(name => name + "CSN").ToList());
        CSN.Add(POBs.Select(name => name + "CSN").ToList());
        CSN[1].Remove("ZeroFever2MKMediaUnit3CSN");
        CSN.Add(Jalbums.Select(name => name + "CSN").ToList());
        CSN.Add(Jpobs.Select(name => name + "CSN").ToList());
        CSN.Add(merch.Select(name => name + "CSN").ToList());

        SMG.Add(albums.Select(name => name + "SMG").ToList());
        SMG[0].Remove("ZeroFever2A1SMG");
        SMG[0].Remove("ZeroFever2A2SMG");
        SMG[0].Remove("ZeroFever2ALimitedSMG");
        SMG[0].Remove("ZeroFever2Diary1SMG");
        SMG[0].Remove("ZeroFever2Diary2SMG");
        SMG[0].Remove("ZeroFever2DiaryLimitedSMG");
        SMG[0].Remove("ZeroFever2Z1SMG");
        SMG[0].Remove("ZeroFever2Z2SMG");
        SMG[0].Remove("ZeroFever2ZLimitedSMG");
        SMG.Add(POBs.Select(name => name + "SMG").ToList());
        SMG[1].Remove("SMG");
        SMG.Add(Jalbums.Select(name => name + "SMG").ToList());
        SMG[2].Remove("IntoAtoZRegularSMG");
        SMG[2].Remove("IntoAtoZLimited1SMG");
        SMG[2].Remove("IntoAtoZLimited2SMG");
        SMG[2].Remove("DreamersASMG");
        SMG[2].Remove("DreamersBSMG");
        SMG[2].Remove("DreamersAtinySMG");
        SMG.Add(Jalbums.Select(name => name + "SMG").ToList());
        SMG[3].Remove("IntoAToZPopUp1SMG");
        SMG[3].Remove("IntoAToZPopUp2SMG");
        SMG[3].Remove("DreamersTowerSMG");
        SMG[3].Remove("DreamersShop1SMG");
        SMG[3].Remove("DreamersShop2SMG");
        SMG.Add(merch.Select(name => name + "SMG").ToList());
        SMG[4].Remove("SMG");

        JWY.Add(albums.Select(name => name + "JWY").ToList());
        JWY.Add(POBs.Select(name => name + "JWY").ToList());
        JWY.Add(Jalbums.Select(name => name + "JWY").ToList());
        JWY.Add(Jpobs.Select(name => name + "JWY").ToList());
        JWY.Add(merch.Select(name => name + "JWY").ToList());

        CJH.Add(albums.Select(name => name + "CJH").ToList());
        CJH.Add(POBs.Select(name => name + "CJH").ToList());
        CJH.Add(Jalbums.Select(name => name + "CJH").ToList());
        CJH.Add(Jpobs.Select(name => name + "CJH").ToList());
        CJH.Add(merch.Select(name => name + "CJH").ToList());
    }

    public List<string> PathList(List<string> list)
    {
        var basePath = "wwwroot/ImagesATEEZ/";
        List<string> paths = new List<string>();
        paths = list.Select(name => Path.Combine(basePath, name.Substring(name.Count() - 3, 3), name.Substring(0, name.Count() - 3) + ".png")).ToList();
        return paths;
    }
}