using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementStateManager : MonoBehaviour
{
    public float moveSpeed = 3;
    [HideInInspector] public Vector3 dir;
    float hzinput, vinput;
    CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        GetDirectionAndMove();
    }
    void GetDirectionAndMove()
    {
        hzinput = Input.GetAxis("Horizontal");
        vinput = Input.GetAxis("vertical");

        dir = transform.forward * vinput + transform.right * hzinput;
        controller.Move(dir * moveSpeed * Time.deltaTime);

    }
}
