using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            Application.LoadLevel("SampleScene");
        }

    }
}
