using System;
using System.Collections.Generic;
using Autodesk.DesignScript.Runtime;
using DSCore;

namespace MultiNodes
	{
	public class MMIFarger
		{
		private MMIFarger() { }

		/// <summary>
		/// Generate random color
		/// </summary>
		/// <param name="amount">Number of color want to generate</param>
		/// <param name="start">start of range color(0-255)</param>
		/// <param name="end">end of range color(0-255)</param>
		/// <returns name="MMI000">list colors random</returns>
		[MultiReturn(new[] {
			"MMI000", "MMI100", "MMI125", "MMI150", "MMI175",
			"MMI200", "MMI225", "MMI250", "MMI275",
			"MMI300", "MMI325", "MMI350", "MMI375",
			"MMI400", "MMI425", "MMI450", "MMI475",
			"MMI500",
			"MMI600"
			})]
		public static Dictionary<string, DSCore.Color> MMICollores()
			{
			DSCore.Color MMI000 = DSCore.Color.ByARGB(75, 75, 75);
			DSCore.Color MMI100 = DSCore.Color.ByARGB(155, 155, 155);
			DSCore.Color MMI125 = DSCore.Color.ByARGB(125, 125, 125);
			DSCore.Color MMI150 = DSCore.Color.ByARGB(125, 125, 125);
			DSCore.Color MMI175 = DSCore.Color.ByARGB(125, 125, 125);
			DSCore.Color MMI200 = DSCore.Color.ByARGB(125, 125, 125);
			DSCore.Color MMI225 = DSCore.Color.ByARGB(125, 125, 125);
			DSCore.Color MMI250 = DSCore.Color.ByARGB(125, 125, 125);
			DSCore.Color MMI275 = DSCore.Color.ByARGB(125, 125, 125);
			DSCore.Color MMI300 = DSCore.Color.ByARGB(125, 125, 125);
			DSCore.Color MMI325 = DSCore.Color.ByARGB(125, 125, 125);
			DSCore.Color MMI350 = DSCore.Color.ByARGB(125, 125, 125);
			DSCore.Color MMI375 = DSCore.Color.ByARGB(125, 125, 125);
			DSCore.Color MMI400 = DSCore.Color.ByARGB(125, 125, 125);
			DSCore.Color MMI425 = DSCore.Color.ByARGB(125, 125, 125);
			DSCore.Color MMI450 = DSCore.Color.ByARGB(125, 125, 125);
			DSCore.Color MMI475 = DSCore.Color.ByARGB(125, 125, 125);
			DSCore.Color MMI500 = DSCore.Color.ByARGB(125, 125, 125);
			DSCore.Color MMI600 = DSCore.Color.ByARGB(125, 125, 125);

			return new Dictionary<string, DSCore.Color>
			{
				{ "MMI000", MMI000 },
				{ "MMI100", MMI100 },
				{ "MMI125", MMI125 },
				{ "MMI150", MMI150 },
				{ "MMI175", MMI175 },
				{ "MMI200", MMI200 },
				{ "MMI225", MMI225 },
				{ "MMI250", MMI250 },
				{ "MMI275", MMI275 },
				{ "MMI300", MMI300 },
				{ "MMI325", MMI325 },
				{ "MMI350", MMI350 },
				{ "MMI375", MMI375 },
				{ "MMI400", MMI400 },
				{ "MMI425", MMI425 },
				{ "MMI450", MMI450 },
				{ "MMI475", MMI475 },
				{ "MMI500", MMI500 },
				{ "MMI600", MMI600 }
			};
			}
		}
	}



