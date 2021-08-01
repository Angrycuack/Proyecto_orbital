using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoves : MonoBehaviour
{

    /// <summary>
    /// La idea es que el jugador se mueva aleatoriamente
    /// no depende de un camino.
    /// la direccion es random de izquierda a derecha. 
    /// Usando el eje z
    /// </summary>
    /// 

    // Player componente Transfor
    // Target Position
    public Transform Waypoint;
    // velocidad que va la esfera
    [SerializeField]
    public float speed = 0;
    // Usar Random 
    private float gotoLeft;
    private float gotoRight;

    // Score del jugador get from distance
    public static float playerScore;
    Vector3 target;
    // ultima posicion de la esfera
    private Vector3 player_lastPosition;
    private Vector3 player_currentPosition;

    // la distancia recurridad de su ultima posicion hasta la actual
    private float distance;
    // la distancia cuando modifica aleatoriamente la direccion
    [SerializeField]
    public int reachThisDistance;

    private float t = 1;
    void Start()
    {
        
        
        
    }

    void FixedUpdate()
    {
        //// probar poner en un array los direcciones
        //// y llamarlo con loop
        player_lastPosition = transform.position;
        //// Debug.Log(player_lastPosition);
        distance = Vector3.Distance(player_currentPosition, transform.position);
        //Debug.Log("The distance " + distance);
        Vector3 target = Waypoint.position;
        //Debug.Log("Where is the target " + target);
        transform.position = Vector3.MoveTowards(player_lastPosition, Vector3.Lerp(player_lastPosition, target, t), speed);

        playerScore = distance;
        //for (int i = 0; i <= 10; i++)
        //{
        //    if (player_lastPosition == target)
        //    {
        //        target = new Vector3(10f, 0, 0);
        //        transform.position = Vector3.MoveTowards(player_lastPosition, Vector3.Lerp(player_lastPosition, target, t), speed);
        //    }
        //}


    }

    //private void SpawntargetPosition ()
    //{
    //    bool targetPositioned = false;
    //    while (!targetPositioned)
    //    {
    //        Vector3 targetPosition = new Vector3(Random.Range(-7f, 7f), 0, Random.Range(0f, 100f));
    //        if((targetPosition - transform.position).magnitude < 10)
    //        {
    //            continue;
    //        } 
    //        else
    //        {
    //            Instantiate(points, targetPosition, Quaternion.identity);
    //            targetPositioned = true;
    //            target = targetPosition;
    //            transform.position = Vector3.MoveTowards(player_lastPosition, Vector3.Lerp(player_lastPosition, target, t), speed);
    //        }
    //    }
    //    Debug.Log(targetPositioned);
    //}

    //private void PlayerMovements()
    //{
        
    //    PlayerMoveToForward();

    //    //PlayerMoveToLeft();

    //    PlayerMoveToRight();
    //}
    
    //private void PlayerMoveToForward()
    //{
        
    //    transform.Translate(new Vector3(0,0,2f) * Time.deltaTime);
    //    //Debug.Log(distance);
    //}

    //private void PlayerMoveToLeft()
    //{
    //    int rDistance = (int) Mathf.Round(distance);
    //    //Debug.Log(rDistance);
    //    if (rDistance == 10)
    //    {
            
    //            transform.Translate(new Vector3(-1000f, 0, 5f) * Time.deltaTime);
    //            //int timer = (int) Mathf.Round(Time.time);
    //            //int coolDown = reachThisDistance -= timer;
    //            //Debug.Log(coolDown);
    //            //if (coolDown == 0)
    //            //{
    //            //    reached = false;
    //            //}
            
    //    }
    //}

    //private void PlayerMoveToRight()
    //{
    //    int rDistance = (int)Mathf.Round(distance);
    //    if (rDistance == 10)
    //    {
    //        transform.Translate(new Vector3(20f,0,0) * Time.deltaTime);
    //    }
    //}
}
