using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Co_volta_menu : MonoBehaviour
{
    // Start is called before the first frame update

    Rect Rect_volta = new Rect(400,400,80,40);
    public Sprite Img_volta;
    public Sprite Img_volta_de;
    Vector2 mouse;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouse = new Vector2(Input.mousePosition.x, Screen.height - Input.mousePosition.y);
    }

    private void OnGUI()
    {

        if (GUI.Button(Rect_volta, Img_volta.texture, GUIStyle.none))
        {
            //print("Go play");
            SceneManager.LoadScene("Ce_menu");
        }
            if (Rect_volta.Contains(mouse))
            {
                GUI.Button(Rect_volta, Img_volta_de.texture, GUIStyle.none);
            }

    }
}
