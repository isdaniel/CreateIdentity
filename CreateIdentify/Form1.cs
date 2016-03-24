using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateIdentify
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^\d+$");
            if (!reg.IsMatch(txt_num.Text))
            {
                MessageBox.Show("請輸入數字");
                txt_num.Text = "";
                return;
            }
            CreateID();
        }
        void CreateID(){
            Create c = new Create();
            IdetifyBLL bll=new IdetifyBLL();
            List<Identify_Model> list = new List<Identify_Model>();
            int num = int.Parse(txt_num.Text);
            for (int i = 0; i < num; i++)
            {
                string id = c.SpellIndentify();
                textBox1.AppendText(id + "\r\n");
                list.Add(new Identify_Model() { Identify = id });
            }
            bll.InsertData(list);
            MessageBox.Show("成功");
        }
    }
}
