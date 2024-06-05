using System.Collections;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject startPoint;
    public GameObject player;

    private void Start()
    {
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.transform.position = startPoint.transform.position;
        }
    }



}
