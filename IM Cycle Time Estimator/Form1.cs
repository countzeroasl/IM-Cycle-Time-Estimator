using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IM_Cycle_Time_Estimator
{
    public partial class Form1 : Form
    {
        public

        double mWall, mThermalDiff = .64;
        double mMoldTemp, mInjectTemp, mEjectTemp, mCycleTime, mTempCycleTime;
        bool mFocused;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                radioButton2.Checked = false;
                radioButton1.Checked = true;
				label7.Visible = false;
				maskedTextBox5.Visible = false;
				mCycleTime = 0.0;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
				label7.Visible = false;
				maskedTextBox5.Visible = false;
				mCycleTime = 0.000;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
			if (mWall == 0.000)
			{
				MessageBox.Show("You must enter a Maximum Wall Thickness.", "Required Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				maskedTextBox1.Focus();
			}
			
			else
				if (mInjectTemp == 0.0)
				{
					MessageBox.Show("You must enter an Injection (Melt) Temperature.", "Required Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					maskedTextBox2.Focus();
				}

				else
					if (mMoldTemp == 0.0)
					{
						MessageBox.Show("You must enter an Mold Temperature.", "Required Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						maskedTextBox3.Focus();
					}

					else
						if (mEjectTemp == 0.0)
						{
							MessageBox.Show("You must enter an Ejection Temperature.", "Required Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							maskedTextBox4.Focus();
						}

						else
							if (mMoldTemp > mInjectTemp)
							{
								MessageBox.Show("Mold Temperature must be less than Melt Temperature.", "Sign Change Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
								maskedTextBox2.Focus();
							}

							else
								if (mMoldTemp > mEjectTemp)
								{
									MessageBox.Show("Mold Temperature must be less than Ejection Temperature.", "Sign Change Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
									maskedTextBox3.Focus();
								}

								else
								{

									label7.Enabled = true;
									label7.Visible = true;
									maskedTextBox5.Enabled = true;
									maskedTextBox5.Visible = true;
									mTempCycleTime = 0.0;

									//If Radio Button 1 is checked use the Centerline cooling calculation, else use the Average cooling calculation

									if (radioButton1.Checked == true)
										mTempCycleTime = ((mWall * mWall * 3600) / (mThermalDiff * 3.14159 * 3.14159)) * Math.Log((4 / 3.14159) * ((mInjectTemp - mMoldTemp) / (mEjectTemp - mMoldTemp)));
									else
										mTempCycleTime = ((mWall * mWall * 3600) / (mThermalDiff * 3.14159 * 3.14159)) * Math.Log((8 / (3.14159 * 3.14159)) * ((mInjectTemp - mMoldTemp) / (mEjectTemp - mMoldTemp)));

									if (checkBox1.Checked == true)
										mCycleTime = (mTempCycleTime * 1.5) + 30;
									else
										mCycleTime = mTempCycleTime * 1.5;

									mCycleTime = Math.Round(mCycleTime, 1);

									maskedTextBox5.Text = mCycleTime.ToString();
								}
        }


        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
			try
			{
				mWall = System.Convert.ToDouble(maskedTextBox1.Text);
			}
			catch (FormatException ex)
			{
				MessageBox.Show("Please enter an input of the format 0.000");
				maskedTextBox1.SelectAll();
			}
			finally
			{
				label7.Visible = false;
				maskedTextBox5.Visible = false;
				mCycleTime = 0.0;
			}
        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
			try
			{
				mInjectTemp = System.Convert.ToDouble(maskedTextBox2.Text);
			}
			catch (FormatException ex)
			{
				MessageBox.Show("Please enter an integer temperature value");
				maskedTextBox2.SelectAll();
			}
			finally
			{
				label7.Visible = false;
				maskedTextBox5.Visible = false;
				mCycleTime = 0.0;
			}
        }

        private void maskedTextBox3_TextChanged(object sender, EventArgs e)
        {
			try
			{
				mMoldTemp = System.Convert.ToDouble(maskedTextBox3.Text);
			}
			catch
			{
				MessageBox.Show("Please enter an integer temperature value");
				maskedTextBox3.SelectAll();
			}
			finally
			{
				label7.Visible = false;
				maskedTextBox5.Visible = false;
				mCycleTime = 0.0;
			}
        }

        private void maskedTextBox4_TextChanged(object sender, EventArgs e)
        {
			try
			{
				mEjectTemp = System.Convert.ToDouble(maskedTextBox4.Text);
			}
			catch
			{
				MessageBox.Show("Please enter an integer temperature value");
				maskedTextBox4.SelectAll();
			}
			finally
			{
				label7.Visible = false;
				maskedTextBox5.Visible = false;
				mCycleTime = 0.0;
			}
        }

        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {
             if (MouseButtons == MouseButtons.None) 
             { 
                 maskedTextBox1.SelectAll(); 
                 mFocused = true; 
             } 
        }

		private void maskedTextBox2_Enter(object sender, EventArgs e)
		{
			if (MouseButtons == MouseButtons.None)
			{
				maskedTextBox2.SelectAll();
				mFocused = true;
			} 
		}

		private void maskedTextBox3_Enter(object sender, EventArgs e)
		{
			if (MouseButtons == MouseButtons.None)
			{
				maskedTextBox3.SelectAll();
				mFocused = true;
			} 
		}

		private void maskedTextBox4_Enter(object sender, EventArgs e)
		{
			if (MouseButtons == MouseButtons.None)
			{
				maskedTextBox4.SelectAll();
				mFocused = true;
			} 
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This application was written by Joshua Walles.\n\n                            Copyright 2010", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			label7.Visible = false;
			maskedTextBox5.Visible = false;
			mCycleTime = 0.0;
		}

		private void comboBox1_Leave(object sender, EventArgs e)
		{
			
		}

		private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
		{
			label7.Visible = false;
			maskedTextBox5.Visible = false;
			mCycleTime = 0.0;
			switch (comboBox1.Text)
			{
				case "ABS":
					mThermalDiff = .66;
					mInjectTemp = 430;
					mMoldTemp = 150;
					mEjectTemp = 170;
					break;
				case "PC/ABS":
					mThermalDiff = .82;
					mInjectTemp = 495;
					mMoldTemp = 180;
					mEjectTemp = 200;
					break;
				case "PA":
					mThermalDiff = .74;
					mInjectTemp = 520;
					mMoldTemp = 175;
					mEjectTemp = 220;
					break;
				case "POM":
					mThermalDiff = .61;
					mInjectTemp = 390;
					mMoldTemp = 125;
					mEjectTemp = 175;
					break;
				case "PS":
					mThermalDiff = .62;
					mInjectTemp = 445;
					mMoldTemp = 125;
					mEjectTemp = 150;
					break;
				case "PC":
					mThermalDiff = .80;
					mInjectTemp = 575;
					mMoldTemp = 165;
					mEjectTemp = 220;
					break;
				case "PPS":
					mThermalDiff = .54;
					mInjectTemp = 605;
					mMoldTemp = 250;
					mEjectTemp = 280;
					break;
				case "PEEK":
					mThermalDiff = .80;
					mInjectTemp = 705;
					mMoldTemp = 250;
					mEjectTemp = 280;
					break;
				case "PBT":
					mThermalDiff = .56;
					mInjectTemp = 490;
					mMoldTemp = 150;
					mEjectTemp = 220;
					break;
				case "PVC":
					mThermalDiff = .80;
					mInjectTemp = 360;
					mMoldTemp = 100;
					mEjectTemp = 140;
					break;
				case "PP":
					mThermalDiff = .56;
					mInjectTemp = 420;
					mMoldTemp = 65;
					mEjectTemp = 150;
					break;
				case "PE":
					mThermalDiff = .57;
					mInjectTemp = 420;
					mMoldTemp = 65;
					mEjectTemp = 150;
					break;
				case "PMMA":
					mThermalDiff = .57;
					mInjectTemp = 440;
					mMoldTemp = 175;
					mEjectTemp = 190;
					break;
				case "PEI":
					mThermalDiff = .47;
					mInjectTemp = 710;
					mMoldTemp = 250;
					mEjectTemp = 280;
					break;
				case "PET":
					mThermalDiff = .89;
					mInjectTemp = 535;
					mMoldTemp = 150;
					mEjectTemp = 220;
					break;
				default:
					mThermalDiff = .67;
					break;
			}
			maskedTextBox2.Text = mInjectTemp.ToString();
			maskedTextBox3.Text = mMoldTemp.ToString();
			maskedTextBox4.Text = mEjectTemp.ToString();
			Form1.ActiveForm.Refresh();
		
		}

		private void comboBox1_TextUpdate(object sender, EventArgs e)
		{

		} 

	}
}