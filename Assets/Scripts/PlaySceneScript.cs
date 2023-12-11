using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class PlaySceneScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public ButtonType currentType;
    public Transform buttonScale;
    Vector3 defaultScale;

    private void Start()
    {
        defaultScale = buttonScale.localScale;
    }
    public void OnBtnClick()
    {
        switch (currentType)
        {
            case ButtonType.Back:
                Debug.Log("Back");
                SceneManager.LoadScene("1.Main Scene");
                break;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonScale.localScale = defaultScale * 1.2f;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        buttonScale.localScale = defaultScale;
    }
}
