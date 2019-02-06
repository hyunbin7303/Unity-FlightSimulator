using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace IndiePixel
{

    public class IP_BaseAirplane_Input : MonoBehaviour
    {
        #region Variables
        protected float pitch = 0f;
        protected float roll = 0f;
        protected float yaw = 0f;
        protected float throttle = 0f;
        protected float brake = 0f;

        public KeyCode brakeKey = KeyCode.Space;

        protected int flaps = 0;
        public int maxFlapIncrements = 2;
        


        #endregion

        #region Properties
        public float Pitch
        {
            get { return pitch; }
        }
        public float Roll
        {
            get { return roll; }
        }
        public float Yaw
        {
            get { return yaw; }
        }
        public float Throttle
        {
            get { return throttle; }
        }
        public int Flaps
        {
            get { return flaps; }
        }
        public float Brake
        {
            get { return brake; }
        }
        #endregion






        #region Builtin Methods  

        // Use this for initialization
        void Start()
        {
            Debug.Log("INPUT STARTED!.");

        }

        // Update is called once per frame
        void Update()
        {
            HandleInput();
        }
        #endregion




        #region Custom Methods
        protected virtual void HandleInput()
        {

            pitch = Input.GetAxis("Vertical");
            roll = Input.GetAxis("Horizontal");
            yaw = Input.GetAxis("Yaw");
            throttle = Input.GetAxis("Throttle");
            brake = Input.GetKey(brakeKey) ? 1f : 0f;
            

            // Process flaps Inputs.
            if(Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log("F key pressed.");
                flaps += 1;
            }
            if(Input.GetKeyDown(KeyCode.G))
            {
                Debug.Log("G key pressed.");
                flaps -= 1;
            }


            flaps = Mathf.Clamp(flaps, 0, maxFlapIncrements);
         }


        #endregion
    }
}
