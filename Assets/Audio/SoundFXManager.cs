using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class SoundFXManager : MonoBehaviour
{
    public static SoundFXManager soundFXManager;
    public AudioSource soundFXObject;
    private void Awake()
    {
        // If there is no instance, set the current instance
        if (soundFXManager == null)
        {
            soundFXManager = this;
            // Don't destroy this GameObject when loading a new scene
            DontDestroyOnLoad(gameObject);
        }
        else if (soundFXManager != this)
        {
            // Destroy duplicate instances
            Destroy(gameObject);
        }

        // Ensure we have an AudioSource attached
        
    }

    public void PlaySoundEffect(AudioClip audioClip){
        AudioSource audioSource = Instantiate(soundFXObject, new Vector3(0,0,0), quaternion.identity);
        audioSource.clip = audioClip;
        audioSource.Play();
        float clipLength = audioSource.clip.length;
        Destroy(audioSource.gameObject, clipLength);
    }
}