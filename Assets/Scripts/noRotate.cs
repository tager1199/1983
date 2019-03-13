using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noRotate : MonoBehaviour {

    void LateUpdate()
    {
        transform.rotation = Quaternion.identity;
    }
}
