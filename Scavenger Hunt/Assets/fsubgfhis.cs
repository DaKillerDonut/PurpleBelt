using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Rigidbody rb;
    public int baseSpeed;
    public int sprint;
    private int currentSpeed;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void Update() {
        if (Input.GetKey(KeyCode.LeftShift)) {
            currentSpeed = baseSpeed + sprint;
        } else {
            currentSpeed = baseSpeed;
        }
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

    }


}