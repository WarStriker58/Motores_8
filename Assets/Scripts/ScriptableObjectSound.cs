using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Sound", menuName = "Sound/DoorSound", order = 2)]
public class ScriptableObjectSound : ScriptableObject
{
    public AudioClip doorSound;
    public float soundMaster = 1f;
    public float soundSFX = 1f;
    public float soundMusic = 1f;
}