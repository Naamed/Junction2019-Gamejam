using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10.0f;
    private float translation;
    private float strafe;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        strafe = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(strafe, 0, translation);

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}