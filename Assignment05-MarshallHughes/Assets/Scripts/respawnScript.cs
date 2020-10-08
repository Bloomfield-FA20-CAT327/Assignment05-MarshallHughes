using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnScript : MonoBehaviour
{
    public GameObject prefab;

    public GameObject respawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {

            if (Input.GetKeyDown(KeyCode.R))
            {
                prefab.transform.position = respawn.transform.position;
            }

        }

       
    }
}
