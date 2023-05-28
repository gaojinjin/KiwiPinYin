using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pinyin4net;
using TMPro;
public class TestPin : MonoBehaviour
{
    public TextMeshProUGUI show;
    public TMP_InputField input;
    void Start()
    {
        input.onValueChanged.AddListener((arg) =>
        {
            string tempStr = "";
            foreach(char c in arg)
            {
                string[] result = PinyinHelper.ToHanyuPinyinStringArray(c);
                foreach (string pinyin in result)
                {
                    tempStr+=pinyin+" ";
                }
            } 
            show.text = tempStr;
        });


    }

    // Update is called once per frame
    void Update()
    {

    }
}
