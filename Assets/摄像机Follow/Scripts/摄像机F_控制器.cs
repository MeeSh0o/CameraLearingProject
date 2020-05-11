using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 摄像机F_控制器 : MonoBehaviour
{
    public float MoveForce = 3f;
    public float JumpForce = 5f;
    public Rigidbody RB;

    private void Start() {
        RB = GetComponent<Rigidbody>();
    }

    private void Update() {
        float v = Input.GetAxis("Horizontal") * MoveForce;
        RB.AddForce(new Vector3(v,0,0));

        if(Input.GetButtonDown("Jump")){
            RB.AddForce(new Vector3(0,JumpForce,0));
            Debug.Log(Input.GetButtonDown("Jump"));
        }
    }
}


