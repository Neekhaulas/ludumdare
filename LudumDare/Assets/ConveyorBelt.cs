using UnityEngine;
using System.Collections;

public class ConveyorBelt : MonoBehaviour
{

    private float time;
    public float spawnFrequence;
    public Vector3 position;
    public GameObject Objetproduit;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > spawnFrequence)
        {
            Instantiate(Objetproduit, position, Quaternion.identity);
            time = 0;
        }
    }
}
