using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene1_Script : MonoBehaviour
{
    public SpriteRenderer s1;
    public SpriteRenderer s2;
    public SpriteRenderer s3;
    public SpriteRenderer s4;

    private float timer = 0f;
    private bool s1Enabled = false;
    private bool sceneLoaded = false;

    private void Start()
    {
        s1.enabled = false;
        s2.enabled = false;
        s3.enabled = false;
        s4.enabled = false;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if(timer >= 2f && !s1Enabled)
        {
            s1.enabled = true;
            s1Enabled = true;
        }

        if(timer>=4f && s1Enabled && !s2.enabled)
        {
            s2.enabled = true;
        }

        if(timer>=6f && s2.enabled && !s3.enabled)
        {
            s3.enabled = true;
        }

        if(timer >= 8f && s3.enabled && !s4.enabled)
        {
            s1.enabled = false;
        }

        if(timer >= 9.5f && s3.enabled && !s1.enabled)
        {
            s4.enabled = true;
        }

        // 씬 로드는 한 번만 실행되도록 수정
        if (timer >= 12f && s3.enabled && !s1.enabled && !sceneLoaded)
        {
            SceneManager.LoadScene("INTER_1_puzzle");
            sceneLoaded = true;
        }
    }


}
