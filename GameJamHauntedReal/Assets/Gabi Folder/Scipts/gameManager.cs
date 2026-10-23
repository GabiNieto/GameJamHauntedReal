using TMPro;
using UnityEngine;

public class gameManager : MonoBehaviour
{


    public player player;

    public detector detector;

    private int playerHealth;
    private int playerTreasure;

    [SerializeField] TextMeshProUGUI healthText;
    [SerializeField] TextMeshProUGUI treasureText;
    [SerializeField] TextMeshProUGUI deadText;
    [SerializeField] TextMeshProUGUI detectorText;

    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource sfxSource;

    [SerializeField] private AudioClip music;
    [SerializeField] private AudioClip sfxCoin;
    [SerializeField] private AudioClip sfxMimic;

    private bool innerCircle = false;
    private bool middleCircle = false;
    private bool outerCircle = false;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        detectorText.enabled = false;
        playerHealth = player.getHealth();
        playerTreasure = player.getTreasure();
        Debug.Log(playerHealth);
        Debug.Log(playerTreasure);


        deadText.enabled = false;
        healthText.text = "Health: " + playerHealth.ToString();
        treasureText.text = "Treasure: " + playerTreasure.ToString();

        //Start Music
        musicSource.clip = music;
        musicSource.loop = true;
        musicSource.Play();
    }


    public void updateData()
    {
        playerHealth = player.getHealth();
        playerTreasure = player.getTreasure();

        healthText.text = "Health: " + playerHealth.ToString();
        treasureText.text = "Treasure: " + playerTreasure.ToString();

        if(playerHealth == 2)
        {
            detector.healthIs2();
        }
        if(playerHealth == 1)
        {
            detector.healthIs1();
        }
    }

    public void playerDead()
    {
        deadText.enabled = true;
    }

    public void playTreasureSFX()
    {
        sfxSource.clip = sfxCoin;
        sfxSource.Play();
    }

    public void playHurtSFX()
    {
        sfxSource.clip = sfxMimic;
        sfxSource.Play();
    }


    public void isInnerCircle()
    {
        innerCircle = true;
        detectTextUpdate();

        //UI Detect
    }

    public void leftInnerCircle()
    {
        innerCircle = false;
        detectTextUpdate();

        //UI Detect


    }

    public void isMiddleCircle()
    {
        middleCircle = true;
        detectTextUpdate();
        //UI Detect
    }

    public void leftMiddleCircle()
    {
        middleCircle=false;
        detectTextUpdate();
        //UI Detect


    }

    public void isOuterCircle()
    {
        outerCircle = true;
        detectTextUpdate();

        //UI Dtect
    }

    public void leftOuterCircle()
    {
        outerCircle = false;
        detectTextUpdate();

        //UI Detect

    }

    public void detectTextUpdate()
    {
        if(!innerCircle ||  !outerCircle || !middleCircle)
        {
            detectorText.enabled = true;
            detector.isNothing();
        }
        if (innerCircle)
        {
            detector.isNear();
            detector.notIsFar();
            detector.notIsMid();
            //detectorText.text = "Mimic Close!";
            //detector.isClose();
            //detector.notIsNear();
            //detector.notIsFar();
        }
        else if (middleCircle)
        {
            detector.isMid();
            detector.notIsNear();
            detector.notIsFar();
        }
        else if (outerCircle)
        {
            detector.isFar();
            detector.notIsNear();
            detector.notIsMid();
            //detectorText.text = "Mimic Near";
            //detector.isNear();
            //detector.notIsFar();
            //detector.notIsClose();
        }
    }






    // Update is called once per frame
    void Update()
    {
        
    }
}
