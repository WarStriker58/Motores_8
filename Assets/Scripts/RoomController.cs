using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RoomScript : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioSource doorSound;
    public ScriptableObjectRoomMusic RM;
    public static event Action OnCollisionEnter;
    public static event Action OnCollisionExit;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void Start()
    {
        audioSource.clip = RM.roomMusic;
    }

    private void OnTriggerEnter(Collider other)
    {
        MusicManager.musicManager.PlayDoors();

        if (other.tag == "Player")
        {
            audioSource.Play();
            OnCollisionEnter?.Invoke();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        MusicManager.musicManager.PlayDoors();

        audioSource.Stop();
        OnCollisionExit?.Invoke();

    }

}
