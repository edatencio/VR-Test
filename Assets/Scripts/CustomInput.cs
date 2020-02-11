using UnityEngine;

public static class CustomInput
{
    public static float CameraX
    {
        get
        {
            if (Application.platform == RuntimePlatform.Android)
            {
                if (!Input.gyro.enabled)
                    Input.gyro.enabled = true;
                return -Input.gyro.rotationRateUnbiased.y;
            }
            else
            {
                return Input.GetAxis("Mouse X");
            }
        }
    }

    public static float CameraY
    {
        get
        {
            if (Application.platform == RuntimePlatform.Android)
            {
                if (!Input.gyro.enabled)
                    Input.gyro.enabled = true;
                return Input.gyro.rotationRateUnbiased.x;
            }
            else
            {
                return Input.GetAxis("Mouse Y");
            }
        }
    }
}
