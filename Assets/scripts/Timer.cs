using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float MaxTime = 60f;

    [SerializeField]
    private float CountDown = 0f;

    // Use this for initialization
    void Start()
    {
        CountDown = MaxTime;
    }

    // Update is called once per frame
    void Update()
    {
        CountDown -= Time.deltaTime;
        
        // Restart level if time runs out
        if (CountDown <= 0)
        {
            Debug.Log("Time limit reached");

            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }
}
