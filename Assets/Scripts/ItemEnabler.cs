using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemEnabler : MonoBehaviour
{
    public Image clovis;
    public Image nyu;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (CollectDetector.clovis == true)
        {
            clovis.enabled = true;
        }

        if (CollectDetector.nyu == true)
        {
            nyu.enabled = true;
        }
    }
}
