using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour {

    public float speed;

	void Update () {
        transform.Rotate(Vector3.down * Time.deltaTime * speed);
    }
}
