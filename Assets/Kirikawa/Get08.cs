using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get08 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject, 0.2f);
            PlayerPrefs.SetInt("SCOREH", 8);
            PlayerPrefs.Save();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
