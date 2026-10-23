using UnityEngine;

public class mimic : MonoBehaviour
{
    public Animator anim;

    public AnimationClip attackVase;
    public AnimationClip attackStatue;
    public AnimationClip attackChair;
    public bool isVase;
    public bool isStatue;
    public bool isChair;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void WhenAction()
    {
        if (isVase == true)
        {
            anim.SetBool("Attack", true);
            Destroy(gameObject);
        }
        if(isStatue == true)
        {
            anim.SetBool("Attack", true);
            Destroy(gameObject);
        }
        if(isChair == true)
        {
            anim.SetBool("Attack", true);
            Destroy(gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onBigZoneEnter(Collider2D other)
    {

    }

    public void onSmallZoneEnter(Collider2D other)
    {

    }

}
