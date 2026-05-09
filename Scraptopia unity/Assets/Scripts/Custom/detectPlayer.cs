using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectPlayer : MonoBehaviour
{
    [SerializeField] public Mover move;
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(waitThenReverseMovement());
    }

    private void OnTriggerExit(Collider other)
    {
        StartCoroutine(waitThenReverseMovement());
    }
    void Update()
    {
        
    }

    IEnumerator waitThenReverseMovement()
    {
        yield return new WaitForSeconds(0.5f);
        move.reverseMovement();
        Debug.Log("Reversed");

    }
}
