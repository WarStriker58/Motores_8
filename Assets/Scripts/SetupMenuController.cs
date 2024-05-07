using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetupMenuController : MonoBehaviour
{
    public GameObject menuImage;
    public Button openButton;
    public Button closeButton;

    void Start()
    {
        openButton.onClick.AddListener(OpenMenu);
        closeButton.onClick.AddListener(CloseMenu);
        menuImage.SetActive(false);
    }

    void OpenMenu()
    {
        menuImage.SetActive(true);
    }

    void CloseMenu()
    {
        menuImage.SetActive(false);
    }
}