using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    
    public float radius = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            //¿ÞÂÊ È­»ìÇ¥¸¦ ´­·¶´Ù¸é
            MoveLeft();
        }

        else if (Input.GetKeyDown(KeyCode.RightArrow)) {
            MoveRight();
        }
    }
    public void MoveLeft()
    {
        this.transform.Translate(-3, 0, 0);
    }

    public void MoveRight()
    {
        this.transform.Translate(3, 0, 0);
    }
}
