using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class kasaHareketi : MonoBehaviour
{
    public float hiz;
    public Transform sise;
    int puan;
    public TextMeshProUGUI puanYazisi;


    void Update()
    {

        puanYazisi.text = "puan : " + puan.ToString();

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-hiz * Time.deltaTime, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(hiz * Time.deltaTime, 0f, 0f);
        }
    }

    void OnCollisionEnter(Collision Temas)
    {

        float rastgele = Random.Range(-6f, 6f);

        if (Temas.gameObject.tag == "sise")
        {
            sise.position = new Vector3 (rastgele, 6f, 0f);

            puan += 5;
        }
        
    }
}
