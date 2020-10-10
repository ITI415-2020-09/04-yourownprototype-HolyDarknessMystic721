using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
	public GameObject winText;

    // Start is called before the first frame update
    void Start()
    {
        winText.SetActive(false);
    }

	void OnTriggerEnter(Collider other) {
		
		if (other.gameObject.tag == "BALL Player") {
			
			winText.SetActive(true);
		}
	}
    // Update is called once per frame
    void Update()
    {
        
    }
}
