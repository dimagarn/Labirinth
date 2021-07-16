using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class collDetect : MonoBehaviour
{
    private TextMesh text;
    private int hits = 0;
    public int count;
    public UnityEvent script;
    public void Hits()
    {
        var textMeshs = GetComponentsInChildren<TextMesh>();
        text = textMeshs[0];
        hits++;
        text.text = "Hits: " + hits + " / 3";
        if (hits == count)
            script.Invoke();
    }
}
