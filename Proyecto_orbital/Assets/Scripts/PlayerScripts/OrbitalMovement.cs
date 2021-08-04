using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitalMovement : MonoBehaviour
{
    [SerializeField] private Transform centralSphere;
    private static float speed;
    private float basicSpeed = 30f;
    private bool rotateUp;
    private static bool timer;
    private float countDown = 10f;
    private Vector3 direction;

    // OverlapSphere Collider
    static Collider[] hitColliders;

    // Wall detectection
    


    private void Start()
    {
        centralSphere = GameObject.Find("CentralSphere").transform;
        this.gameObject.transform.SetParent(centralSphere);
        rotateUp = true;
        ReturnSpeed();
        direction = Vector3.up;


        
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!rotateUp) { direction = Vector3.up; }
            if (rotateUp) { direction = Vector3.down; }
            rotateUp = !rotateUp;
        }
        if (timer) { countDown -= Time.deltaTime; }
        if (countDown <= 0) { ReturnSpeed(); }

        //DetectWallsNear(transform.position, 1);

    }
    private void FixedUpdate()
    {
        transform.RotateAround(centralSphere.transform.position, direction, speed * Time.deltaTime);
        // Debug.Log(speed);
        //Vector3 fwd = transform.TransformDirection(Vector3.forward);
        //if (Physics.Raycast(transform.position, fwd, 1))
        //{
        //    Collider detectedWall = GameObject.FindGameObjectWithTag("Wall").GetComponent<Collider>();
        //    if (Wall.name == detectedWall.name)

        //        Debug.Log("Detectado " + detectedWall);
        //    else
        //        Debug.LogError("Dectectado un muro");
            
          
        //}

    }
    /// <summary>
    /// M�todo que se encarga de aumentar o disminuar la velocidad del orbital.
    /// </summary>
    /// <param name="up_down">Indica si hay que aumentar la velocidad o parar el orbital.</param>
    public void SpeedUp(bool up_down)
    {
        if (up_down) { speed *= 3; }
        else { speed = 0; }
        timer = true;
    }
    /// <summary>
    /// Se encarga de devolver la velocidad del orbital al valor original.
    /// </summary>
    private void ReturnSpeed()
    {
        speed = basicSpeed;
        countDown = 10f;
        timer = false;
    }
    /// <summary>
    /// M�todo llamado cuando se toma el PowerUp Ghost y que desactiva o activa el collider.
    /// </summary>
    /// <param name="state">Activar o desactivar collider.</param>
    public void RemoveCollider(bool state)
    {
        GetComponent<SphereCollider>().enabled = state;
    }

    /// <summary>
    /// Detectar un muro cerca 
    /// return true;
    /// </summary>
    /// <param name="center"></param>
    /// <param name="radius"></param>
    //public void DetectWallsNear(Vector3 center, float radius)
    //{


        
    //    hitColliders = Physics.OverlapSphere(center, radius);

    //    foreach (Collider c in hitColliders)
    //    {
    //        if (c.CompareTag("Wall"))
    //        {
    //            if (!c.GetComponent<Collider>().isTrigger)
    //            {
    //                Debug.LogWarning("Wall detected");

    //            }
                
                
                
    //        }
    //    }
    //}
    private void OnTriggerEnter(Collider other)
    {
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, 1);
    }
}
