using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Stoneselect : MonoBehaviour
{
    int a;
    
    // Start is called before the first frame update
    void Start()
    {
        a = PlayerPrefs.GetInt("CHARA_NUMBER", 1);
        Debug.Log(a);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
