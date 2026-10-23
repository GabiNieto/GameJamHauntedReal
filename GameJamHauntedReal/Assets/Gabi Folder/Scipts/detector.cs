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

    public void isNear()
    {
        anim.SetBool("MidSuccess", true);
    }

    public void notIsNear()
    {
        anim.SetBool("MidSuccess", false);
    }

    public void isClose()
    {
        anim.SetBool("NearSuccess", true);
    }

    public void notIsClose()
    {
        anim.SetBool("MidSuccess", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
