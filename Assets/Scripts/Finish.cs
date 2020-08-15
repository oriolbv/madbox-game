using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : ExtendedBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("YOU WIN! :)");
            Wait(2f, () => {
                SceneManager.LoadScene("MainScene");
            });
        }
    }
}
