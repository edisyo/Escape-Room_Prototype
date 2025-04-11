using UnityEngine.Audio;
using System;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    public Sound[] sounds;

    public static audioManager instance;
    private void Awake()
    {
        if(instance == null)//check if there already is instance of audiomanager in scene
        {
            instance = this;//if not, this is the main instance
        }
        else//if there already is, then delete new instance
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);//save object between scenes

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    public void Play(string name)
    {
        //find sound in sounds array, where 
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.source.Play();
    }
}
