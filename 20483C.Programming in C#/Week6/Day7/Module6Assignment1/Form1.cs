using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Module6Ex1
{

    public partial class Form1 : Form
    {
        Customer newAccount = new Customer();
        string filePath = "C:\\Users\\Steven\\Desktop\\MSSA\\Microsoft-Software-and-Systems-Academy-Repo\\20483C.Programming in C#\\Week6\\Day7\\DummyFile.txt";
        string currentMode;
        StringBuilder sb = new StringBuilder();
        BinaryFormatter bn = new BinaryFormatter();
        SoapFormatter soapFormatter = new SoapFormatter();
        DataContractJsonSerializer jsonSerializer;

        public Form1()
        {
            InitializeComponent();
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            //accountList = new ArrayList();
            newAccount.CustId = Int32.Parse(txtCustId.Text);
            newAccount.FirstName = txtFname.Text;
            newAccount.LastName = txtLname.Text;
            //accountList.Add(newAccount);
            //gbLogin.Visible = false;
            /*GrdAccount.DataSource = accountList;
            GrdAccount.Visible = true;*/
            if (txtFname.Text != null && txtLname.Text != null && txtCustId.Text != null)
            {
                gbLogin.Visible = false;
                lbHeader.Visible = true;
                lbHeader.Text = "Welcome, " + newAccount.FirstName + " " + newAccount.LastName;
                lbSubHeader.Visible = true;
                btnJSON.Visible = true;
                btnBinary.Visible = true;
                btnXML.Visible = true;
                textArea.Visible = true;
                sb.Append("Your Info: \n");
                sb.Append($"Customer Id: {newAccount.CustId} \n");
                sb.Append($"First Name: {newAccount.FirstName} \n");
                sb.Append($"Last Name: {newAccount.LastName} ");
                File.WriteAllText(filePath, sb.ToString());
                textArea.Text = sb.ToString();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbHeader.Visible = false;
            lbSubHeader.Visible = false;
            lbthree.Visible = false;
            btnSerialize.Visible = false;
            btnDeserialize.Visible = false;
            btnJSON.Visible = false;
            btnBinary.Visible = false;
            btnXML.Visible = false;
            textArea.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        

        private void lbSubHeader_Click(object sender, EventArgs e)
        {

        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            btnSerialize.Visible = false;
            btnDeserialize.Visible = true;
            lbthree.Visible = false;

            switch (currentMode)
            {
                case "binary":
                    sb.Clear();
                    FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    bn = new BinaryFormatter();
                    bn.Serialize(fileStream, newAccount);
                    fileStream.Close();
                    sb.Append("Your information was serialized via XML and ready to be deserialized.");
                    textArea.Text = sb.ToString();
                    break;
                case "xml":
                    sb.Clear();
                    FileStream fileStreamxml = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    soapFormatter.Serialize(fileStreamxml, newAccount);
                    fileStreamxml.Close();
                    sb.Append("Your information was serialized via XML and ready to be deserialized.");
                    textArea.Text = sb.ToString();
                    break;
                case "json":
                    sb.Clear();
                    jsonSerializer = new DataContractJsonSerializer(newAccount.GetType());
                    FileStream jsonBuffer = File.Create(filePath);
                    jsonSerializer.WriteObject(jsonBuffer, newAccount);
                    jsonBuffer.Close();
                    sb.Append("Your information was serialized via JSON and ready to be deserialized.");
                    textArea.Text = sb.ToString();
                    break;
            }
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            switch (currentMode)
            {
                case "binary":
                    sb.Clear();
                    sb.Append("Here is your deserialized information: \n");
                    FileStream fileStream1 = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);
                    Customer tempCust;
                    tempCust = (Customer)bn.Deserialize(fileStream1);
                    fileStream1.Close();
                    byte[] arr = File.ReadAllBytes(filePath);
                    foreach(var b in arr)
                    {
                    sb.Append(b);
                    }
                    textArea.Text = sb.ToString();
                    break;
                case "xml":
                    sb.Clear();
                    sb.Append("Here is your deserialized information: \n");
                    FileStream bufferxml = File.OpenRead(filePath);
                    Customer exml = soapFormatter.Deserialize(bufferxml) as Customer;
                    bufferxml.Close();
                    sb.Append(File.ReadAllText(filePath.ToString()));
                    textArea.Text = sb.ToString();
                    break;
                case "json":
                    sb.Clear();
                    sb.Append("Here is your deserialized information: \n");
                    FileStream jsonBuffered = File.OpenRead(filePath);
                    Customer jsonEmp = jsonSerializer.ReadObject(jsonBuffered) as Customer;
                    jsonBuffered.Close();
                    sb.Append(File.ReadAllText(filePath.ToString()));
                    textArea.Text = sb.ToString();
                    break;
            }
            btnDeserialize.Visible = false;
            btnJSON.Visible = true;
            btnBinary.Visible = true;
            btnXML.Visible = true;
            lbHeader.Visible = true;
            lbSubHeader.Visible = true;
        }
        private void btnBinary_Click(object sender, EventArgs e)
        {
            sb.Clear();
            textArea.Clear();
            btnJSON.Visible = false;
            btnBinary.Visible = false;
            btnXML.Visible = false;
            btnSerialize.Visible = true;
            lbHeader.Visible = false;
            lbSubHeader.Visible = false;
            lbthree.Visible = true;
            currentMode = "binary";

        }
        private void btnXML_Click(object sender, EventArgs e)
        {
            sb.Clear();
            textArea.Clear();
            btnJSON.Visible = false;
            btnBinary.Visible = false;
            btnXML.Visible = false;
            btnSerialize.Visible = true;
            lbHeader.Visible = false;
            lbSubHeader.Visible = false;
            lbthree.Visible = true;
            currentMode = "xml";
        }

        private void btnJSON_Click(object sender, EventArgs e)
        {
            sb.Clear();
            textArea.Clear();
            btnJSON.Visible = false;
            btnBinary.Visible = false;
            btnXML.Visible = false;
            btnSerialize.Visible = true;
            lbHeader.Visible = false;
            lbSubHeader.Visible = false;
            lbthree.Visible = true;
            currentMode = "json";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
