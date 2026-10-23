using UnityEngine;

public class detector : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Animator anim;



    void Start()
    {
        //Debug.Log(anim);
        //anim.SetInteger("Hp", 2);
        //Debug.Log(anim.GetInteger("Hp"));
    }

    public void healthIs2()
    {
        anim.SetInteger("Hp", 2);
    }

    public void healthIs1()
    {
        anim.SetInteger("Hp", 1);
    }

    public void isFar()
    {
        anim.SetBool("FarSuccess", true);
    }

    public void notIsFar()
    {
        anim.SetBool("FarSuccess", false);
    }

    public void isMid()
    {
        anim.SetBool("MidSuccess", true);
    }

    public void notIsMid()
    {
        anim.SetBool("MidSuccess", false);
    }

    public void isNear()
    {
        anim.SetBool("NearSuccess", true);
    }

    public void notIsNear()
    {
        anim.SetBool("NearSuccess", false);
    }

    public void isNothing()
    {
        anim.SetBool("NearSuccess", false);
        anim.SetBool("MidSuccess", false);
        anim.SetBool("FarSuccess", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
