using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Text.Json;

namespace DemoCourseSerializationWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_CourseId.Clear();
            txt_CourseName.Clear();
            txt_CourseFees.Clear();
        }

        private void btn_BinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Course c = new Course();
                c.courseId = Convert.ToInt32(txt_CourseId.Text);
                c.courseName = txt_CourseName.Text;
                c.fees = Convert.ToInt32(txt_CourseFees.Text);
                FileStream fs = new FileStream("d:\\democoursebin", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, c);
                MessageBox.Show("Binary Write Completed.");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_BinaryRead_Click(object sender, EventArgs e)
        {

            FileStream fs = new FileStream("d:\\democoursebin", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            Course c=(Course)bf.Deserialize(fs);
            txt_CourseId.Text = Convert.ToString(c.courseId);
            txt_CourseName.Text = c.courseName;
            txt_CourseFees.Text = Convert.ToString(c.fees);
        }

        private void btn_XmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Course c = new Course();
                c.courseId = Convert.ToInt32(txt_CourseId.Text);
                c.courseName = txt_CourseName.Text;
                c.fees = Convert.ToInt32(txt_CourseFees.Text);
                FileStream fs = new FileStream("d:\\democoursexml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs=new XmlSerializer(typeof(Course));
                xs.Serialize(fs, c);                
                MessageBox.Show("xml Write Completed.");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_XmlRead_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("d:\\democoursexml", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(Course));
            Course c = (Course)xs.Deserialize(fs);
            txt_CourseId.Text = Convert.ToString(c.courseId);
            txt_CourseName.Text = c.courseName;
            txt_CourseFees.Text = Convert.ToString(c.fees);
        }

        private void btn_SoapWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Course c = new Course();
                c.courseId = Convert.ToInt32(txt_CourseId.Text);
                c.courseName = txt_CourseName.Text;
                c.fees = Convert.ToInt32(txt_CourseFees.Text);
                FileStream fs = new FileStream("d:\\democoursesoap", FileMode.Create, FileAccess.Write);
                SoapFormatter soapFormatter = new SoapFormatter();
                soapFormatter.Serialize(fs, c);                
                MessageBox.Show("xml Write Completed.");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_SoapRead_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("d:\\democoursesoap", FileMode.Open, FileAccess.Read);
            SoapFormatter soapFormatter = new SoapFormatter();           
            Course c = (Course)soapFormatter.Deserialize(fs);
            txt_CourseId.Text = Convert.ToString(c.courseId);
            txt_CourseName.Text = c.courseName;
            txt_CourseFees.Text = Convert.ToString(c.fees);
        }

        private void btn_JsonWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Course c = new Course();
                c.courseId = Convert.ToInt32(txt_CourseId.Text);
                c.courseName = txt_CourseName.Text;
                c.fees = Convert.ToInt32(txt_CourseFees.Text);
                FileStream fs = new FileStream("d:\\democoursejson", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, c);               
                MessageBox.Show("xml Write Completed.");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_JsonRead_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("d:\\democoursejson", FileMode.Open, FileAccess.Read);            
            Course c = JsonSerializer. Deserialize<Course>(fs);
            txt_CourseId.Text = Convert.ToString(c.courseId);
            txt_CourseName.Text = c.courseName;
            txt_CourseFees.Text = Convert.ToString(c.fees);
        }
    }
}
