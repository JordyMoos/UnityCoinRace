using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static int CoinCount = 0;

	// Use this for initialization
	void Start ()
    {
        CoinCount++;

        Debug.Log("Current coint count = " + CoinCount);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update ()
    {
		
	}

    void OnDestroy()
    {
        CoinCount--;

        if (CoinCount <= 0)
        {
            Debug.Log("We won!");
        }
    }
}
