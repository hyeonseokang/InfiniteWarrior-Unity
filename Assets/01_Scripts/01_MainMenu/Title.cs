using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void MoveNextScene()
    {
        SceneManager.LoadScene("01_MainMenu");
    }
}
