using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class world_generator : MonoBehaviour
{
    public GameObject end;
    GameObject zone;
    public Vector3 spawn_offset;
    public GameObject[] zones;
    public World_settings world_setings;
    public GameObject devtest;

    private void Start()
    {
        if (world_setings.dificulty <= 1)
        {
            zone = zones[Random.Range(0, 1)];
        }
        if (world_setings.dificulty <= 2)
        {
            zone = zones[Random.Range(0, 2)];
        }
        if (world_setings.dificulty <= 3)
        {
            zone = zones[Random.Range(1, 3)];
        }
        if (world_setings.dificulty <= 4)
        {
            zone = zones[Random.Range(1, 4)];
        }
        if (world_setings.dificulty <= 5)
        {
            zone = zones[Random.Range(1, 5)];
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("caca");
        Instantiate(zone, new Vector3((end.transform.position.x + spawn_offset.x), (end.transform.position.y + spawn_offset.y), (end.transform.position.z + spawn_offset.z)), Quaternion.identity);
        world_setings.exp += 5;
    }
}
