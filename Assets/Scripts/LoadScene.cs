using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadRespond1()
    {
        SceneManager.LoadScene("Respond1");
    }

    public void LoadRespond2()
    {
        SceneManager.LoadScene("Respond2");
    }
    public void LoadPrefaceContinue()
    {
        SceneManager.LoadScene("PrefaceContinue");
    }

    public void LoadSceneLevel1()
    {
        SceneManager.LoadScene("SceneLevel1");
    }

    public void LoadGameEnd()
    {
        SceneManager.LoadScene("GameEnd");
    }
}
