
namespace TailwindPOS
{
	partial class frmCashCount
	{

		#region "Upgrade Support "
		private static frmCashCount m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmCashCount DefInstance
		{
			get
			{
				if (m_vb6FormDefInstance is null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = new frmCashCount();
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
		private string[] visualControls = new string[]{"components", "ToolTipMain", "txtHalfDollars", "txtPennies", "txtNickels", "txtDimes", "txtQuarters", "txtOnes", "txtFives", "txtTens", "txtHundreds", "txtTwenties", "txtFifties", "cbOK", "cbClear", "ucNumbers", "lblMessage", "lblPennies", "lblNickels", "lblDimes", "lblQuarters", "lblHalfDollars", "lblOnes", "lblFives", "lblTens", "lblTwenties", "lblFifties", "lblHundreds", "lblTotalTitle", "lblTotal", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.TextBox txtHalfDollars;
		public System.Windows.Forms.TextBox txtPennies;
		public System.Windows.Forms.TextBox txtNickels;
		public System.Windows.Forms.TextBox txtDimes;
		public System.Windows.Forms.TextBox txtQuarters;
		public System.Windows.Forms.TextBox txtOnes;
		public System.Windows.Forms.TextBox txtFives;
		public System.Windows.Forms.TextBox txtTens;
		public System.Windows.Forms.TextBox txtHundreds;
		public System.Windows.Forms.TextBox txtTwenties;
		public System.Windows.Forms.TextBox txtFifties;
		public System.Windows.Forms.Button cbOK;
		public System.Windows.Forms.Button cbClear;
		public ucNumbersPad ucNumbers;
		public System.Windows.Forms.Label lblMessage;
		public System.Windows.Forms.Label lblPennies;
		public System.Windows.Forms.Label lblNickels;
		public System.Windows.Forms.Label lblDimes;
		public System.Windows.Forms.Label lblQuarters;
		public System.Windows.Forms.Label lblHalfDollars;
		public System.Windows.Forms.Label lblOnes;
		public System.Windows.Forms.Label lblFives;
		public System.Windows.Forms.Label lblTens;
		public System.Windows.Forms.Label lblTwenties;
		public System.Windows.Forms.Label lblFifties;
		public System.Windows.Forms.Label lblHundreds;
		public System.Windows.Forms.Label lblTotalTitle;
		public System.Windows.Forms.Label lblTotal;
		public UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCashCount));
			ToolTipMain = new System.Windows.Forms.ToolTip(components);
			txtHalfDollars = new System.Windows.Forms.TextBox();
			txtPennies = new System.Windows.Forms.TextBox();
			txtNickels = new System.Windows.Forms.TextBox();
			txtDimes = new System.Windows.Forms.TextBox();
			txtQuarters = new System.Windows.Forms.TextBox();
			txtOnes = new System.Windows.Forms.TextBox();
			txtFives = new System.Windows.Forms.TextBox();
			txtTens = new System.Windows.Forms.TextBox();
			txtHundreds = new System.Windows.Forms.TextBox();
			txtTwenties = new System.Windows.Forms.TextBox();
			txtFifties = new System.Windows.Forms.TextBox();
			cbOK = new System.Windows.Forms.Button();
			cbClear = new System.Windows.Forms.Button();
			ucNumbers = new ucNumbersPad();
			lblMessage = new System.Windows.Forms.Label();
			lblPennies = new System.Windows.Forms.Label();
			lblNickels = new System.Windows.Forms.Label();
			lblDimes = new System.Windows.Forms.Label();
			lblQuarters = new System.Windows.Forms.Label();
			lblHalfDollars = new System.Windows.Forms.Label();
			lblOnes = new System.Windows.Forms.Label();
			lblFives = new System.Windows.Forms.Label();
			lblTens = new System.Windows.Forms.Label();
			lblTwenties = new System.Windows.Forms.Label();
			lblFifties = new System.Windows.Forms.Label();
			lblHundreds = new System.Windows.Forms.Label();
			lblTotalTitle = new System.Windows.Forms.Label();
			lblTotal = new System.Windows.Forms.Label();
			SuspendLayout();
			commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
			// 
			// txtHalfDollars
			// 
			txtHalfDollars.AcceptsReturn = true;
			txtHalfDollars.AllowDrop = true;
			txtHalfDollars.BackColor = System.Drawing.Color.White;
			txtHalfDollars.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtHalfDollars.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtHalfDollars.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtHalfDollars.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			txtHalfDollars.Location = new System.Drawing.Point(160, 296);
			txtHalfDollars.MaxLength = 0;
			txtHalfDollars.Name = "txtHalfDollars";
			txtHalfDollars.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtHalfDollars.Size = new System.Drawing.Size(113, 49);
			txtHalfDollars.TabIndex = 12;
			txtHalfDollars.Text = "0";
			txtHalfDollars.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			txtHalfDollars.Enter += new System.EventHandler(txtHalfDollars_Enter);
			txtHalfDollars.Leave += new System.EventHandler(txtHalfDollars_Leave);
			// 
			// txtPennies
			// 
			txtPennies.AcceptsReturn = true;
			txtPennies.AllowDrop = true;
			txtPennies.BackColor = System.Drawing.Color.White;
			txtPennies.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtPennies.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtPennies.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtPennies.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			txtPennies.Location = new System.Drawing.Point(160, 72);
			txtPennies.MaxLength = 0;
			txtPennies.Name = "txtPennies";
			txtPennies.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtPennies.Size = new System.Drawing.Size(113, 49);
			txtPennies.TabIndex = 11;
			txtPennies.Text = "0";
			txtPennies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			txtPennies.Enter += new System.EventHandler(txtPennies_Enter);
			txtPennies.Leave += new System.EventHandler(txtPennies_Leave);
			// 
			// txtNickels
			// 
			txtNickels.AcceptsReturn = true;
			txtNickels.AllowDrop = true;
			txtNickels.BackColor = System.Drawing.Color.White;
			txtNickels.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtNickels.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtNickels.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtNickels.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			txtNickels.Location = new System.Drawing.Point(160, 128);
			txtNickels.MaxLength = 0;
			txtNickels.Name = "txtNickels";
			txtNickels.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtNickels.Size = new System.Drawing.Size(113, 49);
			txtNickels.TabIndex = 10;
			txtNickels.Text = "0";
			txtNickels.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			txtNickels.Enter += new System.EventHandler(txtNickels_Enter);
			txtNickels.Leave += new System.EventHandler(txtNickels_Leave);
			// 
			// txtDimes
			// 
			txtDimes.AcceptsReturn = true;
			txtDimes.AllowDrop = true;
			txtDimes.BackColor = System.Drawing.Color.White;
			txtDimes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtDimes.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtDimes.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtDimes.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			txtDimes.Location = new System.Drawing.Point(160, 184);
			txtDimes.MaxLength = 0;
			txtDimes.Name = "txtDimes";
			txtDimes.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtDimes.Size = new System.Drawing.Size(113, 49);
			txtDimes.TabIndex = 9;
			txtDimes.Text = "0";
			txtDimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			txtDimes.Enter += new System.EventHandler(txtDimes_Enter);
			txtDimes.Leave += new System.EventHandler(txtDimes_Leave);
			// 
			// txtQuarters
			// 
			txtQuarters.AcceptsReturn = true;
			txtQuarters.AllowDrop = true;
			txtQuarters.BackColor = System.Drawing.Color.White;
			txtQuarters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtQuarters.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtQuarters.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtQuarters.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			txtQuarters.Location = new System.Drawing.Point(160, 240);
			txtQuarters.MaxLength = 0;
			txtQuarters.Name = "txtQuarters";
			txtQuarters.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtQuarters.Size = new System.Drawing.Size(113, 49);
			txtQuarters.TabIndex = 8;
			txtQuarters.Text = "0";
			txtQuarters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			txtQuarters.Enter += new System.EventHandler(txtQuarters_Enter);
			txtQuarters.Leave += new System.EventHandler(txtQuarters_Leave);
			// 
			// txtOnes
			// 
			txtOnes.AcceptsReturn = true;
			txtOnes.AllowDrop = true;
			txtOnes.BackColor = System.Drawing.Color.White;
			txtOnes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtOnes.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtOnes.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtOnes.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			txtOnes.Location = new System.Drawing.Point(416, 72);
			txtOnes.MaxLength = 0;
			txtOnes.Name = "txtOnes";
			txtOnes.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtOnes.Size = new System.Drawing.Size(113, 49);
			txtOnes.TabIndex = 7;
			txtOnes.Text = "0";
			txtOnes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			txtOnes.Enter += new System.EventHandler(txtOnes_Enter);
			txtOnes.Leave += new System.EventHandler(txtOnes_Leave);
			// 
			// txtFives
			// 
			txtFives.AcceptsReturn = true;
			txtFives.AllowDrop = true;
			txtFives.BackColor = System.Drawing.Color.White;
			txtFives.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtFives.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtFives.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtFives.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			txtFives.Location = new System.Drawing.Point(416, 128);
			txtFives.MaxLength = 0;
			txtFives.Name = "txtFives";
			txtFives.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtFives.Size = new System.Drawing.Size(113, 49);
			txtFives.TabIndex = 6;
			txtFives.Text = "0";
			txtFives.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			txtFives.Enter += new System.EventHandler(txtFives_Enter);
			txtFives.Leave += new System.EventHandler(txtFives_Leave);
			// 
			// txtTens
			// 
			txtTens.AcceptsReturn = true;
			txtTens.AllowDrop = true;
			txtTens.BackColor = System.Drawing.Color.White;
			txtTens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtTens.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtTens.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtTens.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			txtTens.Location = new System.Drawing.Point(416, 184);
			txtTens.MaxLength = 0;
			txtTens.Name = "txtTens";
			txtTens.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtTens.Size = new System.Drawing.Size(113, 49);
			txtTens.TabIndex = 5;
			txtTens.Text = "0";
			txtTens.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			txtTens.Enter += new System.EventHandler(txtTens_Enter);
			txtTens.Leave += new System.EventHandler(txtTens_Leave);
			// 
			// txtHundreds
			// 
			txtHundreds.AcceptsReturn = true;
			txtHundreds.AllowDrop = true;
			txtHundreds.BackColor = System.Drawing.Color.White;
			txtHundreds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtHundreds.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtHundreds.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtHundreds.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			txtHundreds.Location = new System.Drawing.Point(416, 352);
			txtHundreds.MaxLength = 0;
			txtHundreds.Name = "txtHundreds";
			txtHundreds.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtHundreds.Size = new System.Drawing.Size(113, 49);
			txtHundreds.TabIndex = 4;
			txtHundreds.Text = "0";
			txtHundreds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			txtHundreds.Enter += new System.EventHandler(txtHundreds_Enter);
			txtHundreds.Leave += new System.EventHandler(txtHundreds_Leave);
			// 
			// txtTwenties
			// 
			txtTwenties.AcceptsReturn = true;
			txtTwenties.AllowDrop = true;
			txtTwenties.BackColor = System.Drawing.Color.White;
			txtTwenties.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtTwenties.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtTwenties.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtTwenties.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			txtTwenties.Location = new System.Drawing.Point(416, 240);
			txtTwenties.MaxLength = 0;
			txtTwenties.Name = "txtTwenties";
			txtTwenties.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtTwenties.Size = new System.Drawing.Size(113, 49);
			txtTwenties.TabIndex = 3;
			txtTwenties.Text = "0";
			txtTwenties.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			txtTwenties.Enter += new System.EventHandler(txtTwenties_Enter);
			txtTwenties.Leave += new System.EventHandler(txtTwenties_Leave);
			// 
			// txtFifties
			// 
			txtFifties.AcceptsReturn = true;
			txtFifties.AllowDrop = true;
			txtFifties.BackColor = System.Drawing.Color.White;
			txtFifties.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtFifties.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtFifties.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtFifties.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			txtFifties.Location = new System.Drawing.Point(416, 296);
			txtFifties.MaxLength = 0;
			txtFifties.Name = "txtFifties";
			txtFifties.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtFifties.Size = new System.Drawing.Size(113, 49);
			txtFifties.TabIndex = 2;
			txtFifties.Text = "0";
			txtFifties.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			txtFifties.Enter += new System.EventHandler(txtFifties_Enter);
			txtFifties.Leave += new System.EventHandler(txtFifties_Leave);
			// 
			// cbOK
			// 
			cbOK.AllowDrop = true;
			cbOK.BackColor = System.Drawing.Color.FromArgb(97, 44, 67);
			cbOK.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbOK.ForeColor = System.Drawing.SystemColors.ControlText;
			cbOK.Location = new System.Drawing.Point(568, 136);
			cbOK.Name = "cbOK";
			cbOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cbOK.Size = new System.Drawing.Size(409, 57);
			cbOK.TabIndex = 1;
			cbOK.Text = "OK";
			cbOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cbOK.UseVisualStyleBackColor = false;
			cbOK.Click += new System.EventHandler(cbOK_Click);
			// 
			// cbClear
			// 
			cbClear.AllowDrop = true;
			cbClear.BackColor = System.Drawing.Color.White;
			cbClear.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbClear.ForeColor = System.Drawing.SystemColors.ControlText;
			cbClear.Location = new System.Drawing.Point(568, 72);
			cbClear.Name = "cbClear";
			cbClear.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cbClear.Size = new System.Drawing.Size(409, 57);
			cbClear.TabIndex = 0;
			cbClear.Text = "Clear";
			cbClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cbClear.UseVisualStyleBackColor = false;
			cbClear.Click += new System.EventHandler(cbClear_Click);
			// 
			// ucNumbers
			// 
			ucNumbers.AllowDrop = true;
			ucNumbers.Location = new System.Drawing.Point(568, 200);
			ucNumbers.Name = "ucNumbers";
			ucNumbers.Size = new System.Drawing.Size(377, 425);
			ucNumbers.TabIndex = 13;
			ucNumbers.OnBack += new ucNumbersPad.OnBackHandler(ucNumbers_OnBack);
			ucNumbers.OnNumber += new ucNumbersPad.OnNumberHandler(ucNumbers_OnNumber);
			// 
			// lblMessage
			// 
			lblMessage.AllowDrop = true;
			lblMessage.BackColor = System.Drawing.Color.White;
			lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblMessage.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblMessage.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			lblMessage.Location = new System.Drawing.Point(8, 8);
			lblMessage.MinimumSize = new System.Drawing.Size(297, 49);
			lblMessage.Name = "lblMessage";
			lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblMessage.Size = new System.Drawing.Size(297, 49);
			lblMessage.TabIndex = 27;
			lblMessage.Text = "Enter Cash Amount";
			// 
			// lblPennies
			// 
			lblPennies.AllowDrop = true;
			lblPennies.BackColor = System.Drawing.Color.White;
			lblPennies.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblPennies.Font = new System.Drawing.Font("Arial", 20.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblPennies.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			lblPennies.Location = new System.Drawing.Point(8, 72);
			lblPennies.MinimumSize = new System.Drawing.Size(145, 49);
			lblPennies.Name = "lblPennies";
			lblPennies.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblPennies.Size = new System.Drawing.Size(145, 49);
			lblPennies.TabIndex = 26;
			lblPennies.Text = "Pennies";
			// 
			// lblNickels
			// 
			lblNickels.AllowDrop = true;
			lblNickels.BackColor = System.Drawing.Color.White;
			lblNickels.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblNickels.Font = new System.Drawing.Font("Arial", 20.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblNickels.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			lblNickels.Location = new System.Drawing.Point(8, 128);
			lblNickels.MinimumSize = new System.Drawing.Size(145, 49);
			lblNickels.Name = "lblNickels";
			lblNickels.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblNickels.Size = new System.Drawing.Size(145, 49);
			lblNickels.TabIndex = 25;
			lblNickels.Text = "Nickels";
			// 
			// lblDimes
			// 
			lblDimes.AllowDrop = true;
			lblDimes.BackColor = System.Drawing.Color.White;
			lblDimes.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblDimes.Font = new System.Drawing.Font("Arial", 20.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblDimes.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			lblDimes.Location = new System.Drawing.Point(8, 184);
			lblDimes.MinimumSize = new System.Drawing.Size(145, 49);
			lblDimes.Name = "lblDimes";
			lblDimes.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblDimes.Size = new System.Drawing.Size(145, 49);
			lblDimes.TabIndex = 24;
			lblDimes.Text = "Dimes";
			// 
			// lblQuarters
			// 
			lblQuarters.AllowDrop = true;
			lblQuarters.BackColor = System.Drawing.Color.White;
			lblQuarters.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblQuarters.Font = new System.Drawing.Font("Arial", 20.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblQuarters.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			lblQuarters.Location = new System.Drawing.Point(8, 240);
			lblQuarters.MinimumSize = new System.Drawing.Size(145, 49);
			lblQuarters.Name = "lblQuarters";
			lblQuarters.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblQuarters.Size = new System.Drawing.Size(145, 49);
			lblQuarters.TabIndex = 23;
			lblQuarters.Text = "Quarters";
			// 
			// lblHalfDollars
			// 
			lblHalfDollars.AllowDrop = true;
			lblHalfDollars.BackColor = System.Drawing.Color.White;
			lblHalfDollars.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblHalfDollars.Font = new System.Drawing.Font("Arial", 20.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblHalfDollars.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			lblHalfDollars.Location = new System.Drawing.Point(8, 304);
			lblHalfDollars.MinimumSize = new System.Drawing.Size(145, 65);
			lblHalfDollars.Name = "lblHalfDollars";
			lblHalfDollars.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblHalfDollars.Size = new System.Drawing.Size(145, 65);
			lblHalfDollars.TabIndex = 22;
			lblHalfDollars.Text = "Half Dollars";
			// 
			// lblOnes
			// 
			lblOnes.AllowDrop = true;
			lblOnes.BackColor = System.Drawing.Color.White;
			lblOnes.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblOnes.Font = new System.Drawing.Font("Arial", 20.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblOnes.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			lblOnes.Location = new System.Drawing.Point(296, 72);
			lblOnes.MinimumSize = new System.Drawing.Size(185, 41);
			lblOnes.Name = "lblOnes";
			lblOnes.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblOnes.Size = new System.Drawing.Size(185, 41);
			lblOnes.TabIndex = 21;
			lblOnes.Text = "Ones";
			// 
			// lblFives
			// 
			lblFives.AllowDrop = true;
			lblFives.BackColor = System.Drawing.Color.White;
			lblFives.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblFives.Font = new System.Drawing.Font("Arial", 20.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblFives.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			lblFives.Location = new System.Drawing.Point(296, 128);
			lblFives.MinimumSize = new System.Drawing.Size(185, 41);
			lblFives.Name = "lblFives";
			lblFives.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblFives.Size = new System.Drawing.Size(185, 41);
			lblFives.TabIndex = 20;
			lblFives.Text = "Fives";
			// 
			// lblTens
			// 
			lblTens.AllowDrop = true;
			lblTens.BackColor = System.Drawing.Color.White;
			lblTens.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblTens.Font = new System.Drawing.Font("Arial", 20.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblTens.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			lblTens.Location = new System.Drawing.Point(296, 184);
			lblTens.MinimumSize = new System.Drawing.Size(185, 41);
			lblTens.Name = "lblTens";
			lblTens.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblTens.Size = new System.Drawing.Size(185, 41);
			lblTens.TabIndex = 19;
			lblTens.Text = "Tens";
			// 
			// lblTwenties
			// 
			lblTwenties.AllowDrop = true;
			lblTwenties.BackColor = System.Drawing.Color.White;
			lblTwenties.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblTwenties.Font = new System.Drawing.Font("Arial", 20.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblTwenties.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			lblTwenties.Location = new System.Drawing.Point(296, 240);
			lblTwenties.MinimumSize = new System.Drawing.Size(185, 41);
			lblTwenties.Name = "lblTwenties";
			lblTwenties.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblTwenties.Size = new System.Drawing.Size(185, 41);
			lblTwenties.TabIndex = 18;
			lblTwenties.Text = "Twenties";
			// 
			// lblFifties
			// 
			lblFifties.AllowDrop = true;
			lblFifties.BackColor = System.Drawing.Color.White;
			lblFifties.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblFifties.Font = new System.Drawing.Font("Arial", 20.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblFifties.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			lblFifties.Location = new System.Drawing.Point(296, 288);
			lblFifties.MinimumSize = new System.Drawing.Size(185, 41);
			lblFifties.Name = "lblFifties";
			lblFifties.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblFifties.Size = new System.Drawing.Size(185, 41);
			lblFifties.TabIndex = 17;
			lblFifties.Text = "Fifties";
			// 
			// lblHundreds
			// 
			lblHundreds.AllowDrop = true;
			lblHundreds.BackColor = System.Drawing.Color.White;
			lblHundreds.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblHundreds.Font = new System.Drawing.Font("Arial", 20.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblHundreds.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			lblHundreds.Location = new System.Drawing.Point(296, 344);
			lblHundreds.MinimumSize = new System.Drawing.Size(185, 41);
			lblHundreds.Name = "lblHundreds";
			lblHundreds.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblHundreds.Size = new System.Drawing.Size(185, 41);
			lblHundreds.TabIndex = 16;
			lblHundreds.Text = "Hundreds";
			// 
			// lblTotalTitle
			// 
			lblTotalTitle.AllowDrop = true;
			lblTotalTitle.BackColor = System.Drawing.Color.White;
			lblTotalTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblTotalTitle.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblTotalTitle.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			lblTotalTitle.Location = new System.Drawing.Point(568, 8);
			lblTotalTitle.MinimumSize = new System.Drawing.Size(113, 57);
			lblTotalTitle.Name = "lblTotalTitle";
			lblTotalTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblTotalTitle.Size = new System.Drawing.Size(113, 57);
			lblTotalTitle.TabIndex = 15;
			lblTotalTitle.Text = "Total";
			// 
			// lblTotal
			// 
			lblTotal.AllowDrop = true;
			lblTotal.BackColor = System.Drawing.Color.White;
			lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblTotal.Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblTotal.ForeColor = System.Drawing.Color.FromArgb(47, 75, 102);
			lblTotal.Location = new System.Drawing.Point(728, 8);
			lblTotal.MinimumSize = new System.Drawing.Size(249, 65);
			lblTotal.Name = "lblTotal";
			lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblTotal.Size = new System.Drawing.Size(249, 65);
			lblTotal.TabIndex = 14;
			lblTotal.Text = "$0";
			lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// frmCashCount
			// 
			AllowDrop = true;
			AutoScaleDimensions = new System.Drawing.SizeF(16, 31);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.White;
			ClientSize = new System.Drawing.Size(1038, 640);
			ControlBox = false;
			Controls.Add(txtHalfDollars);
			Controls.Add(txtPennies);
			Controls.Add(txtNickels);
			Controls.Add(txtDimes);
			Controls.Add(txtQuarters);
			Controls.Add(txtOnes);
			Controls.Add(txtFives);
			Controls.Add(txtTens);
			Controls.Add(txtHundreds);
			Controls.Add(txtTwenties);
			Controls.Add(txtFifties);
			Controls.Add(cbOK);
			Controls.Add(cbClear);
			Controls.Add(ucNumbers);
			Controls.Add(lblMessage);
			Controls.Add(lblPennies);
			Controls.Add(lblNickels);
			Controls.Add(lblDimes);
			Controls.Add(lblQuarters);
			Controls.Add(lblHalfDollars);
			Controls.Add(lblOnes);
			Controls.Add(lblFives);
			Controls.Add(lblTens);
			Controls.Add(lblTwenties);
			Controls.Add(lblFifties);
			Controls.Add(lblHundreds);
			Controls.Add(lblTotalTitle);
			Controls.Add(lblTotal);
			Font = new System.Drawing.Font("Arial", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Location = new System.Drawing.Point(4, 27);
			MaximizeBox = true;
			MinimizeBox = true;
			Name = "frmCashCount";
			RightToLeft = System.Windows.Forms.RightToLeft.No;
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Count Cash Drawer";
			commandButtonHelper1.SetStyle(cbOK, 1);
			commandButtonHelper1.SetStyle(cbClear, 1);
			Activated += new System.EventHandler(frmCashCount_Activated);
			Closed += new System.EventHandler(Form_Closed);
			Load += new System.EventHandler(Form_Load);
			ResumeLayout(false);
		}
		#endregion
	}
}