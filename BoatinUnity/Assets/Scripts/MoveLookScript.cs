using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLookScript : MonoBehaviour
{

    public float sensititvity=1000f;
    public Transform playerBody;
    public Transform playerboat;
    float xRotation = 0f;
    Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //float mouseX = Input.GetAxis("Mouse X") * sensititvity * Time.deltaTime;
        //float mouseY = Input.GetAxis("Mouse Y") * sensititvity * Time.deltaTime;

        //xRotation -= mouseY;
        //xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        //playerBody.Rotate(Vector3.up*mouseX);



        //float x = Input.GetAxis("Horizontal");

        float mouseX = Input.GetAxis("Mouse X") * sensititvity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensititvity * Time.deltaTime;
        direction = new Vector2(mouseX, mouseY);
        direction *= sensititvity;

        xRotation -= direction.y;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        playerBody.Rotate(Vector3.up * direction.x);
    }
}
