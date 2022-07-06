using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scrip : MonoBehaviour
{
    public TMP_Text type1;
    // Start is called before the first frame update
    private static int cnt = 0;

    private void OnMouseDown()
    {
        if (GetComponent<TMP_Text>().text == "")
        {
            GetComponent<TMP_Text>().text = cnt % 2 == 0 ? "X" : "O";
            cnt++;
        }
    }

}
