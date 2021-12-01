using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (SceneManager.GetActiveScene().buildIndex + 1 <= 2)
            {
                Debug.Log("Scene +1");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            if (SceneManager.GetActiveScene().buildIndex - 1 >= 0)
            {
                Debug.Log("Scene -1");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            }
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (SceneManager.GetActiveScene().buildIndex + 1 <= 1)
            {
                Debug.Log("Scene +1");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
