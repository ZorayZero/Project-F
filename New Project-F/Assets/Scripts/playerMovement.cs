using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public float moveSpeed;
    public GameObject player;
    public Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /* - Player inputs for forward, backward, left, and right relative to world space 
           - Normalize the vectors so the diagnal movement speed is equal to the X and Z movement speed.
         */
        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.Translate(moveDirection.normalized * moveSpeed * Time.deltaTime);

        while (Input.GetMouseButtonDown(1))
        {
            moveSpeed *= 2;
        }
    }
}
