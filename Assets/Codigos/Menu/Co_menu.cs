using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Co_menu : MonoBehaviour
{
    // Start is called before the first frame update

    Rect Rect_play = new Rect(300,100,80,40);
    Rect Rect_load = new Rect(300, 150, 80, 40);
    Rect Rect_option = new Rect(300, 200, 80, 40);
    Rect Rect_info = new Rect(300, 250, 80, 40);
    Rect Rect_exit = new Rect(300, 300, 80, 40);
    public Sprite Img_play;
    public Sprite Img_load;
    public Sprite Img_option;
    public Sprite Img_info;
    public Sprite Img_exit;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnGUI()
    {
        GUI.Button(new Rect(Rect_play),Img_play.texture,GUIStyle.none);
        GUI.Button(new Rect(Rect_load), Img_load.texture, GUIStyle.none);
        GUI.Button(new Rect(Rect_option), Img_option.texture, GUIStyle.none);
        GUI.Button(new Rect(Rect_info), Img_info.texture, GUIStyle.none);
        GUI.Button(new Rect(Rect_exit), Img_exit.texture, GUIStyle.none);
    }
}
