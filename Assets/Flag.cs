using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    [SerializeField] private MeshRenderer _flag;
    [SerializeField] private Material _flagMaterialGreen;

    void Update() {
        transform.rotation *= Quaternion.AngleAxis(Time.deltaTime * 90, Vector3.up);
    }
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _flag.material = _flagMaterialGreen;
        }
    }
}
