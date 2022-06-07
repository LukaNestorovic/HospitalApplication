using System;
using Appointments.Model;
using System.IO;
using System.Collections.Generic;
using Appointments.Repository;
using System.Collections;
using Serialization;
using System.Windows;
using Appointments.DTO;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Tables;
using System.Data;
using System.Drawing;
using Interface;
using Syncfusion.Pdf.Parsing;
using System.Windows.Controls;

namespace Appointments.Service
{
    public class PrescriptionService
    {
		public int createId()
		{
			int newID;
			if (File.Exists(idFile))
			{
				newID = int.Parse(File.ReadAllText(idFile));
				newID++;
			}
			else
			    newID = 0;
			File.Create(idFile).Close();
			File.WriteAllText(idFile, newID.ToString());
			id = newID;
			return newID;
		}
		public Boolean CreatePrescription(PrescriptionDTO prescriptionDTO)
		{
			int newID = createId();
			Prescription newPrescription = new Prescription(prescriptionDTO.Instructions, newID, prescriptionDTO.doctor, prescriptionDTO.patient, prescriptionDTO.drug, prescriptionDTO.datetime);
			File.WriteAllText(idFile, newID.ToString());
			return prescriptionRepository.Save(newPrescription);
		}

        public List<Prescription> FindAllByPatientId(List<Prescription> all, int id)
        {
            List<Prescription> ret = new List<Prescription>();
            foreach (Prescription prescription in all)
            {
                if(prescription.patient == null)
                {
                    continue;
                }
                if(prescription.patient.Id == id)
                {
                    ret.Add(prescription);
                }
            }
            return ret;
        }

		public List<Prescription> PrescriptionListOfPatient(int id)
		{
            List<Prescription> all = prescriptionRepository.FindAll();
            List<Prescription> ret = FindAllByPatientId(all, id);
            foreach (Prescription i in ret)
            {
                DateTime now = DateTime.Now;
                TimeSpan value = i.datetime.Subtract(now);
                if (value.TotalMinutes < 15 && value.TotalMinutes > 0)
                {
                    MessageBox.Show("Za manje od 15 minuta treba da popijete lek " + i.drug.Name, "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            return ret;
        }

        public List<Prescription> FindAllPrescriptionsByDate(DateTime dateTime)
        {
            List<Prescription> all = prescriptionRepository.FindAll();
            List<Prescription> ret = new List<Prescription>();
            foreach (Prescription p in all)
            {
                if (String.Format("{0:M/d/yyyy}", p.datetime) == String.Format("{0:M/d/yyyy}", dateTime))
                {
                    ret.Add(p);
                }
            }
            return ret;
        }

       

 /*       public void GeneratePDF(int id, DateTime dateTime)
        {
            using (PdfDocument doc = new PdfDocument())
            {
                PdfPage page = doc.Pages.Add();
                PdfGraphics graphics = page.Graphics;
                PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20);
                PdfFont font1 = new PdfStandardFont(PdfFontFamily.Helvetica, 15);
                string naslov = "Klinika Zdravo";
                PdfImage image = PdfImage.FromFile(@"..\..\..\srce.jpg");
                graphics.DrawImage(image, 165, 0);
                graphics.DrawString(naslov, font, PdfBrushes.Black, new PointF(200, 0));
                string textPDF = "Izvestaj o lekovima za dan: " + String.Format("{0:M/d/yyyy}", dateTime);
                graphics.DrawString(textPDF, font1, PdfBrushes.Black, new PointF(270, 75));
                PdfLightTable pdfLightTable = new PdfLightTable();
                DataTable table = new DataTable();
                table.Columns.Add("Naziv leka");
                table.Columns.Add("Instrukcije");
                table.Columns.Add("Doktor");
                List<Prescription> prescriptions = FindAllPrescriptionsByDate(dateTime);
                foreach(Prescription p in prescriptions)
                {
                    table.Rows.Add(new string[] { p.drug.Name, p.Instructions, p.doctor.Name});
                }
                pdfLightTable.DataSource = table;
                pdfLightTable.Style.ShowHeader = true;
                Patient patient = patientService.FindPatientById(id);
                string ime ="Pacijent: " + patient.Name + " " + patient.Surname;
                graphics.DrawString(ime, font1, PdfBrushes.Black, new PointF(0, 75));
                pdfLightTable.Draw(page, new PointF(0, 100));
                doc.Save(@"..\..\..\Reports\MedicineReport.pdf");
                doc.Close(true);
            }
        }

        public void SendMessage()
        {
            MessageBox.Show("Report is succesfully created!");
        }

        public void GenerateReport(int id, DateTime dateTime)
        {
            GeneratePDF(id, dateTime);
            SendMessage();
        }*/



        public String idFile = @"..\..\..\Data\prescriptionID.txt";
		public IPrescriptionRepository prescriptionRepository = new PrescriptionRepository();
        public PatientService patientService = new PatientService();
        public int id = 0;
    }
}
