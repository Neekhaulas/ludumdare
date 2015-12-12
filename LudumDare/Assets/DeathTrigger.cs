using UnityEngine;
using System.Collections;

public class DeathTrigger : MonoBehaviour {

    void OnTriggerEnter(Collider entering)
    {
        Destroy(entering.gameObject);
    }
}
