using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RoomController : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioSource backgroundMusic;
    [SerializeField] private AudioSource doorSound;
    public ScriptableObjectRoomMusic RM;
    public static event Action OnCollisionEnter;
    public static event Action OnCollisionExit;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        backgroundMusic.Play();
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
            backgroundMusic.mute = true;
            OnCollisionEnter?.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        MusicManager.musicManager.PlayDoors();
        audioSource.Stop();
        backgroundMusic.mute = false;
        OnCollisionExit?.Invoke();
    }
}