using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void OnButtonSwitchScene(int SceneIndex)
    { 
        SceneManager.LoadScene(SceneIndex);
    }
}
