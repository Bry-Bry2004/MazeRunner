using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{

    [SerializeField] GameObject door;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        door.transform.position = transform.position + (Vector3.up * 10);

        Destroy(gameObject);
        Debug.Log("Sounds like a door opened . .");
    }
}
