using UnityEngine;
using System.Collections;

public class TextGenerator : MonoBehaviour
{
    public GameObject canvas;//ƒLƒƒƒ“ƒoƒX
    public GameObject text;

    void Start()
    {
        GameObject prefab = (GameObject)Instantiate(text);
        prefab.transform.SetParent(canvas.transform, false);
    }

    void Update() { }
}