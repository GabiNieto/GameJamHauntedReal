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
    public customTrigger middleCircle;
    public customTrigger outerCircle;
    public customTrigger playerHitBox;

    private bool isMoving;

    public Animator animator;
    public SpriteRenderer sr;

    private GameObject attacker;

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

        if(speedX == 0 &&  speedY == 0)
        {
            isMoving = false;
        }
        else
        {
            isMoving = true;
        }
        if(speedX > 0)
        {
            sr.flipX = true;
        }
        else
        {
            sr.flipX = false;
        }

            animator.SetBool("isMoving", isMoving);

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
        middleCircle.EnteredTrigger += onMiddleCircleTriggerEnter;
        middleCircle.ExitedTrigger += onMiddleCircleTrigerExit;
        outerCircle.EnteredTrigger += onOuterCircleTriggerEnter;
        outerCircle.ExitedTrigger += onOuterCircleTriggerExit;
        playerHitBox.EnteredTrigger += onPlayerHitBoxEnter;
        playerHitBox.ExitedTrigger += onPlayerHitBoxExit;
    }

    void onInnerCircleTriggerEnter(Collider2D collider)
    {
        //Debug.Log("Hey I entered inner cicle says" + collider.name);
        if(collider.CompareTag("mimic"))
        {
            gameManager.isInnerCircle();
        }
    }

    void onInnerCircleTriggerExit(Collider2D collider)
    {
        //Debug.Log("Hey I exited inner cicle says" + collider.name);
        if(collider.CompareTag("mimic"))
        {
            gameManager.leftInnerCircle();
        }
    }

    void onMiddleCircleTriggerEnter(Collider2D collider)
    {
        Debug.Log("Hey I Entered middle circle says" + collider.name);
        gameManager.isMiddleCircle();
    }

    void onMiddleCircleTrigerExit(Collider2D collider)
    {
        Debug.Log("Hey I exited middle cicle says" + collider.name);
        gameManager.leftMiddleCircle();
    }

    void onOuterCircleTriggerEnter(Collider2D collider)
    {
        //Debug.Log("Hey I entered outer cicle says" + collider.name);
        if(collider.CompareTag("mimic"))
        {
            gameManager.isOuterCircle();
        }
    }

    void onOuterCircleTriggerExit(Collider2D collider)
    {
        //Debug.Log("Hey I exited outer cicle says" + collider.name);
        if(collider.CompareTag("mimic"))
        {
            gameManager.leftOuterCircle();
        }
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
            attacker = collider.gameObject;
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
            attacker.GetComponent<mimic>().WhenAction();
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
