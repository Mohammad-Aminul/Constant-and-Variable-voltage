using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms.DataVisualization.Charting;
namespace Constant_Voltage
{
    public partial class Form1 : Form
    {
        bool flag;
        //public void hiderow2(){
        //    textBox5.Clear();
        //    textBox6.Clear();
        //    textBox7.Clear();
        //    textBox8.Clear();
        //    textBox5.Hide();
        //    textBox6.Hide();
        //    textBox7.Hide();
        //    textBox8.Hide();
        //    btn_row2.Hide();
        //    lbl_row2.Hide();


        //}
        //public void hiderow3()
        //{
        //    textBox9.Clear();
        //    textBox10.Clear();
        //    textBox11.Clear();
        //    textBox12.Clear();
        //    textBox9.Hide();
        //    textBox10.Hide();
        //    textBox11.Hide();
        //    textBox12.Hide();

        //}
        public Form1()
        {
            InitializeComponent();
            flag = true;
            //hiderow2();
        }

        public void row1()
        {
            double q = Convert.ToDouble(textBox1.Text);
            double h = Convert.ToDouble(textBox2.Text);
            double p = Convert.ToDouble(textBox3.Text);
            double eta = (q * h * 101.952 * 3048) / (366 * p * 100);
            textBox4.Text = eta.ToString("f2");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text))
                {
                    row1();
                }
                else
                    textBox4.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert correct data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text))
                {
                    row1();
                }
                else
                    textBox4.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert correct data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text))
                {
                    row1();
                }
                else
                    textBox4.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert correct data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //first row end here
        public void row2()
        {
            double q = Convert.ToDouble(textBox5.Text);
            double h = Convert.ToDouble(textBox6.Text);
            double p = Convert.ToDouble(textBox7.Text);
            double eta = (q * h * 101.952 * 3048) / (366 * p * 100);
            textBox8.Text = eta.ToString("f2");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrEmpty(textBox7.Text))
                {
                    row2();
                }
                else
                    textBox8.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert correct data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrEmpty(textBox7.Text))
                {
                    row2();
                }
                else
                    textBox8.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert correct data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrEmpty(textBox7.Text))
                {
                    row2();
                }
                else
                    textBox8.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert correct data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //Row two end here

        public void row3()
        {
            double q = Convert.ToDouble(textBox9.Text);
            double h = Convert.ToDouble(textBox10.Text);
            double p = Convert.ToDouble(textBox11.Text);
            double eta = (q * h * 101.952 * 3048) / (366 * p * 100);
            textBox12.Text = eta.ToString("f2");
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox9.Text) && !string.IsNullOrEmpty(textBox10.Text) && !string.IsNullOrEmpty(textBox11.Text))
                {
                    row3();
                }
                else
                    textBox12.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert correct data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox9.Text) && !string.IsNullOrEmpty(textBox10.Text) && !string.IsNullOrEmpty(textBox11.Text))
                {
                    row3();
                }
                else
                    textBox12.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert correct data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox9.Text) && !string.IsNullOrEmpty(textBox10.Text) && !string.IsNullOrEmpty(textBox11.Text))
                {
                    row3();
                }
                else
                    textBox12.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert correct data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //Row three end here

        public void row4()
        {
            double q = Convert.ToDouble(textBox13.Text);
            double h = Convert.ToDouble(textBox14.Text);
            double p = Convert.ToDouble(textBox15.Text);
            double eta = (q * h * 101.952 * 3048) / (366 * p * 100);
            textBox16.Text = eta.ToString("f2");
        }
        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox13.Text) && !string.IsNullOrEmpty(textBox14.Text) && !string.IsNullOrEmpty(textBox15.Text))
                {
                    row4();
                }
                else
                    textBox16.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert correct data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox13.Text) && !string.IsNullOrEmpty(textBox14.Text) && !string.IsNullOrEmpty(textBox15.Text))
                {
                    row4();
                }
                else
                    textBox16.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert correct data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox13.Text) && !string.IsNullOrEmpty(textBox14.Text) && !string.IsNullOrEmpty(textBox15.Text))
                {
                    row4();
                }
                else
                    textBox16.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert correct data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //Row four end here
        public void row5()
        {
            double q = Convert.ToDouble(textBox17.Text);
            double h = Convert.ToDouble(textBox18.Text);
            double p = Convert.ToDouble(textBox19.Text);
            double eta = (q * h * 101.952 * 3048) / (366 * p * 100);
            textBox20.Text = eta.ToString("f2");
        }
        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox17.Text) && !string.IsNullOrEmpty(textBox18.Text) && !string.IsNullOrEmpty(textBox19.Text))
                {
                    row5();
                }
                else
                    textBox20.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert correct data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox17.Text) && !string.IsNullOrEmpty(textBox18.Text) && !string.IsNullOrEmpty(textBox19.Text))
                {
                    row5();
                }
                else
                    textBox20.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert correct data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox17.Text) && !string.IsNullOrEmpty(textBox18.Text) && !string.IsNullOrEmpty(textBox19.Text))
                {
                    row5();
                }
                else
                    textBox20.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert correct data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //row 5 end here
        public void row6()
        {
            double q = Convert.ToDouble(textBox21.Text);
            double h = Convert.ToDouble(textBox22.Text);
            double p = Convert.ToDouble(textBox23.Text);
            double eta = (q * h * 101.952 * 3048) / (366 * p * 100);
            textBox24.Text = eta.ToString("f2");
        }
        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox21.Text) && !string.IsNullOrEmpty(textBox22.Text) && !string.IsNullOrEmpty(textBox23.Text))
                {
                    row6();
                }
                else
                    textBox24.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert correct data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox21.Text) && !string.IsNullOrEmpty(textBox22.Text) && !string.IsNullOrEmpty(textBox23.Text))
                {
                    row6();
                }
                else
                    textBox24.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert correct data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox21.Text) && !string.IsNullOrEmpty(textBox22.Text) && !string.IsNullOrEmpty(textBox23.Text))
                {
                    row6();
                }
                else
                    textBox24.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert correct data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //row 6 end here
        public void row7()
        {
            double q = Convert.ToDouble(textBox25.Text);
            double h = Convert.ToDouble(textBox26.Text);
            double p = Convert.ToDouble(textBox27.Text);
            double eta = (q * h * 101.952 * 3048) / (366 * p * 100);
            textBox28.Text = eta.ToString("f2");
        }
        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox25.Text) && !string.IsNullOrEmpty(textBox26.Text) && !string.IsNullOrEmpty(textBox27.Text))
                {
                    row7();
                }
                else
                    textBox28.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert correct data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox25.Text) && !string.IsNullOrEmpty(textBox26.Text) && !string.IsNullOrEmpty(textBox27.Text))
                {
                    row7();
                }
                else
                    textBox28.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert correct data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox25.Text) && !string.IsNullOrEmpty(textBox26.Text) && !string.IsNullOrEmpty(textBox27.Text))
                {
                    row7();
                }
                else
                    textBox28.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert correct data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //row 7 end here
        public void row8()
        {
            double q = Convert.ToDouble(textBox29.Text);
            double h = Convert.ToDouble(textBox30.Text);
            double p = Convert.ToDouble(textBox31.Text);
            double eta = (q * h * 101.952 * 3048) / (366 * p * 100);
            textBox32.Text = eta.ToString("f2");
        }
        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox29.Text) && !string.IsNullOrEmpty(textBox30.Text) && !string.IsNullOrEmpty(textBox31.Text))
                {
                    row8();
                }
                else
                    textBox32.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert correct data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox29.Text) && !string.IsNullOrEmpty(textBox30.Text) && !string.IsNullOrEmpty(textBox31.Text))
                {
                    row8();
                }
                else
                    textBox32.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert correct data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox29.Text) && !string.IsNullOrEmpty(textBox30.Text) && !string.IsNullOrEmpty(textBox31.Text))
                {
                    row8();
                }
                else
                    textBox32.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert correct data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //row 8 end here
        public void row9()
        {
            double q = Convert.ToDouble(textBox33.Text);
            double h = Convert.ToDouble(textBox34.Text);
            double p = Convert.ToDouble(textBox35.Text);
            double eta = (q * h * 101.952 * 3048) / (366 * p * 100);
            textBox36.Text = eta.ToString("f2");
        }
        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox33.Text) && !string.IsNullOrEmpty(textBox34.Text) && !string.IsNullOrEmpty(textBox35.Text))
                {
                    row9();
                }
                else
                    textBox36.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert correct data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox33.Text) && !string.IsNullOrEmpty(textBox34.Text) && !string.IsNullOrEmpty(textBox35.Text))
                {
                    row9();
                }
                else
                    textBox36.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert correct data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox33.Text) && !string.IsNullOrEmpty(textBox34.Text) && !string.IsNullOrEmpty(textBox35.Text))
                {
                    row9();
                }
                else
                    textBox36.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert correct data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //row 9 end here
        public void row10()
        {
            double q = Convert.ToDouble(textBox37.Text);
            double h = Convert.ToDouble(textBox38.Text);
            double p = Convert.ToDouble(textBox39.Text);
            double eta = (q * h * 101.952 * 3048) / (366 * p * 100);
            textBox40.Text = eta.ToString("f2");
        }
        private void textBox37_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox37.Text) && !string.IsNullOrEmpty(textBox38.Text) && !string.IsNullOrEmpty(textBox39.Text))
                {
                    row10();
                }
                else
                    textBox40.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert correct data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox37.Text) && !string.IsNullOrEmpty(textBox38.Text) && !string.IsNullOrEmpty(textBox39.Text))
                {
                    row10();
                }
                else
                    textBox40.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert correct data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox37.Text) && !string.IsNullOrEmpty(textBox38.Text) && !string.IsNullOrEmpty(textBox39.Text))
                {
                    row10();
                }
                else
                    textBox40.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert correct data", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //****************************************************************************
        //****************************************************************************

        double[] discharge = new double[11];
        double[] totalhead = new double[11];

        double[] input_power = new double[11];
        double[] comb_efficiency = new double[11];
        public void get_discharge()
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrEmpty(textBox9.Text) &&
                    !string.IsNullOrEmpty(textBox13.Text) && !string.IsNullOrEmpty(textBox17.Text) && !string.IsNullOrEmpty(textBox21.Text) &&
                    !string.IsNullOrEmpty(textBox25.Text) && !string.IsNullOrEmpty(textBox29.Text) && !string.IsNullOrEmpty(textBox33.Text) &&
                    !string.IsNullOrEmpty(textBox37.Text))
                {
                    discharge[1] = Convert.ToDouble(textBox1.Text);
                    discharge[2] = Convert.ToDouble(textBox5.Text);
                    discharge[3] = Convert.ToDouble(textBox9.Text);
                    discharge[4] = Convert.ToDouble(textBox13.Text);
                    discharge[5] = Convert.ToDouble(textBox17.Text);
                    discharge[6] = Convert.ToDouble(textBox21.Text);
                    discharge[7] = Convert.ToDouble(textBox25.Text);
                    discharge[8] = Convert.ToDouble(textBox29.Text);
                    discharge[9] = Convert.ToDouble(textBox33.Text);
                    discharge[10] = Convert.ToDouble(textBox37.Text);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        public void get_totalhead()
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox6.Text) &&
                    !string.IsNullOrEmpty(textBox10.Text) && !string.IsNullOrEmpty(textBox14.Text) && !string.IsNullOrEmpty(textBox18.Text) &&
                    !string.IsNullOrEmpty(textBox22.Text) && !string.IsNullOrEmpty(textBox26.Text) && !string.IsNullOrEmpty(textBox30.Text) &&
                    !string.IsNullOrEmpty(textBox34.Text) && !string.IsNullOrEmpty(textBox38.Text))
                {
                    totalhead[1] = Convert.ToDouble(textBox2.Text);
                    totalhead[2] = Convert.ToDouble(textBox6.Text);
                    totalhead[3] = Convert.ToDouble(textBox10.Text);
                    totalhead[4] = Convert.ToDouble(textBox14.Text);
                    totalhead[5] = Convert.ToDouble(textBox18.Text);
                    totalhead[6] = Convert.ToDouble(textBox22.Text);
                    totalhead[7] = Convert.ToDouble(textBox26.Text);
                    totalhead[8] = Convert.ToDouble(textBox30.Text);
                    totalhead[9] = Convert.ToDouble(textBox34.Text);
                    totalhead[10] = Convert.ToDouble(textBox38.Text);
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        public void get_input_power()
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox7.Text) &&
                    !string.IsNullOrEmpty(textBox11.Text) && !string.IsNullOrEmpty(textBox15.Text) && !string.IsNullOrEmpty(textBox19.Text) &&
                    !string.IsNullOrEmpty(textBox23.Text) && !string.IsNullOrEmpty(textBox27.Text) && !string.IsNullOrEmpty(textBox31.Text) &&
                    !string.IsNullOrEmpty(textBox35.Text) && !string.IsNullOrEmpty(textBox39.Text))
                {
                    input_power[1] = Convert.ToDouble(textBox3.Text);
                    input_power[2] = Convert.ToDouble(textBox7.Text);
                    input_power[3] = Convert.ToDouble(textBox11.Text);
                    input_power[4] = Convert.ToDouble(textBox15.Text);
                    input_power[5] = Convert.ToDouble(textBox19.Text);
                    input_power[6] = Convert.ToDouble(textBox23.Text);
                    input_power[7] = Convert.ToDouble(textBox27.Text);
                    input_power[8] = Convert.ToDouble(textBox31.Text);
                    input_power[9] = Convert.ToDouble(textBox35.Text);
                    input_power[10] = Convert.ToDouble(textBox39.Text);
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        public void get_comb_efficiency()
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox8.Text) &&
                    !string.IsNullOrEmpty(textBox12.Text) && !string.IsNullOrEmpty(textBox16.Text) && !string.IsNullOrEmpty(textBox20.Text) &&
                    !string.IsNullOrEmpty(textBox24.Text) && !string.IsNullOrEmpty(textBox28.Text) && !string.IsNullOrEmpty(textBox32.Text) &&
                    !string.IsNullOrEmpty(textBox36.Text) && !string.IsNullOrEmpty(textBox40.Text))
                {
                    comb_efficiency[1] = Convert.ToDouble(textBox4.Text);
                    comb_efficiency[2] = Convert.ToDouble(textBox8.Text);
                    comb_efficiency[3] = Convert.ToDouble(textBox12.Text);
                    comb_efficiency[4] = Convert.ToDouble(textBox16.Text);
                    comb_efficiency[5] = Convert.ToDouble(textBox20.Text);
                    comb_efficiency[6] = Convert.ToDouble(textBox24.Text);
                    comb_efficiency[7] = Convert.ToDouble(textBox28.Text);
                    comb_efficiency[8] = Convert.ToDouble(textBox32.Text);
                    comb_efficiency[9] = Convert.ToDouble(textBox36.Text);
                    comb_efficiency[10] = Convert.ToDouble(textBox40.Text);
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }


        public void graph_totalhead(double xvalue, double yvalue)
        {
            chart1.Series["Total Head (ft)"].Points.AddXY(xvalue, yvalue);

        }
        public void graph_input_power(double xvalue, double yvalue)
        {
            chart1.Series["input power(kw)"].Points.AddXY(xvalue, yvalue);

        }
        public void graph_comb_efficiency(double xvalue, double yvalue)
        {
            chart1.Series["comb eff(%)"].Points.AddXY(xvalue, yvalue);

        }
        private void button1_graph_display_Click(object sender, EventArgs e)
        {
            //
            if (flag && !string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox40.Text))
            {
                chart1.Titles.Add("Performance curve for constant voltage(Voltage:400V)");
                get_discharge();
                get_totalhead();
                get_input_power();
                get_comb_efficiency();

                for (int i = 1; i <= 10; i++)
                {
                    graph_totalhead(discharge[i], totalhead[i]);
                }
                for (int i = 1; i <= 10; i++)
                {
                    graph_input_power(discharge[i], input_power[i]);
                }
                for (int i = 1; i <= 10; i++)
                {
                    graph_comb_efficiency(discharge[i], comb_efficiency[i]);
                }
                flag = false;
            }
            else
            {
                MessageBox.Show("Please Insert New Data","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }

        }
        public void clear_textBox()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            textBox22.Clear();
            textBox23.Clear();
            textBox24.Clear();
            textBox25.Clear();
            textBox26.Clear();
            textBox27.Clear();
            textBox28.Clear();
            textBox29.Clear();
            textBox30.Clear();
            textBox31.Clear();
            textBox32.Clear();
            textBox33.Clear();
            textBox34.Clear();
            textBox35.Clear();
            textBox36.Clear();
            textBox37.Clear();
            textBox38.Clear();
            textBox39.Clear();
            textBox40.Clear();

        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear_textBox();
            chart1.Titles.Clear();
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            flag = true;
        }


        private void btn_create_pdf_Click(object sender, EventArgs e)
        {

            Random rd = new Random();// for random number generation
            Document document = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);

            PdfWriter.GetInstance(document, new FileStream("C:/Users/" +
                rd.Next(1, 999999) + "_" + DateTime.Now.ToString("dd-MM-yyyy") + ".pdf", FileMode.Create));
            document.Open();

            Paragraph h = new Paragraph("Result sheet for constant voltage ");
            Paragraph p = new Paragraph("Discharge " + " " + "Total Head " + " " + "Input Power" + "    " + " Comb. Efficiency");
     


            h.Alignment = Element.ALIGN_CENTER;
            p.Alignment = Element.ALIGN_CENTER;
         

            document.Add(h);
            document.Add(p);
        


            var imagechart = new MemoryStream();
            chart1.SaveImage(imagechart, ChartImageFormat.Png);
            iTextSharp.text.Image chart_image = iTextSharp.text.Image.GetInstance(imagechart.GetBuffer());
            chart_image.ScalePercent(96f);
            document.Add(chart_image);

            MessageBox.Show("PDF has been created successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            document.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            about about = new about();
            about.Show();
        }


    }
}
