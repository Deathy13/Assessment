using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Player.Camera.FirstPerson
{
    [AddComponentMenu("Player.Camera.FirstPerson")]
    public class MouseLook : MonoBehaviour
    {
        #region Variables 
        [Header("Sensitivity")] //how sensitivy is mouse is
        public float sensitivityX = 15f;
        public float sensitivityY = 15f;
        [Header("Rotation")] 
        public float minimumY = -60f;
        public float maximumY = 60f;
        float rotationY = 0f;
        #endregion
        public RotaionalAxis axis = RotaionalAxis.MouseX;
        public enum RotaionalAxis//sperated the axies
        {
            MouseXAndY = 0,
            MouseX = 1,
            MouseY = 2
        }
        void Start()
        {
            if(this.GetComponent<Rigidbody>())
            {
                this.GetComponent<Rigidbody>().freezeRotation = true;//stop the the stop  rotation
            }
        }
        void Update()
        {
            if (axis == RotaionalAxis.MouseXAndY)//axis of x and y
            {
                float rotationX =transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX; //is for the rotion in x axes of mouse
                rotationY += Input.GetAxis("Mouse Y") * sensitivityY; // this is for the whean you move mouse in y axes of mouse
                rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);// 
                transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
            }
            else if (axis == RotaionalAxis.MouseX)
            {
                transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityX, 0);
            }
            else //axis == RotaionalAxis.MouseY
            {
                rotationY += Input.GetAxis ("Mouse Y") * sensitivityY;// use y axis  mouse and how fast go
                rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);//
                transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, 0);

            }
        }

    }
    


}
