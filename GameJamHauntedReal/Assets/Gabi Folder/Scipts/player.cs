using UnityEngine;

public class player : MonoBehaviour
{

    public gameManager gameManager;

    public float movSpeed;
    float speedX;
    float speedY;
    Rigidbody2D rb;
    bool isTreasure = false;
    bool isMimic = false;

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

        if(other.CompareTag("mimic"))
        {
            isMimic=true;
        }
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("treasure"))
        {
            isTreasure = false;
        }


        if(other.CompareTag("mimic"))
        {
            isMimic= false;
        }
    }



    public void Action()
    {
        if(isTreasure)
        {
            gainTreasure();
            treasureSelection.SetActive(false);
        }
        Debug.Log(treasure);
        if(isMimic)
        {
            takeDamage();
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
        gameManager.updateData();

    }

    public void gainTreasure()
    {
        treasure++;
        Debug.Log(treasure);
        gameManager.updateData();
    }

    public void dead()
    {
        Debug.Log("You are Dead");
        gameManager.playerDead();
    }

    public int getHealth()
    {
        return health;
    }

    public int getTreasure()
    {
        return treasure;
    }



}
