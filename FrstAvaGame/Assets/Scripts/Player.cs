using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : PlayerPreset
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Movimentos dos personagens
        float moveX = Input.GetAxisRaw("Horizontal") * velocity * Time.deltaTime;
        float moveY = Input.GetAxisRaw("Vertical") * velocity * Time.deltaTime;
        transform.Translate(moveX, moveY, 0.0f);
    }
}
