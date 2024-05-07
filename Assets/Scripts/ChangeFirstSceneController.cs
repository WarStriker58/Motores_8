using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeFirstSceneController : MonoBehaviour
{
    public string FirstScene;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            LoadFirstScene();
        }
    }

    private void LoadFirstScene()
    {
        if (!string.IsNullOrEmpty(FirstScene) && SceneManager.sceneCountInBuildSettings > 0)
        {
            SceneManager.LoadScene(FirstScene);
        }
        else
        {
            Debug.LogWarning("La escena no existe o no se puede cargar.");
        }
    }
}