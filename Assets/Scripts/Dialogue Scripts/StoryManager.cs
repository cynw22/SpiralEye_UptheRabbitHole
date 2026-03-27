using UnityEngine;
using Ink.Runtime;

public class StoryManager : MonoBehaviour
{
    public static StoryManager Instance;

    public TextAsset inkJSON;

    public Story story;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

            story = new Story(inkJSON.text);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start a brand new game
    public void StartNewGame()
    {
        story = new Story(inkJSON.text);
    }

    // Save game state
    public string SaveGame()
    {
        return story.state.ToJson();
    }

    // Load game state
    public void LoadGame(string json)
    {
        story = new Story(inkJSON.text);
        story.state.LoadJson(json);
    }
}