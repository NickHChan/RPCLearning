using PurrNet;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class TestNetwork : NetworkIdentity
{
    public Color _color;
    public Renderer _renderer;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            SetColor(_color);
        }
    }

    [ObserversRpc]
    private void SetColor(Color color)
    {
        _renderer.material.color = color;
    }
//Network Loop, can't spawn things before the server is up and running, Awake and Start methods are no longer good to use, replaced with OnSpawned (Purrnet thing)
}
