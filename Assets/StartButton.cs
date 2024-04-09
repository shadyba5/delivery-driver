using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{

    public GameObject startButton;
    private void Start()
    {
        startButton.SetActive(true);
    }
    // Start is called before the first frame update
    void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
        SceneManager.LoadScene("SampleScene");

    }
}
