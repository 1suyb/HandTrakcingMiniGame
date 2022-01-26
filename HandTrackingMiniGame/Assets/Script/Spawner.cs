using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Queue<Ball> ballPoolingQueue = new Queue<Ball>();
    void Start()
    {
        Ball[] balls = this.GetComponentsInChildren<Ball>();
        foreach(Ball item in ballPoolingQueue)
        {
            item.gameObject.SetActive(false);
            ballPoolingQueue.Enqueue(item);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (ballPoolingQueue.Count > 0)
        {
            Ball obj = ballPoolingQueue.Dequeue();
            obj.isChecking = false;
            GameObject GO = obj.gameObject;
            GO.transform.position = new Vector3(Random.Range(-3, 3), 3, Random.Range(-3, 3));
            
            GO.SetActive(true);
        }
    }
}
