
namespace TailwindPOS
{
	partial class frmCustAdd
	{

		#region "Upgrade Support "
		private static frmCustAdd m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmCustAdd DefInstance
		{
			get
			{
				if (m_vb6FormDefInstance is null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = new frmCustAdd();
					m_InitializingDefInstance = false;
				}
				return m_vb6FormDefInstance;
			}
			set
			{
				m_vb6FormDefInstance = value;
			}
		}

		#endregion
		#region "Windows Form Designer generated code "
		private string[] visualControls = new string[]{"components", "ToolTipMain", "cbClose", "cbSave", "txtPhone", "txtCounty", "txtZipCode", "txtState", "txtCity", "txtStreetAddress2", "txtStreetAddress1", "txtCompany", "txtEmail", "txtLastName", "txtFirstName", "lblCompany", "lblCounty", "lblCity", "lblState", "lblZipCode", "lblStreetAdress2", "lblStreetAddress1", "lblPhone", "lblEmail", "lblLastName", "lblFirstName", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.Button cbClose;
		public System.Windows.Forms.Button cbSave;
		public System.Windows.Forms.TextBox txtPhone;
		public System.Windows.Forms.TextBox txtCounty;
		public System.Windows.Forms.TextBox txtZipCode;
		public System.Windows.Forms.TextBox txtState;
		public System.Windows.Forms.TextBox txtCity;
		public System.Windows.Forms.TextBox txtStreetAddress2;
		public System.Windows.Forms.TextBox txtStreetAddress1;
		public System.Windows.Forms.TextBox txtCompany;
		public System.Windows.Forms.TextBox txtEmail;
		public System.Windows.Forms.TextBox txtLastName;
		public System.Windows.Forms.TextBox txtFirstName;
		public System.Windows.Forms.Label lblCompany;
		public System.Windows.Forms.Label lblCounty;
		public System.Windows.Forms.Label lblCity;
		public System.Windows.Forms.Label lblState;
		public System.Windows.Forms.Label lblZipCode;
		public System.Windows.Forms.Label lblStreetAdress2;
		public System.Windows.Forms.Label lblStreetAddress1;
		public System.Windows.Forms.Label lblPhone;
		public System.Windows.Forms.Label lblEmail;
		public System.Windows.Forms.Label lblLastName;
		public System.Windows.Forms.Label lblFirstName;
		public UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustAdd));
			ToolTipMain = new System.Windows.Forms.ToolTip(components);
			cbClose = new System.Windows.Forms.Button();
			cbSave = new System.Windows.Forms.Button();
			txtPhone = new System.Windows.Forms.TextBox();
			txtCounty = new System.Windows.Forms.TextBox();
			txtZipCode = new System.Windows.Forms.TextBox();
			txtState = new System.Windows.Forms.TextBox();
			txtCity = new System.Windows.Forms.TextBox();
			txtStreetAddress2 = new System.Windows.Forms.TextBox();
			txtStreetAddress1 = new System.Windows.Forms.TextBox();
			txtCompany = new System.Windows.Forms.TextBox();
			txtEmail = new System.Windows.Forms.TextBox();
			txtLastName = new System.Windows.Forms.TextBox();
			txtFirstName = new System.Windows.Forms.TextBox();
			lblCompany = new System.Windows.Forms.Label();
			lblCounty = new System.Windows.Forms.Label();
			lblCity = new System.Windows.Forms.Label();
			lblState = new System.Windows.Forms.Label();
			lblZipCode = new System.Windows.Forms.Label();
			lblStreetAdress2 = new System.Windows.Forms.Label();
			lblStreetAddress1 = new System.Windows.Forms.Label();
			lblPhone = new System.Windows.Forms.Label();
			lblEmail = new System.Windows.Forms.Label();
			lblLastName = new System.Windows.Forms.Label();
			lblFirstName = new System.Windows.Forms.Label();
			SuspendLayout();
			commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
			// 
			// cbClose
			// 
			cbClose.AllowDrop = true;
			cbClose.BackColor = System.Drawing.Color.White;
			cbClose.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbClose.ForeColor = System.Drawing.SystemColors.ControlText;
			cbClose.Location = new System.Drawing.Point(488, 624);
			cbClose.Name = "cbClose";
			cbClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cbClose.Size = new System.Drawing.Size(417, 65);
			cbClose.TabIndex = 23;
			cbClose.Text = "Close";
			cbClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cbClose.UseVisualStyleBackColor = false;
			cbClose.Click += new System.EventHandler(cbClose_Click);
			// 
			// cbSave
			// 
			cbSave.AllowDrop = true;
			cbSave.BackColor = System.Drawing.Color.FromArgb(97, 44, 67);
			cbSave.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbSave.ForeColor = System.Drawing.SystemColors.ControlText;
			cbSave.Location = new System.Drawing.Point(64, 624);
			cbSave.Name = "cbSave";
			cbSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cbSave.Size = new System.Drawing.Size(401, 65);
			cbSave.TabIndex = 22;
			cbSave.Text = "Save";
			cbSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cbSave.UseVisualStyleBackColor = false;
			cbSave.Click += new System.EventHandler(cbSave_Click);
			// 
			// txtPhone
			// 
			txtPhone.AcceptsReturn = true;
			txtPhone.AllowDrop = true;
			txtPhone.BackColor = System.Drawing.Color.White;
			txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtPhone.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtPhone.ForeColor = System.Drawing.SystemColors.WindowText;
			txtPhone.Location = new System.Drawing.Point(184, 216);
			txtPhone.MaxLength = 0;
			txtPhone.Name = "txtPhone";
			txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtPhone.Size = new System.Drawing.Size(305, 65);
			txtPhone.TabIndex = 9;
			// 
			// txtCounty
			// 
			txtCounty.AcceptsReturn = true;
			txtCounty.AllowDrop = true;
			txtCounty.BackColor = System.Drawing.Color.White;
			txtCounty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtCounty.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtCounty.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtCounty.ForeColor = System.Drawing.SystemColors.WindowText;
			txtCounty.Location = new System.Drawing.Point(176, 520);
			txtCounty.MaxLength = 0;
			txtCounty.Name = "txtCounty";
			txtCounty.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtCounty.Size = new System.Drawing.Size(353, 65);
			txtCounty.TabIndex = 21;
			// 
			// txtZipCode
			// 
			txtZipCode.AcceptsReturn = true;
			txtZipCode.AllowDrop = true;
			txtZipCode.BackColor = System.Drawing.Color.White;
			txtZipCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtZipCode.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtZipCode.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtZipCode.ForeColor = System.Drawing.SystemColors.WindowText;
			txtZipCode.Location = new System.Drawing.Point(856, 432);
			txtZipCode.MaxLength = 0;
			txtZipCode.Name = "txtZipCode";
			txtZipCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtZipCode.Size = new System.Drawing.Size(225, 65);
			txtZipCode.TabIndex = 19;
			// 
			// txtState
			// 
			txtState.AcceptsReturn = true;
			txtState.AllowDrop = true;
			txtState.BackColor = System.Drawing.Color.White;
			txtState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtState.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtState.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtState.ForeColor = System.Drawing.SystemColors.WindowText;
			txtState.Location = new System.Drawing.Point(120, 432);
			txtState.MaxLength = 0;
			txtState.Name = "txtState";
			txtState.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtState.Size = new System.Drawing.Size(209, 57);
			txtState.TabIndex = 15;
			// 
			// txtCity
			// 
			txtCity.AcceptsReturn = true;
			txtCity.AllowDrop = true;
			txtCity.BackColor = System.Drawing.Color.White;
			txtCity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtCity.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtCity.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtCity.ForeColor = System.Drawing.SystemColors.WindowText;
			txtCity.Location = new System.Drawing.Point(424, 432);
			txtCity.MaxLength = 0;
			txtCity.Name = "txtCity";
			txtCity.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtCity.Size = new System.Drawing.Size(289, 57);
			txtCity.TabIndex = 17;
			// 
			// txtStreetAddress2
			// 
			txtStreetAddress2.AcceptsReturn = true;
			txtStreetAddress2.AllowDrop = true;
			txtStreetAddress2.BackColor = System.Drawing.Color.White;
			txtStreetAddress2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtStreetAddress2.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtStreetAddress2.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtStreetAddress2.ForeColor = System.Drawing.SystemColors.WindowText;
			txtStreetAddress2.Location = new System.Drawing.Point(256, 360);
			txtStreetAddress2.MaxLength = 0;
			txtStreetAddress2.Name = "txtStreetAddress2";
			txtStreetAddress2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtStreetAddress2.Size = new System.Drawing.Size(937, 57);
			txtStreetAddress2.TabIndex = 13;
			// 
			// txtStreetAddress1
			// 
			txtStreetAddress1.AcceptsReturn = true;
			txtStreetAddress1.AllowDrop = true;
			txtStreetAddress1.BackColor = System.Drawing.Color.White;
			txtStreetAddress1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtStreetAddress1.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtStreetAddress1.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtStreetAddress1.ForeColor = System.Drawing.SystemColors.WindowText;
			txtStreetAddress1.Location = new System.Drawing.Point(256, 288);
			txtStreetAddress1.MaxLength = 0;
			txtStreetAddress1.Name = "txtStreetAddress1";
			txtStreetAddress1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtStreetAddress1.Size = new System.Drawing.Size(937, 65);
			txtStreetAddress1.TabIndex = 11;
			// 
			// txtCompany
			// 
			txtCompany.AcceptsReturn = true;
			txtCompany.AllowDrop = true;
			txtCompany.BackColor = System.Drawing.Color.White;
			txtCompany.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtCompany.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtCompany.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtCompany.ForeColor = System.Drawing.SystemColors.WindowText;
			txtCompany.Location = new System.Drawing.Point(184, 144);
			txtCompany.MaxLength = 0;
			txtCompany.Name = "txtCompany";
			txtCompany.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtCompany.Size = new System.Drawing.Size(857, 65);
			txtCompany.TabIndex = 7;
			// 
			// txtEmail
			// 
			txtEmail.AcceptsReturn = true;
			txtEmail.AllowDrop = true;
			txtEmail.BackColor = System.Drawing.Color.White;
			txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtEmail.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtEmail.ForeColor = System.Drawing.SystemColors.WindowText;
			txtEmail.Location = new System.Drawing.Point(184, 80);
			txtEmail.MaxLength = 0;
			txtEmail.Name = "txtEmail";
			txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtEmail.Size = new System.Drawing.Size(857, 57);
			txtEmail.TabIndex = 5;
			// 
			// txtLastName
			// 
			txtLastName.AcceptsReturn = true;
			txtLastName.AllowDrop = true;
			txtLastName.BackColor = System.Drawing.Color.White;
			txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtLastName.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtLastName.ForeColor = System.Drawing.SystemColors.WindowText;
			txtLastName.Location = new System.Drawing.Point(728, 16);
			txtLastName.MaxLength = 0;
			txtLastName.Name = "txtLastName";
			txtLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtLastName.Size = new System.Drawing.Size(361, 57);
			txtLastName.TabIndex = 3;
			// 
			// txtFirstName
			// 
			txtFirstName.AcceptsReturn = true;
			txtFirstName.AllowDrop = true;
			txtFirstName.BackColor = System.Drawing.Color.White;
			txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtFirstName.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtFirstName.ForeColor = System.Drawing.SystemColors.WindowText;
			txtFirstName.Location = new System.Drawing.Point(184, 16);
			txtFirstName.MaxLength = 0;
			txtFirstName.Name = "txtFirstName";
			txtFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtFirstName.Size = new System.Drawing.Size(337, 57);
			txtFirstName.TabIndex = 1;
			// 
			// lblCompany
			// 
			lblCompany.AllowDrop = true;
			lblCompany.BackColor = System.Drawing.Color.White;
			lblCompany.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblCompany.Font = new System.Drawing.Font("Arial", 20.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblCompany.ForeColor = System.Drawing.SystemColors.ControlText;
			lblCompany.Location = new System.Drawing.Point(40, 144);
			lblCompany.MinimumSize = new System.Drawing.Size(145, 65);
			lblCompany.Name = "lblCompany";
			lblCompany.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblCompany.Size = new System.Drawing.Size(145, 65);
			lblCompany.TabIndex = 6;
			lblCompany.Text = "Company:";
			// 
			// lblCounty
			// 
			lblCounty.AllowDrop = true;
			lblCounty.BackColor = System.Drawing.Color.White;
			lblCounty.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblCounty.Font = new System.Drawing.Font("Arial", 20.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblCounty.ForeColor = System.Drawing.SystemColors.ControlText;
			lblCounty.Location = new System.Drawing.Point(40, 520);
			lblCounty.MinimumSize = new System.Drawing.Size(217, 65);
			lblCounty.Name = "lblCounty";
			lblCounty.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblCounty.Size = new System.Drawing.Size(217, 65);
			lblCounty.TabIndex = 20;
			lblCounty.Text = "Country:";
			// 
			// lblCity
			// 
			lblCity.AllowDrop = true;
			lblCity.BackColor = System.Drawing.Color.White;
			lblCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblCity.Font = new System.Drawing.Font("Arial", 20.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblCity.ForeColor = System.Drawing.SystemColors.ControlText;
			lblCity.Location = new System.Drawing.Point(344, 432);
			lblCity.MinimumSize = new System.Drawing.Size(217, 65);
			lblCity.Name = "lblCity";
			lblCity.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblCity.Size = new System.Drawing.Size(217, 65);
			lblCity.TabIndex = 16;
			lblCity.Text = "City:";
			// 
			// lblState
			// 
			lblState.AllowDrop = true;
			lblState.BackColor = System.Drawing.Color.White;
			lblState.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblState.Font = new System.Drawing.Font("Arial", 20.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblState.ForeColor = System.Drawing.SystemColors.ControlText;
			lblState.Location = new System.Drawing.Point(40, 432);
			lblState.MinimumSize = new System.Drawing.Size(225, 81);
			lblState.Name = "lblState";
			lblState.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblState.Size = new System.Drawing.Size(225, 81);
			lblState.TabIndex = 14;
			lblState.Text = "State:";
			// 
			// lblZipCode
			// 
			lblZipCode.AllowDrop = true;
			lblZipCode.BackColor = System.Drawing.Color.White;
			lblZipCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblZipCode.Font = new System.Drawing.Font("Arial", 20.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblZipCode.ForeColor = System.Drawing.SystemColors.ControlText;
			lblZipCode.Location = new System.Drawing.Point(736, 432);
			lblZipCode.MinimumSize = new System.Drawing.Size(233, 73);
			lblZipCode.Name = "lblZipCode";
			lblZipCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblZipCode.Size = new System.Drawing.Size(233, 73);
			lblZipCode.TabIndex = 18;
			lblZipCode.Text = "Zip Code:";
			// 
			// lblStreetAdress2
			// 
			lblStreetAdress2.AllowDrop = true;
			lblStreetAdress2.BackColor = System.Drawing.Color.White;
			lblStreetAdress2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblStreetAdress2.Font = new System.Drawing.Font("Arial", 20.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblStreetAdress2.ForeColor = System.Drawing.SystemColors.ControlText;
			lblStreetAdress2.Location = new System.Drawing.Point(40, 360);
			lblStreetAdress2.MinimumSize = new System.Drawing.Size(233, 73);
			lblStreetAdress2.Name = "lblStreetAdress2";
			lblStreetAdress2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblStreetAdress2.Size = new System.Drawing.Size(233, 73);
			lblStreetAdress2.TabIndex = 12;
			lblStreetAdress2.Text = "Street Address 2:";
			// 
			// lblStreetAddress1
			// 
			lblStreetAddress1.AllowDrop = true;
			lblStreetAddress1.BackColor = System.Drawing.Color.White;
			lblStreetAddress1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblStreetAddress1.Font = new System.Drawing.Font("Arial", 20.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblStreetAddress1.ForeColor = System.Drawing.SystemColors.ControlText;
			lblStreetAddress1.Location = new System.Drawing.Point(40, 288);
			lblStreetAddress1.MinimumSize = new System.Drawing.Size(233, 57);
			lblStreetAddress1.Name = "lblStreetAddress1";
			lblStreetAddress1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblStreetAddress1.Size = new System.Drawing.Size(233, 57);
			lblStreetAddress1.TabIndex = 10;
			lblStreetAddress1.Text = "Street Address:";
			// 
			// lblPhone
			// 
			lblPhone.AllowDrop = true;
			lblPhone.BackColor = System.Drawing.Color.White;
			lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblPhone.Font = new System.Drawing.Font("Arial", 20.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblPhone.ForeColor = System.Drawing.SystemColors.ControlText;
			lblPhone.Location = new System.Drawing.Point(40, 216);
			lblPhone.MinimumSize = new System.Drawing.Size(185, 57);
			lblPhone.Name = "lblPhone";
			lblPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblPhone.Size = new System.Drawing.Size(185, 57);
			lblPhone.TabIndex = 8;
			lblPhone.Text = "Phone:";
			// 
			// lblEmail
			// 
			lblEmail.AllowDrop = true;
			lblEmail.BackColor = System.Drawing.Color.White;
			lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblEmail.Font = new System.Drawing.Font("Arial", 20.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblEmail.ForeColor = System.Drawing.SystemColors.ControlText;
			lblEmail.Location = new System.Drawing.Point(40, 80);
			lblEmail.MinimumSize = new System.Drawing.Size(185, 57);
			lblEmail.Name = "lblEmail";
			lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblEmail.Size = new System.Drawing.Size(185, 57);
			lblEmail.TabIndex = 4;
			lblEmail.Text = "Email:";
			// 
			// lblLastName
			// 
			lblLastName.AllowDrop = true;
			lblLastName.BackColor = System.Drawing.Color.White;
			lblLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblLastName.Font = new System.Drawing.Font("Arial", 20.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblLastName.ForeColor = System.Drawing.SystemColors.ControlText;
			lblLastName.Location = new System.Drawing.Point(576, 16);
			lblLastName.MinimumSize = new System.Drawing.Size(185, 57);
			lblLastName.Name = "lblLastName";
			lblLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblLastName.Size = new System.Drawing.Size(185, 57);
			lblLastName.TabIndex = 2;
			lblLastName.Text = "Last Name:";
			// 
			// lblFirstName
			// 
			lblFirstName.AllowDrop = true;
			lblFirstName.BackColor = System.Drawing.Color.White;
			lblFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblFirstName.Font = new System.Drawing.Font("Arial", 20.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblFirstName.ForeColor = System.Drawing.SystemColors.ControlText;
			lblFirstName.Location = new System.Drawing.Point(40, 16);
			lblFirstName.MinimumSize = new System.Drawing.Size(201, 49);
			lblFirstName.Name = "lblFirstName";
			lblFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblFirstName.Size = new System.Drawing.Size(201, 49);
			lblFirstName.TabIndex = 0;
			lblFirstName.Text = "First Name:";
			// 
			// frmCustAdd
			// 
			AllowDrop = true;
			AutoScaleDimensions = new System.Drawing.SizeF(16, 31);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.White;
			ClientSize = new System.Drawing.Size(1264, 693);
			Controls.Add(cbClose);
			Controls.Add(cbSave);
			Controls.Add(txtPhone);
			Controls.Add(txtCounty);
			Controls.Add(txtZipCode);
			Controls.Add(txtState);
			Controls.Add(txtCity);
			Controls.Add(txtStreetAddress2);
			Controls.Add(txtStreetAddress1);
			Controls.Add(txtCompany);
			Controls.Add(txtEmail);
			Controls.Add(txtLastName);
			Controls.Add(txtFirstName);
			Controls.Add(lblCompany);
			Controls.Add(lblCounty);
			Controls.Add(lblCity);
			Controls.Add(lblState);
			Controls.Add(lblZipCode);
			Controls.Add(lblStreetAdress2);
			Controls.Add(lblStreetAddress1);
			Controls.Add(lblPhone);
			Controls.Add(lblEmail);
			Controls.Add(lblLastName);
			Controls.Add(lblFirstName);
			Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Location = new System.Drawing.Point(4, 27);
			MaximizeBox = true;
			MinimizeBox = true;
			Name = "frmCustAdd";
			RightToLeft = System.Windows.Forms.RightToLeft.No;
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Register New Customer";
			commandButtonHelper1.SetStyle(cbClose, 1);
			commandButtonHelper1.SetStyle(cbSave, 1);
			Activated += new System.EventHandler(frmCustAdd_Activated);
			Closed += new System.EventHandler(Form_Closed);
			ResumeLayout(false);
		}
		#endregion
	}
}