using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Stoneselect : MonoBehaviour
{
    [SerializeField] int stone_number;

    [SerializeField] GameObject No0;
    [SerializeField] GameObject No1;
    [SerializeField] GameObject No2;
    [SerializeField] GameObject No3;
    [SerializeField] GameObject No4;
    [SerializeField] GameObject No5;
    [SerializeField] GameObject No6;
    [SerializeField] GameObject No7;
    [SerializeField] GameObject No8;
    [SerializeField] GameObject No9;
    [SerializeField] GameObject No10;
    [SerializeField] GameObject No11;


    // Start is called before the first frame update
    void Start()
    {
        stone_number = PlayerPrefs.GetInt("CHARA_NUMBER", 0);

        No0.SetActive(false);
        No1.SetActive(false);
        No2.SetActive(false);
        No3.SetActive(false);
        No4.SetActive(false);
        No5.SetActive(false);
        No6.SetActive(false);
        No7.SetActive(false);
        No8.SetActive(false);
        No9.SetActive(false);
        No10.SetActive(false);
        No11.SetActive(false);



        if (stone_number == 0)
        {
            No0.SetActive(true);
        }else if (stone_number == 1)
        {
            No1.SetActive(true);
        }
        else if (stone_number == 2)
        {
            No2.SetActive(true);
        }
        else if (stone_number == 3)
        {
            No3.SetActive(true);
        }
        else if (stone_number == 4)
        {
            No4.SetActive(true);
        }
        else if (stone_number == 5)
        {
            No5.SetActive(true);
        }
        else if (stone_number == 6)
        {
            No6.SetActive(true);
        }
        else if (stone_number == 7)
        {
            No7.SetActive(true);
        }
        else if (stone_number == 8)
        {
            No8.SetActive(true);
        }
        else if (stone_number == 9)
        {
            No9.SetActive(true);
        }
        else if (stone_number == 10)
        {
            No10.SetActive(true);
        }
        else if (stone_number == 11)
        {
            No11.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
