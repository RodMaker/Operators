using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i, j, k, answer;
        i = 2;
        j = 3;
        k = 4;

        /*
        answer = i + j + k;
        Debug.Log($"answer={answer}");
        answer = i + j * k;
        Debug.Log($"answer={answer}");
        answer = (i + j) * k;
        Debug.Log($"answer={answer}");
        answer = i + j + k * 1000;
        Debug.Log($"answer={answer}");
        answer = (i + j + k) * 1000;
        Debug.Log($"answer={answer}");
        answer = k / 3;
        Debug.Log($"answer={answer}");
        answer = k % 3;
        Debug.Log($"answer={answer}");
        answer = (i + j + k) % 7;
        Debug.Log($"answer={answer}");
        */

        /*
        answer = 10;
        answer++;
        Debug.Log($"answer={answer}");
        answer--;
        Debug.Log($"answer={answer}");
        ++answer;
        Debug.Log($"answer={answer}");
        --answer;
        Debug.Log($"answer={answer}");
        */

        /*
        answer = 10;
        Debug.Log($"answer={answer++}");
        Debug.Log($"answer={answer}");
        answer = 20;
        Debug.Log($"answer={++answer}");
        Debug.Log($"answer={answer}");
        */

        /*
        answer = 10;
        Debug.Log($"answer={+answer}");
        Debug.Log($"answer={-answer}");
        */

        /*
        Debug.Log("Floating Test");
        float x, y;
        double z;
        x = 10.1f;
        z = 50.12345123451234512345;
        y = x + 10;
        y = x + (float)z;
        Debug.Log($"x y z={x} {y} {z}");
        */

        //int i = 2;
        i += 7;
        Debug.Log($"i={i}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
