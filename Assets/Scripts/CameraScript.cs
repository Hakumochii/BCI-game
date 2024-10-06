using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField]private float camSpeed = 0.05f;
    private Vector2 turn;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        turn.x += Input.GetAxis("Mouse X") * camSpeed;
        turn.y += Input.GetAxis("Mouse Y") * camSpeed;
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
    }
}
