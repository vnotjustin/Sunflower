using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutEnable : MonoBehaviour
{
    public Text tuttext;
    bool onlyOnce = false;
    // Start is called before the first frame update
    void Start()
    {
        tuttext.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (CollectDetector.collected == 1 && onlyOnce == false)
        {
            tuttext.enabled = true;
            onlyOnce = true;
        }
        if (Input.GetKey(KeyCode.Tab))
        {
            tuttext.enabled = false;
        }
    }
}
