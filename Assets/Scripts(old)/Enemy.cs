using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //UnityEngine.UI.Image image;

    private void OnCollisionEnter(Collision collision)

    {
        //衝突したオブジェクトがPlayerだったとき
        if (collision.gameObject.CompareTag("Player"))
        {
            //Destroy(this.gameObject);
            //gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }

}