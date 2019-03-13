using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class timeScript : MonoBehaviour {

    public float time;
    public Text text;
    public GameObject rootCanvas;
    public GameObject n;

	void Start ()
    {
        time = 600;
        DontDestroyOnLoad(rootCanvas);
    }

	public void ReduceTime(float x)
    {
        time -= x;
    }

    void Update ()
    {
        if(time <= 0)
        {
            rootCanvas.SetActive(false);
            SceneManager.LoadScene("Ending");
        }
        text.text = time.ToString();
        n.SetActive(true);
        time -= Time.deltaTime;
        if(Input.GetKey(KeyCode.P))
        {
            time = 5;
        }
    }
}
