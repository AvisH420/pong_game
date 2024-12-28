using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 7;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.name == "player1"){
        float verticalinput1 = Input.GetAxis("Vertical1");
        rb.velocity = new Vector2(0f, verticalinput1) * speed;
        }
        else{
            float verticalinput2 = Input.GetAxis("Vertical2");
            rb.velocity = new Vector2(0f, verticalinput2) * speed;
        }
        
    }
}
