using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Managerscript : MonoBehaviour
{
    public TMP_Text[] matrix;
    private static int ok = 0, cnt = 0, nr1 = 0, nr2 = 0;

    // Start is called before the first frame update
    void Update()
    {
        if (ok == 0)
        {
            if (matrix[0].text == matrix[1].text && matrix[0].text == matrix[2].text && matrix[0].text != "")
            {
                matrix[9].text = matrix[0].text;
                matrix[0].color = Color.black;
                matrix[1].color = Color.black;
                matrix[2].color = Color.black;
                ok = 1;
            }
            if (matrix[3].text == matrix[4].text && matrix[3].text == matrix[5].text && matrix[3].text != "")
            {
                matrix[9].text = matrix[3].text;
                matrix[3].color = Color.black;
                matrix[4].color = Color.black;
                matrix[5].color = Color.black;
                ok = 1;
            }
            if (matrix[6].text == matrix[7].text && matrix[6].text == matrix[8].text && matrix[6].text != "")
            {
                matrix[9].text = matrix[6].text;
                matrix[6].color = Color.black;
                matrix[7].color = Color.black;
                matrix[8].color = Color.black;
                ok = 1;
            }

            if (matrix[0].text == matrix[3].text && matrix[0].text == matrix[6].text && matrix[0].text != "")
            {
                matrix[9].text = matrix[0].text;
                matrix[0].color = Color.black;
                matrix[3].color = Color.black;
                matrix[6].color = Color.black;
                ok = 1;
            }
            if (matrix[1].text == matrix[4].text && matrix[1].text == matrix[7].text && matrix[1].text != "")
            {
                matrix[9].text = matrix[1].text;
                matrix[1].color = Color.black;
                matrix[4].color = Color.black;
                matrix[7].color = Color.black;
                ok = 1;
            }
            if (matrix[2].text == matrix[5].text && matrix[2].text == matrix[8].text && matrix[2].text != "")
            {
                matrix[9].text = matrix[2].text;
                matrix[2].color = Color.black;
                matrix[5].color = Color.black;
                matrix[8].color = Color.black;
                ok = 1;
            }

            if (matrix[0].text == matrix[4].text && matrix[0].text == matrix[8].text && matrix[0].text != "")
            {
                matrix[9].text = matrix[0].text;
                matrix[0].color = Color.black;
                matrix[4].color = Color.black;
                matrix[8].color = Color.black;
                ok = 1;
            }
            if (matrix[2].text == matrix[4].text && matrix[2].text == matrix[6].text && matrix[2].text != "")
            {
                matrix[9].text = matrix[2].text;
                matrix[2].color = Color.black;
                matrix[4].color = Color.black;
                matrix[6].color = Color.black;
                ok = 1;
            }

            if (matrix[9].text == "X")
                matrix[9].color = Color.red;
            else if (matrix[9].text == "O")
                matrix[9].color = Color.blue;
        }

        cnt = 0;
        for ( int i = 0; i < 9; i++ )
        {
            if (matrix[i].text != "")
                cnt++;
        }

        if (cnt == 9 && matrix[9].text == ".............")
        {
            matrix[9].text = "Nimeni";
        }

        if (Input.GetKey(KeyCode.R) && (cnt == 9 || matrix[9].text != "............."))
        {
            Invoke("Reset", 0f);
        }

    }

    private void Reset()
    {

        if (matrix[9].text == "X")
        {
            nr1++;
            matrix[10].text = nr1.ToString();
        }
        else if (matrix[9].text == "O")
        {
            nr2++;
            matrix[11].text = nr2.ToString();
        }

        for (int i = 0; i < 9; i++)
        {
            matrix[i].text = "";
            matrix[i].color = Color.grey;
        }

        matrix[9].text = ".............";
        matrix[9].color = Color.yellow;
        cnt = 0;
        ok = 0;
    }

}
