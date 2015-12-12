using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour
{

    public bool isPush;
    public float timeDelay;
    public string number;
    public Animator animation;
    public Combinaison combinaison;

    // Use this for initialization
    void Start()
    {
        isPush = false;
        animation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isPush)
        {
            timeDelay += Time.deltaTime;
            if (timeDelay >= 1)
            {
                timeDelay = 0;
                isPush = false;
                inputHandle();
            }
        }
        else
        {
            inputHandle();
        }
        
    }

    void inputHandle()
    {
        if (Input.GetKey(number))
        {
            isPush = true;
            print("number : " + number);
            animation.Play(0);
        }
    }
}