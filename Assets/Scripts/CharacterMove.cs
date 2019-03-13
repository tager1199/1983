using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterMove : MonoBehaviour {

  bool first = true;
  public float moveSpeed;
  bool Radio = false;
  bool xDir = false;
  bool yDir = false;
  public GameObject displayText;
  public GameObject change;
  public float Health = 1000;
  Text ChangeText;
  Queue Dialogue = new Queue();
  List<string> AllText = new List<string>();

	// Use this for initialization

	void Start ()	{
		displayText = GameObject.FindGameObjectWithTag("Warning");
    change = GameObject.FindGameObjectWithTag("WarnText");
    ChangeText = change.GetComponent<Text>();
    change.SetActive(false);
		displayText.SetActive(false);
      AllText.Add("Damn, never felt the call of the bottle this strongly for months. Been a rough week.");
      AllText.Add("Feels so empty here.");
      AllText.Add("Just vodka and a bartender cleaning glasses that are already spotless. ");
      AllText.Add("Looking at the ceiling… ");
      AllText.Add("does he want me to think he’s busy?");
      AllText.Add("This place feels cold, dead. Vodka used to burn my throat, put a warmth in my belly.");
      AllText.Add("Even that’s gone.");
      AllText.Add("EMERGENCY TRANSMISSION. \n NUCLEAR WARHEADS HAVE BEEN LAUNCHED BY US FORCES. LOCATE A BUNKER IMMEDIATELY.");
      AllText.Add("What the hell?!! I thought this cold war stuff was cooling down?!");
      AllText.Add("...");
      AllText.Add("Nukes? That’s it then, right? That’s the end of the world. The end of me.");
      foreach (string i in AllText)
      {
        Dialogue.Enqueue(i);
      }
      change.SetActive(true);
      displayText.SetActive(true);
    }


    public void DisplayText() {
            displayText.SetActive(true);
            change.SetActive(true);
    }

    public void Change()
    {
      if (Dialogue.Count == 0)
      {
        change.SetActive(false);
        displayText.SetActive(false);
      }

      else if (first == false)
      {
      ChangeText.text = (Dialogue.Dequeue().ToString());
      }
      if (first == true)
      {
        if (Dialogue.Count > 4)
        {
          ChangeText.text = (Dialogue.Dequeue().ToString());
        }
        else
        {
          change.SetActive(false);
          displayText.SetActive(false);
          ChangeText.text = (Dialogue.Dequeue().ToString());
        }
      }



  }



	void Update () {
    if (Dialogue.Count < 4)
    {


        if (Radio == true)
		{
			if (transform.position.x < 2.032498)
			{
				transform.Translate(new Vector3(moveSpeed,0,0));
			}
			else
			{
				xDir = true;
			}

			if (transform.position.y < 2.826213)
			{
				transform.Translate(new Vector3(0,moveSpeed,0));
			}
			else
			{
				yDir = true;
			}

			if (yDir == true && xDir == true) {
				Radio = false;
				first = false;
			}

		}

		else
		{
			if (Input.GetKey(KeyCode.A))
			{
				if (transform.position.x > -9.37)
				{
					transform.Translate(new Vector3(-moveSpeed,0,0));
				}
			}

			if (Input.GetKey(KeyCode.D))
			{
				if (transform.position.x < 9.4)
				{
					transform.Translate(new Vector3(moveSpeed,0,0));
				}
			}

			if (Input.GetKey(KeyCode.W))
			{
				if (transform.position.y < 3.75)
				{
					transform.Translate(new Vector3(0,moveSpeed,0));
				}
			}

			if (Input.GetKey(KeyCode.S))
			{
				if (transform.position.y > -4.36)
				{
					transform.Translate(new Vector3(0,-moveSpeed,0));
				}
				if (transform.position.y < -4 && transform.position.x < 0.49)
				{
					if  (transform.position.x > -0.66)
					{
						if (first == true)
						{
							Radio = true;
							DisplayText();
						}
            else
            {

              SceneManager.LoadScene("Street3");
            }
					}
				}
			}
		}
	}
}
}
