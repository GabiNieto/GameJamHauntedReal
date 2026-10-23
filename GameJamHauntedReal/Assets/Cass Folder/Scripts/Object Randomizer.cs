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

        Debug.Log(transform.position);

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


    public void notMimic()
    {
        int randomNumMim = Random.Range(0, 3);
        if(randomNumMim == 0)
        {
            Instantiate(baseVase, transform.position, Quaternion.identity);
        }
        if(randomNumMim == 1)
        {
            Instantiate(baseStatue, transform.position, Quaternion.identity);
        }
        else
        {
            Instantiate(baseChair, transform.position, Quaternion.identity);
        }
    }

    public void isMimic()
    {
        int randomNumNotMim = Random.Range(0, 3);
        if(randomNumNotMim == 0)
        {
            Instantiate(mimicVase, transform.position, Quaternion.identity);
        }
        else if(randomNumNotMim == 1)
        {
            Instantiate(mimicStatue, transform.position, Quaternion.identity);
        }
        else if(randomNumNotMim == 2)
        {
            Instantiate(mimicChair, transform.position, Quaternion.identity);
        }

    }



    // Update is called once per frame
    void Update()
    {

    }
}
