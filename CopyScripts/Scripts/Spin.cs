using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Spin : MonoBehaviour {
    public float speed = 3.0f;   
    void Update() {
        transform.Rotate(0, speed, 0);
    }
}
