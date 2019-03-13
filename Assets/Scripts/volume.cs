using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class volume : MonoBehaviour {

    public float sfx = 1;
    public float music = 1;
    public GameObject obj;

    void Start()
    {
        obj = GameObject.Find("Egg");
    }

    void Update ()
    {
        try
        {
            sfx = obj.GetComponent<audioOptions>().sfxVol;
            music = obj.GetComponent<audioOptions>().musicVol;
            if (gameObject.tag == "sfx")
            {
                gameObject.GetComponent<AudioSource>().volume = sfx;
            }
            else
            {
                gameObject.GetComponent<AudioSource>().volume = music;
            }
        }
        catch (NullReferenceException e)
        {
            gameObject.GetComponent<AudioSource>().volume = 1;
        }
    }
}
