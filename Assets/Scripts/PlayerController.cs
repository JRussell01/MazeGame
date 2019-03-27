using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;
    public AudioSource Win;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = " ";
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertival = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertival);

        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Chest")) 
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }
        void SetCountText ()
    {
        countText.text = "Treasure Aquired: " + count.ToString();
        if (count >= 7)
        {
            winText.text = "Congratulations You Win!";
            Win.Play(); 
        }
    }
}


