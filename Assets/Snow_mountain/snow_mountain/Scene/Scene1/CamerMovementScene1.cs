using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerMovementScene1 : MonoBehaviour
{
    // Start is called before the first frame update
    public float timer = 0f;
    public float speed;
    public float rotSpeed;
    public float posSpeed;
    void Update()
    {
        timer += Time.deltaTime;
        if (timer <= 10)
        {

                Vector3 pos = transform.position; // getting the position of the camera
                transform.Rotate(-timer / 2 * rotSpeed, speed * timer * rotSpeed, 0);
                pos.x += speed * timer * rotSpeed;
                pos.y += speed * timer * rotSpeed;
                pos.z += speed * timer * posSpeed;
                transform.position = pos; // applying the new position 
            
        }
        if (timer > 10)
        {
            GameObject.FindGameObjectWithTag("Music").GetComponent<MusicScript>().StopMusic();
        }

    }
}
