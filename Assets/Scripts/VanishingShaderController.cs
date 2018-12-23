using UnityEngine;

[ExecuteInEditMode]
public class VanishingShaderController : MonoBehaviour
{
    [SerializeField] float strengthX = 0f;
    [SerializeField] float strengthY = 0f;
    [SerializeField] float alpha = 1f;
    [SerializeField] Material material;

    void Update()
    {
        UpdateMaterial();
    }

    void UpdateMaterial()
    {
        if (material == null) { return; }

        material.SetFloat("_StrengthX", strengthX);
        material.SetFloat("_StrengthY", strengthY);
        material.SetFloat("_Alpha", alpha);
    }
}
