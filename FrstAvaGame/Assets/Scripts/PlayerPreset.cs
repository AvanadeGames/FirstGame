using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPreset : MonoBehaviour
{
    //Preset para colocar nos personagens, inimigos, etc.

    public GameObject player;
    public SpriteRenderer spriteRenderer;
    public Rigidbody2D rigidbody;
    public Animator animator;
    public float velocity;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
