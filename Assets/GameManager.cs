using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject ThradsHolder;
    public GameObject[] Threads;

    [SerializeField] 
    int totalThreads = 0;
    [SerializeField]
    int correctedThreads = 0;
    void Start()
    {
        totalThreads = ThradsHolder.transform.childCount;

        Threads = new GameObject[totalThreads];

        for (int i = 0; i < Threads.Length; i++)
        {
            Threads[i] = ThradsHolder.transform.GetChild(i).gameObject;
        }
        
    }

    public void correctMove()
    {
        correctedThreads += 1;

        Debug.Log("correct Move");

        if(correctedThreads == totalThreads)
        {
            SceneManager.LoadScene("secondScene");
            Debug.Log("correct Win!");
        }
    }

    public void wrongMove()
    {
        correctedThreads -= 1;
    }
}
