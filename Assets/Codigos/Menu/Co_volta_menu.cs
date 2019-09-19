using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Co_volta_menu : MonoBehaviour
{
    // Start is called before the first frame update

    Rect Rect_volta = new Rect(400,400,80,40);
    public Sprite Img_volta;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {

        if (GUI.Button(Rect_volta, Img_volta.texture, GUIStyle.none))
        {
            print("Go play");
            SceneManager.LoadScene("Ce_menu");
        }

    }
}
