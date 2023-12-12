using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene2_Script : MonoBehaviour
{
    public SpriteRenderer s1;
    public SpriteRenderer s2;
    public SpriteRenderer s3;

    private float timer = 0f;
    private bool sceneLoaded = false;

    private void Start()
    {
        s1.enabled = false;
        s2.enabled = false;
        s3.enabled = false;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 2f && !s1.enabled)
        {
            s1.enabled = true;
        }

        if (timer >= 4f && !s2.enabled)
        {
            s2.enabled = true;
        }

        if (timer >= 6f && !s3.enabled)
        {
            s3.enabled = true;
        }


        // 씬 로드는 한 번만 실행되도록 수정
        if (timer >= 8f && !sceneLoaded && s1.enabled && s2.enabled && s3.enabled)
        {
            SceneManager.LoadScene("INTER_2_maze");
            sceneLoaded = true;
        }
    }

}
