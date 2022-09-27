using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WaveScript : MonoBehaviour
{
    public static int waveValue = 1;
    private Text wave;
    // Start is called before the first frame update
    void Start()
    {
        wave = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        wave.text = "Wave: " + waveValue;
    }
}
