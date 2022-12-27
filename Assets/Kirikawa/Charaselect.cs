using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Charaselect : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;
    int selectCharaNumber;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        selectCharaNumber = 0;
    }
    public void OnClickA()
    {
        audioSource.PlayOneShot(sound1);
        selectCharaNumber = 0;
        PlayerPrefs.SetInt("CHARA_NUMBER", selectCharaNumber);
    }
    public void OnClickB()
    {
        audioSource.PlayOneShot(sound1);
        selectCharaNumber = 1;
        PlayerPrefs.SetInt("CHARA_NUMBER", selectCharaNumber);
    }
    public void OnClickC()
    {
        audioSource.PlayOneShot(sound1);
        selectCharaNumber = 2;
        PlayerPrefs.SetInt("CHARA_NUMBER", selectCharaNumber);
    }
    public void OnClickD()
    {
        audioSource.PlayOneShot(sound1);
        selectCharaNumber = 3;
        PlayerPrefs.SetInt("CHARA_NUMBER", selectCharaNumber);
    }
    public void OnClickE()
    {
        audioSource.PlayOneShot(sound1);
        selectCharaNumber = 4;
        PlayerPrefs.SetInt("CHARA_NUMBER", selectCharaNumber);
    }
    public void OnClickF()
    {
        audioSource.PlayOneShot(sound1);
        selectCharaNumber = 5;
        PlayerPrefs.SetInt("CHARA_NUMBER", selectCharaNumber);
    }
    public void OnClickG()
    {
        audioSource.PlayOneShot(sound1);
        selectCharaNumber = 6;
        PlayerPrefs.SetInt("CHARA_NUMBER", selectCharaNumber);
    }
    public void OnClickH()
    {
        audioSource.PlayOneShot(sound1);
        selectCharaNumber = 7;
        PlayerPrefs.SetInt("CHARA_NUMBER", selectCharaNumber);
    }
    public void OnClickI()
    {
        audioSource.PlayOneShot(sound1);
        selectCharaNumber = 8;
        PlayerPrefs.SetInt("CHARA_NUMBER", selectCharaNumber);
    }
    public void OnClickJ()
    {
        audioSource.PlayOneShot(sound1);
        selectCharaNumber = 9;
        PlayerPrefs.SetInt("CHARA_NUMBER", selectCharaNumber);
    }
    public void OnClickK()
    {
        audioSource.PlayOneShot(sound1);
        selectCharaNumber = 10;
        PlayerPrefs.SetInt("CHARA_NUMBER", selectCharaNumber);
    }
    public void OnClickL()
    {
        audioSource.PlayOneShot(sound1);
        selectCharaNumber = 11;
        PlayerPrefs.SetInt("CHARA_NUMBER", selectCharaNumber);
    }



}