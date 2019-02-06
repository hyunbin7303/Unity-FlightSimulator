using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndiePixel
{ 
    public class IP_XboxAirplane_Input : IP_BaseAirplane_Input {

        protected override void HandleInput()
        {
            pitch = Input.GetAxis("Vertical");
            roll = Input.GetAxis("Horizontal");
            yaw = Input.GetAxis("Yaw");
            throttle = Input.GetAxis("Throttle");
            brake = Input.GetAxis("Fire1");

            if(Input.GetButtonDown("X_R_Bumper"))
            {
                flaps += 1;
            }

            if (Input.GetButtonDown("X_L_Bumper"))
            {
                flaps -= 1;
            }
            //if (Input.GetKeyDown(KeyCode.G))
            //{
            //    flaps -= 1;
            //}
            flaps = Mathf.Clamp(flaps, 0, maxFlapIncrements);
        }
    }
}