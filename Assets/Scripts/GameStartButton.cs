using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStartButton : MonoBehaviour
{
    [SerializeField]
    private string SceneName = "SampleScene";   // Scene��

    // �Q�[��Scene�����[�h����
    public void OnRetry()
    {
        SceneManager.LoadScene(SceneName);
    }
}
