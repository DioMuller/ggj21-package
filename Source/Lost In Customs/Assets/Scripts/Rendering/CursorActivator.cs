using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorActivator : MonoBehaviour
{    
    void OnEnable()
    {
        Cursor.visible = true;
    }

    private void OnDisable() 
    {
        Cursor.visible = false;
    }
}
