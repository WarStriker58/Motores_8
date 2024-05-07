using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{

    [SerializeField] private ScriptableObjectSound newSound;
    [SerializeField] private AudioMixer audioMixer;
    private AudioSource audioSource;
    public static MusicManager musicManager { get; private set; }

    private void Awake()
    {
        if (musicManager != null && musicManager != this)
        {
            Destroy(this);
        }
        else
        {
            musicManager = this;
            DontDestroyOnLoad(this.gameObject);
        }
        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        audioSource.clip = newSound.doorSound;
    }
    
    public void Setmaster(float sound)
    {
        newSound.soundMaster = sound;
        audioMixer.SetFloat("Master", Mathf.Log10(sound) * 20f);
    }

    public void SetSFX(float sound)
    {
        newSound.soundSFX = sound;
        audioMixer.SetFloat("SFX", Mathf.Log10(sound) * 20f);
    }
    
    public void SetMusic(float sound)
    {
        newSound.soundMusic = sound;
        audioMixer.SetFloat("Music", Mathf.Log10(sound) * 20f);
    }
    
    public void PlayDoors()
    {
        audioSource.Play();
    }
}