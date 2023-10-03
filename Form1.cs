using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;    //FileStream
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;     //xml
using System.Runtime.Serialization.Json;    //json

namespace Assignment_5._4_Serialization
{
    public partial class Form1 : Form
    {
        Person person;
        const string binaryfile = @"C:\Files\binary.txt";
        const string jsonfile = @"C:\Files\json.txt";
        const string xmlfile = @"C:\Files\xml.xml";


        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            person = new Person();
            person.Name = txtName.Text;
            person.Age = Int32.Parse(txtAge.Text);
            person.Phone = txtPhone.Text;
            MessageBox.Show("Person object created!");
            btnBinarySer.Enabled = true;
            btnJSONSer.Enabled = true;
            btnXMLSer.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            btnBinarySer.Enabled = false;
            btnBinaryDS.Enabled = false;
            btnJSONSer.Enabled = false;
            btnJSONDS.Enabled = false;
            btnXMLSer.Enabled = false;
            btnXMLDS.Enabled = false;
            
        }

        #region BinaryGroupBox
        private void btnBinarySer_Click(object sender, EventArgs e)
        {
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(binaryfile, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, person);
                MessageBox.Show("Binary data serialized!");
                btnBinaryDS.Enabled = true; 
            }
            catch (Exception ex)
            {

            }
            finally
            {
                fileStream.Close();
            }

        }

        private void btnBinaryDS_Click(object sender, EventArgs e)
        {
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(binaryfile, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                Person temp = (Person)formatter.Deserialize(fileStream);
                MessageBox.Show($"Name: {temp.Name}, Age: {temp.Age}, Phone: {temp.Phone}");
            }
            catch
            {

            }
            finally { fileStream.Close(); }

        }

        private void linkBinary_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkBinary.LinkVisited = true;
            System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/dotnet/standard/serialization/binary-serialization");
        }
        #endregion

        #region JSONGroupBox
        private void btnJSONSer_Click(object sender, EventArgs e)
        {
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(jsonfile, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Person));
                serializer.WriteObject(fileStream, person);
                MessageBox.Show("JSON data serialized!");
                btnJSONDS.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { fileStream.Close(); }
        }

        private void btnJSONDS_Click(object sender, EventArgs e)
        {
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(jsonfile, FileMode.Open, FileAccess.Read);
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Person));
                Person temp = jsonSerializer.ReadObject(fileStream) as Person;
                MessageBox.Show($"Name: {temp.Name}, Age: {temp.Age}, Phone: {temp.Phone}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { fileStream.Close(); }

        }

        private void linkJSON_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkJSON.LinkVisited = true;
            System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-overview?pivots=dotnet-6-0");
        }
        #endregion

        #region XMLGroupBox
        private void btnXMLSer_Click(object sender, EventArgs e)
        {
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(xmlfile, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                SoapFormatter soapFormatter = new SoapFormatter();
                soapFormatter.Serialize(fileStream, person);
                MessageBox.Show("XML data serialized!");
                btnXMLDS.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { fileStream.Close(); }
        }

        private void btnXMLDS_Click(object sender, EventArgs e)
        {
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(xmlfile, FileMode.Open, FileAccess.Read);
                SoapFormatter soapFormatter = new SoapFormatter();
                Person temp = (Person)soapFormatter.Deserialize(fileStream);
                MessageBox.Show($"Name: {temp.Name}, Age: {temp.Age}, Phone: {temp.Phone}");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { fileStream.Close(); }
        }

        private void linkXML_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkJSON.LinkVisited = true;
            System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/dotnet/standard/serialization/xml-and-soap-serialization");
        } 
        #endregion
    }
}
