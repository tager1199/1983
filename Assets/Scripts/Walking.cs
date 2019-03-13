using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Walking : MonoBehaviour {

  public float moveSpeed;

    void Start()
    {

    }

  	void Update ()
    {
      if (Input.GetKey(KeyCode.A))
      {
          transform.Translate(new Vector3(-moveSpeed,0,0));
      }

      if (Input.GetKey(KeyCode.D))
      {
          transform.Translate(new Vector3(moveSpeed,0,0));
      }

      if (Input.GetKey(KeyCode.W))
      {
          transform.Translate(new Vector3(0,moveSpeed,0));
          // if (transform.position.x > 8.095 && transform.position.x < 8.646 && transform.position.y > 4.08)
          // {
          //     SceneManager.LoadScene("Bar");
          // }
      }

      if (Input.GetKey(KeyCode.S))
      {
          transform.Translate(new Vector3(0,-moveSpeed,0));
      }
  }
}
