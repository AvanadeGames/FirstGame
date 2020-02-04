using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : PlayerPreset
{
    public float velocity;
    public float jumpForce;
    public Transform floorVerify;

    bool onFloor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Movimentos dos personagens
        float moveX = Input.GetAxisRaw("Horizontal") * velocity * Time.deltaTime;
        //float moveY = Input.GetAxisRaw("Vertical") * velocity * Time.deltaTime;
        transform.Translate(moveX, 0.0f, 0.0f);

        //Verifica colisao com o chao
        onFloor = Physics2D.Linecast(transform.position, floorVerify.transform.position,
            1 << LayerMask.NameToLayer("Floor"));

        print(onFloor);

        //Pulo do Player
        if (Input.GetButtonDown("Jump") && onFloor == true)
        {
            rigidbody.AddForce(Vector2.up * jumpForce);
        }

        //Orientacao do Player conforme direcao
        if(Input.GetAxisRaw("Horizontal") > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            spriteRenderer.flipX = true;
        }

        //animacoes
        animator.SetBool("Jumpin", onFloor);
        animator.SetFloat("Move", Mathf.Abs(Input.GetAxisRaw("Horizontal")));
    }
}
