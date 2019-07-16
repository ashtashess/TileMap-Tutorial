using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D rb2d;
    private int count;
    public float speed;
    public float jumpForce;
    public Text countText;
    public Text winText;


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        count = 0;
        winText.text = "";
        SetAllText();
    }

    private void SetAllText()
    {
        throw new NotImplementedException();
    }

    void FixedUpdate()
        {


        if (Input.GetKey("escape"))
            Application.Quit();


        float moveHozizontal = Input.GetAxis("Horizontal");

            Vector2 movement = new Vector2(moveHozizontal, 0);

            rb2d.AddForce(movement * speed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetAllText();
        }

        void SetAllText()
        {
            countText.text = "Count " + count.ToString();
            if (count>= 4)
            {
                winText.text = "You Win!";
            }
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground") { 
            if (Input.GetKey(KeyCode.UpArrow)) {

                rb2d.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);

            }
        }
    }

}
