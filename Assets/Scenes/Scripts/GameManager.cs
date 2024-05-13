using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int count;

    public static GameManager instance;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(count == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void Awake()
    {
        instance = this;
    }
}
