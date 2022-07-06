using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string currentMapName;
    public float moveSpeed;
    float axisH;
    float axisV;

    Rigidbody2D rigid;
    

    void Awake()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
    }
    
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }


    void Update()
    {
        axisH = Input.GetAxisRaw("Horizontal");
        axisV = Input.GetAxisRaw("Vertical");
        

        
    }

    void FixedUpdate()
    {
        rigid.velocity = new Vector2(axisH,axisV) * moveSpeed;
    }
}
