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

namespace P5_3_12040177
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TB_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^.*/.*$", RegexOptions.IgnoreCase);
            if (regex.IsMatch(TBta.Text))
            {
                epWarn.Clear();
            }
            else
            {
                epWarn.SetError(TBta, "Tahun Akademik Tidak Sesuai");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if ((Laki.Checked == true || PER.Checked == true) && numericTB1.Text != "" && charTB1.Text != "" && CBalamat.Text != "" && comboBox1.Text != "" && TBta.Text != "" && numericTB2.Text != "")
            {
                Size = new Size(784, 650);
                if (radioButton1.Checked == true)
                {
                    matkul.Enabled = true;
                    checkBox12.Enabled = false;
                    checkBox9.Enabled = false;
                }
                else if (radioButton2.Checked == true)
                {
                    matkul.Enabled = true;
                    mtk.Enabled = false;
                    checkBox9.Enabled = false;
                }

                else if (radioButton3.Checked == true)
                {
                    matkul.Enabled = true;
                    mtk.Enabled = false;
                    checkBox12.Enabled = false;
                }
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string kelas = " ";
            if (mtk.Checked) { kelas += mtk.Text; }
            if (checkBox2.Checked) { kelas += checkBox2.Text; }
            if (checkBox10.Checked) { kelas += checkBox10.Text; }
            if (checkBox11.Checked) { kelas += checkBox11.Text; }
            if (checkBox12.Checked) { kelas += checkBox12.Text; }
            if (checkBox3.Checked) { kelas += checkBox3.Text; }
            if (checkBox4.Checked) { kelas += checkBox4.Text; }
            if (checkBox5.Checked) { kelas += checkBox5.Text; }
            if (checkBox6.Checked) { kelas += checkBox6.Text; }
            if (checkBox7.Checked) { kelas += checkBox7.Text; }
            if (checkBox8.Checked) { kelas += checkBox8.Text; }
            if (checkBox9.Checked) { kelas += checkBox9.Text; }
            string jk = Laki.Checked == true ? Laki.Text : PER.Text;
            string kuri = "";
            if (radioButton1.Checked) { kuri = radioButton1.Text; } else if (radioButton2.Checked) { kuri = radioButton2.Text; } else if (radioButton3.Checked) { kuri = radioButton3.Text; }
            string message = String.Format("NIM : {0}\nNama : {1}\nJenis Kelamin : {2}\nAlamat : {3}\nProgram Studi : {4}\nTahun Akademik : {5}\nSemester : {6}\nKurikulum : {7}\nKelas : {8}\n", numericTB1.Text, charTB1.Text, jk, CBalamat.Text, comboBox1.Text, TBta.Text, numericTB2.Text, kuri, kelas);
            MessageBox.Show(message);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

