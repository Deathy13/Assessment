using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace player
{
    public class MovementScripts : MonoBehaviour
    {//varaiables

        public float moveSpeed = 10f;
        public float jumpSpeed = 8f;
        public float gravity = 20f;
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Movement();

        }
        public void Movement()
        {// manny you know this it is movement scripts
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            }
        }
    }
}