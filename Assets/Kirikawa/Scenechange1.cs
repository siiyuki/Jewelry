using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenechange1 : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("Garnet");
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
