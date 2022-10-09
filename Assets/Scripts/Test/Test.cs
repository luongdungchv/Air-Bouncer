using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class Test : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            string[] str = { "a", "b", "c", "d" };
            Debug.Log(string.Join(",", str.ToList()));  
        }
    }
    private string MakeLine(int initVal, int multVal, string sep)
    {
        string[] sArr = new string[10];

        for (int i = initVal; i < initVal + 10; i++)
            sArr[i - initVal] = string.Format("{0,-3}", i * multVal);

        return string.Join(sep, sArr);
    }
}
