using UnityEngine;

public class TrailArc : MonoBehaviour
{
	private int savedIndex;

	private int pointIndex;

	public Material material;

	private bool Emit;

	private bool emittingDone;

	public int maxPointsDrawn;

	public int pointsStored;

	public float minVel;

	public bool faceCamera;

	public bool twist;

	private float time;

	public float lifetime;

	private float lifeTimeRatio;

	private float fadeOutRatio;

	public Color[] colors;

	public float[] widths;

	public float pointDistance;

	private float pointSqrDistance;

	public int segmentsPerPoint;

	private float tRatio;

	public bool printResults;

	public bool printSavedPoints;

	public bool printSegmentPoints;

	private GameObject trail;

	private Renderer mRenderer;

	private Mesh mesh;

	private Material trailMaterial;

	private Vector3[] saved;

	private Vector3[] savedUp;

	private int savedCnt;

	private Vector3[] points;

	private Vector3[] pointsUp;

	private int pointCnt;

	private int displayCnt;

	private float lastPointCreationTime;

	private float averageCreationTime;

	private float averageInsertionTime;

	private float elapsedInsertionTime;

	private float creationTime;

	public float maxLifeTime;

	private bool initialized;

	public bool emit
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	private void printPoints()
	{
	}

	private void printAllPoints()
	{
	}

	private void findCoordinates(int index)
	{
	}

	public void SetTrailColor(Color baseColor)
	{
	}

	private void Update()
	{
	}
}
