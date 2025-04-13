using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public Sprite[] availableSprites; 

    void Awake()
    {
        // Give random sprite to each new card
        Image sr = GetComponent<Image>();
        if (sr != null && availableSprites != null && availableSprites.Length > 0)
        {
            int rand = Random.Range(0, availableSprites.Length);
            sr.sprite = availableSprites[rand];
        }
    }
}
