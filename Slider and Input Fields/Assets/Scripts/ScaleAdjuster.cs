using UnityEngine;

public class ScaleAdjuster : MonoBehaviour
{
    public void AdjustUniformScale(float value)
    {
        transform.localScale = new Vector3(value, value, value);
    }
}
