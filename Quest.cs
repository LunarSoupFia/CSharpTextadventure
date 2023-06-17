using System;

public class Quest
{
    private string _questIdentifier;
	public string QuestIdentifier
    {
		get { return _questIdentifier; }
		set { _questIdentifier = value; }
    }

    private string _questName;
	public string QuestName
		{
			get { return _questName; }
			set { _questName = value; }
		}
	private string _questDescription;	
	public string QuestDescription
		{
			get { return _questDescription; }
			set { _questDescription = value; }
		}
	private string _endSceneIdentifier;	
	public string EndSceneIdentifier
		{
			get { return _endSceneIdentifier; }
			set { _endSceneIdentifier = value; }
		}
	private string _questReward;
	public string QuestReward
		{
			get { return _questReward; }
			set { _questReward = value; }
		}

	private double _questStatus;
	public double QuestStatus 
		{
			get { return _questStatus; }
			set { _questStatus = value; }
		}
		
	 
		public Quest(string QuestIdentifier, string QuestName, string QuestDescription, string EndSceneIdentifier, string QuestReward, double QuestStatus)
		{
		this.QuestIdentifier = QuestIdentifier;
		this.QuestName = QuestName;
		this.QuestDescription = QuestDescription;	
		this.EndSceneIdentifier = EndSceneIdentifier;
		this.QuestReward = QuestReward;
		this.QuestStatus = QuestStatus;
		}

}
