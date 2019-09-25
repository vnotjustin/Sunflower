using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playMove : MonoBehaviour
{
    public GameObject player;
    public Camera cam;
    public CharacterController controller;
    public float epicspeed = 5;
    public float jumpSpeed = 5;
    public float gravity = 4;
    private Vector3 moveDirection = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < -10)
        {
            player.transform.position = new Vector3(0, 1, 0);
        }

        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = cam.transform.TransformDirection(moveDirection);
            moveDirection *= epicspeed;

            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
        }

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
