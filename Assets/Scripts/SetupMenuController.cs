using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetupMenuController : MonoBehaviour
{
    public GameObject menuImage; // Referencia al objeto de la imagen del men� que deseas mostrar
    public Button openButton; // Bot�n para abrir el men�
    public Button closeButton; // Bot�n para cerrar el men�

    void Start()
    {
        // Agrega listeners a los botones para que respondan a los eventos de clic
        openButton.onClick.AddListener(OpenMenu);
        closeButton.onClick.AddListener(CloseMenu);

        // Aseg�rate de que el men� est� desactivado al inicio
        menuImage.SetActive(false);
    }

    void OpenMenu()
    {
        // Activa el objeto de la imagen del men�
        menuImage.SetActive(true);
    }

    void CloseMenu()
    {
        // Desactiva el objeto de la imagen del men�
        menuImage.SetActive(false);
    }
}