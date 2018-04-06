using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Player
{
    public class Cannon : MonoBehaviour
    {//variables you know it.
        public GameObject cannonBallPrefabs;
        public Transform[] spawnPoint;
        public float coannonBallS;
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {//shootin when presa some thing
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("pressed");
                //shoot the bullet .in direction couse we need it 
                Fire(transform.forward);
            }
        }
        public void Fire(Vector3 Direction)
        {//check the lenght ang get parent in the player
            for (int i = 0; i < spawnPoint.Length; i++)
            {
                //spawn bullet
                SCannon(Direction, spawnPoint[i].position);
            }

        }
        //some Phsyisc for the shot ting and direction
        public void SCannon(Vector3 Direction, Vector3 point)
        {// macke clon gameboject from prefabbs
            GameObject clon = Instantiate(cannonBallPrefabs);
            //the coln postion to the point
            clon.transform.position = point;
            //get angle of the player and rotate of clone = player and insainsate the bollet  in theface of  player from the position
            float angle = Mathf.Atan2(Direction.z, Direction.x);
            float degres = angle * Mathf.Rad2Deg;
            clon.transform.rotation = Quaternion.AngleAxis(degres, Vector3.forward);
            // tell it rigidbody to fly in direction
            Rigidbody rigid = clon.GetComponent<Rigidbody>();
            rigid.AddForce(Direction * coannonBallS, ForceMode.Impulse);
        }
    }
}