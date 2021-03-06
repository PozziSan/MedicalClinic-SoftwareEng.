﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;
using MetroFramework.Forms;
using MedicalClinic.Forms;
using static MedicalClinic.SlidePanel;

namespace MedicalClinic.Panel
{
    class ClinicPanel : MetroPanel
    {
        static ClinicPanel clinicPanel;

        public ClinicPanel()
        {
            initializeComponent();
            clinicPanel = this;
        }

        //Agendamento - 1
        //Doutores -    2
        //Pacientes -   3
        //Convenios -   4
        //Receitas -    5

        public enum PanelPosition
        {
            Appointment = 1,
            Doctor,
            Pacient,
            HealthPlan,
            Prescription
        };

        public PanelPosition actualPosition = 0;
        public MetroPanel lastPanel { get; set; }

        private void initializeComponent()
        {      
            this.panel_clinicInside = new MetroFramework.Controls.MetroPanel();
            this.btn_clinicBack = new MetroFramework.Controls.MetroButton();
            this.btn_clinicPrescription = new MetroFramework.Controls.MetroButton();
            this.btn_clinicHealtPlan = new MetroFramework.Controls.MetroButton();
            this.btn_clinicPacients = new MetroFramework.Controls.MetroButton();
            this.btn_clinicDoctors = new MetroFramework.Controls.MetroButton();
            this.btn_clinicSchedule = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();

            this.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Controls.Add(this.panel_clinicInside);
            this.Controls.Add(this.btn_clinicBack);
            this.Controls.Add(this.btn_clinicPrescription);
            this.Controls.Add(this.btn_clinicHealtPlan);
            this.Controls.Add(this.btn_clinicPacients);
            this.Controls.Add(this.btn_clinicDoctors);
            this.Controls.Add(this.btn_clinicSchedule);
            this.HorizontalScrollbarBarColor = true;
            this.HorizontalScrollbarHighlightOnWheel = false;
            this.HorizontalScrollbarSize = 10;
            this.Location = new System.Drawing.Point(0, 51);
            this.Name = "panel_Clinic";
            this.Size = new System.Drawing.Size(593, 333);
            this.TabIndex = 0;
            this.VerticalScrollbarBarColor = true;
            this.VerticalScrollbarHighlightOnWheel = false;
            this.VerticalScrollbarSize = 10;

            // 
            // panel_clinicInside
            // 
            this.panel_clinicInside.HorizontalScrollbarBarColor = true;
            this.panel_clinicInside.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_clinicInside.HorizontalScrollbarSize = 10;
            this.panel_clinicInside.Location = new System.Drawing.Point(176, 12);
            this.panel_clinicInside.Name = "panel_clinicInside";
            this.panel_clinicInside.Size = new System.Drawing.Size(414, 321);
            this.panel_clinicInside.TabIndex = 4;
            this.panel_clinicInside.VerticalScrollbarBarColor = true;
            this.panel_clinicInside.VerticalScrollbarHighlightOnWheel = false;
            this.panel_clinicInside.VerticalScrollbarSize = 10;
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
            // btn_clinicSchedule
            // 
            this.btn_clinicSchedule.Location = new System.Drawing.Point(13, 12);
            this.btn_clinicSchedule.Name = "btn_clinicSchedule";
            this.btn_clinicSchedule.Size = new System.Drawing.Size(157, 42);
            this.btn_clinicSchedule.TabIndex = 2;
            this.btn_clinicSchedule.Text = "Agendamento";

            //Agendamento - 1
            //Doutores -    2
            //Pacientes -   3
            //Convenios -   4
            //receitas -    5

            //Inicializa em schedule
            switchPanel(PanelPosition.Appointment);

            btn_clinicSchedule.MouseClick += delegate {
                switchPanel(PanelPosition.Appointment);
            };
            btn_clinicDoctors.MouseClick += delegate {
                switchPanel(PanelPosition.Doctor);
            };
            btn_clinicPacients.MouseClick += delegate {
                switchPanel(PanelPosition.Pacient);
            };
            btn_clinicHealtPlan.MouseClick += delegate {
                switchPanel(PanelPosition.HealthPlan);
            };
            btn_clinicPrescription.MouseClick += delegate {
                switchPanel(PanelPosition.Prescription);
            };

            btn_clinicBack.MouseClick += Btn_clinicBack_MouseClick;

        }

        private void Btn_clinicBack_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Clinic_SPA temp = new Clinic_SPA();
            MetroPanel initialPanel = temp.panel_initialPanel;
            //temp.Dispose();
            Clinic_SPA clinic_SPAForm = Clinic_SPA.get();
            clinic_SPAForm.Controls.Add(initialPanel);
            SlidePanel.setPanel(Slide.Left, initialPanel, this);
            clinic_SPAForm.Controls.Remove(this);
            clinic_SPAForm.actualPanel = initialPanel;
            this.Dispose();

        }

        private void switchPanel(PanelPosition panelPosition){
            SlidePanel.Slide slideType;

            if (panelPosition == actualPosition)
                return;

            MetroPanel panel = new ListViewPanel((int) panelPosition);

            if (panelPosition > actualPosition)
                slideType = SlidePanel.Slide.Up;
            else
                slideType = SlidePanel.Slide.Down;

            this.Controls.Add(panel);
            SlidePanel.setPanel(slideType, panel, this.panel_clinicInside);
            this.Controls.Remove(panel_clinicInside);
            panel_clinicInside.Dispose();
            panel_clinicInside = panel;
            actualPosition = panelPosition;
        }

        public void switchLateralPanel(MetroPanel panel, SlidePanel.Slide slideType)
        {
            this.Controls.Add(panel);
            SlidePanel.setPanel(slideType, panel, this.panel_clinicInside);
            this.Controls.Remove(panel_clinicInside);
            panel_clinicInside.Dispose();
            panel_clinicInside = panel;
        }

        public static ClinicPanel getThis()
        {
            return clinicPanel;
        }

        private MetroFramework.Controls.MetroPanel panel_clinicInside;
        private MetroFramework.Controls.MetroButton btn_clinicBack;
        private MetroFramework.Controls.MetroButton btn_clinicPrescription;
        private MetroFramework.Controls.MetroButton btn_clinicHealtPlan;
        private MetroFramework.Controls.MetroButton btn_clinicPacients;
        private MetroFramework.Controls.MetroButton btn_clinicDoctors;
        private MetroFramework.Controls.MetroButton btn_clinicSchedule;


    }
}