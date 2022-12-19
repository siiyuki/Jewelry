using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zukankaihou : MonoBehaviour
{
    public int zukan_numa;
    public int zukan_numb;
    public int zukan_numc;
    public int zukan_numd;
    public int zukan_nume;
    public int zukan_numf;
    public int zukan_numg;
    public int zukan_numh;
    public int zukan_numi;
    public int zukan_numj;
    public int zukan_numk;
    public int zukan_numl;
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
        zukan_numa = PlayerPrefs.GetInt("SCOREA", 1);
        zukan_numb = PlayerPrefs.GetInt("SCOREB", 1);
        zukan_numc = PlayerPrefs.GetInt("SCOREC", 1);
        zukan_numd = PlayerPrefs.GetInt("SCORED", 1);
        zukan_nume = PlayerPrefs.GetInt("SCOREE", 1);
        zukan_numf = PlayerPrefs.GetInt("SCOREF", 1);
        zukan_numg = PlayerPrefs.GetInt("SCOREG", 1);
        zukan_numh = PlayerPrefs.GetInt("SCOREH", 1);
        zukan_numi = PlayerPrefs.GetInt("SCOREI", 1);
        zukan_numj = PlayerPrefs.GetInt("SCOREJ", 1);
        zukan_numk = PlayerPrefs.GetInt("SCOREK", 1);
        zukan_numl = PlayerPrefs.GetInt("SCOREL", 1);
    }

    // Update is called once per frame
    void Update() 
    {
        if (zukan_numa == 1)
        {
            iti.SetActive(false);
        }
        if (zukan_numb == 2)
        {
            ni.SetActive(false);
        }

        if (zukan_numc == 3)
        {
            san.SetActive(false);
        }

        if (zukan_numd == 4)
        {
            yon.SetActive(false);
        }

        if (zukan_nume == 5)
        {
            go.SetActive(false);
        }
        if (zukan_numf == 6)
        {
            roku.SetActive(false);
        }
        if (zukan_numg == 7)
        {
            nana.SetActive(false);
        }
        if (zukan_numh == 8)
        {
            hati.SetActive(false);
        }
        if (zukan_numi == 9)
        {
            q.SetActive(false);
        }
        if (zukan_numj == 10)
        {
            ju.SetActive(false);
        }
        if (zukan_numk == 11)
        {
            juiti.SetActive(false);
        }
        if (zukan_numl == 12)
        {
            juni.SetActive(false);
        }

    }
}
