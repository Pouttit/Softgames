using TMPro;
using UnityEngine;

[System.Serializable]
public class DialogueLine
{
    public string speakerName;
    [TextArea(2, 5)] public string message;
}

public class DialogueManager : MonoBehaviour
{
    public GameObject dialogueLinePrefab; 
    public Transform dialogueParent; // A UI panel with Vertical Layout Group

    DialogueLine[] dialogueLines = new DialogueLine[]
{
    new DialogueLine { speakerName = "<sprite name=\"Sheldon\">", message = "I admit <sprite name=\"satisfied\"> the design of Cookie Crush is quite elegant in its simplicity." },
    new DialogueLine { speakerName = "<sprite name=\"Lenord\">", message = "That’s practically a compliment, Sheldon. <sprite name=\"intrigued\"> Are you feeling okay?" },
    new DialogueLine { speakerName = "<sprite name=\"penny\">", message = "Don’t worry, Leonard. He’s probably just trying to justify playing it himself." },
    new DialogueLine { speakerName = "<sprite name=\"Sheldon\">", message = "Incorrect. <sprite name=\"neutral\"> I’m studying its mechanics. The progression system is oddly satisfying." },
    new DialogueLine { speakerName = "<sprite name=\"penny\">", message = "It’s called fun, Sheldon. You should try it more often." },
    new DialogueLine { speakerName = "<sprite name=\"Lenord\">", message = "She’s got a point. Sometimes, a simple game can be relaxing." },
    new DialogueLine { speakerName = "Neighbour", message = "I fully agree <sprite name=\"affirmative\">" },
    new DialogueLine { speakerName = "<sprite name=\"Sheldon\">", message = "Relaxing? I suppose there’s merit in low-stakes gameplay to reduce cortisol levels." },
    new DialogueLine { speakerName = "<sprite name=\"penny\">", message = "Translation: Sheldon likes crushing cookies but won’t admit it. <sprite name=\"laughing\">" },
    new DialogueLine { speakerName = "<sprite name=\"Sheldon\">", message = "Fine. I find the color-matching oddly soothing. Happy?" },
    new DialogueLine { speakerName = "<sprite name=\"Lenord\">", message = "Very. Now we can finally play as a team in Wordscapes." },
    new DialogueLine { speakerName = "<sprite name=\"penny\">", message = "Wait, Sheldon’s doing team games now? What’s next, co-op decorating?" },
    new DialogueLine { speakerName = "<sprite name=\"Sheldon\">", message = "Unlikely. But if the design involves symmetry and efficiency, I may consider it." },
    new DialogueLine { speakerName = "<sprite name=\"penny\">", message = "See? Casual gaming brings people together!" },
    new DialogueLine { speakerName = "<sprite name=\"Lenord\">", message = "Even Sheldon. That’s a win for everyone. <sprite name=\"win\">" },
    new DialogueLine { speakerName = "<sprite name=\"Sheldon\">", message = "Agreed. <sprite name=\"neutral\"> Though I still maintain chess simulators are superior." },
    new DialogueLine { speakerName = "<sprite name=\"penny\">", message = "Sure, Sheldon. <sprite name=\"intrigued\"> You can play chess *after* we beat this next level." }
};

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (DialogueLine line in dialogueLines)
        {
            GameObject instance = Instantiate(dialogueLinePrefab, dialogueParent);
            TextMeshProUGUI tmpText = instance.GetComponentInChildren<TextMeshProUGUI>();
            tmpText.text = $"{line.speakerName} {line.message}";
        }
    }

}
