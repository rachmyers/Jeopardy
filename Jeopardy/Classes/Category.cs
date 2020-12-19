using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace JeopardyGame.Classes
{
	/// <summary>
	/// Class for the Category node in the XML file
	/// </summary>
	[XmlRoot(ElementName = "category")]
	public class Category
	{
		[XmlElement(ElementName = "first")]
		public First First { get; set; }
		[XmlElement(ElementName = "second")]
		public Second Second { get; set; }
		[XmlElement(ElementName = "third")]
		public Third Third { get; set; }
		[XmlElement(ElementName = "fourth")]
		public Fourth Fourth { get; set; }
		[XmlElement(ElementName = "fifth")]
		public Fifth Fifth { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
	}
}
