using UnityEngine;

[CreateAssetMenu]
public class NoiseData : UpdateableData
{
    public Noise.NormalizeMode normalizeMode;

    public float noiseScale;
    public int octaves;

    [Range(0, 1)] public float persistance;
    public float lacunarity;

    public int seed;
    public Vector2 offset;

    #if UNITY_EDITOR
    protected override void OnValidate()
    {
        // Prevent these values from being less than their minimum possible values
        if (lacunarity < 1)
            lacunarity = 1;

        if (octaves < 0)
            octaves = 0;

        base.OnValidate();
    }
    #endif
}
