using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public bool gamehasended = false;
    public float restartdel = 1f;

    public GameObject completelevelui;
    
    


    public void complete()
    {
        UnityEngine.Debug.Log("level complete");
        
        completelevelui.SetActive(true);
        

    }

    public void endgame()
    {
        if(gamehasended == false)
        {
            gamehasended = true;
            
            UnityEngine.Debug.Log("Game Over!!!!");
            Invoke("restart", restartdel);

        }
    }

    

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
}
