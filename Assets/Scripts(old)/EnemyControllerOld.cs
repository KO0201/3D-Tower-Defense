using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyControllerOld : MonoBehaviour
{
    GameObject cube;
    
    Transform tmp1 = GameObject.Find("Stone").transform;

    [SerializeField]
    private Transform target;
    private Stone stone;

    public int scoreValue;  // これが敵を倒すと得られる点数になる
    private Score score;

    NavMeshAgent agent;

    private Vector3 tmp;
    void Start()
    {
        tmp = GameObject.Find("Stone").transform.position;
        Debug.Log(tmp);
        
        //cube = GameObject.Find("Stone");

        agent.destination = target.position;

    }
    void Update()
    {
        //Debug.Log(tmp1); //null
        agent = GetComponent<NavMeshAgent>();
        //agent.destination = target.position;


        //Debug.Log(stone.stoneTransform);
        //agent.destination = new Vector3(40,1,50); //stone.transformから取得したい
        //agent.destination = stone.stoneTransform;
        //Transform stonePosition = stone.stoneTransform.position;
    }
    private void OnCollisionEnter(Collision collision)

    {
        //衝突したオブジェクトがPlayerだったとき
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log(this.gameObject);
            Destroy(gameObject);
            //gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        if (collision.gameObject.tag == "Stone")
        {
            Destroy(this);
        }
    }
}
