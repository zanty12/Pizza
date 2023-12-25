using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStartButton : MonoBehaviour
{
    [SerializeField]
    private string SceneName = "SampleScene";   // Scene–¼

    // ƒQ[ƒ€Scene‚ğƒ[ƒh‚·‚é
    public void OnRetry()
    {
        SceneManager.LoadScene(SceneName);
    }
}
