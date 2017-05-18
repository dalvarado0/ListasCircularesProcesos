using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesosListasCirculares
{
    class Simulacion
    {
        private int _ciclo = 0, p, _prob = 0, _numMin = 0, _numMax = 0, _numMinCProceso = 0, _numMaxCProceso = 0;
        private static Random _ran = new Random();
        Proceso inicio, ultimo;

        public Simulacion(int ciclo)
        {
            _ciclo = ciclo;
            _prob = 25;
            _numMin = 0;
            _numMax = 101;
            _numMinCProceso = 4;
            _numMaxCProceso = 14;
        }

        public Simulacion(int ciclo, int probabilidad, int numMin, int numMax, int numMinCP, int numMaxCP)
        {
            _ciclo = ciclo;
            _prob = probabilidad;
            _numMin = numMin;
            _numMax = numMax;
            _numMinCProceso = numMinCP;
            _numMaxCProceso = numMaxCP;
        }

        public string simular()
        {
            int libre = 0;
            Proceso temp = inicio;
            for (int i = 1; i <= _ciclo; i++)
            {
                p = probabilidad(_numMin, _numMax);
                if (p <= _prob)
                {
                    crearProceso();
                }
                
                if (temp != null)
                {
                    temp.ciclosP -= 1;
                    if (temp.ciclosP == 0)
                    {
                        if(temp == inicio)
                        {
                            inicio = temp.siguiente;
                            inicio.anterior = ultimo;
                        }
                        if(temp == ultimo)
                        {
                            ultimo = temp.anterior;
                            ultimo.siguiente = inicio;
                        }
                        temp.anterior.siguiente = temp.siguiente;
                        temp.siguiente.anterior = temp.anterior;
                    }
                    temp = temp.siguiente;
                    
                }
                else
                    libre += 1;
            }
            return reporte() + Environment.NewLine + "Sin procesar " + libre.ToString() + " ciclos";
        }

        private int probabilidad(int min, int max)
        {
            return _ran.Next(min, max);
        }

        private void crearProceso()
        {
            Proceso nuevo = new Proceso();
            p = probabilidad(_numMinCProceso, _numMaxCProceso);
            nuevo.ciclosP = p;
            agregarProceso(nuevo);
        }

        private void agregarProceso(Proceso nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
                inicio.siguiente = nuevo;
                ultimo = nuevo;
                inicio.anterior = nuevo;  //----------
                inicio.nProceso = 1;
            }
            else
            {
                nuevo.anterior = ultimo;
                ultimo.siguiente = nuevo;
                ultimo = nuevo;
                ultimo.siguiente = inicio;
                ultimo.nProceso = ultimo.anterior.nProceso + 1;
            }

        }

        private string reporte()
        {
            string datos = "";
            int contProcesos = 0, contCiclos = 0;
            Proceso temp = inicio;
            while (temp.siguiente != inicio)
            {
                contProcesos += 1;
                contCiclos += temp.ciclosP;
                temp = temp.siguiente;
                if(temp == inicio)
                {
                    contProcesos += 1;
                    contCiclos += temp.ciclosP;
                }
                datos = "Procesos pendiente " + contProcesos.ToString() + Environment.NewLine + "Ciclos faltantes " + contCiclos.ToString();
            }
            return datos;
        }

        public void algo()
        {
            Proceso temp = inicio;
            string datos = "";
            while (temp.siguiente == inicio)
            {
                datos += temp;
                temp = temp.siguiente;
                if (temp == inicio)
                {
                    datos += temp;
                    break;
                }                    
            }
            datos += "1";
        }
    }
}
