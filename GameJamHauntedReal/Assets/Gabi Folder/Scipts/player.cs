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

    public customTrigger innerCircle;
    public customTrigger outerCircle;
    public customTrigger playerHitBox;




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

    /* Legacy Enter
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
    */


    private void Awake()
    {
        innerCircle.EnteredTrigger += onInnerCircleTriggerEnter;
        innerCircle.ExitedTrigger += onInnerCircleTriggerExit;
        outerCircle.EnteredTrigger += onOuterCircleTriggerEnter;
        outerCircle.ExitedTrigger += onOuterCircleTriggerExit;
        playerHitBox.EnteredTrigger += onPlayerHitBoxEnter;
        playerHitBox.ExitedTrigger += onPlayerHitBoxExit;
    }

    void onInnerCircleTriggerEnter(Collider2D collider)
    {
        //Debug.Log("Hey I entered inner cicle says" + collider.name);
    }

    void onInnerCircleTriggerExit(Collider2D collider)
    {
        //Debug.Log("Hey I exited inner cicle says" + collider.name);
    }

    void onOuterCircleTriggerEnter(Collider2D collider)
    {
        //Debug.Log("Hey I entered outer cicle says" + collider.name);
    }

    void onOuterCircleTriggerExit(Collider2D collider)
    {
        //Debug.Log("Hey I exited outer cicle says" + collider.name);
    }

    void onPlayerHitBoxEnter(Collider2D collider)
    {
        //Debug.Log("Hey I Enter Player says " + collider.name);
        if (collider.CompareTag("treasure"))
        {
            isTreasure = true;
            treasureSelection = collider.gameObject;
        }
        if (collider.CompareTag("mimic"))
        {
            isMimic = true;
        }
    }
    void onPlayerHitBoxExit(Collider2D collider)
    {
        //Debug.Log("Hey I Exit Player says " + collider.name);
        if(collider.CompareTag("treasure"))
        {
            isTreasure = false;
        }

        if(collider.CompareTag("mimic"))
        {
            isMimic = false;
        }
    }




    /* Legacy Exit
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
    */


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
        gameManager.playHurtSFX();
        gameManager.updateData();

    }

    public void gainTreasure()
    {
        treasure++;
        Debug.Log(treasure);
        gameManager.playTreasureSFX();
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
