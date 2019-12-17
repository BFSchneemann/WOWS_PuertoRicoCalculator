using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PuertoRicoCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.endDatePicker.MinDate = DateTime.Now.AddDays(1); // Verhindert die Auswahl des gleichen Tages
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

        /* Wird nicht benötigt (Konstruktor von TimeSpan erledigt das bereits)
        private TimeSpan GetTimeNeeded(Decimal timeLeftSeconds)
        {
            Decimal truncLeftSeconds = Math.Ceiling(timeLeftSeconds);

            int days = Convert.ToInt32(Math.Truncate((truncLeftSeconds / 3600) / 24));
            truncLeftSeconds -= (days * 24 * 3600);

            int hours = Convert.ToInt32(Math.Truncate(truncLeftSeconds / 3600));
            truncLeftSeconds -= (hours * 3600);

            int minutes = Convert.ToInt32(Math.Truncate(truncLeftSeconds / 60));
            truncLeftSeconds -= (minutes * 60);

            int seconds = Convert.ToInt32(Math.Truncate(truncLeftSeconds));

            return (new TimeSpan(days, hours, minutes, seconds));
        }
        */
    }
}
