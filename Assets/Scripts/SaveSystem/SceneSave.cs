using System.Collections.Generic;

[System.Serializable]

public class SceneSave
{
    // String key is an identifier name we choose for this list
    public Dictionary<string, List<SceneItem>> listSceneItemDictionary;
}
