using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panel_sc3 : MonoBehaviour
{

    public Text HStext;
    public Text HCtext;

    // Start is called before the first frame update
    void Start()

    {
        HStext.text = "HIGHSCORE:" + PlayerPrefs.GetInt("HighScore");
        HCtext.text = "HIGHCOIN:" + PlayerPrefs.GetInt("HighCoin");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void retry()
    {

        GameManager.I.retry();

    }

}
