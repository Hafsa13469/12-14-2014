using CSVLib;
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

namespace AddressBookMakingApp
{
    public partial class AdressBookMakingUI : Form
    {
        private string path = @"E:\AdressBook.CSV";
        public AdressBookMakingUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {


            bool isvalid = true;
            if (File.Exists(path))
            {
                FileStream aStream = new FileStream(path, FileMode.Open);
                CsvFileReader aReader = new CsvFileReader(aStream);

                List<String> phoneNo = new List<String>();
                while (aReader.ReadRow(phoneNo))
                {
                    string no = phoneNo[2];
                    if (personalContactNoTextBox.Text == no)
                    {
                        isvalid = false;
                        break;
                    }
                }
                aStream.Close();
            }
            if (isvalid)
            {
                FileStream bStream = new FileStream(path, FileMode.Append);
                CSVLib.CsvFileWriter aWriter = new CSVLib.CsvFileWriter(bStream);

                List<string> aAdressBookRecord = new List<string>();
                aAdressBookRecord.Add(nameTextBox.Text);
                aAdressBookRecord.Add(emailAdressTextBox.Text);
                aAdressBookRecord.Add(personalContactNoTextBox.Text);
                aAdressBookRecord.Add(homeContactNoTextBox.Text);
                aAdressBookRecord.Add(homeAdressTextBox.Text);


                aWriter.WriteRow(aAdressBookRecord);

                bStream.Close();
            }
            else
            {
                MessageBox.Show("Duplicate Phone. No.");
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            FileStream aStream = new FileStream(path, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aStream);
            List<string> aAdressBookRecord = new List<string>();
            searchListBox.Items.Clear();
            while (aReader.ReadRow(aAdressBookRecord))
            {
                string name = aAdressBookRecord[0];
                string email =aAdressBookRecord[1];
                string phoneNo = aAdressBookRecord[2];
                string homeNo = aAdressBookRecord[3];
                string adress = aAdressBookRecord[4];
                searchListBox.Items.Add(name + " " + email + " "+ phoneNo+ " " + homeNo+ " "+ adress+ "\n");
            }
            aStream.Close();


        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            searchListBox.Items.Clear();
            FileStream aStream = new FileStream(path, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aStream);
            List<string> InfoList = new List<string>();
            if (selectComboBox.Text != string.Empty)
            {
                

                    while (aReader.ReadRow(InfoList))
                    {
                        if (selectComboBox.Text == "Name")
                        {
                            string detailList = InfoList[0].ToLower();
                            if (InfoList[0].Contains(insertDataTextBox.Text))
                            {
                                string name = InfoList[0];
                                string email = InfoList[1];
                                string phoneNo = InfoList[2];
                                string homeNo = InfoList[3];
                                string adress = InfoList[4];

                               searchListBox.Items.Add(name + " " + email + " " + phoneNo + " " + homeNo + " " + adress);
                            }
                            else
                            {
                                // MessageBox.Show("Data is not found");
                                continue;
                            }
                        }
                            

                        }
                       


                    }
                    aStream.Close();
                }
            }

        }
    