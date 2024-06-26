using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace TailwindPOS
{
	internal partial class frmCashCount
		: System.Windows.Forms.Form
	{

		public frmCashCount()
			: base()
		{
			if (m_vb6FormDefInstance is null)
			{
				if (m_InitializingDefInstance)
				{
					m_vb6FormDefInstance = this;
				}
				else
				{
					try
					{
						//For the start-up form, the first instance created is the default instance.
						if (!(System.Reflection.Assembly.GetExecutingAssembly().EntryPoint is null) && System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == this.GetType())
						{
							m_vb6FormDefInstance = this;
						}
					}
					catch
					{
					}
				}
			}
			//This call is required by the Windows Form Designer.
			InitializeComponent();
		}


		private void frmCashCount_Activated(System.Object eventSender, System.EventArgs eventArgs)
		{
			if (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm != eventSender)
			{
				UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = (System.Windows.Forms.Form) eventSender;
			}
		}
		TextBox m_LastTextBox = null;
		decimal m_total = 0;

		public decimal Total => m_total;


		private void cbClear_Click(Object eventSender, EventArgs eventArgs)
		{
			ucNumbers.Value = "0";
			txtPennies.Text = "0";
			txtNickels.Text = "0";
			txtDimes.Text = "0";
			txtQuarters.Text = "0";
			txtHalfDollars.Text = "0";

			txtOnes.Text = "0";
			txtFifties.Text = "0";
			txtFives.Text = "0";
			txtTens.Text = "0";

			txtTwenties.Text = "0";
			txtFifties.Text = "0";
			txtHundreds.Text = "0";
			UpdateTotals();
		}

		private void cbOK_Click(Object eventSender, EventArgs eventArgs)
		{
			m_total = Decimal.Parse(lblTotal.Text, NumberStyles.Currency | NumberStyles.AllowExponent);
			this.Hide();
		}

		private void ClearHighlight()
		{
			txtPennies.BackColor = SystemColors.Window;
			txtNickels.BackColor = SystemColors.Window;
			txtDimes.BackColor = SystemColors.Window;
			txtQuarters.BackColor = SystemColors.Window;
			txtHalfDollars.BackColor = SystemColors.Window;

			txtOnes.BackColor = SystemColors.Window;
			txtFifties.BackColor = SystemColors.Window;
			txtFives.BackColor = SystemColors.Window;
			txtTens.BackColor = SystemColors.Window;

			txtTwenties.BackColor = SystemColors.Window;
			txtFifties.BackColor = SystemColors.Window;
			txtHundreds.BackColor = SystemColors.Window;
		}

		//UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load event and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
		private void Form_Load(Object eventSender, EventArgs eventArgs) => ucNumbers.ShowValue = false;


		private void Highlight(TextBox X)
		{
			ClearHighlight();
			X.BackColor = Color.Yellow;
			m_LastTextBox = X;
		}

		private void txtDimes_Enter(Object eventSender, EventArgs eventArgs) => Highlight(txtDimes);


		private void txtDimes_Leave(Object eventSender, EventArgs eventArgs) => ExitTextBox(txtDimes);


		private void txtFifties_Enter(Object eventSender, EventArgs eventArgs) => Highlight(txtFifties);


		private void txtFifties_Leave(Object eventSender, EventArgs eventArgs) => ExitTextBox(txtFifties);


		private void txtFives_Enter(Object eventSender, EventArgs eventArgs) => Highlight(txtFives);


		private void txtFives_Leave(Object eventSender, EventArgs eventArgs) => ExitTextBox(txtFives);


		private void txtHalfDollars_Enter(Object eventSender, EventArgs eventArgs) => Highlight(txtHalfDollars);


		private void txtHalfDollars_Leave(Object eventSender, EventArgs eventArgs) => ExitTextBox(txtHalfDollars);


		private void txtHundreds_Enter(Object eventSender, EventArgs eventArgs) => Highlight(txtHundreds);


		private void txtHundreds_Leave(Object eventSender, EventArgs eventArgs) => ExitTextBox(txtHundreds);


		private void txtNickels_Enter(Object eventSender, EventArgs eventArgs) => Highlight(txtNickels);


		private void txtNickels_Leave(Object eventSender, EventArgs eventArgs) => ExitTextBox(txtNickels);


		private void txtOnes_Enter(Object eventSender, EventArgs eventArgs) => Highlight(txtOnes);


		private void txtOnes_Leave(Object eventSender, EventArgs eventArgs) => ExitTextBox(txtOnes);


		private void txtPennies_Enter(Object eventSender, EventArgs eventArgs) => Highlight(txtPennies);


		private void txtPennies_Leave(Object eventSender, EventArgs eventArgs) => ExitTextBox(txtPennies);


		private void txtQuarters_Enter(Object eventSender, EventArgs eventArgs) => Highlight(txtQuarters);


		private void txtQuarters_Leave(Object eventSender, EventArgs eventArgs) => ExitTextBox(txtQuarters);


		private void txtTens_Enter(Object eventSender, EventArgs eventArgs) => Highlight(txtTens);


		private void txtTens_Leave(Object eventSender, EventArgs eventArgs) => ExitTextBox(txtTens);


		private void txtTwenties_Enter(Object eventSender, EventArgs eventArgs) => Highlight(txtTwenties);


		private void txtTwenties_Leave(Object eventSender, EventArgs eventArgs) => Highlight(txtTwenties);


		private void ucNumbers_OnBack(Object Sender, EventArgs eventArgs)
		{
			string val = "";
			if (m_LastTextBox != null)
			{
				val = m_LastTextBox.Text.Trim();
				if (val == "0")
				{
					m_LastTextBox.Text = "0";
				}
				else
				{
					m_LastTextBox.Text = m_LastTextBox.Text.Substring(0, Math.Min(Strings.Len(m_LastTextBox.Text) - 1, m_LastTextBox.Text.Length));
				}
			}
			UpdateTotals();
		}

		private void ucNumbers_OnNumber(Object Sender, ucNumbersPad.OnNumberEventArgs eventArgs)
		{
			string Number = eventArgs.Number;
			string val = "";
			if (m_LastTextBox != null)
			{
				val = m_LastTextBox.Text.Trim();
				if (val == "0")
				{
					m_LastTextBox.Text = Number;
				}
				else if (val == "00" && m_LastTextBox.Text == "")
				{ 
					m_LastTextBox.Text = "0";
				}
				else if (val == "")
				{ 
					m_LastTextBox.Text = "0";
				}
				else if (val == ".")
				{ 
					//Ignore
				}
				else
				{
					m_LastTextBox.Text = $"{m_LastTextBox.Text}{Number}";
				}
			}
			UpdateTotals();
		}

		public void ExitTextBox(TextBox txt)
		{
			string contents = txt.Text;
			int newValue = 0;
			try
			{
				newValue = Convert.ToInt32(Double.Parse(contents));
				txt.Text = newValue.ToString();
				UpdateTotals();
			}
			catch
			{
				txt.Text = "0";
				UpdateTotals();
			}
		}

		public void UpdateTotals()
		{
			decimal Total = 0;
			Total += ((decimal) (Double.Parse(txtPennies.Text) * 0.01d));
			Total += ((decimal) (Double.Parse(txtNickels.Text) * 0.05d));
			Total += ((decimal) (Double.Parse(txtDimes.Text) * 0.1d));
			Total += ((decimal) (Double.Parse(txtQuarters.Text) * 0.25d));
			Total += ((decimal) (Double.Parse(txtHalfDollars.Text) * 0.5d));
			Total += Decimal.Parse(txtOnes.Text, NumberStyles.Currency | NumberStyles.AllowExponent) * 1;
			Total += Decimal.Parse(txtFives.Text, NumberStyles.Currency | NumberStyles.AllowExponent) * 5;
			Total += Decimal.Parse(txtTens.Text, NumberStyles.Currency | NumberStyles.AllowExponent) * 10;
			Total += Decimal.Parse(txtTwenties.Text, NumberStyles.Currency | NumberStyles.AllowExponent) * 20;
			Total += Decimal.Parse(txtFifties.Text, NumberStyles.Currency | NumberStyles.AllowExponent) * 50;
			Total += Decimal.Parse(txtHundreds.Text, NumberStyles.Currency | NumberStyles.AllowExponent) * 100;

			lblTotal.Text = Total.ToString();
		}
		private void Form_Closed(Object eventSender, EventArgs eventArgs)
		{
		}
	}
}