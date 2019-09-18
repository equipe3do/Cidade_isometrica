using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Co_intro : MonoBehaviour
{
    // Start is called before the first frame update
    float tempo = 2.0f;
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        tempo -= Time.deltaTime;
            if (tempo < 0)
            {
                SceneManager.LoadScene("Ce_menu");
            }
        
    }
}
