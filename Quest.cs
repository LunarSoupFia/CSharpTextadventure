using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Quest
{
	
		public string QuestName
		{
			get { return QuestName; }
			set { QuestName = value; }
		}
		public string QuestDescription
		{
			get { return QuestDescription; }
			set { QuestDescription = value; }
		}
		public string EndSceneIdentifier
		{
			get { return EndSceneIdentifier; }
			set { EndSceneIdentifier = value; }
		}
		public string QuestReward
		{
			get { return QuestReward; }
			set { QuestReward = value; }
		}

		public Quest(string Name, string Description, string Identifier, string Reward)
		{
		this.QuestName = Name;
		this.QuestDescription = Description;	
		this.EndSceneIdentifier = Identifier;
		this.QuestReward = Reward;
		}

}
