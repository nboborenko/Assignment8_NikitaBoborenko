using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment8_NikitaBoborenko
{
    public partial class Form1 : Form
    {
        List<String> first_list;
        List<String> second_list;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            first_list = load_file("FirstFile.txt");
            second_list = load_file("SecondFile.txt");
        }

        private List<String> load_file(String file_name)
        {

            List<String> loaded_array = new List<String>();
            StreamReader inputFile;
            inputFile = File.OpenText(file_name);

            while (!inputFile.EndOfStream)
            {
                loaded_array.Add(inputFile.ReadLine());
            }
            inputFile.Close();
            return loaded_array;
        }

        private void find_btn_Click(object sender, EventArgs e)
        {
            if (first_list.Contains(input_textBox.Text))
            {
                output_label.Text = "Word "+ input_textBox.Text + " was found in the first list";
            }else if (second_list.Contains(input_textBox.Text)) 
            {
                output_label.Text = "Word " + input_textBox.Text + " was found in the second list";
            }
            else
            {
                output_label.Text = "Word was not found";
            }
        }
    }
}
