using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ball : MonoBehaviour
{
    public Score score;
    public Spawner spawner;
    public int speed = 1;
    public bool isChecking = false;

    private void OnCollisionEnter(Collision collision)
    {

        if( collision.gameObject.name.Split('_')[0] == "Hand"&&!isChecking)
        {
            isChecking = true;
            score.nowGameScore += 1;
            this.gameObject.SetActive(false);
            this.spawner.ballPoolingQueue.Enqueue(this);
        }
        if (collision.gameObject.CompareTag("DeadZone")){
            this.gameObject.SetActive(false);
            this.spawner.ballPoolingQueue.Enqueue(this);
        }

        
        
    }
    // Start is called before the first frame update
    void Start()
    {
        spawner = this.GetComponentInParent<Spawner>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
    }
}
