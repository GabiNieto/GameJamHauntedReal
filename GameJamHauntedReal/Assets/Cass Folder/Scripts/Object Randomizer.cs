using JetBrains.Annotations;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectRandomizer : MonoBehaviour
{
    public Vector3 RandomObjectPosition = new Vector3(0, 0, 0);
    public int mimicType = 0;
    public bool IsAMimic = false;

    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        int randomNumber = Random.Range(0, 11);

        if (randomNumber == 11)
        {
            IsAMimic = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = RandomObjectPosition;
    }
}
