using System;
using System.Collections.Generic;

public class SupernaturalManager : Manager {
	protected Dictionary<string, Supernaturals> dict;

	public SupernaturalManager() {
		dict = new Dictionary<string, Supernaturals> ();
	}

	public void RegisterMember(string key, Supernaturals who) {
		if (dict.ContainsKey (key))
			dict.Remove (key);
		dict.Add (key, who);
	}

	public override void RemoveMember(string key) {
		if (dict.ContainsKey (key))
		    dict.Remove (key);
	}

	public Supernaturals GetMember(string key) {
		Supernaturals s = null;
		if (dict.ContainsKey (key))
			dict.TryGetValue (key, out s);
		else
			throw new KeyNotFoundException ();
		return s;
	}

	public override bool HasMember(string key) {
		return dict.ContainsKey (key);
	}

	public bool HasMember(Supernaturals o) {
		return dict.ContainsValue (o);
	}
}
