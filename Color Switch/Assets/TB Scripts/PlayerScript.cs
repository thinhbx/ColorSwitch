using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]
    private float jumpForce;
    [SerializeField]
    private Color blue;
    [SerializeField]
    private Color yellow;
    [SerializeField]
    private Color pink;
    [SerializeField]
    private Color purple;
    public SpriteRenderer renSprite;
    string currentColor;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        SetRandomColor();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ChangeColor")
        {
            SetRandomColor();
            Destroy(collision.gameObject);
            return;
        }
        if (collision.tag != currentColor)
        {
            Debug.LogError("EndGame");
        }
       
    }
    void SetRandomColor()
    {
        int index = Random.Range(0, 3);
        switch (index)
        {
            case 0:
                currentColor = "Blue";
                renSprite.color = blue;
                break;
            case 1:
                 currentColor = "Yellow";
                renSprite.color = yellow;
                break;
            case 2:
                currentColor = "Pink";
                renSprite.color = pink;
                break;
            case 3:
                currentColor = "Purple";
                renSprite.color = purple;
                break;
        }
    }
}
