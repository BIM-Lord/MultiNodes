using System;
using System.Collections.Generic;
using Autodesk.DesignScript.Runtime;

namespace MultiNodes
	{
	public class SplitStringList
	
		{
		private SplitStringList() { }
		[MultiReturn(new[] { "List100", "List200", "List300","Feil" })]
		public static Dictionary<string, object> SplitStrings(List<string> inputList)
			{
			List<string> list100 = new List<string>();
			List<string> list200 = new List<string>();
			List<string> list300 = new List<string>();
			List<string> listnot = new List<string>();

			foreach (string item in inputList)
				{
				switch (item)
					{
					case "100":
						list100.Add(item);
						break;
					case "200":
						list200.Add(item);
						break;
					case "300":
						list300.Add(item);
						break;
					default:
						listnot.Add(item);
						break;
					}
				}

			return new Dictionary<string, object>
			{
				{ "List100", list100 },
				{ "List200", list200 },
				{ "List300", list300 },
				{ "Feil", listnot}
			};
			}
		}
	}
