using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tosapphire : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;
    public void OnClickStartButton()
    {
        audioSource.PlayOneShot(sound1);
        Invoke(nameof(DelayMethod), 0.8f);
    }
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void DelayMethod()
    {

        SceneManager.LoadScene("Sapphire");
    }
}
