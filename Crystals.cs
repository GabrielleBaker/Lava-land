using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystals : MonoBehaviour
{
    public GameObject endMenu;
    // Start is called before the first frame update
    void Start()
    {
        endMenu.SetActive(false);
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
                Time.timeScale = 0f;
                endMenu.SetActive(true);
                Cursor.visible = true;
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
