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

    // Update is called once per frame
    void Update()
    {
        
    }
}
