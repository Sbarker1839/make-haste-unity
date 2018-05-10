using UnityEngine;
using System.Collections;

// maintains position offset while orbiting around target

public class OrbitCamera : MonoBehaviour {
	[SerializeField] private Transform target;

	public float rotSpeed = 1.5f;

	private float _rotY;
	private Vector3 _offset;
    private bool firstLoop = true;
    //Left clamp for rotation
    private Quaternion LeftBound = Quaternion.Euler(0, 90, 0);
    //Right clamp for rotation
    private Quaternion RightBound = Quaternion.Euler(0, 180, 0);
    //Quaternion rotation = Quaternion.Euler(0, _rotY, 0);
	private Quaternion rotation;
    //Flips the camera view to be in front of the player
    private Quaternion flip = Quaternion.Euler(0, 180, 20);

    // Use this for initialization
    void Start() {
		_rotY = transform.eulerAngles.y;
		_offset = target.position - transform.position;
	}
	
	// Update is called once per frame
	void Update() {
		float horInput = Input.GetAxis("Horizontal");
		if (horInput != 0) {
			_rotY += horInput * rotSpeed;
            }
	     else {
			_rotY += Input.GetAxis("Mouse X") * rotSpeed * 3;
		}
        /*
        //Left clamp for rotation
        Quaternion LeftBound = Quaternion.Euler(0, 90, 0);
        //Right clamp for rotation
        Quaternion RightBound = Quaternion.Euler(0, 180, 0);
        //Quaternion rotation = Quaternion.Euler(0, _rotY, 0);
        Quaternion rotation = Quaternion.Lerp(LeftBound, RightBound, _rotY);
        //Flips the camera view to be in front of the player
        Quaternion flip = Quaternion.Euler(0, 180, 0);
        //Calculates camera view
        */

        if(firstLoop)
        {
            rotation = Quaternion.Lerp(LeftBound, RightBound, _rotY);
            firstLoop = false;
        }

		transform.position = target.position - (flip* rotation * _offset);
        //Applies camera view
		transform.LookAt(target);
	}
}
