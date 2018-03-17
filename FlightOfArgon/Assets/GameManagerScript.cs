using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{

    public Player player;
    public GameObject UI;
    // Use this for initialization
    void Start()
    {
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey&& player != null)
        {
            player.gameObject.SetActive(true);
            UI.SetActive(false);
        }
    }

    public IEnumerator Restart()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
    }
}
