using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static Random _r = new Random();

        public static void sendEmail(string giftGiver, string message, string GiftReciever)
        {
            string email;
            switch (giftGiver)
            {
                case "Henning":
                    email = "Henninglai@gmail.com";
                    break;
                case "Rikke":
                    email = "Aril@aarhus.dk";
                    break;
                case "Frederik":
                    email = "Frederik-lai@outlook.com";
                    break;
                //case "Andreas":
                //    email = "";
                //    break;
                case "Karoline":
                    email = "karolinela1903@hotmail.com";
                    break;
                //case "Maiken":
                //    email = "";
                //    break;
                case "Mogens":
                    email = "mo.holm@live.dk";
                    break;
                case "Lise":
                    email = "Woobylulle@hotmail.com";
                    break;
                case "Simon":
                    email = "Bassenoir@hotmail.com";
                    break;
                case "Kristian":
                    email = "Kristian_lyngby@hotmail.com";
                    break;
                case "Janni":
                    email = "Janni210294@gmail.com";
                    break;
                case "Per":
                    email = "pma@aaservice.dk";
                    break;
                case "Maj":
                    email = "Missionmaj@yahoo.dk";
                    break;
                case "Mikkel":
                    email = "Meldgaardmikkel@gmail.com";
                    break;
                case "Niklas":
                    email = "Meldgaard0409@gmail.com";
                    break;
                case "Michelle":
                    email = "Michelle2010@live.dk";
                    break;
                case "Arne":
                    email = "aa3812@live.dk";
                    break;
                default:
                    email = "";
                    break;
            }
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("hjolleren@gmail.com", "Julemanden");
                //mail.To.Add("frederiklaiandersen@gmail.com");
                //mail.To.Add(email);
                mail.Subject = "Secret Santa";
                mail.Body = "Hej " + giftGiver + message + GiftReciever;

                SmtpServer.Port = 587;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential("hjolleren@gmail.com", "cafe1122");
                SmtpServer.EnableSsl = true;

                //SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Der skete en fejl");
            }
            MessageBox.Show(giftGiver + " Har fået tildelt" + GiftReciever);
        }

        public static void secretSanta(string[] input)
        {
            List<string> giftRecepients = new List<string>();
            List<string> everybody = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                var matches = Regex.Matches(input[i], @"\w+");
                for (int j = 0; j < matches.Count; j++)
                {
                    everybody.Add(matches[j].Value);
                    int randomLine, randomName, index;
                    string recepient;
                    MatchCollection lineMatches;
                    do
                    {
                        do
                        {
                            randomLine = _r.Next(input.Length);
                        } while (randomLine == i);
                        lineMatches = Regex.Matches(input[randomLine], @"\w+");
                        randomName = _r.Next(lineMatches.Count);
                        recepient = lineMatches[randomName].Value;
                        index = everybody.IndexOf(recepient);
                    } while (giftRecepients.Contains(recepient) || (index % 2 == 0 && everybody[index + 1] == matches[j].Value));
                    giftRecepients.Add(recepient);
                    everybody.Add(recepient);
                    Properties.Settings.Default[matches[j].Value] = recepient;
                    Properties.Settings.Default.Save();
                    sendEmail(matches[j].Value, " i år er du nisse for ", recepient);
                    
                }
            }
        }

        private void GlemtNisse_Click(object sender, EventArgs e)
        {
            if (Navne.SelectedItem == null)
            {
                MessageBox.Show("Du skal vælge en person");
            }
            else
            {
               
            }
        }

        private void Fordel_Click(object sender, EventArgs e)
        {
            string[] instructions = File.ReadAllLines(@"C:\Users\Frederik\secretsanta.txt");
            secretSanta(instructions);
            Properties.Settings.Default.Uddelt = true;
            Properties.Settings.Default.Save();
            Glemt.Visible = true;
            MANGLER.Visible = true;
            genuddel.Visible = true;
            Navne.Visible = true;
            Fordel.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Uddelt)
            {
                Glemt.Visible = true; 
                MANGLER.Visible = true;
                genuddel.Visible = true;
                Navne.Visible = true;
                Fordel.Visible = false;
            }
            else
            {
                Glemt.Visible = false;
                MANGLER.Visible = false;
                genuddel.Visible = false;
                Navne.Visible = false;
                Fordel.Visible = true;
            }
        }

        private void genuddel_Click(object sender, EventArgs e)
        {
            DialogResult gd = MessageBox.Show("Sikker på at du vil genuddele nisser?", "Genuddel", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);
            if (gd == DialogResult.Yes)
            {
                Properties.Settings.Default.Uddelt = false;
                Properties.Settings.Default.Save();
                Glemt.Visible = false;
                MANGLER.Visible = false;
                genuddel.Visible = false;
                Navne.Visible = false;
                Fordel.Visible = true;
            }
        }

        private void MANGLER_Click(object sender, EventArgs e)
        {
            if (Navne.SelectedItem == null)
            {
                MessageBox.Show("Du skal vælge en person");
            }
            else
            {
                
            }
        }
    }
}
