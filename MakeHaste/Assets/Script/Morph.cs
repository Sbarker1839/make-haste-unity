
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morph : MonoBehaviour {

	public float rotationsPerMinute = 1.0f;

	private float _currentScale = InitScale;
	public float TargetScale = 5f;
	private const float InitScale = 1f;
	private const int FramesCount = 100;
	private const float AnimationTimeSeconds = 2;
	public float upperbound = 20f;
	public float lowerbound = 20f;

	private bool _upScale = true;
	private IEnumerator Breath()
	{
		float _deltaTime = AnimationTimeSeconds/FramesCount;
		float _dx = (TargetScale - InitScale)/FramesCount;
		while (transform.position.y>8)
		{
			Debug.Log("a");
			while (_upScale)
			{
				Debug.Log(transform.position.y);

				_currentScale += _dx;
				if (_currentScale > TargetScale)
				{
					_upScale = false;
					_currentScale = TargetScale;
				}
				transform.localScale = new Vector3(
					_currentScale, 
					_currentScale, 
					_currentScale)
					;

				yield return new WaitForSeconds(_deltaTime);
			}

			while (!_upScale)
			{
				_currentScale -= _dx;
				if (_currentScale < InitScale)
				{
					_upScale = true;
					_currentScale = InitScale;
				}
				transform.localScale = new Vector3(
					_currentScale, 
					_currentScale, 
					_currentScale)
					;

				yield return new WaitForSeconds(_deltaTime);
			}
			while (transform.position.y < 20) {
				transform.position += Vector3.up * 3.0F * Time.deltaTime;
			}
		}
	}


	private void Start()
	{
		StartCoroutine(Breath());
	}
}



/**

public class Morph : MonoBehaviour {

    public float rotationsPerMinute = 1.0f;
    public float upperbound = 4.5f;
    public float lowerbound = -3.5f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Rotate();
        Resize();
        
        
    }

    void Resize()
    {
        // Widen the object by 0.1
        transform.localScale += new Vector3(
            Random.Range(lowerbound, upperbound) * Time.deltaTime, 
            Random.Range(lowerbound, upperbound) * Time.deltaTime, 
            Random.Range(lowerbound, upperbound) * Time.deltaTime);
    }

    void Rotate()
    {
        // Widen the object by 0.1
        transform.Rotate(
            Random.Range(-1f, 1f) * rotationsPerMinute * Time.deltaTime,
            Random.Range(-1f, 1f) * rotationsPerMinute * Time.deltaTime,
            Random.Range(-1f, 1f) * rotationsPerMinute * Time.deltaTime);
    }

}
**/