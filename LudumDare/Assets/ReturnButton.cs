using UnityEngine;
using System.Collections;

public class ReturnButton{

    private string key;
    private float duration;

    public ReturnButton(string _key, float _duration)
    {
        key = _key;
        duration = _duration;
    }

    public string getKey()
    {
        return key;
    }

    public float getDuration()
    {
        return duration;
    }
}
