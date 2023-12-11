using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class threadsScript : MonoBehaviour
{
    float[] rotations = {0,90,180,270};

    public float[] correctRotation;
    [SerializeField]
    bool isPlaced = false;

    int PossibleRots = 1;

    GameManager gameManager;

    private void Awake() {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    
    private void Start()
    {
        PossibleRots = correctRotation.Length;
        int rand = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0,0,rotations[rand]);

        if(PossibleRots > 1)
        {
            if (transform.eulerAngles.z == correctRotation[0] || transform.eulerAngles.z == correctRotation[1]) //correctRotation size가 2개 있는 경우 즉 -180과 0도 가 있다
            {
                isPlaced = true;        // -180일 때도 true, 0(180)일 때도 true를 반환
                gameManager.correctMove();

            }
        }
        else{
            if (transform.eulerAngles.z == correctRotation[0])      //curve같은 지정각도가 하나만 있는 경우 
            {
                isPlaced = true;
                gameManager.correctMove();
            }
        }
        
    }

    private void OnMouseDown() {
        transform.Rotate(0,0,90);
        transform.eulerAngles = new Vector3(0,0,Mathf.Round(transform.eulerAngles.z));

        if(PossibleRots > 1)
        {
            if (transform.eulerAngles.z == correctRotation[0] || transform.eulerAngles.z == correctRotation[1] && isPlaced == false)
                {
                    isPlaced = true;
                    gameManager.correctMove();
                }
            else if(isPlaced == true)
                {
                    isPlaced = false;
                    gameManager.wrongMove();
                }
        }
       else
       {
            if (transform.eulerAngles.z == correctRotation[0] && isPlaced == false)
                {
                    isPlaced = true;
                    gameManager.correctMove();
                }
            else if(isPlaced == true)
                {
                    isPlaced = false;
                     gameManager.wrongMove();
                }
       }
    }
}
