using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ppScript : MonoBehaviour
{
    public PostProcessVolume ppVol;
    public PostProcessVolume ppVol2;
    public GameObject rain;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CollectDetector.collected == 1)
        {
            ppVol.weight = .9f;
        }

        if (CollectDetector.collected == 2)
        {
            ppVol.weight = .75f;
        }

        if (CollectDetector.collected == 3)
        {
            ppVol.weight = .6f;
        }

        if (CollectDetector.collected == 4)
        {
            ppVol.weight = .4f;
        }

        if (CollectDetector.collected == 5)
        {
            ppVol.weight = .2f;
        }

        if (CollectDetector.collected == 6)
        {
            ppVol.weight = 0f;
            rain.SetActive(false);
        }

        if (CollectDetector.collected == 7)
        {
            ppVol2.weight = .5f;
        }

        if (CollectDetector.collected == 8)
        {
            ppVol2.weight = 1f;
        }
    }
}
