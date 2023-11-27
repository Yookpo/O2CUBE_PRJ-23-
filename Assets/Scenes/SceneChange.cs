using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void NewGameBtn()
    {
        SceneManager.LoadScene("2.Loading");
    }
    public void ContinueBtn()
    {
        SceneManager.LoadScene("2.Loading");
    }

    public void BackBtn()
    {
        SceneManager.LoadScene("1.Main Scene");
    }
}
