using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.UI;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    [SerializeField]private Transform camTransform;
    [SerializeField]private float speed = 1;
    [SerializeField]private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        Vector3 camForward = camTransform.forward;
        Vector3 camRight = camTransform.right;

        camForward.y = 0f;
        camRight.y = 0f;
        camForward.Normalize();
        camRight.Normalize();

        // Combine input with camera direction
        Vector3 movement = (camForward * vertical + camRight * horizontal) * speed * Time.deltaTime;

        // Apply the movement to the player
        Vector3 newPosition = rb.position + movement;
        rb.MovePosition(newPosition);

    }
}
