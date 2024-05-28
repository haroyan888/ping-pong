using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;

public class BarController : MonoBehaviour
{
    private Dictionary<string, Vector2> movableRange;
    
    // Start is called before the first frame update
    void Start()
    {
        movableRange = new Dictionary<string, Vector2>();
        movableRange["min"] =  Camera.main.ViewportToWorldPoint(Vector2.zero);
        movableRange["max"] =  Camera.main.ViewportToWorldPoint(Vector2.one);
    }

    // Update is called once per frame
    void Update()
    {
        // 前に移動
        if (Input.GetKey (KeyCode.UpArrow) && this.movableRange["max"].y >= this.transform.position.y) {
            this.transform.Translate (0.0f,0.1f,0.0f);
        }
        // 後ろに移動
        if (Input.GetKey (KeyCode.DownArrow) && this.movableRange["min"].y <= this.transform.position.y) {
             this.transform.Translate (0.0f,-0.1f,0.0f);
        }
    }
}
