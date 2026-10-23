using JetBrains.Annotations;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectRandomizer : MonoBehaviour
{
    public Vector2 RandomObjectPosition = new Vector2(0, 0);
    public int mimicType = 0; //staute, chair, etcct
    public bool IsAMimic = false;



    public GameObject baseVase;
    public GameObject baseStatue;
    public GameObject baseChair;
    public GameObject mimicVase;
    public GameObject mimicStatue;
    public GameObject mimicChair;






    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        int randomNumber = Random.Range(0, 11);

        if (randomNumber == 10)
        {
            isMimic();
        }
        else
        {
            notMimic();
        }
    }


    public void isMimic()
    {
        int randomNumMim = Random.Range(0, 3);
        if(randomNumMim == 0)
        {

        }
        if(randomNumMim == 1)
        {

        }
        else
        {

        }
    }

    public void notMimic()
    {
        int randomNumNotMim = Random.Range(0, 3);
        if(randomNumNotMim == 0)
        {

        }
        if(randomNumNotMim == 1)
        {

        }
        else
        {

        }

    }



    // Update is called once per frame
    void Update()
    {

    }
}
