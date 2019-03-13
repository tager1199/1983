using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audioOptions : MonoBehaviour {

    public Slider sfx;
    public Slider music;
    public float sfxVol = 1;
    public float musicVol = 1;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

	public void ChangeValue ()
    {
        sfxVol = sfx.value;
        musicVol = music.value;
	}
}
