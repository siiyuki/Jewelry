using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zukankaihou : MonoBehaviour
{
    public int zukan_num;
    public GameObject iti;
    public GameObject ni;
    public GameObject san;
    public GameObject yon;
    public GameObject go;
    public GameObject roku;
    public GameObject nana;
    public GameObject hati;
    public GameObject q;
    public GameObject ju;
    public GameObject juiti;
    public GameObject juni;

    // Start is called before the first frame update
    void Start()
    {
        zukan_num = PlayerPrefs.GetInt("SCORE", 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (zukan_num >= 1)
        {
            iti.SetActive(false);
        }
        if (zukan_num >= 2)
        {
            ni.SetActive(false);
        }

        if (zukan_num >= 3)
        {
            san.SetActive(false);
        }

        if (zukan_num >= 4)
        {
            yon.SetActive(false);
        }

        if (zukan_num >= 5)
        {
            go.SetActive(false);
        }
        if (zukan_num >= 6)
        {
            roku.SetActive(false);
        }
        if (zukan_num >= 7)
        {
            nana.SetActive(false);
        }
        if (zukan_num >= 8)
        {
            hati.SetActive(false);
        }
        if (zukan_num >= 9)
        {
            q.SetActive(false);
        }
        if (zukan_num >= 10)
        {
            ju.SetActive(false);
        }
        if (zukan_num >= 11)
        {
            juiti.SetActive(false);
        }
        if (zukan_num >= 12)
        {
            juni.SetActive(false);
        }

    }
}
