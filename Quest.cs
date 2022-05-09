using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Quest
{
	public Quest()
	{
		//
		// TODO: Add constructor logic here
		//
		public string QuestName
		{
			get { return QuestName; }
		}
		public string QuestDescription
		{
			get { return QuestDescription; }
		}
		public string EndSceneIdentifier
		{
			get { return EndSceneIdentifier; }
		}
		public string QuestReward
		{
			get { return QuestReward; }
		}

		public Quest(string Name, string Description, string Identifier, string Reward)
    {
		this.QuestName = Name;
		this.QuestDescription = Description;	
		this.EndSceneIdentifier = Identifier;
		this.QuestReward = Reward;
    }

	}
}
