using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class world_generator : MonoBehaviour
{
    public GameObject Next_spawn;
    GameObject zone;
    public Vector3 spawn_offset;
    public GameObject[] zones;
    public World_settings world_setings;
    bool do_once;
    DevLog_zone devzone;
    public string code;

    private void Start()
    {
        devzone = FindObjectOfType<DevLog_zone>();
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
        if (other.CompareTag("Player"))
        {
            if (do_once == false)
            {
                devzone.codezone = code;
                Instantiate(zone, new Vector3((Next_spawn.transform.position.x + spawn_offset.x), (Next_spawn.transform.position.y + spawn_offset.y), (Next_spawn.transform.position.z + spawn_offset.z)), Quaternion.identity);
                do_once = true;
            }
        }
    }
}
