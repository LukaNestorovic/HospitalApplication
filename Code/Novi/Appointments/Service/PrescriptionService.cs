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

        public void GeneratePDF(int id, DateTime dateTime)
        {
            using (PdfDocument doc = new PdfDocument())
            {
                PdfPage page = doc.Pages.Add();
                PdfGraphics graphics = page.Graphics;
                PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 12);
                string textPDF = "Report of medicine for date: " + String.Format("{0:M/d/yyyy}", dateTime);
                graphics.DrawString(textPDF, font, PdfBrushes.Black, new PointF(70, 0));
                PdfLightTable pdfLightTable = new PdfLightTable();
                DataTable table = new DataTable();
                table.Columns.Add("Id");
                table.Columns.Add("Date");
                table.Columns.Add("Instructions");
                table.Columns.Add("Doctor");
                table.Columns.Add("Drug");
                List<Prescription> prescriptions = FindAllPrescriptionsByDate(dateTime);
                foreach(Prescription p in prescriptions)
                {
                    table.Rows.Add(new string[] { p.Id.ToString(), String.Format("{0:M/d/yyyy}", dateTime), p.Instructions, p.doctor.Name, p.drug.Name});
                }
                pdfLightTable.DataSource = table;
                pdfLightTable.Style.ShowHeader = true;
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
        }



        public String idFile = @"..\..\..\Data\prescriptionID.txt";
		public PrescriptionRepository prescriptionRepository = new PrescriptionRepository();
        public int id = 0;
    }
}
