using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class şişe : MonoBehaviour
{
    public Transform sise;


    void OnCollisionEnter(Collision temas)
    {
        float rastgele = Random.Range(-6f, 6f);

        if (temas.gameObject.tag == "zemin")
        {
            sise.position = new Vector3(rastgele, 6f, 0f);
        }
    }
}
