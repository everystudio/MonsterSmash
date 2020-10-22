using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BallController : MonoBehaviour
{
    public float m_fPower;
    public float m_fTorque;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(new Vector2(0.0f, 1.0f) * m_fPower, ForceMode2D.Impulse);
        rb2d.AddTorque(m_fTorque);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
