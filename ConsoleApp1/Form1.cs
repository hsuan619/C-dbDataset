using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int index;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 '_p11_1dbDataSet.書籍' 資料表。您可以視需要進行移動或移除。
            this.書籍資料TableAdapter1.Fill(this.testdbDataSet.書籍資料);
            recorddata();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            書籍資料BindingSource.MoveFirst();
            recorddata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            書籍資料BindingSource.MovePrevious();
            recorddata();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            書籍資料BindingSource.MoveNext();
            recorddata();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            書籍資料BindingSource.MoveLast();
            recorddata();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            書籍資料BindingSource.EndEdit();
            書籍資料TableAdapter1.Update(testdbDataSet);
            MessageBox.Show("update");
            Form1_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            書籍資料BindingSource.AddNew();
            recorddata();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            書籍資料BindingSource.RemoveCurrent();
            recorddata();

        }
        void recorddata()
        {
            label1.Text = "第" + (書籍資料BindingSource.Position + 1).ToString() + "筆 ，共" + (書籍資料BindingSource.Count).ToString() + "筆";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
