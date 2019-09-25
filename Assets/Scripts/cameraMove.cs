using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public float maxX = 60;
    public float minX = -60;
    public float maxY = 360;
    public float minY = -360;
    public float sensitivityX = 35f;
    public float sensitivityY = 35f;
    public float rotationX = 0f;
    public float rotationY = 0f;
    public Transform cameraTransform;

    // Start is called before the first frame update
    void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        rotationY += Input.GetAxis("Mouse X");
        rotationX += Input.GetAxis("Mouse Y");
        rotationX = Mathf.Clamp(rotationX, minX, maxX);
        transform.localEulerAngles = new Vector3(-rotationX, rotationY, 0);




        if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        if (Input.GetMouseButton(0))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        //if (Input.GetKey(KeyCode.W))
        //{
        //    move.transform(epicspeed, 0, 0);
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.Translate(-epicspeed, 0, 0);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Translate(0, -epicspeed, 0);
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.Translate(0, epicspeed, 0);
        //}

    }
}
