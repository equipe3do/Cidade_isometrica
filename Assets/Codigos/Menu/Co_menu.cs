using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public Sprite Img_mouse_sobre;
    bool mouse = false;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Rect_play.Contains(Input.mousePosition))
        {
            OnMouseEnter();
            print("mouse sobre o play");
        }
        else
        {
            mouse = false;
        }
    }

     void OnMouseEnter()
    {
        mouse = true;
    }
    void OnGUI()
    {
        if(GUI.Button(Rect_play, Img_play.texture, GUIStyle.none))
        {
            print("Go play");
            SceneManager.LoadScene("Ce_jogar");
        }
        if(GUI.Button(Rect_load, Img_load.texture, GUIStyle.none))
        {
            print("Go load");
            SceneManager.LoadScene("Ce_carregar");
        }
        if(GUI.Button(Rect_option, Img_option.texture, GUIStyle.none))
        {
            print("Go options");
            SceneManager.LoadScene("Ce_opcoes");
        }
        if(GUI.Button(Rect_info, Img_info.texture, GUIStyle.none))
        {
            print("Go infos");
            SceneManager.LoadScene("Ce_info");
        }
        if(GUI.Button(Rect_exit, Img_exit.texture, GUIStyle.none))
        {
            print("Go exit");
        }
        if(mouse==true){
            GUI.Button(Rect_play, Img_mouse_sobre.texture, GUIStyle.none);
        }
    }
}
