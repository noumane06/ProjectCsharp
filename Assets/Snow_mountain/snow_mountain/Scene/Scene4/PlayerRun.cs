using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRun : MonoBehaviour
{
    public Animator animatior;
    public float speed;
    public Vector3 position; 
    public float InputY;
    // Start is called before the first frame update
    void Start()
    {
        // getting the animator 
        animatior = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        InputY = Input.GetAxis("Vertical");
        animatior.SetFloat("InputY", InputY);
        if (InputY == 1 )
        {
            position = transform.position;
            position.z += InputY * speed ;
            transform.position =  position;
        }
        // 83.32 -10.44 6
    }
}
