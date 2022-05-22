using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Quest
{
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
		
	 
		public Quest(string QuestName, string QuestDescription, string EndSceneIdentifier, string QuestReward, double QuestStatus)
		{
		this.QuestName = QuestName;
		this.QuestDescription = QuestDescription;	
		this.EndSceneIdentifier = EndSceneIdentifier;
		this.QuestReward = QuestReward;
		this.QuestStatus = QuestStatus;
		}

}
