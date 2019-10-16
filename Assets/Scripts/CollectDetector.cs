using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectDetector : MonoBehaviour
{
    public static bool clovis = false;
    public static bool nyu = false;
    public static bool board = false;
    public static bool juul = false;
    public static bool prof = false;
    public static bool prosp = false;
    public static bool phone = false;
    public static bool therapy = false;
    public static int collected = 0;

    public AudioSource aclovis;
    public AudioSource anyu;
    public AudioSource ajuul;
    public AudioSource aboard;
    public AudioSource aprof;
    public AudioSource aprosp;
    public AudioSource aphone;
    public AudioSource atherapy;

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
            collected++;
            aclovis.Play();
        }

        if (other.tag == "nyu")
        {
            nyu = true;
            collected++;
            anyu.Play();
        }

        if (other.tag == "board")
        {
            board = true;
            collected++;
            aboard.Play();
        }

        if (other.tag == "juul")
        {
            juul = true;
            collected++;
            ajuul.Play();
        }

        if (other.tag == "prosp")
        {
            prosp = true;
            collected++;
            aprosp.Play();
        }

        if (other.tag == "prof")
        {
            prof = true;
            collected++;
            aprof.Play();
        }

        if (other.tag == "phone")
        {
            phone = true;
            collected++;
            aphone.Play();
        }

        if (other.tag == "therapy")
        {
            therapy = true;
            collected++;
            atherapy.Play();
        }

        other.gameObject.SetActive(false);

        if (collected >= 8)
        {
            StartCoroutine(NextScene());
        }
    }

    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(25);
        SceneManager.LoadScene("FinalScene", LoadSceneMode.Single);
    }
}
