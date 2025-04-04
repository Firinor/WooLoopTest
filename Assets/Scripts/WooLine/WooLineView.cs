using UnityEngine;

public class WooLineView : MonoBehaviour
{
    [SerializeField] private LineRenderer _lineRenderer;
    public LineRenderer LineRenderer => _lineRenderer;
    
    [SerializeField] private SpriteRenderer _handleSpriteRenderer;
    public SpriteRenderer HandleSpriteRenderer => _handleSpriteRenderer;
}