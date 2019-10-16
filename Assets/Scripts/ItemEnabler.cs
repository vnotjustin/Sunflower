using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemEnabler : MonoBehaviour
{
    public Image clovis;
    public Image nyu;
    public Image board;
    public Image therapy;
    public Image prof;
    public Image prosp;
    public Image phone;
    public Image juul;
    public Image clovish;
    public Image nyuh;
    public Image boardh;
    public Image therapyh;
    public Image profh;
    public Image prosph;
    public Image phoneh;
    public Image juulh;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
  
            if (CollectDetector.clovis == true)
            {
                clovis.enabled = true;
            }

            if (CollectDetector.nyu == true)
            {
                nyu.enabled = true;
            }

            if (CollectDetector.board == true)
            {
                board.enabled = true;
            }

            if (CollectDetector.juul == true)
            {
                juul.enabled = true;
            }

            if (CollectDetector.prosp == true)
            {
                prosp.enabled = true;
            }

            if (CollectDetector.therapy == true)
            {
                therapy.enabled = true;
            }

            if (CollectDetector.phone == true)
            {
                phone.enabled = true;
            }

            if (CollectDetector.prof == true)
            {
                prof.enabled = true;
            }

            if (CollectDetector.clovis == false)
            {
                clovish.enabled = true;
            }

            if (CollectDetector.nyu == false)
            {
                nyuh.enabled = true;
            }

            if (CollectDetector.board == false)
            {
                boardh.enabled = true;
            }

            if (CollectDetector.juul == false)
            {
                juulh.enabled = true;
            }

            if (CollectDetector.prosp == false)
            {
                prosph.enabled = true;
            }

            if (CollectDetector.therapy == false)
            {
                therapyh.enabled = true;
            }

            if (CollectDetector.phone == false)
            {
                phoneh.enabled = true;
            }

            if (CollectDetector.prof == false)
            {
                profh.enabled = true;
            }


        }

        else
        {
            clovis.enabled = false;
            nyu.enabled = false;
            prof.enabled = false;
            prosp.enabled = false;
            phone.enabled = false;
            juul.enabled = false;
            therapy.enabled = false;
            board.enabled = false;

            clovish.enabled = false;
            nyuh.enabled = false;
            profh.enabled = false;
            prosph.enabled = false;
            phoneh.enabled = false;
            juulh.enabled = false;
            therapyh.enabled = false;
            boardh.enabled = false;
        }
    }
}
