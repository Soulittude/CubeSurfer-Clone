using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToplayiciKup : MonoBehaviour
{
    GameObject coreCube;
    int yukseklik;
    
    private GameManager gm;

    void Start()
    {
        coreCube = GameObject.Find("CoreCube");
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    void Update()
    {
        coreCube.transform.position = new Vector3(transform.position.x, yukseklik + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -yukseklik, 0);
    }

    public void YukseklikAzalt()
    {
        yukseklik--;
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Stack" && other.gameObject.GetComponent<StackCube>().GetToplandiMi() == false)
        {
            yukseklik += 1;
            
            other.gameObject.GetComponent<StackCube>().ToplandiYap();
            other.gameObject.GetComponent<StackCube>().KatAyarla(yukseklik);

            other.gameObject.transform.parent = coreCube.transform;
        }

        else if(other.gameObject.tag == "Void")
        {
            gm.restartGame();
        }

    }
}
