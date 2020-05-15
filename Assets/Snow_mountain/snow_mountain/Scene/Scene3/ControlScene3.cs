using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlScene3 : MonoBehaviour
{
    private float timer = 0f;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 12)
        {
            SceneManager.LoadScene(4);
        }
        
    }
}
