﻿/*
	AsterNET ARI Framework
	Automatically generated file @ 12/10/2015 11:53:28
*/
using System;
using System.Collections.Generic;
using AsterNET.ARI.Models;
using AsterNET.ARI;

namespace AsterNET.ARI.Actions
{
	
	public interface ISoundsActions
	{
		/// <summary>
		/// List all sounds.. 
		/// </summary>
		/// <param name="lang">Lookup sound for a specific language.</param>
		/// <param name="format">Lookup sound in a specific format.</param>
		List<Sound> List(string lang = null, string format = null);
		/// <summary>
		/// Get a sound's details.. 
		/// </summary>
		/// <param name="soundId">Sound's id</param>
		Sound Get(string soundId);
	}
}
