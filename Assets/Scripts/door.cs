using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public void MoveDown()
    {
        StartCoroutine(MoveObject(transform.position, transform.position - new Vector3(0,2.5f,0)));
    }

    private IEnumerator MoveObject(Vector3 origin, Vector3 destination)
    {
        float totalMovementTime = 5f;
        float currentMovementTime = 0f;
        while (Vector3.Distance(transform.position, destination) > 0)
        {
            currentMovementTime += Time.deltaTime;
            transform.position = Vector3.Lerp(origin, destination, currentMovementTime / totalMovementTime);
            yield return null;
        }
    }   
}
