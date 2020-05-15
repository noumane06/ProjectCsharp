using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public float timer = 0f;
    
    void Update()
    {
        timer += Time.deltaTime;
       
        if (timer > 10)
        {
            SceneManager.LoadScene(3);
        }

    }
}
