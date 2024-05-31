using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour



{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "playar")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
