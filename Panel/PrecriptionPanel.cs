﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;
using MedicalClinic.Model.DataModel;

namespace MedicalClinic.Panel
{
    class PrecriptionPanel : MetroPanel
    {

        public PrecriptionPanel()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_id = new MetroFramework.Controls.MetroTextBox();
            this.btn_save = new MetroFramework.Controls.MetroButton();
            this.btn_cancel = new MetroFramework.Controls.MetroButton();
            this.btn_clinicBack = new MetroFramework.Controls.MetroButton();
            this.btn_clinicPrescription = new MetroFramework.Controls.MetroButton();
            this.btn_clinicHealtPlan = new MetroFramework.Controls.MetroButton();
            this.btn_clinicPacients = new MetroFramework.Controls.MetroButton();
            this.btn_clinicDoctors = new MetroFramework.Controls.MetroButton();
            this.btn_clinicAppointment = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // panel_clinicInside
            // 
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancel);
            this.HorizontalScrollbarBarColor = true;
            this.HorizontalScrollbarHighlightOnWheel = false;
            this.HorizontalScrollbarSize = 10;
            this.Location = new System.Drawing.Point(176, 12);
            this.Name = "panel_clinicInside";
            this.Size = new System.Drawing.Size(414, 321);
            this.TabIndex = 4;
            this.VerticalScrollbarBarColor = true;
            this.VerticalScrollbarHighlightOnWheel = false;
            this.VerticalScrollbarSize = 10;
            //
            // metroLabel1
            //
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(44, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(131, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Nome";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(181, 19);
            this.txt_id.Name = "txt_name";
            this.txt_id.Size = new System.Drawing.Size(212, 23);
            this.txt_id.TabIndex = 4;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(299, 286);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(112, 32);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Salvar";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(181, 286);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(112, 32);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancelar";
            // 
            // btn_clinicBack
            // 
            this.btn_clinicBack.Location = new System.Drawing.Point(13, 277);
            this.btn_clinicBack.Name = "btn_clinicBack";
            this.btn_clinicBack.Size = new System.Drawing.Size(157, 42);
            this.btn_clinicBack.TabIndex = 2;
            this.btn_clinicBack.Text = "Voltar";
            // 
            // btn_clinicPrescription
            // 
            this.btn_clinicPrescription.Location = new System.Drawing.Point(13, 204);
            this.btn_clinicPrescription.Name = "btn_clinicPrescription";
            this.btn_clinicPrescription.Size = new System.Drawing.Size(157, 42);
            this.btn_clinicPrescription.TabIndex = 2;
            this.btn_clinicPrescription.Text = "Receitas";
            // 
            // btn_clinicHealtPlan
            // 
            this.btn_clinicHealtPlan.Location = new System.Drawing.Point(13, 156);
            this.btn_clinicHealtPlan.Name = "btn_clinicHealtPlan";
            this.btn_clinicHealtPlan.Size = new System.Drawing.Size(157, 42);
            this.btn_clinicHealtPlan.TabIndex = 2;
            this.btn_clinicHealtPlan.Text = "Convênios";
            // 
            // btn_clinicPacients
            // 
            this.btn_clinicPacients.Location = new System.Drawing.Point(13, 108);
            this.btn_clinicPacients.Name = "btn_clinicPacients";
            this.btn_clinicPacients.Size = new System.Drawing.Size(157, 42);
            this.btn_clinicPacients.TabIndex = 2;
            this.btn_clinicPacients.Text = "Pacientes";
            // 
            // btn_clinicDoctors
            // 
            this.btn_clinicDoctors.Location = new System.Drawing.Point(13, 60);
            this.btn_clinicDoctors.Name = "btn_clinicDoctors";
            this.btn_clinicDoctors.Size = new System.Drawing.Size(157, 42);
            this.btn_clinicDoctors.TabIndex = 2;
            this.btn_clinicDoctors.Text = "Médicos";
            // 
            // btn_clinicAppointment
            // 
            this.btn_clinicAppointment.Location = new System.Drawing.Point(13, 12);
            this.btn_clinicAppointment.Name = "btn_clinicAppointment";
            this.btn_clinicAppointment.Size = new System.Drawing.Size(157, 42);
            this.btn_clinicAppointment.TabIndex = 2;
            this.btn_clinicAppointment.Text = "Consulta";
           

            btn_save.MouseClick += Btn_save_MouseClick;
            btn_cancel.MouseClick += Btn_cancel_MouseClick;
        }

        private void Btn_cancel_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            ClinicPanel clinicPanel = ClinicPanel.getThis();
            clinicPanel.switchLateralPanel(new ListViewPanel(5), SlidePanel.Slide.Right);
        }

        private void Btn_save_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Doctor_Appointment doctorAppointment = new Doctor_Appointment();

            using (var dE = new Model.DataModel.databaseEntities())
            {
                dE.Doctor_Appointment.Add(doctorAppointment);
                dE.SaveChanges();
            }
            ClinicPanel clinicPanel = ClinicPanel.getThis();
            clinicPanel.switchLateralPanel(new ListViewPanel(5), SlidePanel.Slide.Right);
        }

        private MetroFramework.Controls.MetroButton btn_clinicBack;
        private MetroFramework.Controls.MetroButton btn_clinicPrescription;
        private MetroFramework.Controls.MetroButton btn_clinicHealtPlan;
        private MetroFramework.Controls.MetroButton btn_clinicPacients;
        private MetroFramework.Controls.MetroButton btn_clinicDoctors;
        private MetroFramework.Controls.MetroButton btn_clinicAppointment;
        private MetroFramework.Controls.MetroButton btn_cancel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_id;
        private MetroFramework.Controls.MetroButton btn_save;


    }
}
