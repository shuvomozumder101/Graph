using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chartDataDataSet.MyDb' table. You can move, or remove it, as needed.
            this.myDbTableAdapter.Fill(this.chartDataDataSet.MyDb);

        }

        private void Load_Click(object sender, EventArgs e)
        {
            //chart1.Series.XValueMember = "Name";
            //chart1.Series.YValueMembers = "Name";

            chart1.Series[1].XValueMember = "Month";
            chart1.Series[1].YValueMembers = "Month";

            chart1.Series[0].XValueMember = "Year";
            chart1.Series[0].YValueMembers = "Year";

            chart1.Series[2].XValueMember = "value";
            chart1.Series[2].YValueMembers = "value";

            chart1.DataSource = myDataSet.MyDb;
            chart1.DataBind();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet.MyDb' table. You can move, or remove it, as needed.
            this.myDbTableAdapter2.Fill(this.myDataSet.MyDb);

        }
    }
}
