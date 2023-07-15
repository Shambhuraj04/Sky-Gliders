using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientLight : MonoBehaviour
{
  public float speed = 1.0f;
  public Gradient ambientLight;
  public Gradient fog;
  public Gradient topSky;
  public Gradient botSky;
  public Gradient sunFlarePower;
  public Gradient moonFlarePower;
  public Gradient lightPower;
  public Transform skyPlane;
  public AnimationCurve rotationCurve;

  public float t = 0.0f;
  private Material sky { get; set; }
  private Material sunFlare { get; set; }
  private Material moonFlare { get; set; }
  private Light gameLight { get; set; }

	// Use this for initialization
	void Start ()
  {
    #if UNITY_EDITOR
    if (runInEditMode)
    {
      sky = GetComponentInChildren <MeshRenderer> ().sharedMaterial;
      sunFlare = skyPlane.Find ("Sun").Find ("Flare").GetComponent <Renderer> ().sharedMaterial;
      moonFlare = skyPlane.Find ("Moon").Find ("Flare").GetComponent <Renderer> ().sharedMaterial;
    }
    else
    #endif
    {
      sky = GetComponentInChildren <MeshRenderer> ().material;
      sunFlare = skyPlane.Find ("Sun").Find ("Flare").GetComponent <Renderer> ().material;
      moonFlare = skyPlane.Find ("Moon").Find ("Flare").GetComponent <Renderer> ().material;
    }

    gameLight = FindObjectOfType <Light> ();
	}
	
	// Update is called once per frame
	void Update ()
  {
    t += Time.deltaTime * speed;
    RenderSettings.ambientLight = ambientLight.Evaluate (t);
    RenderSettings.fogColor = fog.Evaluate (t);

    sky.SetColor ("_TopColor", topSky.Evaluate (t));
    sky.SetColor ("_BottomColor", botSky.Evaluate (t));

    skyPlane.localEulerAngles = -Vector3.forward * rotationCurve.Evaluate (t);

    sunFlare.SetFloat ("_Power", sunFlarePower.Evaluate (t).a);
    moonFlare.SetFloat ("_Power", moonFlarePower.Evaluate (t).a);

    if (gameLight != null)
      gameLight.color = lightPower.Evaluate (t);

    if (t > 1.25f)
    {
      t = 0.0f;
    }
	}
}
