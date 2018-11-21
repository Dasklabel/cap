using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectScene : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {

    }

    public void Button()
    {
        SceneManager.LoadScene("Select");
    }

}
