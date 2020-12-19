using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace JeopardyGame.Classes
{
	/// <summary>
	/// Class for the Third node in the XML file
	/// </summary>
	[XmlRoot(ElementName = "third")]
	public class Third
	{
		[XmlAttribute(AttributeName = "points")]
		public string Points { get; set; }
		[XmlAttribute(AttributeName = "answer")]
		public string Answer { get; set; }
		[XmlText]
		public string Text { get; set; }
	}
}
