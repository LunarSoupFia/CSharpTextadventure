using System;
using System.Collections;
using Textadventure;

public class Scene
{
    private string _sceneIdentifier;

    public string SceneIdentifier
    {
        get { return _sceneIdentifier; }
        set { _sceneIdentifier = value; }
    }
    private string _sceneDescription;

    public string SceneDescription
    {
        get { return _sceneDescription; }
        set { _sceneDescription = value; }
    }
    private Option[] _options;
    public Option[] Options
    {
        get { return _options; }
        set { _options = value; }
    }

    private string _backgroundImage;

    public string BackgroundImage
    {
        get { return _backgroundImage; }
        set { _backgroundImage = value; }
    }

    private string[] _toActivateQuest;

    public string[] ToActivateQuest
    {
        get { return _toActivateQuest; }
        set { _toActivateQuest = value; }
    }

    //Konstruktor mit notwendigen Attributen
    public Scene(Option[] Options, string SceneIdentifier, string SceneDescription)
    {
        this.Options = Options;
        this.SceneIdentifier = SceneIdentifier;
        this.SceneDescription = SceneDescription;
    }

    //Konstruktor mit notwendigen Attributen + BackgroundImage
    public Scene(Option[] Options, string SceneIdentifier, string SceneDescription, string BackgroundImage)
    {
        this.Options = Options;
        this.SceneIdentifier = SceneIdentifier;
        this.SceneDescription = SceneDescription;
        this.BackgroundImage = BackgroundImage;
    }

    //Konstruktor mit notwendigen Attributen + ActivateQuest
    public Scene(Option[] Options, string SceneIdentifier, string SceneDescription, string[] ToActivateQuest)
    {
        this.Options = Options;
        this.SceneIdentifier = SceneIdentifier;
        this.SceneDescription = SceneDescription;
        this.ToActivateQuest = ToActivateQuest;
    }

    //Konstruktor mit notwendigen Attributen + BackgroundImage + ActivateQuest
    public Scene(Option[] Options, string SceneIdentifier, string SceneDescription, string BackgroundImage, string[] ToActivateQuest)
    {
        this.Options = Options;
        this.SceneIdentifier = SceneIdentifier;
        this.SceneDescription = SceneDescription;
        this.BackgroundImage = BackgroundImage;
        this.ToActivateQuest = ToActivateQuest;
    }


    //Diese Methode ermittelt alle möglichen Optionen anhand eines Identifiers,
    //ihres Zustand und den Quests aus QuestLog.cs
    internal Option[] getOptionsByIdentifier(OptionIdentifier identifier)
    {
        ArrayList validOptions = new ArrayList();
        
        foreach (Option option in this.Options)
        {
            if (option.Identifier == identifier && 
                (option.Visibility == VisibilityCondition.ALWAYS || option.Visibility == VisibilityCondition.ONCE))
            {
                if (option.NeededQuest != null)
                {
                    string[] SplitNeeded = option.NeededQuest.Split('_');
                    if (SplitNeeded.Length == 2)
                    {
                        /*foreach (Quest quest in story.QuestLog)
                        *{
                        *  if (SplitNeeded[0] == quest.QuestName) 
                        *  {
                        *      foreach (Stage in quest.Stages)
                        *      {
                        *          if (SplitNeeded[1] == Stage.Ident && Stage.Status == Status.Active)
                        *          {
                        *              validOptions.Add(option);
                        *          }
                        *      }
                        *  }
                        *}
                    */
                    }
                }
                else
                {
                    validOptions.Add(option);
                } 
                if (option.Visibility == VisibilityCondition.ONCE)
                {
                    option.Visibility = VisibilityCondition.INACTIVE_ONCE;
                }
            }
            
        }
        return (Option[])validOptions.ToArray(typeof(Option));
    }
}

