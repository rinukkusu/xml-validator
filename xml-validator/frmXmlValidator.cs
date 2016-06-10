using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using System.IO;

namespace xml_validator
{
	public partial class frmXmlValidator : Form
	{
		public frmXmlValidator()
		{
			InitializeComponent();
		}

		private void lstXsd_DragDrop(object sender, DragEventArgs e)
		{
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

			foreach (string file in files)
			{
				if (file.EndsWith(".xsd"))
				{
					lstXsd.Items.Add(file);
				}
				else if (file.EndsWith(".xml"))
				{
					lstXsd.Items.Add(file);
				}
			}
		}

		private void lstXsd_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		private void lstXml_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		private void lstXml_DragDrop(object sender, DragEventArgs e)
		{
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

			foreach (string file in files)
			{
				if (file.EndsWith(".xsd"))
				{
					lstXsd.Items.Add(file);
				}
				else if (file.EndsWith(".xml"))
				{
					lstXsd.Items.Add(file);
				}
			}
		}

		private void btnValidate_Click(object sender, EventArgs e)
		{
			// Set the validation settings.
			XmlReaderSettings settings = new XmlReaderSettings { ValidationType = ValidationType.Schema };

			settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessInlineSchema;
			settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessSchemaLocation;
			settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;

			foreach (string item in lstXsd.Items)
			{
				settings.Schemas.Add(null, item);
			}

			settings.ValidationEventHandler += (eventSender, args) =>
			{
				if (args.Severity == XmlSeverityType.Warning)
					AddError($"Warning: L{args.Exception.LineNumber}:{args.Exception.LinePosition} - {args.Message}");
				else
					AddError($"Error: L{args.Exception.LineNumber}:{args.Exception.LinePosition} - {args.Message}");

				Application.DoEvents();
			};

			// Create the XmlReader object.
			using (XmlReader reader = XmlReader.Create(txtXml.Text, settings))
			{
				// Parse the file. 
				while (reader.Read())
				{
					Application.DoEvents();
				};
			}			
		}

		private void AddError(string message)
		{
			txtError.AppendText(message);
			txtError.AppendText(Environment.NewLine);
		}

		private void txtXml_MouseClick(object sender, MouseEventArgs e)
		{
			OpenFileDialog dlgOpenFile = new OpenFileDialog();
			dlgOpenFile.Filter = "Xml Files|*.xml|All Files|*.*";

			if (dlgOpenFile.ShowDialog() == DialogResult.OK)
			{
				txtXml.Text = dlgOpenFile.FileName;
			}
		}
	}
}
