using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Decoration", menuName = "Decoration", order = 1)]
public class Decoration : ScriptableObject {

	public Sprite sprite;

	public bool isPlaced;
}
