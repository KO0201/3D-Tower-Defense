using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class People : MonoBehaviour
{
    private GameObject player;
    [System.NonSerialized]
    public GameObject speechBubbleOb;
    private GameManager2 gameManager;

    public List<string> talkingWords = new List<string>();

    public bool man;

    private AudioSource audioSource;
    public float audioPitch;
    private CapsuleCollider capsuleCollider;


    // Start is called before the first frame update
    public virtual void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager2>();
        speechBubbleOb = transform.Find("SpeechBubble").gameObject;
        audioSource = GetComponent<AudioSource>();
        AddWords();
        Gender();
    }


    // Update is called once per frame
    void Update()
    {
        if (speechBubbleOb == null) return;
        float disToPlayer = Vector3.Distance(transform.position, player.transform.position);
        if (disToPlayer < 2.5f && speechBubbleOb.activeSelf == false)
        {
            StartCoroutine("DisplaySB");
        }
        if (disToPlayer >= 2.5f && speechBubbleOb.activeSelf == true)
        {
            StartCoroutine("CloseSB");
            gameManager.CloseMessageWindow();
        }

        if (speechBubbleOb.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (gameManager.messageWindow.activeSelf == false)
                {
                    gameManager.DisplayMessageWindow(talkingWords, this.gameObject.name);
                }
                else
                {
                    gameManager.ProceedingTalk(audioSource, audioPitch);
                }
            }
        }
    }
    private IEnumerator DisplaySB()
    {
        speechBubbleOb.SetActive(true);
        float c = 0.05f;
        while (speechBubbleOb.transform.localScale.x < 0.7f)
        {
            yield return new WaitForSeconds(0.01f);
            speechBubbleOb.transform.localScale += new Vector3(c, c, c);
        }
        yield break;
    }

    public IEnumerator CloseSB()
    {
        float c = 0.05f;
        while (speechBubbleOb.transform.localScale.x > 0f)
        {
            yield return new WaitForSeconds(0.01f);
            speechBubbleOb.transform.localScale -= new Vector3(c, c, c);
        }
        speechBubbleOb.transform.localScale = new Vector3(0, 0, 0);
        speechBubbleOb.SetActive(false);
        yield break;
    }

    public virtual void AddWords()
    {

    }

    public virtual void Gender()
    {

    }

}