using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace led_matrix_code_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Byte [] Pattern = {0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00};
            Pattern[0] = (byte)(
                (checkBox1.Checked ? 1 : 0) +
                (checkBox2.Checked ? 2 : 0) +
                (checkBox3.Checked ? 4 : 0) +
                (checkBox4.Checked ? 8 : 0) +
                (checkBox5.Checked ? 16 : 0) +
                (checkBox6.Checked ? 32 : 0) +
                (checkBox7.Checked ? 64 : 0) +
                (checkBox8.Checked ? 128 : 0));
            Pattern[1] = (byte)(
                (checkBox9.Checked ? 1 : 0) +
                (checkBox10.Checked ? 2 : 0) +
                (checkBox11.Checked ? 4 : 0) +
                (checkBox12.Checked ? 8 : 0) +
                (checkBox13.Checked ? 16 : 0) +
                (checkBox14.Checked ? 32 : 0) +
                (checkBox15.Checked ? 64 : 0) +
                (checkBox16.Checked ? 128 : 0));
            Pattern[2] = (byte)(
                (checkBox17.Checked ? 1 : 0) +
                (checkBox18.Checked ? 2 : 0) +
                (checkBox19.Checked ? 4 : 0) +
                (checkBox20.Checked ? 8 : 0) +
                (checkBox21.Checked ? 16 : 0) +
                (checkBox22.Checked ? 32 : 0) +
                (checkBox23.Checked ? 64 : 0) +
                (checkBox24.Checked ? 128 : 0));
            Pattern[3] = (byte)(
                (checkBox25.Checked ? 1 : 0) +
                (checkBox26.Checked ? 2 : 0) +
                (checkBox27.Checked ? 4 : 0) +
                (checkBox28.Checked ? 8 : 0) +
                (checkBox29.Checked ? 16 : 0) +
                (checkBox30.Checked ? 32 : 0) +
                (checkBox31.Checked ? 64 : 0) +
                (checkBox32.Checked ? 128 : 0));
            Pattern[4] = (byte)(
                (checkBox33.Checked ? 1 : 0) +
                (checkBox34.Checked ? 2 : 0) +
                (checkBox35.Checked ? 4 : 0) +
                (checkBox36.Checked ? 8 : 0) +
                (checkBox37.Checked ? 16 : 0) +
                (checkBox38.Checked ? 32 : 0) +
                (checkBox39.Checked ? 64 : 0) +
                (checkBox40.Checked ? 128 : 0));
            Pattern[5] = (byte)(
                (checkBox41.Checked ? 1 : 0) +
                (checkBox42.Checked ? 2 : 0) +
                (checkBox43.Checked ? 4 : 0) +
                (checkBox44.Checked ? 8 : 0) +
                (checkBox45.Checked ? 16 : 0) +
                (checkBox46.Checked ? 32 : 0) +
                (checkBox47.Checked ? 64 : 0) +
                (checkBox48.Checked ? 128 : 0));
            Pattern[6] = (byte)(
                (checkBox49.Checked ? 1 : 0) +
                (checkBox50.Checked ? 2 : 0) +
                (checkBox51.Checked ? 4 : 0) +
                (checkBox52.Checked ? 8 : 0) +
                (checkBox53.Checked ? 16 : 0) +
                (checkBox54.Checked ? 32 : 0) +
                (checkBox55.Checked ? 64 : 0) +
                (checkBox56.Checked ? 128 : 0));
            Pattern[7] = (byte)(
                (checkBox57.Checked ? 1 : 0) +
                (checkBox58.Checked ? 2 : 0) +
                (checkBox59.Checked ? 4 : 0) +
                (checkBox60.Checked ? 8 : 0) +
                (checkBox61.Checked ? 16 : 0) +
                (checkBox62.Checked ? 32 : 0) +
                (checkBox63.Checked ? 64 : 0) +
                (checkBox64.Checked ? 128 : 0));
            
            textBox1.Text = "0x" + BitConverter.ToString(Pattern).Replace("-", ",0x");
            Clipboard.SetText(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
            checkBox21.Checked = false;
            checkBox22.Checked = false;
            checkBox23.Checked = false;
            checkBox24.Checked = false;
            checkBox25.Checked = false;
            checkBox26.Checked = false;
            checkBox27.Checked = false;
            checkBox28.Checked = false;
            checkBox29.Checked = false;
            checkBox30.Checked = false;
            checkBox31.Checked = false;
            checkBox32.Checked = false;
            checkBox33.Checked = false;
            checkBox34.Checked = false;
            checkBox35.Checked = false;
            checkBox36.Checked = false;
            checkBox37.Checked = false;
            checkBox38.Checked = false;
            checkBox39.Checked = false;
            checkBox40.Checked = false;
            checkBox41.Checked = false;
            checkBox42.Checked = false;
            checkBox43.Checked = false;
            checkBox44.Checked = false;
            checkBox45.Checked = false;
            checkBox46.Checked = false;
            checkBox47.Checked = false;
            checkBox48.Checked = false;
            checkBox49.Checked = false;
            checkBox50.Checked = false;
            checkBox51.Checked = false;
            checkBox52.Checked = false;
            checkBox53.Checked = false;
            checkBox54.Checked = false;
            checkBox55.Checked = false;
            checkBox56.Checked = false;
            checkBox57.Checked = false;
            checkBox58.Checked = false;
            checkBox59.Checked = false;
            checkBox60.Checked = false;
            checkBox61.Checked = false;
            checkBox62.Checked = false;
            checkBox63.Checked = false;
            checkBox64.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Byte[] Pattern = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            Pattern[0] = (byte)(
                (checkBox8.Checked ? 1 : 0) +
                (checkBox16.Checked ? 2 : 0) +
                (checkBox24.Checked ? 4 : 0) +
                (checkBox32.Checked ? 8 : 0) +
                (checkBox40.Checked ? 16 : 0) +
                (checkBox48.Checked ? 32 : 0) +
                (checkBox56.Checked ? 64 : 0) +
                (checkBox64.Checked ? 128 : 0));
            Pattern[1] = (byte)(
                (checkBox7.Checked ? 1 : 0) +
                (checkBox15.Checked ? 2 : 0) +
                (checkBox23.Checked ? 4 : 0) +
                (checkBox31.Checked ? 8 : 0) +
                (checkBox39.Checked ? 16 : 0) +
                (checkBox47.Checked ? 32 : 0) +
                (checkBox55.Checked ? 64 : 0) +
                (checkBox63.Checked ? 128 : 0));
            Pattern[2] = (byte)(
                (checkBox6.Checked ? 1 : 0) +
                (checkBox14.Checked ? 2 : 0) +
                (checkBox22.Checked ? 4 : 0) +
                (checkBox30.Checked ? 8 : 0) +
                (checkBox38.Checked ? 16 : 0) +
                (checkBox46.Checked ? 32 : 0) +
                (checkBox54.Checked ? 64 : 0) +
                (checkBox62.Checked ? 128 : 0));
            Pattern[3] = (byte)(
                (checkBox5.Checked ? 1 : 0) +
                (checkBox13.Checked ? 2 : 0) +
                (checkBox21.Checked ? 4 : 0) +
                (checkBox29.Checked ? 8 : 0) +
                (checkBox37.Checked ? 16 : 0) +
                (checkBox45.Checked ? 32 : 0) +
                (checkBox53.Checked ? 64 : 0) +
                (checkBox61.Checked ? 128 : 0));
            Pattern[4] = (byte)(
                (checkBox4.Checked ? 1 : 0) +
                (checkBox12.Checked ? 2 : 0) +
                (checkBox20.Checked ? 4 : 0) +
                (checkBox28.Checked ? 8 : 0) +
                (checkBox36.Checked ? 16 : 0) +
                (checkBox44.Checked ? 32 : 0) +
                (checkBox52.Checked ? 64 : 0) +
                (checkBox60.Checked ? 128 : 0));
            Pattern[5] = (byte)(
                (checkBox3.Checked ? 1 : 0) +
                (checkBox11.Checked ? 2 : 0) +
                (checkBox19.Checked ? 4 : 0) +
                (checkBox27.Checked ? 8 : 0) +
                (checkBox35.Checked ? 16 : 0) +
                (checkBox43.Checked ? 32 : 0) +
                (checkBox51.Checked ? 64 : 0) +
                (checkBox59.Checked ? 128 : 0));
            Pattern[6] = (byte)(
                (checkBox2.Checked ? 1 : 0) +
                (checkBox10.Checked ? 2 : 0) +
                (checkBox18.Checked ? 4 : 0) +
                (checkBox26.Checked ? 8 : 0) +
                (checkBox34.Checked ? 16 : 0) +
                (checkBox42.Checked ? 32 : 0) +
                (checkBox50.Checked ? 64 : 0) +
                (checkBox58.Checked ? 128 : 0));
            Pattern[7] = (byte)(
                (checkBox1.Checked ? 1 : 0) +
                (checkBox9.Checked ? 2 : 0) +
                (checkBox17.Checked ? 4 : 0) +
                (checkBox25.Checked ? 8 : 0) +
                (checkBox33.Checked ? 16 : 0) +
                (checkBox41.Checked ? 32 : 0) +
                (checkBox49.Checked ? 64 : 0) +
                (checkBox57.Checked ? 128 : 0));
            textBox2.Text = "0x" + BitConverter.ToString(Pattern).Replace("-", ",0x");
            Clipboard.SetText(textBox2.Text);
        }
    }
}
