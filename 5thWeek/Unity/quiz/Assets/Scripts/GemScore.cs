using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemScore : MonoBehaviour
{
    public static int countGem;
    Text countGemText;

    // Start is called before the first frame update
    void Start()
    {
        countGem = 0;
        countGemText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        countGemText.text = countGem.ToString();
    }
}
