using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour
{

    private bool isPush;

    // Use this for initialization
    void Start()
    {
        isPush = false;
    }

    // Update is called once per frame
    void Update()
    {
        inputHandle();
    }

    void inputHandle()
    {
        if (Input.GetKey("a"))
        {
            isPush = !isPush;
            print("is push");
        }
    }
}