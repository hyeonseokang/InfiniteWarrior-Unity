using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingame : MonoBehaviour

   
{
    public Pause pausePanel;
    private bool isPause = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void Update()
    {
        

    }

    public void onClickPauseButton()
    {
        pausePanel.initPausePanel();
    }

    public void SetPause()
    {
        if (!isPause)
        {
            isPause = true;
            Time.timeScale = 0;
        }
        
    }
    public void Continue()
    {
        if (isPause)
        {
            isPause = false;
            Time.timeScale = 1;

        }
    }


}
