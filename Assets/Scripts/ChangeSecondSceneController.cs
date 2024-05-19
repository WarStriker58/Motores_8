using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSecondSceneController : MonoBehaviour
{
    public string SecondScene;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            LoadSecondScene();
        }
    }

    private void LoadSecondScene()
    {
        if (!string.IsNullOrEmpty(SecondScene) && SceneManager.sceneCountInBuildSettings > 0)
        {
            SceneManager.LoadScene(SecondScene);
        }
        else
        {
            Debug.LogWarning("La escena no existe o no se puede cargar.");
        }
    }
}