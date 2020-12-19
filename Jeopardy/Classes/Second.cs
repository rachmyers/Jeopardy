using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace JeopardyGame.Classes
{
	/// <summary>
	/// Class for the Second node in the XML file
	/// </summary>
	[XmlRoot(ElementName = "second")]
	public class Second
	{
		[XmlAttribute(AttributeName = "points")]
		public string Points { get; set; }
		[XmlAttribute(AttributeName = "answer")]
		public string Answer { get; set; }
		[XmlText]
		public string Text { get; set; }
	}
}
