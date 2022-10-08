using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BitOperatorTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        uint a, b, c;
        a = 32;
        b = a >> 3;
        c = a << 3;
        Debug.Log($"a,b,c={a} {b} {c}");

        uint d, e, f;
        
        a = 0x04700_8999;
        b = 0x0ffff_0000;

        c = a & b;  // and
        d = a | b;  // or
        e = a ^ b;  // xor
        f = ~a;     // complement

        Debug.Log($"a={a:x}");
        Debug.Log($"b={b:x}");
        Debug.Log($"c={c:x}");
        Debug.Log($"d={d:x}");
        Debug.Log($"e={e:x}");
        Debug.Log($"f={f:x}");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
