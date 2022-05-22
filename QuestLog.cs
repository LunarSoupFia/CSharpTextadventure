using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class QuestLog
{
    private static string nl = Environment.NewLine;
    //
    // TODO: Add Quest Log logic here
    //
    private string _questLogTitle;

    public string QuestLogTitle
    {
        get { return _questLogTitle; }
        set { _questLogTitle = value; }
    }

    private string _questLogDescription;

    public string QuestLogDescription
    {
        get { return _questLogDescription; }
        set { _questLogDescription = value; }
    }

    private Quest[] _quests;
    public Quest[] Quests
    {
        get { return _quests; }
        set { _quests = value; }
    }

    public QuestLog(string QuestLogTitle, string QuestLogDescription, Quest[] Quests)
    {
        this.QuestLogTitle = QuestLogTitle;
        this.QuestLogDescription = QuestLogDescription;
        this.Quests = Quests;
    }
}
