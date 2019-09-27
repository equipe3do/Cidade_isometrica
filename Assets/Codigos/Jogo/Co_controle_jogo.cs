using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Co_controle_jogo : MonoBehaviour
{
    public Texture2D mouse;
    public Vector2 hotspot = Vector2.zero;
    public CursorMode cursormode = CursorMode.Auto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnGUI()
    {
        Cursor.SetCursor(mouse, hotspot, cursormode);
    }
}
