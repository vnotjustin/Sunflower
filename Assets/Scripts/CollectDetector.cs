using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectDetector : MonoBehaviour
{
    public static bool clovis = false;
    public static bool nyu = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "clovis")
        {
            clovis = true;
        }

        if (other.tag == "nyu")
        {
            nyu = true;
        }

        other.gameObject.SetActive(false);
    }
}
