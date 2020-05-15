using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimTest : MonoBehaviour
{
    // Start is called before the first frame update
    public float timer = 0f;

    void Start()
    {
        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicScript>().PlayMusic();
        GameObject.FindGameObjectWithTag("wind").GetComponent<MusicScript>().PlayMusic();
    }
    void Update()
    {
            timer += Time.deltaTime;
            if (timer >= 5)
            {
            SceneManager.LoadScene(1);
                
            }
            
            
    }
        
}
