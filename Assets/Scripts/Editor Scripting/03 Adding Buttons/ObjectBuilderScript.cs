using UnityEngine;


public class ObjectBuilderScript : MonoBehaviour
{
    public GameObject TheObject;
    public Vector3 spawnPoint;


    public void BuildObject()
    {
        Instantiate(TheObject, spawnPoint, Quaternion.identity);
    }
}