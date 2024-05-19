using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeController : MonoBehaviour
{
    [SerializeField] private Image fadeImage;
    [SerializeField] private Color startColor;
    [SerializeField] private Color currentColor;
    [SerializeField] private Color finalColor;

    public void OnEnable()
    {
        RoomController.OnCollisionEnter += CallFadeIn;
        RoomController.OnCollisionExit += CallFadeOut;
    }
    
    public void OnDisable()
    {
        RoomController.OnCollisionEnter -= CallFadeIn;
        RoomController.OnCollisionExit -= CallFadeOut;
    }
    
    public void CallFadeIn()
    {
        StartCoroutine(FadeIn());
    }

    public void CallFadeOut()
    {
        StartCoroutine(FadeOut());

    }

    IEnumerator FadeIn()
    {
        currentColor = fadeImage.color;
        for (float color = 1f; color >= -1; color = color - 0.15f)
        {
            currentColor.a = color;
            fadeImage.color = currentColor;
            yield return new WaitForSeconds(0.04f);
        }
    }

    IEnumerator FadeOut()
    {
        currentColor = fadeImage.color;
        for (float color = 0f; color <= 2; color = color + 0.15f)
        {
            currentColor.a = color;
            fadeImage.color = currentColor;
            yield return new WaitForSeconds(0.04f);
        }
        currentColor.a = 0f;
        fadeImage.color = currentColor;
    }
}