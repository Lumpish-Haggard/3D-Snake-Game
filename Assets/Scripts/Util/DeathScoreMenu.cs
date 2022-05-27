using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class DeathScoreMenu : MonoBehaviour
{


    [SerializeField]
    public TextMeshProUGUI DeathScore;
    // Start is called before the first frame update
    void Awake ()
    {
        
        DeathScore.text = "Your Score was: " + GameplayController.instance.scoreCount;
        
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(0);

    }
}
