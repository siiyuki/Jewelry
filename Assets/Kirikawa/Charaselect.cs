using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Charaselect : MonoBehaviour
{
    int selectCharaNumber;
    // Start is called before the first frame update
    void Start()
    {
        selectCharaNumber = 0;
    }
    public void OnClickA()
    {
        selectCharaNumber = 0;
        PlayerPrefs.SetInt("CHARA_NUMBER", selectCharaNumber);
    }
    public void OnClickB()
    {
        selectCharaNumber = 1;
        PlayerPrefs.SetInt("CHARA_NUMBER", selectCharaNumber);
    }
    public void OnClickC()
    {
        selectCharaNumber = 2;
        PlayerPrefs.SetInt("CHARA_NUMBER", selectCharaNumber);
    }
    public void OnClickD()
    {
        selectCharaNumber = 3;
        PlayerPrefs.SetInt("CHARA_NUMBER", selectCharaNumber);
    }
    public void OnClickE()
    {
        selectCharaNumber = 4;
        PlayerPrefs.SetInt("CHARA_NUMBER", selectCharaNumber);
    }
    public void OnClickF()
    {
        selectCharaNumber = 5;
        PlayerPrefs.SetInt("CHARA_NUMBER", selectCharaNumber);
    }
    public void OnClickG()
    {
        selectCharaNumber = 6;
        PlayerPrefs.SetInt("CHARA_NUMBER", selectCharaNumber);
    }
    public void OnClickH()
    {
        selectCharaNumber = 7;
        PlayerPrefs.SetInt("CHARA_NUMBER", selectCharaNumber);
    }
    public void OnClickI()
    {
        selectCharaNumber = 8;
        PlayerPrefs.SetInt("CHARA_NUMBER", selectCharaNumber);
    }
    public void OnClickJ()
    {
        selectCharaNumber = 9;
        PlayerPrefs.SetInt("CHARA_NUMBER", selectCharaNumber);
    }
    public void OnClickK()
    {
        selectCharaNumber = 10;
        PlayerPrefs.SetInt("CHARA_NUMBER", selectCharaNumber);
    }
    public void OnClickL()
    {
        selectCharaNumber = 11;
        PlayerPrefs.SetInt("CHARA_NUMBER", selectCharaNumber);
    }



}