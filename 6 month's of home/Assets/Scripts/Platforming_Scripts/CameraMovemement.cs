 using UnityEngine;

public class CameraMovemement : MonoBehaviour {

    public static CameraMovemement instance;

    public Transform target;
    public Transform target2;

    public float smoothSpeed = 10f;

    public Vector3 offSet;

    private void Awake()
    {
        if (instance != null) { Debug.Log("Badthing3"); }

        else
        {
            instance = this;
        }
    }



    private void Update()
    {
        if (Movement.instance == false)
        {
            smoothSpeed = 3f;
        }

       
    }
    void LateUpdate()
    {
        if (Movement.instance.playerActive == true) {
            Vector3 desiredPosition = target.position + offSet;

            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;
        }

        if (Movement.instance.playerActive == false)
        {
            Vector3 desiredPosition = target2.position + offSet;

            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;
        }
    }
}
