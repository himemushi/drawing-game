using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toolcontrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        if (gameObject.name == "icon eraser")
        {
            paintGM.toolType = "eraser";
            //Debug.Log("eraser selected");
        }

        if (gameObject.name == "icon pencil")
        {
            paintGM.toolType = "pencilsprite";
            //Debug.Log("eraser selected");
        }
    }
}
