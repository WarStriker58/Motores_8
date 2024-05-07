using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC1Controller : MonoBehaviour
{
    public float speed = 3.0f;
    public float pauseDuration = 5.0f;

    private Vector3[] destinations = new Vector3[]
    {
        new Vector3(-72, 3.0f, 122),
        new Vector3(-72, 3.0f, 78),
        new Vector3(-28, 3.0f, 78), 
        new Vector3(-28, 3.0f, 122) 
    };

    private int currentDestinationIndex = 0;

    void Start()
    {
        transform.position = destinations[0];
        StartCoroutine(StartMoving());
    }

    IEnumerator StartMoving()
    {
        yield return new WaitForSeconds(1.0f);
        StartCoroutine(MoveNPC());
    }

    IEnumerator MoveNPC()
    {
        while (true)
        {
            Vector3 currentDestination = destinations[currentDestinationIndex];
            while (transform.position != currentDestination)
            {
                transform.position = Vector3.MoveTowards(transform.position, currentDestination, speed * Time.deltaTime);
                yield return null;
            }
            yield return new WaitForSeconds(pauseDuration);
            currentDestinationIndex++;
            if (currentDestinationIndex >= destinations.Length)
            {
                currentDestinationIndex = 0;
            }
        }
    }
}