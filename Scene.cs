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

    private string[] _toActivate;

    public string[] ToActivate
    {
        get { return _toActivate; }
        set { _toActivate = value; }
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

    //Konstruktor mit notwendigen Attributen + ActivateOptions
    public Scene(Option[] Options, string SceneIdentifier, string SceneDescription, string[] ActivateOptions)
    {
        this.Options = Options;
        this.SceneIdentifier = SceneIdentifier;
        this.SceneDescription = SceneDescription;
        this.ToActivate = ToActivate;
    }

    //Konstruktor mit notwendigen Attributen + BackgroundImage + ActivateOptions
    public Scene(Option[] Options, string SceneIdentifier, string SceneDescription, string BackgroundImage, string[] ToActivate)
    {
        this.Options = Options;
        this.SceneIdentifier = SceneIdentifier;
        this.SceneDescription = SceneDescription;
        this.BackgroundImage = BackgroundImage;
        this.ToActivate = ToActivate;
    }

    internal Option[] ActivateOptions(string[] ToActivate)
    {
        Option[] Options;
        Option[] ActivatedOptions;
        for (int i = 0; i < ToActivate.Length; i++)
        {

        }
        return Options;
    }

    //Diese Methode ermittelt alle möglichen Optionen anhand eines Identifiers.
    internal Option[] getOptionsByIdentifier(OptionIdentifier identifier)
    {
        ArrayList validOptions = new ArrayList();
        
        foreach (Option option in this.Options)
        {
            if (option.Identifier == identifier && 
                (option.Visibility == VisibilityCondition.ALWAYS || option.Visibility == VisibilityCondition.ONCE))
            {
                validOptions.Add(option);
                if (option.Visibility == VisibilityCondition.ONCE)
                {
                    option.Visibility = VisibilityCondition.INACTIVE_ONCE;
                }
            }
        }
        return (Option[])validOptions.ToArray(typeof(Option));
    }
}

