using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using Autodesk.DesignScript;
using Autodesk.DesignScript.Runtime;
using CoreNodeModels;
using Dynamo.Graph.Nodes.CustomNodes;
using ProtoCore.AST.AssociativeAST;

namespace MultiNodes
{
<<<<<<< HEAD
	public class GetSystemInfo
	{
        private GetSystemInfo() { }
		[MultiReturn("UserDomain", "UserMachineName")]
		public static Dictionary<string, object> SystemInfo()
=======
	public class MultiNodes
	{
        private MultiNodes() { }
		[MultiReturn("UserDomain", "UserMachineName")]
		public static Dictionary<string, object> GetSystemInfo()
>>>>>>> 8005e53ab3e85504aebc81b6e90e1f9fd77145f6
		{
				List<string> UDX = new List<string>();
				List<string> UMNX = new List<string>();
			String UserDomainx = Environment.UserDomainName;
			UDX.Add(UserDomainx);
			String UserMachineNamex = Environment.MachineName;
			UMNX.Add(UserMachineNamex);
			
				// Create a dictionary to store the outputs with their keys
				var result = new Dictionary<string, object>
			{
				{ "UserDomain", UDX },
				{ "UserMachineName", UMNX}	
			};

			return result;

		}

    }

}
