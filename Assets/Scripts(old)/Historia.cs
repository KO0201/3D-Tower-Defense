using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;



[CustomEditor(typeof(People))]
public class Historia : People
{
    public override void AddWords()
    {
        talkingWords.Add("Hi!");
        talkingWords.Add("Im historia");
        talkingWords.Add("Bye!");
    }

    public override void Gender()
    {
        man = false;
        audioPitch = 2.5f;
    }
}
