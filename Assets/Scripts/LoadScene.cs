using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField]
    private string SceneName;   // Scene��

    // �Q�[��Scene�����[�h����
    public void OnRetry()
    {
        SceneManager.LoadScene(SceneName);
    }
}
