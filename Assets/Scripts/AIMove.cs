using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AIMove : MonoBehaviour {

    public float AIHealth = 500;
    public float mode;
    public Transform target;
    public float speed;
    public GameObject player;
    public Text text;
    List<string> dialog = new List<string>();
    public GameObject displayText;
    public GameObject change;
    Text ChangeText;
    Queue Dialogue = new Queue();
    List<string> AllText = new List<string>();


    void Start()
    {
      //start peaceful
        mode = 1;
        dialog.Add("egg"); //add dialog quips
        dialog.Add("sausage");
        dialog.Add("beans");
    }

	void Update ()
    {
        if (mode == 1)
        {
            for (int i = 0; i < 50; i++) //random movement
            {
                Move();
            }
            transform.Rotate(0, 0, Random.Range(-90, 90));
        }
        else //aggro
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }

    void Move ()
    {
        transform.Translate(new Vector3(Mathf.Sin(transform.eulerAngles.x) / 1000, Mathf.Cos(transform.eulerAngles.y) / 1000, 0));
    }

    void OnCollisionEnter(Collision other)
    {
      Debug.Log("collision");
        if (other.gameObject.tag == "Player")
        Debug.Log("player");
        {
            if (Input.GetKey(KeyCode.Space)) //if being attacked
            {
                mode = 2; //get violent
                AIHealth -= 25;
            }
            else if (mode == 2)
            {
                player.GetComponent<CharacterMove>().Health -= 5;
            }
            else
            {
                text.text = dialog[Random.Range(0, dialog.Count-1)];
                GameObject.FindWithTag("ConvoPanel").SetActive(true);
            }
            change.SetActive(true);
            displayText.SetActive(true);
            ChangeText.text = (Dialogue.Dequeue().ToString());
        }
    }
}
