using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuButtons : MonoBehaviour
{

    public void PlayeGame()
    {
     
        SceneManager.LoadScene(1);
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
