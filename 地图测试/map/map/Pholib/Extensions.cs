using System;
using UnityEngine;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Pholib
{
	public static class Extensions
	{
		public static void RemoveDef<DefType>(this GameObject go) where DefType : StateMachine.BaseDef
		{
			StateMachineController stateMachineController = go.AddOrGet<StateMachineController>();
			DefType def = stateMachineController.GetDef<DefType>();
			if (def != null)
			{
				def.Configure(null);
				stateMachineController.cmpdef.defs.Remove(def);
			}
		}

		public static string Dump(this object obj)
		{
			return new SerializerBuilder().WithNamingConvention(new CamelCaseNamingConvention()).Build().Serialize(obj);
		}
	}
}
