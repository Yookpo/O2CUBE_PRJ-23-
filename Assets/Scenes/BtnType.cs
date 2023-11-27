using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class BtnType : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public ButtonType currentType;
    public Transform buttonScale;
    Vector3 defaultScale;
    public CanvasGroup mainGroup;
    public CanvasGroup optionGroup;
    public Image FadeBtn;

    public TextMeshProUGUI tmpUgui; // TextProMesh꺼 받아옴

    private void Start()
    {
        defaultScale = buttonScale.localScale;
    }
    public void OnBtnClick()
    {
        switch(currentType)
        {
            case ButtonType.New:
                Debug.Log("New Game");
                break;
            case ButtonType.Continue:
                Debug.Log("Continue Game");
                break;
            case ButtonType.Option:
                Debug.Log("Option");
                CanvasGroupOn(optionGroup);
                CanvasGroupOff(mainGroup);
                break;
            case ButtonType.Sound_on:
                Debug.Log("Sound on");
                break;
            case ButtonType.Sound_off:
                Debug.Log("Sound off");
                break;
            case ButtonType.Back:
                Debug.Log("Back");
                CanvasGroupOn(mainGroup);
                CanvasGroupOff(optionGroup);
                break;
            case ButtonType.Fade:
                Destroy(FadeBtn); // 누르면 버튼이 사라짐
                Destroy(tmpUgui); //글자 사라지게 하기
                break;
            case ButtonType.Quit:
                Debug.Log("Quit");
                break;
        }
    }
    
    public void CanvasGroupOn(CanvasGroup cg)
    {
        cg.alpha = 1;
        cg.interactable = true; 
        cg.blocksRaycasts = true;   
    }
    public void CanvasGroupOff(CanvasGroup cg)
    {
        cg.alpha = 0;
        cg.interactable = false;
        cg.blocksRaycasts = false;
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
