using UnityEngine;

[System.Serializable]
public class ShotDispersion {
	public float minDispersion = 0f;
	public float maxDispersion = 0.1f;
	public AnimationCurve scaleFunction;
	public float dispersionTime = 2f;

	public float getDispersionRate(float shootingTime) {
		float normalizedDispersionTime = Mathf.Clamp(shootingTime, 0, dispersionTime) / dispersionTime;
		float currentDispersion = scaleFunction.Evaluate(normalizedDispersionTime) * maxDispersion;
		return currentDispersion;
	}
}