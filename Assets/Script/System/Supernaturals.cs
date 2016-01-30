using UnityEngine;
using System.Collections;

public abstract class Supernaturals : MonoBehaviour {
	protected string name;
	protected string description;

	public Supernaturals(string name, string description) {
		this.name = name;
		this.description = description;
	}

	public abstract void appear();
	public abstract void attack();
	public abstract void attacked();
	public abstract void disappear();
}
