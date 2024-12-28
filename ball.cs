using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class ball : MonoBehaviour
{
    Rigidbody2D rb;
    public TextMeshProUGUI p1score,p2score;
    public int p1,p2;
    Vector3 ogPosition;
    Vector3 ogPositionP1;
    Vector3 ogPositionP2;
    public float speed;
    public Transform player1Transform;
    public Transform player2Transform;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ogPosition = transform.position;
        ogPositionP1 = player1Transform.position;
        ogPositionP2 = player2Transform.position;
        resetBall();
        p1 = 0;
        p2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void resetBall()
    {
         transform.position = ogPosition;
         player1Transform.position = ogPositionP1;
         player2Transform.position = ogPositionP2;

         float randomX = Random.Range(-1f , 1f);
         float randomY = Random.Range(-randomX,randomX);

         Vector3 throwDirection = new Vector2(speed*randomX,speed*randomY).normalized;

         rb.velocity = throwDirection*speed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.name == "right wall" || other.collider.name == "left wall")
        {
            if(other.collider.name == "right wall")
            {
                p1 += 1;
                p1score.text = p1.ToString();
            }
            else if(other.collider.name == "left wall")
            {
                p2 += 1;
                p2score.text = p2.ToString();
            }
            resetBall();
        }
    }
}
