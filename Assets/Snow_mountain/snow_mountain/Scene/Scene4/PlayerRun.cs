using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRun : MonoBehaviour
{
    public Animator Animator;
    
    public float gravity = 20.0f;

    public Vector3 moveDirection = Vector3.zero;
    public CharacterController controller;
    private readonly float speed = 6.0f;
    private float InputY;
    // Start is called before the first frame update
    void Start()
    {
        // getting the animator 
       // Animator = this.gameObject.GetComponent<Animator>();
        // getting the controller 
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        /*InputY = Input.GetAxis("Vertical");
        Animator.SetFloat("InputY", InputY);
        if (InputY == 1 )
        {*/
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            moveDirection.y -= gravity * Time.deltaTime;
            controller.SimpleMove(moveDirection * Time.deltaTime);

        //}
        
    }
}
