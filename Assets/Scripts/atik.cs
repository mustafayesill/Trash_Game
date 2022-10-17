using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class atik : MonoBehaviour
{

    [SerializeField] private AudioSource source; 
    [SerializeField] private AudioClip pickupClip, dropClip,comleteClips;
    private Transform transform;
    private bool dragging;
    private Vector2 offset, originalPosition;
    [SerializeField] GameManager gamemanager;
    

    private void Awake()
    {        
        transform = GetComponent<Transform>();
        
        originalPosition = transform.position;     
    }
    
    private void Update()
    {
        if (!dragging) return; 
        var mousePosition = GetMousePos(); 
        transform.position = mousePosition - offset; 
    }
    void OnMouseDown() 
    {
        dragging = true; 
        source.PlayOneShot(pickupClip);
        offset = GetMousePos() - (Vector2)transform.position; 
    }
    void OnMouseUp() 
    {      
        transform.position = originalPosition;
        dragging = false; 
        source.PlayOneShot(dropClip);       
    }
    Vector2 GetMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition); 
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        ProcessCollision(collision.gameObject);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        ProcessCollision(collision.gameObject);
    }
    public void ProcessCollision(GameObject collider)
    {
        if (collider.CompareTag(tag))
        {
            gamemanager.spawn();
            Debug.Log("dogru!");
            ScoreTezt.scoreValue += 10;
            Destroy(gameObject);
            
            
        }     
        else
        {
            dragging = false;
            if (dragging == false)
            {
                transform.position = originalPosition; 
            }

            Debug.Log("yanlýþ");
            ScoreTezt.scoreValue -= 10;
        }

    }
}


