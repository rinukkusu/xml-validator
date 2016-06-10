namespace xml_validator
{
	partial class frmXmlValidator
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lstXsd = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtError = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnValidate = new System.Windows.Forms.Button();
			this.txtXml = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lstXsd
			// 
			this.lstXsd.AllowDrop = true;
			this.lstXsd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstXsd.FormattingEnabled = true;
			this.lstXsd.Location = new System.Drawing.Point(12, 52);
			this.lstXsd.Name = "lstXsd";
			this.lstXsd.Size = new System.Drawing.Size(610, 56);
			this.lstXsd.TabIndex = 1;
			this.lstXsd.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstXml_DragDrop);
			this.lstXsd.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstXml_DragEnter);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "XSD";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "XML";
			// 
			// txtError
			// 
			this.txtError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtError.Location = new System.Drawing.Point(12, 132);
			this.txtError.Multiline = true;
			this.txtError.Name = "txtError";
			this.txtError.Size = new System.Drawing.Size(610, 152);
			this.txtError.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 116);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Error";
			// 
			// btnValidate
			// 
			this.btnValidate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnValidate.Location = new System.Drawing.Point(547, 295);
			this.btnValidate.Name = "btnValidate";
			this.btnValidate.Size = new System.Drawing.Size(75, 23);
			this.btnValidate.TabIndex = 6;
			this.btnValidate.Text = "Validate";
			this.btnValidate.UseVisualStyleBackColor = true;
			this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
			// 
			// txtXml
			// 
			this.txtXml.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtXml.Location = new System.Drawing.Point(47, 6);
			this.txtXml.Name = "txtXml";
			this.txtXml.Size = new System.Drawing.Size(575, 20);
			this.txtXml.TabIndex = 7;
			this.txtXml.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtXml_MouseClick);
			// 
			// frmXmlValidator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 330);
			this.Controls.Add(this.txtXml);
			this.Controls.Add(this.btnValidate);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtError);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lstXsd);
			this.Name = "frmXmlValidator";
			this.Text = "XmlValidator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ListBox lstXsd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtError;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnValidate;
		private System.Windows.Forms.TextBox txtXml;
	}
}

