﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinAround : MonoBehaviour {

    public float speed;

	void Update ()
    {
        transform.RotateAround(Vector3.zero, Vector3.up, speed * Time.deltaTime);
        transform.RotateAround(Vector3.zero, Vector3.left, speed * Time.deltaTime);
    }
}
