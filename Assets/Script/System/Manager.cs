using System;
using System.Collections.Generic;

public abstract class Manager {
	/* Simply a manager class to speak of a behavior. */
	// public abstract void RegisterMember(string key, Object o);
	public abstract void RemoveMember(string key);
	// public abstract Object GetMember(string key);
	public abstract bool HasMember(string key);
	// public abstract bool HasMember(Object o);
}
