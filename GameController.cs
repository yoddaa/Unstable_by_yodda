using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public void Reset()
    {
        SceneManager.LoadScene("Level01");
    }

    public void Exit()
    {
        SceneManager.LoadScene("Intro");
        //Application.Quit();
    }
}
