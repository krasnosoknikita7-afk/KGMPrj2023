using UnityEngine;

public class AudioBuild : MonoBehaviour
{
	public AudioClip cubeAdded;

	public AudioClip cubeRemoved;

	public AudioClip faceMoved;

	public AudioClip edgeMoved;

	public AudioClip vertexMoved;

	public AudioClip cubePainted;

	public AudioClip translateNotGrid;

	public AudioClip translateGrid;

	private AudioSource buildSource;

	private float currentTranslateMoveValue;

	private void Awake()
	{
	}

	public void CubeAdded(Vector3 worldPos)
	{
	}

	public void CubeRemoved(Vector3 worldPos)
	{
	}

	public void FaceMoved(Vector3 worldPos)
	{
	}

	public void EdgeMoved(Vector3 worldPos)
	{
	}

	public void VertexMoved(Vector3 worldPos)
	{
	}

	public void CubePainted(Vector3 worldPos)
	{
	}

	public void Translate(float moveValue, bool moveToGridPos, Vector3 worldPos)
	{
	}

	public void PlayClip(Vector3 worldPos, AudioClip audioClip, float randMin, float randMax)
	{
	}
}
