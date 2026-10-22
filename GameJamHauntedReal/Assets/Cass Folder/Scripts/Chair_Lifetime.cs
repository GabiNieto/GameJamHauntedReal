using JetBrains.Annotations;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Statue_Lifetime : MonoBehaviour
{
    public int HighestValue = 11;
    int ObjectType = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int AreYouAMimic = Random.Range(1, HighestValue);
        print(AreYouAMimic);
        if (AreYouAMimic == 11) {
            bool IsAMimic = true;
        }


    }

    public bool IsAMimic;

    // Update is called once per frame
    void Update()
    {
        if (IsAMimic)
        {
            
        }
    }
}
