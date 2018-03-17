using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour {

    public bool checker = false;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);    
    }

    // Use this for initialization
    void Start () {
        //Invoke("LoadGameScene", 1000f);
	}
    void LoadGameScene()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update () {
        
        if(Input.anyKey)
        {
            if (!checker)
            {
                LoadGameScene();
                checker = true;
            }
        }
	}

}
