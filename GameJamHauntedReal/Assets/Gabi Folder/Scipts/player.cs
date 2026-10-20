using UnityEngine;

public class player : MonoBehaviour
{

    public float movSpeed;
    float speedX;
    float speedY;
    Rigidbody2D rb;
    bool isTreasure = false;

    public int health;
    public int treasure;


    GameObject treasureSelection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame





    void Update()
    {
        speedX = Input.GetAxisRaw("Horizontal") * movSpeed;
        speedY = Input.GetAxisRaw("Vertical") * movSpeed;
        rb.linearVelocity = new Vector2(speedX, speedY);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Action();
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("treasure"))
        {
            isTreasure=true;
            treasureSelection = other.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("treasure"))
        {
            isTreasure = false;
        }
    }



    public void Action()
    {
        Debug.Log(treasure);
        if(isTreasure)
        {
            treasure++;
            treasureSelection.SetActive(false);
        }
    }

    public void takeDamage()
    {
        health--;
        Debug.Log("Current Health " + health);
        if (health <= 0)
        {
            dead();
        }

    }

    public void gainTreasure()
    {
        treasure++;
        Debug.Log(treasure);
    }

    public void dead()
    {
        Debug.Log("You are Dead");
    }



}
