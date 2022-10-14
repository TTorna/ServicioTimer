using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Timers;
using System.IO;

namespace ServicioTimer
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        public System.Timers.Timer TimerServicio = new System.Timers.Timer();

        protected override void OnStart(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\PC1\source\repos\ServicioTimer\configHorarios.txt");
            string dia = lines[1];
            string hora = lines[4];
            string intervalo = lines[7];
            DayOfWeek semana = DateTime.Today.DayOfWeek;
            String horaReal = DateTime.Now.ToString("HH:mm");

            TimerServicio = new System.Timers.Timer();
            TimerServicio.Elapsed += (_, __) => EjecutaUnaAccion();

            if (dia == "Lunes")
            {
                if (semana == DayOfWeek.Monday)
                    do
                    {
                        horaReal = DateTime.Now.ToString("HH:mm");
                        TimerServicio.Interval = Convert.ToDouble(intervalo);
                    } while (horaReal != hora);
                TimerServicio.Start();
            }
            else if (dia == "Martes")
            {
                if (semana == DayOfWeek.Tuesday)
                    do
                    {
                        horaReal = DateTime.Now.ToString("HH:mm");
                        TimerServicio.Interval = Convert.ToDouble(intervalo);
                    } while (horaReal != hora);
                TimerServicio.Start();
            }
            else if (dia == "Miercoles")
            {
                if (semana == DayOfWeek.Wednesday)
                    do
                    {
                        horaReal = DateTime.Now.ToString("HH:mm");
                        TimerServicio.Interval = Convert.ToDouble(intervalo);
                    } while (horaReal != hora);
                TimerServicio.Start();
            }
            else if (dia == "Jueves")
            {
                if (semana == DayOfWeek.Thursday)
                    do
                    {
                        horaReal = DateTime.Now.ToString("HH:mm");
                        TimerServicio.Interval = Convert.ToDouble(intervalo);
                    } while (horaReal != hora);
                TimerServicio.Start();
            }
            else if (dia == "Viernes")
            {
                if (semana == DayOfWeek.Friday)
                    do
                    {
                        horaReal = DateTime.Now.ToString("HH:mm");
                        TimerServicio.Interval = Convert.ToDouble(intervalo);
                    } while (horaReal != hora);
                TimerServicio.Start();
            }
            else if (dia == "Sabado")
            {
                if (semana == DayOfWeek.Saturday)
                    do
                    {
                        horaReal = DateTime.Now.ToString("HH:mm");
                        TimerServicio.Interval = Convert.ToDouble(intervalo);
                    } while (horaReal != hora);
                TimerServicio.Start();
            }
            else if (dia == "Domingo")
            {
                if (semana == DayOfWeek.Sunday)
                    do
                    {
                        horaReal = DateTime.Now.ToString("HH:mm");
                        TimerServicio.Interval = Convert.ToDouble(intervalo);
                    } while (horaReal != hora);
                TimerServicio.Start();
            }
        }

        public void EjecutaUnaAccion()
        {
            int i;
            for (i = 1; i <= 1000; i++)
            { File.AppendAllText(@"C:\xd\INFORME1.TXT", "LINEA: " + i + System.Environment.NewLine); }

            TimerServicio.Close();
        }

        protected override void OnStop()
        {
            // Agregue el código aquí para realizar cualquier anulación necesaria para detener el servicio.
            TimerServicio.Close();
        }
        protected override void OnPause()
        {
            TimerServicio.Stop();
        }

        protected override void OnContinue()
        {
            TimerServicio.Start();
        }
    }    
}