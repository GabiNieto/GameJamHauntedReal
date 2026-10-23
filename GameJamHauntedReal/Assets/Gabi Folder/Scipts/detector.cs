using UnityEngine;

public class detector : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public SpriteRenderer spriteRenderer;
    public Sprite health3;
    public Sprite health2;
    public Sprite health1;



    public void healthIs3()
    {
        spriteRenderer.sprite = health3;
    }

    public void healthIs2()
    {
        spriteRenderer.sprite = health2;
    }

    public void healthIs1()
    {
        spriteRenderer.sprite = health1;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
