using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class şişe : MonoBehaviour
{
    public Transform sise;
    public TextMeshProUGUI canYazisi;
    int can = 3;


    private void Update()
    {
        canYazisi.text = "Can : " + can.ToString();

        if (can== 0 )
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void OnCollisionEnter(Collision temas)
    {
        float rastgele = Random.Range(-6f, 6f);

        if (temas.gameObject.tag == "zemin")
        {
            sise.position = new Vector3(rastgele, 6f, 0f);
            can--;
        }
    }
}
