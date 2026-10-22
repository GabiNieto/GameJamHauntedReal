using TMPro;
using UnityEngine;

public class gameManager : MonoBehaviour
{


    public player player;

    private int playerHealth;
    private int playerTreasure;

    [SerializeField] TextMeshProUGUI healthText;
    [SerializeField] TextMeshProUGUI treasureText;
    [SerializeField] TextMeshProUGUI deadText;

    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource sfxSource;

    [SerializeField] private AudioClip music;
    [SerializeField] private AudioClip sfxCoin;
    [SerializeField] private AudioClip sfxMimic;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
