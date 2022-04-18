using System;
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

    public Scene(Option[] Options, string SceneIdentifier, string SceneDescription)
    {
        this.Options = Options;
        this.SceneIdentifier = SceneIdentifier;
        this.SceneDescription = SceneDescription;
    }

    //Diese Methode ermittelt eine Option anhand ihres Identifiers
    internal Option getOptionByIdentifier(OptionIdentifier identifier)
    {
        foreach (Option option in this.Options)
        {
            if (option.Identifier == identifier)
            {
                return option;
            }
        }
        return null;
    }
}

