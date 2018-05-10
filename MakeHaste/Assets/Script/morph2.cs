using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class morph2 : MonoBehaviour {

	public float rotationsPerMinute = 1.0f;

	private float _currentScale = InitScale;
	public float TargetScale = 3f;
	private const float InitScale = 1f;
	private const int FramesCount = 100;
	private const float AnimationTimeSeconds = 2;


	private bool _upScale = true;
	private IEnumerator Breath()
	{
		float _deltaTime = AnimationTimeSeconds/FramesCount;
		float _dx = (TargetScale - InitScale)/FramesCount;
		while (true)
		{
			while (_upScale)
			{
				_currentScale += _dx;
				if (_currentScale > TargetScale)
				{
					_upScale = false;
					_currentScale = TargetScale;
				}
				transform.localScale = new Vector3(
					1, 
					_currentScale, 
					1)
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
					1, 
					_currentScale, 
					1)
					;

				yield return new WaitForSeconds(_deltaTime);
			}

		}
	}


	private void Start()
	{
		StartCoroutine(Breath());
	}
}
