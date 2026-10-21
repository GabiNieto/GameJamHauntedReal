using UnityEngine;

public class customTrigger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    public event System.Action<Collider2D> EnteredTrigger;

    public event System.Action<Collider2D> ExitedTrigger;


    void OnTriggerEnter2D(Collider2D collider)
    {
        EnteredTrigger?.Invoke(collider);
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        ExitedTrigger?.Invoke(collider);
    }



}
