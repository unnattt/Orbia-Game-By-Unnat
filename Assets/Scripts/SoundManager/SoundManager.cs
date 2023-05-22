using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static SoundManager inst;

    [SerializeField] public AudioSource audioSource;

    public Audio[] clips;

    void Start()
    {
        inst = this;
    }

    public void PlaySound(SoundName name)
    {
        foreach (var item in clips)
        {
            if (item.name == name)
            {
                audioSource.clip = item.clip;
                audioSource.Play();
                break;
            }
        }
    }

    [System.Serializable]
    public class Audio
    {
        public SoundName name;
        public AudioClip clip;
    }

    public enum SoundName
    {
       GamePlaySound,
    }
}
