using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace JeopardyGame.Classes
{
	/// <summary>
	/// Class for the root Jeopardy node in the XML file
	/// </summary>
	[XmlRoot(ElementName = "Jeopardy")]
	public class Jeopardy
	{
		[XmlElement(ElementName = "category")]
		public List<Category> Category { get; set; }
	}
}
