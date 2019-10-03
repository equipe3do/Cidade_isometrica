using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Co_menu : MonoBehaviour
{
    // Start is called before the first frame update

    Rect Rect_play = new Rect(Screen.height/2, 100,80,40);
    Rect Rect_load = new Rect(Screen.height / 2, 150, 80, 40);
    Rect Rect_option = new Rect(Screen.height / 2, 200, 80, 40);
    Rect Rect_info = new Rect(Screen.height / 2, 250, 80, 40);
    Rect Rect_exit = new Rect(Screen.height / 2, 300, 80, 40);
    public Sprite Img_play;
    public Sprite Img_load;
    public Sprite Img_option;
    public Sprite Img_info;
    public Sprite Img_exit;
    public Sprite Img_mouse_sobre;
    public Sprite Img_play_in;
    public Sprite Img_load_in;
    public Sprite Img_option_in;
    public Sprite Img_info_in;
    public Sprite Img_exit_in;
    public Sprite Img_mouse_fora;
    //bool mouse = false;
    Vector2 mouse;
    bool play = false;
    bool load = false;
    bool option = false;
    bool info = false;
    bool exit = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Verifica_menu();
        mouse = new Vector2(Input.mousePosition.x, Screen.height - Input.mousePosition.y);
    }
    void Verifica_menu()
    {

        if (Img_play.rect.Contains(Input.mousePosition))
        {
            OnMouseEnter();
            print("mouse sobre o play");
            play = true;
        }
        else
        {
            //mouse = false;
            play = false;
        }
        if (Rect_load.Contains(Input.mousePosition))
        {
            OnMouseEnter();
            print("mouse sobre o load");
            load = true;
        }
        else
        {
            //mouse = false;
            load = false;
        }

        if (Rect_info.Contains(Input.mousePosition))
        {
            OnMouseEnter();
            print("mouse sobre o info");
            info = true;
        }
        else
        {
            //mouse = false;
            info = false;
        }
        if (Rect_option.Contains(Input.mousePosition))
        {
            OnMouseEnter();
            print("mouse sobre o option");
            option = true;
        }
        else
        {
            //mouse = false;
            option = false;
        }
        if (Rect_exit.Contains(Input.mousePosition))
        {
            OnMouseEnter();
            print("mouse sobre o exit");
            exit = true;
        }
        else
        {
            //mouse = false;
            exit = false;
        }
    }

     void OnMouseEnter()
    {
        //mouse = true;
    }
    void OnGUI()
    {
        //GUI.DrawTexture(new Rect (0,0,64,64),Img_exit.texture);
        if(GUI.Button(Rect_play, Img_play.texture, GUIStyle.none))
        {
            SceneManager.LoadScene("Ce_jogar");
            //print("Go play");
        }
            if (Rect_play.Contains(mouse)) {
                GUI.Button(Rect_play, Img_play_in.texture, GUIStyle.none);
            
            }
        if(GUI.Button(Rect_load, Img_load.texture, GUIStyle.none))
        {
            //print("Go load");
            SceneManager.LoadScene("Ce_carregar");
        }
            if (Rect_load.Contains(mouse))
            {
                GUI.Button(Rect_load, Img_load_in.texture, GUIStyle.none);
            }
       
        if(GUI.Button(Rect_option, Img_option.texture, GUIStyle.none))
        {
            //print("Go options");
            SceneManager.LoadScene("Ce_opcoes");
        }
            if (Rect_option.Contains(mouse))
            {
                GUI.Button(Rect_option, Img_option_in.texture, GUIStyle.none);
            }

        if(GUI.Button(Rect_info, Img_info.texture, GUIStyle.none))
        {
            //print("Go infos");
            SceneManager.LoadScene("Ce_info");
        }

            if (Rect_info.Contains(mouse))
            {
                GUI.Button(Rect_info, Img_info_in.texture, GUIStyle.none);
            }

        if(GUI.Button(Rect_exit, Img_exit.texture, GUIStyle.none))
        {
            //print("Go exit");
        }
            if (Rect_exit.Contains(mouse))
            {
                GUI.Button(Rect_exit, Img_exit_in.texture, GUIStyle.none);
            }
        //if(mouse==true){
        //  GUI.Button(Rect_play, Img_mouse_sobre.texture, GUIStyle.none);
        //
        // }


    }
}
