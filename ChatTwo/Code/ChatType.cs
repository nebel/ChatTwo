namespace ChatTwo.Code;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1028:Enum Storage should be Int32")]
public enum ChatType : ushort
{
    Debug = 1,
    Urgent = 2,
    Notice = 3,
    Say = 10,
    Shout = 11,
    TellOutgoing = 12,
    TellIncoming = 13,
    Party = 14,
    Alliance = 15,
    Linkshell1 = 16,
    Linkshell2 = 17,
    Linkshell3 = 18,
    Linkshell4 = 19,
    Linkshell5 = 20,
    Linkshell6 = 21,
    Linkshell7 = 22,
    Linkshell8 = 23,
    FreeCompany = 24,
    NoviceNetwork = 27,
    CustomEmote = 28,
    StandardEmote = 29,
    Yell = 30,

    // 31 - also party?
    CrossParty = 32,
    PvpTeam = 36,
    CrossLinkshell1 = 37,
    Damage = 41,
    Miss = 42,
    Action = 43,
    Item = 44,
    Healing = 45,
    GainBuff = 46,
    GainDebuff = 47,
    LoseBuff = 48,
    LoseDebuff = 49,
    Alarm = 55,
    Echo = 56,
    System = 57,
    BattleSystem = 58,
    GatheringSystem = 59,
    Error = 60,
    NpcDialogue = 61,
    LootNotice = 62,
    Progress = 64,
    LootRoll = 65,
    Crafting = 66,
    Gathering = 67,
    NpcAnnouncement = 68,
    FreeCompanyAnnouncement = 69,
    FreeCompanyLoginLogout = 70,
    RetainerSale = 71,
    PeriodicRecruitmentNotification = 72,
    Sign = 73,
    RandomNumber = 74,
    NoviceNetworkSystem = 75,
    Orchestrion = 76,
    PvpTeamAnnouncement = 77,
    PvpTeamLoginLogout = 78,
    MessageBook = 79,
    GmTell = 80,
    GmSay = 81,
    GmShout = 82,
    GmYell = 83,
    GmParty = 84,
    GmFreeCompany = 85,
    GmLinkshell1 = 86,
    GmLinkshell2 = 87,
    GmLinkshell3 = 88,
    GmLinkshell4 = 89,
    GmLinkshell5 = 90,
    GmLinkshell6 = 91,
    GmLinkshell7 = 92,
    GmLinkshell8 = 93,
    GmNoviceNetwork = 94,
    CrossLinkshell2 = 101,
    CrossLinkshell3 = 102,
    CrossLinkshell4 = 103,
    CrossLinkshell5 = 104,
    CrossLinkshell6 = 105,
    CrossLinkshell7 = 106,
    CrossLinkshell8 = 107,

    // Custom types:
    ExtraChatLinkshell1 = 1001,
    ExtraChatLinkshell2 = 1002,
    ExtraChatLinkshell3 = 1003,
    ExtraChatLinkshell4 = 1004,
    ExtraChatLinkshell5 = 1005,
    ExtraChatLinkshell6 = 1006,
    ExtraChatLinkshell7 = 1007,
    ExtraChatLinkshell8 = 1008,
}
