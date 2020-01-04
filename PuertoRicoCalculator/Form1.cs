using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PuertoRicoCalculator
{
    public partial class Form1 : Form
    {
        private string dataPath = ".\\saved_data.csv";

        public Form1()
        {
            InitializeComponent();
            this.endDatePicker.MinDate = DateTime.Now.AddDays(1); // Verhindert die Auswahl des gleichen Tages
            ReadSavedData();
        }

        private void SaveData()
        {
            StreamWriter writer = new StreamWriter(File.OpenWrite(dataPath));

            string line = numPPM.Value.ToString() + "," + numCurrentPoints.Value.ToString() + "," + numTarget.Value.ToString(); 

            writer.WriteLine(line);

            writer.Close();
        }

        private void ReadSavedData()
        {
            if (!File.Exists(dataPath))
            {
               File.Create(dataPath).Close();
            }

            StreamReader reader = new StreamReader(File.OpenRead(dataPath));
            string[] values = null;

            if (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                values = line.Split(',');
            }

            if (values != null && values.Length == 3)
            {
                try
                {
                    numPPM.Value = Convert.ToDecimal(values[0]);
                    numCurrentPoints.Value = Convert.ToDecimal(values[1]);
                    numTarget.Value = Convert.ToDecimal(values[2]);
                }
                catch (FormatException e)
                {
                    MessageBox.Show(e.ToString(), "Ungültige Werte beim Einlesen erkannt!");
                }
            }
            else
            {
                numPPM.Value = 0;
                numCurrentPoints.Value = 0;
                numTarget.Value = 0;
            }

            reader.Close();
        }

        /// <summary>
        /// Eventhandler für die Berechnung aller Ergebnisse.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmdCalc_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime end = GetEndTime();
            TimeSpan timeLeft = end - now;
            decimal remainingPoints = numTarget.Value - numCurrentPoints.Value;

            decimal pointsPerSecond = numPPM.Value / 60;
            Decimal timeLeftSeconds = remainingPoints / pointsPerSecond; // Ermittlung der verbleibenden Zeit

            TimeSpan timeNeeded = new TimeSpan((long)timeLeftSeconds * 10000000); // Ermittlung der benötigten Zeit

            double ppmNeeded = ((double)remainingPoints / timeLeft.TotalSeconds) * 60; // Ermittlung der mindestens notwendigen Punkte pro Minute

            PrintResult(timeLeft, timeNeeded, ppmNeeded);
        }
        
        /// <summary>
        /// Ausgabe aller Ergebnisse, sowie farbliche Interpretation.
        /// </summary>
        /// <param name="timeLeft"></param>
        /// <param name="timeNeeded"></param>
        /// <param name="ppmNeeded"></param>
        private void PrintResult(TimeSpan timeLeft, TimeSpan timeNeeded, double ppmNeeded)
        {
            txtRemainingDateTime.Text =
                Math.Truncate(timeLeft.TotalDays).ToString("00") + " Tage " 
                + timeLeft.Hours.ToString("00") + ":" 
                + timeLeft.Minutes.ToString("00") + ":" 
                + timeLeft.Seconds.ToString("00");

            txtNeededTime.Text = 
                Math.Truncate(timeNeeded.TotalDays).ToString("00") + " Tage "
                + timeNeeded.Hours.ToString("00") + ":"
                + timeNeeded.Minutes.ToString("00") + ":"
                + timeNeeded.Seconds.ToString("00");

            txtPPMMin.Text = Math.Ceiling(ppmNeeded).ToString();

            txtNeededTime.BackColor = timeLeft > timeNeeded ? Color.Green : Color.Red;
        }

        /// <summary>
        /// Ermittlung des Enddatums aus den Werten der beiden Steuerelemente. (Zeit + Datum)
        /// </summary>
        /// <returns></returns>
        private DateTime GetEndTime()
        {
            return new DateTime(
                endDatePicker.Value.Year,
                endDatePicker.Value.Month,
                endDatePicker.Value.Day,
                endTimePicker.Value.Hour,
                endTimePicker.Value.Minute,
                endTimePicker.Value.Second);
        }

        /// <summary>
        /// Evenhandler für den Menüeintrag "Speichern"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpeichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}
